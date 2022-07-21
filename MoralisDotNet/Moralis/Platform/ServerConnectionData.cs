using System;
using System.Collections.Generic;
using Moralis.Platform.Abstractions;

namespace Moralis.Platform
{
    /// <summary>
    /// Represents the configuration of the Moralis SDK.
    /// </summary>
    public class ServerConnectionData : IServerConnectionData
    {
        // Default to Moralis Server values
        private string moralisEndpointBase = "server";
        private string moralisEndpointCloudfunctions = "functions";
        private string moralisEndpointFileService = "files";
        private string moralisEndpointClasses = "classes";

        public bool Test { get; set; }

        /// <summary>
        /// The App ID of your app.
        /// </summary>
        public string ApplicationID { get; set; }

        /// <summary>
        /// A URI pointing to the target Moralis Server instance hosting the app targeted by <see cref="ApplicationID"/>.
        /// </summary>
        public string ServerURI { get; set; }

        /// <summary>
        /// A URI pointing to the target Moralis WS/WSS server.
        /// </summary>
        public string LiveQueryServerURI { get; set; }

        /// <summary>
        /// The Web3Api key, must be supplied to initialize Web3Api to use 
        /// standard REST server.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The .NET Key for the Moralis app targeted by <see cref="ServerURI"/>.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The Master Key for the Moralis app targeted by <see cref="Key"/>.
        /// </summary>
        public string MasterKey { get; set; }

        /// <summary>
        /// Used to 
        /// </summary>
        public string LocalStoragePath { get; set; }

        /// <summary>
        /// Auth 2.0 server endpoint URL
        /// </summary>
        public string AuthenticationApiUrl { get; set; }

        /// <summary>
        /// Additional HTTP headers to be sent with network requests from the SDK.
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Base endpoint for a Parse server backend
        /// </summary>
        public string ParseEndpointBase
        {
            get { return moralisEndpointBase; }
            set { moralisEndpointBase = value; }
        }

        /// <summary>
        /// Cloud Functions endpoint for a Parse Backend
        /// </summary>
        public string ParseEndpointCloudfunctions
        {
            get { return $"{ParseEndpointBase}/{moralisEndpointCloudfunctions}"; }
            set { moralisEndpointCloudfunctions = value; }
        }

        /// <summary>
        /// File Service endpoint for Parse backend
        /// </summary>
        public string ParseEndpointFileService
        {
            get { return $"{ParseEndpointBase}/{moralisEndpointFileService}"; }
            set { moralisEndpointFileService = value; }
        }

        /// <summary>
        /// Classes endpoint for a Parse Backend
        /// </summary>
        public string ParseEndpointClasses
        {
            get { return $"{ParseEndpointBase}/{moralisEndpointClasses}"; }
            set { moralisEndpointClasses = value; }
        }


    }

}
