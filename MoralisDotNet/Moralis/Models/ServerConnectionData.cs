using System.Collections.Generic;

namespace Moralis.Models
{
    /// <summary>
    /// The set of properties required to access Moralis services.
    /// </summary>
    public class ServerConnectionData
    {
        /// <summary>
        /// Default constructor - sets default configuration values.
        /// </summary>
        public ServerConnectionData()
        {
            ApiKey = "NOT SET";
            AuthenticationApiUrl = "https://auth-api.do-prod-1.moralis.io/";
            Web3ApiUrl = "https://deep-index.moralis.io/api/v2";
            StreamsApiUrl = "https://streams-api.aws-prod-streams-master-1.moralis.io";
            MasterKey = "NOT SET";
        }

        /// <summary>
        /// The Web3Api key, must be supplied to initialize Web3Api to use 
        /// standard REST server.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The Master Key for the Moralis app targeted by <see cref="Key"/>.
        /// </summary>
        public string MasterKey { get; set; }

        /// <summary>
        /// URL for the Authentication 2.0 API
        /// </summary>
        public string AuthenticationApiUrl { get; set; }

        /// <summary>
        /// URL for Streams Api
        /// </summary>
        public string StreamsApiUrl { get; set; }

        /// <summary>
        /// URL for Web3 Api and Solana Api
        /// </summary>
        public string Web3ApiUrl { get; set; }

        /// <summary>
        /// Additional HTTP headers to be sent with network requests from the SDK.
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }
    }
}
