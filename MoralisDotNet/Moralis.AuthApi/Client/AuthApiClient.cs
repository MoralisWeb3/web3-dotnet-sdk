using Moralis.AuthApi.Api;
using Moralis.AuthApi.Interfaces;
using Moralis.Network;

namespace Moralis.AuthApi.Client
{
    public class AuthApiClient : IAuthClientApi
    {

        private static string defaultServerUrl = "https://auth-api.do-prod-1.moralis.io/";

        /// <summary>
        /// Target Authentication Endpoint.
        /// </summary>
        public IAuthenticationApi AuthEndpoint { get; private set; }

        /// <summary>
        /// Indicates that the client has been initialized.
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AuthApiClient() { }

        /// <summary>
        /// Initialize client using just server url.
        /// </summary>
        /// <param name="serverUrl"></param>
        public AuthApiClient(string serverUrl)
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

            AuthEndpoint = new AuthenticationApi(client);

            // Indicate that the client is initialized.
            this.IsInitialized = true;
        }
    }
}
