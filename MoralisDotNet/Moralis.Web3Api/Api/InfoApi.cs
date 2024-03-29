﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Moralis.Network;
using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System.Net.Http;

namespace Moralis.Web3Api.Api
{
    public class InfoApi : IInfoApi
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="DefiApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public InfoApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DefiApi"/> class.
		/// </summary>
		/// <returns></returns>
		public InfoApi(String basePath)
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

		/// <summary>
		/// Returns the current version of the Web3 API
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ApiException"></exception>
		public async Task<VersionResponse> GetWeb3ApiVersion()
		{
			var postBody = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();

			var path = "/web3/version";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, bodyData, headerParams, formParams, fileParams, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (VersionResponse)ApiClient.Deserialize(data, typeof(VersionResponse), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairReserves: {response.ReasonPhrase} {data}");
			}
		}

		/// <summary>
		/// Returns the endpoint price list for rate limits and costs.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ApiException"></exception>
		public async Task<List<EndpointWeights>> GetEndpointWeights()
		{
			var postBody = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();

			var path = "/info/endpointWeights";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, bodyData, headerParams, formParams, fileParams, authSettings);

			string data = await response.ExtractContentAsString();

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (List<EndpointWeights>)ApiClient.Deserialize(data, typeof(List<EndpointWeights>), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairReserves: {response.ReasonPhrase} {data}");
			}
		}
	}
}
