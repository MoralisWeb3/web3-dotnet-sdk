using System;
using Moralis.Network;
using Moralis.SolanaApi.Client;

namespace Moralis.SolanaApi
{
    public class MoralisSolanaApiClient
    {
        SolanaApiClient client = new SolanaApiClient();

        static MoralisSolanaApiClient instance = new MoralisSolanaApiClient();

        private MoralisSolanaApiClient() { }

        /// <summary>
        /// Initialize Moralis Web3API. 
        /// </summary>
        /// <param name="url">Optional server url. If not provided default standard server Url is used.</param>
        /// <param name="apiKey">Required if useStandardServer is true</param>
        public static void Initialize(string url, string apiKey)
        {
            Configuration.ApiKey["X-API-Key"] = apiKey;

            instance.client.Initialize(url);
        }

        /// <summary>
        /// Gets the Web3ApiClient instance. Moralis.Initialize must be called first.
        /// If Moralis is not initialized this will throw an ApiException.
        /// </summary>
        /// <exception cref="ApiException">Thrown when Moralis.Initialize has not been called.</exception>
        public static SolanaApiClient SolanaApi
        {
            get => instance.client.IsInitialized ? instance.client : throw new ApiException(109, "Moralis must be initialized before use.");
        }
    }
}
