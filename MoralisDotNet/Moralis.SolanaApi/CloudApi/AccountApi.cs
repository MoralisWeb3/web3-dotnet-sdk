using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using Moralis.SolanaApi.Client;
using Moralis.SolanaApi.Interfaces;
using Moralis.SolanaApi.Models;
using System.Net.Http;
using Moralis.Network;

namespace Moralis.SolanaApi.CloudApi
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
		public AccountApi(String basePath)
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

		public async Task<NativeBalance> Balance(NetworkTypes network, string address)
		{
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var postBody = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			var path = "/functions/sol-balance";
			postBody.Add("network", ApiClient.ParameterToString(network.ToString()));
			if (address != null) postBody.Add("address", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<NativeBalance>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<NativeBalance>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Balance: {response.ReasonPhrase}");
			}
		}

		public async Task<List<SplTokenBalanace>> GetSplTokens(NetworkTypes network, string address)
		{
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var postBody = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			var path = "/functions/sol-getSPL";
			postBody.Add("network", ApiClient.ParameterToString(network.ToString()));
			if (address != null) postBody.Add("address", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<List<SplTokenBalanace>>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<List<SplTokenBalanace>>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetSplTokens: {response.ReasonPhrase}");
			}
		}

		public async Task<List<SplNft>> GetNFTs(NetworkTypes network, string address)
		{
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var postBody = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			var path = "/functions/sol-getNFTs";
			postBody.Add("network", ApiClient.ParameterToString(network.ToString()));
			if (address != null) postBody.Add("address", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<List<SplNft>>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<List<SplNft>>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetNFTs: {response.ReasonPhrase}");
			}
		}

		public async Task<Portfolio> GetPortfolio(NetworkTypes network, string address)
		{
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var postBody = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			var path = "/functions/sol-getPortfolio";
			postBody.Add("network", ApiClient.ParameterToString(network.ToString()));
			if (address != null) postBody.Add("address", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<Portfolio>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<Portfolio>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPortfolio: {response.ReasonPhrase}");
			}
		}
	}
}
