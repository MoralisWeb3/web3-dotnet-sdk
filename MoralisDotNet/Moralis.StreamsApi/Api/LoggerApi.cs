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
    public class LoggerApi : ILoggerApi
	{       
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		public LoggerApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		public LoggerApi(String basePath)
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
		/// Retrieves stream logs.
		/// </summary>
		/// <param name="limit">double</param>
		/// <param name="logType">string</param>
		/// <param name="cursor">string</param>
		/// <returns>LogResponse</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<LogResponse> GetLogs(double limit, string logType, string cursor)
		{
			var headerParams = new Dictionary<String, String>();

			var path = "/logger";
			var queryParams = new Dictionary<String, String>();

			queryParams.Add("limit", ApiClient.ParameterToString(limit));
			if (logType != null) queryParams.Add("logType", ApiClient.ParameterToString(logType));
			if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor));
			 
			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, null, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (LogResponse)ApiClient.Deserialize(data, typeof(LogResponse), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Authentication Health Check: {response.ReasonPhrase}");
			}
		}
	}
}
