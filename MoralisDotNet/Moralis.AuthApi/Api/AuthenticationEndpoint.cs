using Moralis.AuthApi.Interfaces;
using Moralis.AuthApi.Models;
using Moralis.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.AuthApi.Api
{
    public class AuthenticationEndpoint : IAuthEndpoint
    {

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationEndpoint"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public AuthenticationEndpoint(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationEndpoint"/> class.
		/// </summary>
		/// <returns></returns>
		public AuthenticationEndpoint(String basePath)
		{
			this.ApiClient = new ApiClient(basePath);
		}

		/// <summary>
		/// Sets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public void SetBasePath(String basePath)
		{
			this.ApiClient.BasePath = basePath;
		}

		/// <summary>
		/// Gets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public String GetBasePath(String basePath)
		{
			return this.ApiClient.BasePath;
		}

		/// <summary>
		/// Gets or sets the API client.
		/// </summary>
		/// <value>An instance of the ApiClient</value>
		public ApiClient ApiClient { get; set; }

		public ChallengeResponseDto Challenge(ChallengeRequestDto request)
        {
            throw new NotImplementedException();
        }

        public CompleteChallengeResponseDto CompleteChallenge(CompleteChallengeRequestDto request)
        {
            throw new NotImplementedException();
        }

        public HealthCheckResponse HealthCheck()
        {
            throw new NotImplementedException();
        }
    }
}
