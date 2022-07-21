﻿using System;
using System.Collections.Generic;
using System.Threading;
using Moralis.Platform.Utilities;
using System.Threading.Tasks;
using System.Net;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Services.Models;

namespace Moralis.Platform.Services.ClientServices
{
    /// <summary>
    /// This service enables an application to call Moralis Cloud Functions.
    /// </summary>
    public class MoralisCloudFunctionService : ICloudFunctionService
    {
        IMoralisCommandRunner CommandRunner { get; }

        IServerConnectionData ServerConnectionData { get; }

        IJsonSerializer JsonSerializer { get; }

        public MoralisCloudFunctionService(IMoralisCommandRunner commandRunner, IServerConnectionData serverConnectionData, IJsonSerializer jsonSerializer) => (CommandRunner, ServerConnectionData, JsonSerializer) = (commandRunner, serverConnectionData, jsonSerializer);

        /// <summary>
        /// Calls Moralis cloud function specified by 'name'.
        /// </summary>
        /// <typeparam name="T">Expected result type</typeparam>
        /// <param name="name">Name of cloud function</param>
        /// <param name="parameters">Parameters that will be passed to the cloud function</param>
        /// <param name="sessionToken">current user's session token</param>
        /// <param name="cancellationToken">Threading cancellation token</param>
        /// <returns>T - result of cloud function call.</returns>
        public async Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters, string sessionToken, System.Threading.CancellationToken cancellationToken = default)
        {
            MoralisCommand command = new MoralisCommand($"{ServerConnectionData.ParseEndpointCloudfunctions}/{Uri.EscapeDataString(name)}", method: "POST", sessionToken: sessionToken, data: parameters is { } && parameters.Count > 0 ? JsonSerializer.Serialize(parameters) : "{}");

            Tuple<HttpStatusCode, string> cmdResult = await CommandRunner.RunCommandAsync(command, cancellationToken: cancellationToken);
            
            T resp = default;

            if ((int)cmdResult.Item1 < 400)
            {
                resp = (T)JsonSerializer.Deserialize<T>(cmdResult.Item2);
            }

            return resp;
         
        }
    }
}