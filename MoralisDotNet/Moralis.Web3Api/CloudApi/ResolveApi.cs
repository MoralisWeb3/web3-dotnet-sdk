/**
*            Module: ResolveApi.cs
*       Description: Represents a collection of functions to interact with the API endpoints
*            Author: Moralis Web3 Technology AB, 559307-5988 - David B. Goodrich
*  
* NOTE: THIS FILE HAS BEEN AUTOMATICALLY GENERATED. ANY CHANGES MADE TO THIS 
* FILE WILL BE LOST
*
* MIT License
*  
* Copyright (c) 2022 Moralis Web3 Technology AB, 559307-5988
*  
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the 'Software'), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Moralis.Web3Api.Client;
using Moralis.Web3Api.Core;
using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System.Net.Http;

namespace Moralis.Web3Api.CloudApi
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class ResolveApi : IResolveApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ResolveApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public ResolveApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient; 
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ResolveApi"/> class.
		/// </summary>
		/// <returns></returns>
		public ResolveApi(String basePath)
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
		public ApiClient ApiClient {get; set;}


		/// <summary>
		/// Resolves an Unstoppable domain and returns the address
		/// 
		/// </summary>
		/// <param name="domain">Domain to be resolved</param>
		/// <param name="currency">The currency to query</param>
		/// <returns>Returns an address</returns>
		public async Task<Resolve> ResolveDomain (string domain, string currency=null)
		{
			// Verify the required parameter 'domain' is set
			if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling ResolveDomain");

			var postBody = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();

			var path = "/functions/resolveDomain";
			if (domain != null) postBody.Add("domain", ApiClient.ParameterToString(domain));
			if (currency != null) postBody.Add("currency", ApiClient.ParameterToString(currency));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, queryParams, bodyData, headerParams, formParams, fileParams, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<Resolve>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<Resolve>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling ResolveDomain: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Resolves an ETH address and find the ENS name
		/// 
		/// </summary>
		/// <param name="address">The address to be resolved</param>
		/// <returns>Returns an ENS</returns>
		public async Task<Ens> ResolveAddress (string address)
		{
			// Verify the required parameter 'address' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling ResolveAddress");

			var postBody = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();
			var formParams = new Dictionary<String, String>();
			var fileParams = new Dictionary<String, FileParameter>();

			var path = "/functions/resolveAddress";
			if (address != null) postBody.Add("address", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = postBody.Count > 0 ? JsonConvert.SerializeObject(postBody) : null;

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, queryParams, bodyData, headerParams, formParams, fileParams, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return ((CloudFunctionResult<Ens>)ApiClient.Deserialize(data, typeof(CloudFunctionResult<Ens>), headers)).Result;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling ResolveAddress: {response.ReasonPhrase}");
			}
		}
	}
}
