
namespace Moralis.StreamsApi.Interfaces
{
    public interface IStreamsApiClient
    {
        /// <summary>
        /// Target Logger Endpoint.
        /// </summary>
        public ILoggerApi LoggerEndpoint { get; }

        /// <summary>
        /// Target Settings Endpoint
        /// </summary>
        public ISettingsApi SettingsEndpoint { get; }

        /// <summary>
        /// Target Streams Endpoint
        /// </summary>
        public IStreamsApi StreamsEndpoint { get; }

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
