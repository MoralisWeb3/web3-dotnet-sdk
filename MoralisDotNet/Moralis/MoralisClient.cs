using System;
using Moralis.AuthApi.Interfaces;
using Moralis.Web3Api.Interfaces;
using Moralis.SolanaApi.Interfaces;
using Moralis.Models;
using Moralis.SolanaApi;
using Moralis.Web3Api;
using Moralis.AuthApi;
using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi;

namespace Moralis
{
    /// <summary>
    /// Main object used to access Moralis APIs and other functioinality. 
    /// 
    /// The MoralisClient is provided as a singleto object. It need only 
    /// be setup once within an application.
    /// 
    /// Before the Moralis Client can be used, it must be started (initialized). 
    /// There are several ways to do the, however the easiest way to do so is 
    /// to setup _MoralisClient.ConnectionData_ before doing anything else with 
    /// the MoralisClient. The MoralisClient is self initializing provided 
    /// _MoralisClient.ConnectionData_ has been setup with valid information.
    /// 
    /// For Example:
    /// <code>
    /// MoralisClient.ConnectionData = new ServerConnectionData()
    /// {
    ///     ApiKey = "YOUR API KEY HERE"
    /// };
    /// 
    /// IWeb3Api apiClient = MoralisClient.Web3Api;
    /// </code>
    /// 
    /// This code is perfectly valid as, since ConnectionData was instantiated properly, 
    /// calling any public class level object on MoralisClient will, if MoralisClient
    /// has not already been initialize, automatically initialize MoralisClient
    /// using the information provided in ConnectionData.
    /// </summary>
    public class MoralisClient
    {
        #region Instance variables
        private IAuthClientApi AuthenticationApiClient { get; set; }
        private ISolanaApi SolanaApiClient { get; set; }
        private IStreamsApiClient StreamsApiClient { get; set; }
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
        /// Instance of the Streams Api
        /// </summary>
        public static IStreamsApiClient StreamsApi
        {
            get
            {
                // Initialize Moralis using default values if it has not been initialized.
                if (!IsInitialized)
                {
                    Start();
                }

                return instance.StreamsApiClient;
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
        public static void Start()
        {
            if (ConnectionData == null)
            {
                // Default to default instance.
                ConnectionData = new ServerConnectionData();
            }

            Start(ConnectionData);
        }
        #endregion

        /// <summary>
        /// Initialize Moralis Client using Connection Data to derive all API clients
        /// </summary>
        /// <param name="connectionData"></param>
        public static void Start(ServerConnectionData connectionData)
        { 
            Start(connectionData, null, null, null, null);
        }

        /// <summary>
        /// Initialize Moralis Client by providing connection data and pre-initialized Api Clients
        /// </summary>
        /// <param name="connectionData"></param>
        /// <param name="authApi"></param>
        /// <param name="streamsApi"></param>
        /// <param name="web3Api"></param>
        public static void Start(ServerConnectionData connectionData, IAuthClientApi authApi = null, ISolanaApi solanaApi = null, IStreamsApiClient streamsApi = null, IWeb3Api web3Api = null)
        { 
            instance = new MoralisClient(connectionData, authApi, solanaApi, streamsApi, web3Api);  
        }

        /// <summary>
        /// Creates an instance of the Moralis Client.
        /// </summary>
        /// <param name="connectionData"></param>
        /// <param name="authApi"></param>
        /// <param name="streamsApi"></param>
        /// <param name="web3Api"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private MoralisClient(ServerConnectionData connectionData, IAuthClientApi authApi = null, ISolanaApi solanaApi = null, IStreamsApiClient streamsApi = null, IWeb3Api web3Api = null)
        {
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
            // Setup Streams Api
            // --------------------------------------------------------------------------------
            StreamsApiClient = streamsApi;

            if (StreamsApiClient is { })
            {
                StreamsApiClient.Initialize();
            }
            else
            {
                // Api URI is required.
                if (string.IsNullOrEmpty(connectionData.Web3ApiUrl)) throw new ArgumentNullException(nameof(connectionData.Web3ApiUrl));

                MoralisStreamsApiClient.Initialize(connectionData.StreamsApiUrl, connectionData.ApiKey);

                StreamsApiClient = MoralisStreamsApiClient.StreamsApiClient;
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
