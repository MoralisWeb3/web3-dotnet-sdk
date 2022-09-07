using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.StreamsApi.Interfaces
{
    public interface IStreamsApiClient
    {
        /// <summary>
        /// Target Authentication Endpoint.
        /// </summary>
        IStreamsApi StreamsEndpoint { get; }

        /// <summary>
        /// Indicates that the client has been initialized.
        /// </summary>
        bool IsInitialized { get; }

        /// <summary>
        /// Initialize the client using serverUrl. If serverUrl is null default is used. 
        /// ApiKey is passed via Configuration signleton.
        /// </summary>
        /// <param name="serverUrl"></param>
        void Initialize(string serverUrl = null);
    }
}
