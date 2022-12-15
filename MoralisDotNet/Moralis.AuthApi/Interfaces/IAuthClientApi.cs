using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Moralis.AuthApi.Interfaces
{
    /// <summary>
    /// Defines methods and properties of an Authentication Api Client
    /// </summary>
    public interface IAuthClientApi
    {
        /// <summary>
        /// Target Authentication Endpoint.
        /// </summary>
        IAuthenticationApi AuthEndpoint { get; }

        /// <summary>
        /// Indicates that the client has been initialized.
        /// </summary>
        bool IsInitialized { get; }

        /// <summary>
        /// Initialize the client using serverUrl. If serverUrl is null default is used. 
        /// ApiKey is passed via Configuration signleton.
        /// </summary>
        /// <param name="serverUrl"></param>
        void Initialize(string serverUrl = null, HttpClient httpClient=null);
    }
}
