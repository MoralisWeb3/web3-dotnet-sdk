using Moralis.Network;
using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Api
{
    public class SettingsApi : ISettingsApi
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		public SettingsApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		public SettingsApi(String basePath)
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
		/// Retrieves current stream settings.
		/// </summary>
		/// <returns>SettingsDetail</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<SettingsDetail> GetSettings()
		{
			var headerParams = new Dictionary<String, String>();

			var path = "/settings";
		
			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (SettingsDetail)ApiClient.Deserialize(data, typeof(SettingsDetail), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Authentication Health Check: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Set the settings for the current project based on the project api-key.
		/// </summary>
		/// <param name="req">SettingsDetail</param>
		/// <returns>bool</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<bool> PostSettings(SettingsDetail req)
		{
			bool result = false;

			// Verify the required parameter 'address' is set
			if (req == null) throw new ApiException(400, "Missing required parameter 'req' when calling PostSettings");

			var headerParams = new Dictionary<String, String>();

			var path = "/settings";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				result = true;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairAddress: {response.ReasonPhrase}");
			}

			return result;
		}
	}
}
