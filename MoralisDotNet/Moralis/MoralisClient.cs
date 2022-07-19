using System;
using Moralis.AuthApi.Interfaces;
using Moralis.Web3Api.Interfaces;
using Moralis.SolanaApi.Interfaces;
using Moralis.Models;
using Moralis.SolanaApi;
using Moralis.Web3Api;
using Moralis.AuthApi;

namespace Moralis
{
    /// <summary>
    /// Main object used to access Moralis APIs and other functioinality.
    /// </summary>
    public class MoralisClient
    {
        #region Instance variables
        private IAuthClientApi AuthenticationApiClient { get; set; }
        private ISolanaApi SolanaApiClient { get; set; }
        private IWeb3Api Web3ApiClient { get; set; }
        #endregion

        #region Class level variables
        private static MoralisClient instance;

        /// <summary>
        /// Instance of the Authentication API
        /// </summary>
        public static IAuthClientApi AuthenticationApi
        {
            get
            {
                // Initialize Moralis using default values if it has not been initialized.
                if (!IsInitialized)
                {
                    Start();
                }

                return instance.AuthenticationApiClient;
            }
        }

        /// <summary>
        /// The information used to connect to Moralis Services
        /// </summary>
        public static ServerConnectionData ConnectionData { get; set; }

        /// <summary>
        /// Indicates if the Moralis Client has been initialized.
        /// </summary>
        public static bool IsInitialized
        {
            get { return instance != null; }
        }

        /// <summary>
        /// Instance of the Solana API
        /// </summary>
        public static ISolanaApi SolanaApi
        {
            get
            {
                // Initialize Moralis using default values if it has not been initialized.
                if (!IsInitialized)
                {
                    Start();
                }

                return instance.SolanaApiClient;
            }
        }

        /// <summary>
        /// Instance of the Web3 Api
        /// </summary>
        public static IWeb3Api Web3Api
        {
            get
            {
                // Initialize Moralis using default values if it has not been initialized.
                if (!IsInitialized)
                {
                    Start();
                }

                return instance.Web3ApiClient;
            }
        }

        /// <summary>
        /// Default initializer of the Moralis Client
        /// </summary>
        /// <exception cref="ArgumentNullException">ConnectionData must be supplied.</exception>
        public static void Start()
        {
            if (ConnectionData is { })
            {
                Start(ConnectionData);
            }
            else
            {
                throw new ArgumentNullException(nameof(ConnectionData));
            }
        }
        #endregion

        /// <summary>
        /// Initialize Moralis Client using Connection Data to derive all API clients
        /// </summary>
        /// <param name="connectionData"></param>
        public static void Start(ServerConnectionData connectionData)
        { 
            Start(connectionData, null, null, null);
        }

        /// <summary>
        /// Initialize Moralis Client by providing connection data and pre-initialized Api Clients
        /// </summary>
        /// <param name="connectionData"></param>
        /// <param name="authApi"></param>
        /// <param name="solanaApi"></param>
        /// <param name="web3Api"></param>
        public static void Start(ServerConnectionData connectionData, IAuthClientApi authApi = null, ISolanaApi solanaApi = null, IWeb3Api web3Api = null)
        { 
            instance = new MoralisClient(connectionData, authApi, solanaApi, web3Api);  
        }

        /// <summary>
        /// Creates an instance of the Moralis Client.
        /// </summary>
        /// <param name="connectionData"></param>
        /// <param name="authApi"></param>
        /// <param name="solanaApi"></param>
        /// <param name="web3Api"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private MoralisClient(ServerConnectionData connectionData, IAuthClientApi authApi = null, ISolanaApi solanaApi = null, IWeb3Api web3Api = null)
        {
            // Api Key is required
            if (string.IsNullOrEmpty(connectionData.ApiKey)) throw new ArgumentNullException(nameof(connectionData.ApiKey));
            // Master Key is required.
            if (string.IsNullOrEmpty(connectionData.MasterKey)) throw new ArgumentNullException(nameof(connectionData.MasterKey));
            // Auth 2.0 Api URI is required.
            if (string.IsNullOrEmpty(connectionData.AuthenticationApiUrl)) throw new ArgumentNullException(nameof(connectionData.AuthenticationApiUrl));

            ConnectionData = connectionData;

            // --------------------------------------------------------------------------------
            // Setp Authentication Api
            // --------------------------------------------------------------------------------
            AuthenticationApiClient = authApi;

            if (AuthenticationApiClient is { })
            {
                AuthenticationApiClient.Initialize(connectionData.AuthenticationApiUrl);
            }
            else
            {
                MoralisAuthApiClient.Initialize(connectionData.AuthenticationApiUrl, connectionData.ApiKey);

                AuthenticationApiClient = MoralisAuthApiClient.AuthenticationApi;
            }

            // --------------------------------------------------------------------------------
            // Setup Solana Api
            // --------------------------------------------------------------------------------
            SolanaApiClient = solanaApi;

            if (SolanaApiClient is { })
            {
                SolanaApiClient.Initialize();
            }
            else
            {
                // Api URI is required.
                if (string.IsNullOrEmpty(connectionData.Web3ApiUrl)) throw new ArgumentNullException(nameof(connectionData.Web3ApiUrl));

                MoralisSolanaApiClient.Initialize(connectionData.Web3ApiUrl, connectionData.ApiKey);

                SolanaApiClient = MoralisSolanaApiClient.SolanaApi;
            }

            // --------------------------------------------------------------------------------
            // Setp Web3 Api
            // --------------------------------------------------------------------------------
            Web3ApiClient = web3Api;

            if (Web3ApiClient is { })
            {
                Web3ApiClient.Initialize();
            }
            else
            {
                // Api URI is required.
                if (string.IsNullOrEmpty(connectionData.Web3ApiUrl)) throw new ArgumentNullException(nameof(connectionData.Web3ApiUrl));

                MoralisWeb3ApiClient.Initialize(connectionData.Web3ApiUrl, connectionData.ApiKey);

                Web3ApiClient = MoralisWeb3ApiClient.Web3Api;
            }
        }
    }
}
