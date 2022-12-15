using System.Net.Http;
using Moralis.SolanaApi.Api;
using Moralis.SolanaApi.Interfaces;
using Moralis.Network;

namespace Moralis.SolanaApi.Client
{
    /// <summary>
    /// Provides a wrapper class around the Moralis Web3Api REST service. 
    /// Automagically initializes client to use standard server or
    /// personal server Cloud Function API based on use of Api Key.
    /// </summary>
    public class SolanaApiClient : ISolanaApi
    {
        private static string defaultServerUrl = "https://deep-index.moralis.io/api/v2";

        /// <summary>
        /// AccountApi operations.
        /// </summary>
        public IAccountApi Account { get; private set; }

        /// <summary>
        /// DefiApi operations
        /// </summary>
        public INftApi Nft { get; private set; }

        /// <summary>
        /// Indicates that the client has been initialized.
        /// </summary>
        public bool IsInitialized { get; private set; }

        // Default constructor.
        public SolanaApiClient() { }

        /// <summary>
        /// Initialize client using just server url.
        /// </summary>
        /// <param name="serverUrl"></param>
        public SolanaApiClient(string serverUrl)
        {
            Initialize(serverUrl);
        }

        /// <summary>
        /// Initialize the client using serverUrl. If serverUrl is null default is used. 
        /// ApiKey is passed via Configuration signleton.
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="httpClient"></param>
        public void Initialize(string serverUrl=null, HttpClient httpClient=null)
        {
            // Initialize client
            ApiClient client = new ApiClient(serverUrl is { } ? serverUrl : defaultServerUrl, httpClient);

            this.Account = new AccountApi(client);
            this.Nft = new NftApi(client);

            // Indicate that the client is initialized.
            this.IsInitialized = true;
        }
    }
}
