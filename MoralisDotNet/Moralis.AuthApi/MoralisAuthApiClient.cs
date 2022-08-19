using Moralis.AuthApi.Client;
using Moralis.Network;
using System;

namespace Moralis.AuthApi
{
    /// <summary>
    /// Provides an easy to wrapper around the Moralis Web3Api REST services.
    /// </summary>
    public class MoralisAuthApiClient
    {
        AuthApiClient client = new AuthApiClient();

        static MoralisAuthApiClient instance = new MoralisAuthApiClient();

        private MoralisAuthApiClient() { }

        /// <summary>
        /// Initialize Moralis Web3API. 
        /// </summary>
        /// <param name="apiKey">Required if useStandardServer is true</param>
        /// <param name="url">Optional server url. If not provided default standard server Url is used.</param>
        public static void Initialize(string url, string apiKey)
        {
            Configuration.ApiKey["X-API-Key"] = apiKey;

            instance.client.Initialize(url);
        }

        /// <summary>
        /// Gets the AuthApiClient instance. Moralis.Initialize must be called first.
        /// If Moralis is not initialized this will throw an ApiException.
        /// </summary>
        /// <exception cref="ApiException">Thrown when Moralis.Initialize has not been called.</exception>
        public static AuthApiClient AuthenticationApi
        {
            get => instance.client.IsInitialized ? instance.client : throw new ApiException(109, "Moralis must be initialized before use.");
        }
    }
}
