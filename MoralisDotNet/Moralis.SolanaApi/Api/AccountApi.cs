using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Moralis.Network;
using Moralis.SolanaApi.Interfaces;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Api
{
    public class AccountApi : IAccountApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccountApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public AccountApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AccountApi"/> class.
		/// </summary>
		/// <returns></returns>
		public AccountApi(string basePath, HttpClient httpClient = null)
		{
			this.ApiClient = new ApiClient(basePath, httpClient);
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

		public async Task<NativeBalance> Balance(NetworkTypes network, string address)
        {
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling Balance");

			var headerParams = new Dictionary<String, String>();

			var path = "/account/{network}/{address}/balance";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (NativeBalance)ApiClient.Deserialize(data, typeof(NativeBalance), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Balance: {response.ReasonPhrase} {data}");
			}
		}

		public async Task<List<SplTokenBalanace>> GetSplTokens(NetworkTypes network, string address)
		{
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetSplTokens");

			var headerParams = new Dictionary<String, String>();

			var path = "/account/{network}/{address}/tokens";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (List<SplTokenBalanace>)ApiClient.Deserialize(data, typeof(List<SplTokenBalanace>), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetSplTokens: {response.ReasonPhrase} {data}");
			}
		}

		public async Task<List<SplNft>> GetNFTs(NetworkTypes network, string address)
        {
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTs");

			var headerParams = new Dictionary<String, String>();

			var path = "/account/{network}/{address}/nft";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };
			
			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (List<SplNft>)ApiClient.Deserialize(data, typeof(List<SplNft>), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetNFTs: {response.ReasonPhrase} {data}");
			}
		}

		public async Task<Portfolio> GetPortfolio(NetworkTypes network, string address)
        {
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetPortfolio");

			var headerParams = new Dictionary<String, String>();

			var path = "/account/{network}/{address}/portfolio";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (Portfolio)ApiClient.Deserialize(data, typeof(Portfolio), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Portfolio: {response.ReasonPhrase} {data}");
			}
		}
	}
}
