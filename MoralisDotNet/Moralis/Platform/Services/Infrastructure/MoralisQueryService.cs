using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Moralis.Platform.Utilities;
using System.Threading.Tasks;
using System.Net;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;
using Moralis.Platform.Queries;
using Moralis.Platform.Services.ClientServices;
using Moralis.Platform.Services.Models;

namespace Moralis.Platform.Services.Infrastructure
{
    internal class MoralisQueryService : IQueryService
    {

        IMoralisCommandRunner CommandRunner { get; }

        IJsonSerializer JsonSerializer { get; }
        string SessionToken { get; }
        //IMoralisDataDecoder Decoder { get; }

        public IObjectService ObjectService { get; }

        public MoralisQueryService(IMoralisCommandRunner commandRunner, string sessionToken, IJsonSerializer jsonSerializer, IObjectService objectService) => (CommandRunner, SessionToken, JsonSerializer, ObjectService) = (commandRunner, sessionToken, jsonSerializer, objectService);

        public async Task<IEnumerable<T>> FindAsync<T>(MoralisQuery<T> query, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            string result = await FindAsync(query.ClassName, query.BuildParameters(), sessionToken, cancellationToken);
            
            return JsonSerializer.Deserialize<List<T>>(result) as IEnumerable<T>;
        }

        public async Task<IEnumerable<T>> AggregateAsync<T>(MoralisQuery<T> query, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            string aggResp = await AggregateAsync(query.ClassName, query.BuildParameters(), sessionToken, cancellationToken);
            return JsonSerializer.Deserialize<List<T>>(aggResp) as IEnumerable<T>;
        }

        public async Task<int> CountAsync<T>(MoralisQuery<T> query, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            IDictionary<string, object> parameters = query.BuildParameters();
            parameters["limit"] = 0;
            parameters["count"] = 1;

            string findResp = await FindAsync(query.ClassName, parameters, sessionToken, cancellationToken);
            
            CountQueryResult result = JsonSerializer.Deserialize<CountQueryResult>(findResp); 
            
            return result.count; 
        }

        public async Task<IEnumerable<T>> DistinctAsync<T>(MoralisQuery<T> query, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            IDictionary<string, object> parameters = query.BuildParameters();
            parameters["distinct"] = ""; // key
            parameters["where"] = ""; // where ?
            parameters["hint"] = ""; // hint

            string aggResp = await AggregateAsync(query.ClassName, parameters, sessionToken, cancellationToken);
            
            return JsonSerializer.Deserialize<List<T>>(aggResp) as IEnumerable<T>;
        }

        public async Task<T> FirstAsync<T>(MoralisQuery<T> query, string sessionToken, CancellationToken cancellationToken = default) where T : MoralisObject
        {
            IDictionary<string, object> parameters = query.BuildParameters();
            parameters["limit"] = 1;

            string findResp = await FindAsync(query.ClassName, parameters, sessionToken, cancellationToken);
                
            IList<T> l = JsonSerializer.Deserialize<List<T>>(findResp);

            return l.FirstOrDefault();
        }

        async Task<string> FindAsync(string className, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken = default)
        {
            Tuple<HttpStatusCode, string> cmdResult = await CommandRunner.RunCommandAsync(new MoralisCommand($"server/classes/{Uri.EscapeDataString(className)}?{MoralisService<MoralisUser>.BuildQueryString(parameters)}", method: "GET", sessionToken: sessionToken, data: null), cancellationToken: cancellationToken);

            return cmdResult.Item2;
        }

        async Task<string> AggregateAsync(string className, IDictionary<string, object> parameters, string sessionToken, CancellationToken cancellationToken = default)
        {
            Tuple<HttpStatusCode, string> cmdResult = await CommandRunner.RunCommandAsync(new MoralisCommand($"server/aggregate/{Uri.EscapeDataString(className)}?{MoralisService<MoralisUser>.BuildQueryString(parameters)}", method: "GET", sessionToken: sessionToken, data: null), cancellationToken: cancellationToken);

            return cmdResult.Item2;
        }

    }
}
