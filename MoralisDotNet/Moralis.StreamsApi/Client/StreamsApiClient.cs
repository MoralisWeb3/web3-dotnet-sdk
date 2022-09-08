using Moralis.Network;
using Moralis.StreamsApi.Api;
using Moralis.StreamsApi.Interfaces;

namespace Moralis.StreamsApi.Client
{
    /// <summary>
    /// Client that 
    /// </summary>
    public class StreamsApiClient : IStreamsApiClient
    {
        private static string defaultServerUrl = "https://auth-api.do-prod-1.moralis.io/";

        /// <summary>
        /// Target Logger Endpoint.
        /// </summary>
        public ILoggerApi LoggerEndpoint { get; private set; }

        /// <summary>
        /// Target Settings Endpoint
        /// </summary>
        public ISettingsApi SettingsEndpoint { get; private set; }

        /// <summary>
        /// Target Streams Endpoint
        /// </summary>
        public IStreamsApi StreamsEndpoint { get; private set; }

        /// <summary>
        /// Indicates that the client has been initialized.
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StreamsApiClient() { }

        /// <summary>
        /// Initialize client using just server url.
        /// </summary>
        /// <param name="serverUrl"></param>
        public StreamsApiClient(string serverUrl)
        {
            Initialize(serverUrl);
        }

        /// <summary>
        /// Initialize the client using serverUrl. If serverUrl is null default is used. 
        /// ApiKey is passed via Configuration signleton.
        /// </summary>
        /// <param name="serverUrl"></param>
        public void Initialize(string serverUrl = null)
        {
            // Initialize client
            ApiClient client = new ApiClient(serverUrl is { } ? serverUrl : defaultServerUrl);

            LoggerEndpoint = new LoggerApi(client);
            SettingsEndpoint = new SettingsApi(client);
            StreamsEndpoint = new Api.StreamsApi(client);

            // Indicate that the client is initialized.
            this.IsInitialized = true;
        }
    }
}
