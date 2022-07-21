using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Exceptions;
using Moralis.Platform.Objects;
using Moralis.Platform.Services.Models;
using Moralis.Platform.Utilities;
using Moralis.Core.Exceptions;

namespace Moralis.Platform.Services.ClientServices
{
    public class MoralisObjectService : IObjectService
    {
        IMoralisCommandRunner CommandRunner { get; }

        IJsonSerializer JsonSerializer { get; }

        public IServerConnectionData ServerConnectionData { get; }

        public MoralisObjectService(IMoralisCommandRunner commandRunner, IServerConnectionData serverConnectionData, IJsonSerializer jsonSerializer)
        {
            CommandRunner = commandRunner;
            ServerConnectionData = serverConnectionData;
            JsonSerializer = jsonSerializer;
        }

        public async Task<T> FetchAsync<T>(T item, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            MoralisCommand command = new MoralisCommand($"{ServerConnectionData.ParseEndpointClasses}/{Uri.EscapeDataString(item.ClassName)}/{Uri.EscapeDataString(item.objectId)}", method: "GET", sessionToken: sessionToken, data: default);
            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(command, cancellationToken: cancellationToken);
         
            T resp = default;

            if ((int)cmdResp.Item1 < 400)
            {
                resp = (T)JsonSerializer.Deserialize<T>(cmdResp.Item2);
                    
            }

            return resp;
        }

        public async Task<string> SaveAsync(MoralisObject item, IDictionary<string, IMoralisFieldOperation> operations, string sessionToken, CancellationToken cancellationToken = default)
        {
            MoralisCommand command = new MoralisCommand(item.objectId == null ? $"{ServerConnectionData.ParseEndpointClasses}/{Uri.EscapeDataString(item.ClassName)}" : $"{ServerConnectionData.ParseEndpointClasses}/{Uri.EscapeDataString(item.ClassName)}/{item.objectId}", method: item.objectId is null ? "POST" : "PUT", sessionToken: sessionToken, data: operations is { } && operations.Count > 0 ? JsonSerializer.Serialize(operations, JsonSerializer.DefaultOptions).JsonInsertParseDate() : JsonSerializer.Serialize(item, JsonSerializer.DefaultOptions).JsonInsertParseDate());
            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(command, cancellationToken: cancellationToken);
            
            string resp = default;

            if ((int)cmdResp.Item1 < 400)
            {
                resp = cmdResp.Item2;
            }
            else
            {
                throw new MoralisSaveException(cmdResp.Item2);
            }

            return resp;
        }

        public async Task DeleteAsync(MoralisObject item, string sessionToken, CancellationToken cancellationToken = default)
        {
            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(new MoralisCommand($"{ServerConnectionData.ParseEndpointClasses}/{item.ClassName}/{item.objectId}", method: "DELETE", sessionToken: sessionToken, data: null), cancellationToken: cancellationToken);
         }
               
        int MaximumBatchSize { get; } = 50;

        async Task<IList<Task<IDictionary<string, object>>>> ExecuteBatchRequestAsync<T>(IList<MoralisCommand> requests, string sessionToken, CancellationToken cancellationToken = default)
        {
            int batchSize = requests.Count;

            List<Task<IDictionary<string, object>>> tasks = new List<Task<IDictionary<string, object>>> { };
            List<TaskCompletionSource<IDictionary<string, object>>> completionSources = new List<TaskCompletionSource<IDictionary<string, object>>> { };

            for (int i = 0; i < batchSize; ++i)
            {
                TaskCompletionSource<IDictionary<string, object>> tcs = new TaskCompletionSource<IDictionary<string, object>>();

                completionSources.Add(tcs);
                tasks.Add(tcs.Task);
            }

            List<object> encodedRequests = requests.Select(request =>
            {
                Dictionary<string, object> results = new Dictionary<string, object>
                {
                    ["method"] = request.Method,
                    ["path"] = request is { Path: { }, Resource: { } } ? request.Target.AbsolutePath : new Uri(new Uri(ServerConnectionData.ServerURI), request.Path).AbsolutePath,
                };

                if (request.DataObject != null)
                    results["body"] = request.DataObject;

                return results;
            }).Cast<object>().ToList();

            MoralisCommand command = new MoralisCommand("batch", method: "POST", sessionToken: sessionToken, data: JsonSerializer.Serialize(new Dictionary<string, object> { [nameof(requests)] = encodedRequests }, JsonSerializer.DefaultOptions));

            Tuple<HttpStatusCode, string> cmdResp = await CommandRunner.RunCommandAsync(command, cancellationToken: cancellationToken);

            if ((int)cmdResp.Item1 < 400)
            {
                foreach (TaskCompletionSource<IDictionary<string, object>> tcs in completionSources)
                {
                    if (TaskStatus.Faulted.Equals(tcs.Task.Status))
                        tcs.TrySetException(new Exception("Update failed."));
                    else if (TaskStatus.Canceled.Equals(tcs.Task.Status))
                        tcs.TrySetCanceled();
                }
                

                IList<object> resultsArray = Conversion.As<IList<object>>(cmdResp.Item2);
                int resultLength = resultsArray.Count;

                if (resultLength != batchSize)
                {
                    foreach (TaskCompletionSource<IDictionary<string, object>> completionSource in completionSources)
                        completionSource.TrySetException(new InvalidOperationException($"Batch command result count expected: {batchSize} but was: {resultLength}."));
                }
                else
                {
                    for (int i = 0; i < batchSize; ++i)
                    {
                        Dictionary<string, object> result = resultsArray[i] as Dictionary<string, object>;
                        TaskCompletionSource<IDictionary<string, object>> target = completionSources[i];

                        if (result.ContainsKey("success"))
                            target.TrySetResult(result["success"] as IDictionary<string, object>);
                        else if (result.ContainsKey("error"))
                        {
                            IDictionary<string, object> error = result["error"] as IDictionary<string, object>;
                            target.TrySetException(new MoralisFailureException((MoralisFailureException.ErrorCode)(long)error["code"], error[nameof(error)] as string));
                        }
                        else
                            target.TrySetException(new InvalidOperationException("Invalid batch command response."));
                    }
                }
            }

            return tasks;
        }
    }
}
