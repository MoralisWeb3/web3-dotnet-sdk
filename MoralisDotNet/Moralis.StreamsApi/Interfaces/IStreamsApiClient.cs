
namespace Moralis.StreamsApi.Interfaces
{
    public interface IStreamsApiClient
    {
        /// <summary>
        /// 
        /// </summary>
        public IHistoryApi HistoryEndpoint { get; }

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

        /// <summary>
        /// Verifies that a WebHook message was sent by Moralis using sha3(REQUEST_BODY + WEB3_API_KEY);
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="requestBody"></param>
        /// <returns>bool</returns>
        bool VerifySignature(string signature, string requestBody);
    }
}
