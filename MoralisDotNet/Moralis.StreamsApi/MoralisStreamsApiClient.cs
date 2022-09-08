using Moralis.Network;
using Moralis.StreamsApi.Client;

namespace Moralis.StreamsApi
{
    /// <summary>
    /// Simple, easy to use Api Client initializer.
    /// </summary>
    public class MoralisStreamsApiClient
    {
        StreamsApiClient client = new StreamsApiClient();

        static MoralisStreamsApiClient instance = new MoralisStreamsApiClient();

        private MoralisStreamsApiClient() { }

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
        /// Gets the StreamsApiClient instance. Moralis.Initialize must be called first.
        /// If Moralis is not initialized this will throw an ApiException.
        /// </summary>
        /// <exception cref="ApiException">Thrown when Moralis.Initialize has not been called.</exception>
        public static StreamsApiClient StreamsApiClient
        {
            get => instance.client.IsInitialized ? instance.client : throw new ApiException(109, "Moralis must be initialized before use.");
        }
    }
}
