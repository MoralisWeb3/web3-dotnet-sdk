using Moralis.Network;
using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Api
{
    public class BetaApi : IBetaApi
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HistoryApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		public BetaApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="HistoryApi"/> class.
		/// </summary>
		public BetaApi(String basePath)
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
		/// Retrieves history.
		/// </summary>
		/// <param name="limit">double</param>
		/// <param name="cursor">string</param>
		/// <returns>LogResponse</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<StatsDetail> GetStats()
		{
			var headerParams = new Dictionary<String, String>();

			var path = "/beta/stats";
			var queryParams = new Dictionary<String, String>();
			 
			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (StatsDetail)ApiClient.Deserialize(data, typeof(StatsDetail), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetStats: {response.ReasonPhrase} {data}");
			}
		}
	}
}
