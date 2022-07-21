using Moralis.AuthApi.Interfaces;
using Moralis.AuthApi.Models;
using Moralis.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

		public async Task<ChallengeResponseDto> Challenge(ChallengeRequestDto request, ChainNetworkType network)
        {
			var headerParams = new Dictionary<String, String>();
			//headerParams["Content-Type"] = "application/json";
			//headerParams["accept"] = "application/json";

			// Verify the required parameter 'request' is set
			if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling Challenge");

			var path = $"/challenge/request/{network}";

			// Authentication setting, if any
			String[] authSettings = new String[] { }; // "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(request);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.Created.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (ChallengeResponseDto)ApiClient.Deserialize(data, typeof(ChallengeResponseDto), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Challenge: {response.ReasonPhrase}");
			}
		}

        public async Task<CompleteChallengeResponseDto> CompleteChallenge(CompleteChallengeRequestDto request, ChainNetworkType network)
        {
			var headerParams = new Dictionary<String, String>();

			// Verify the required parameter 'request' is set
			if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling CompleteChallenge");

			var path = $"/challenge/verify/{network}";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(request);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.Created.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (CompleteChallengeResponseDto)ApiClient.Deserialize(data, typeof(CompleteChallengeResponseDto), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Challenge: {response.ReasonPhrase}");
			}
		}

        public async Task<HealthCheckResponse> HealthCheck()
        {
			var headerParams = new Dictionary<String, String>();

			var path = "/health";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (HealthCheckResponse)ApiClient.Deserialize(data, typeof(HealthCheckResponse), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Authentication Health Check: {response.ReasonPhrase}");
			}
		}
    }
}
