using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Moralis.Network;
using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using Newtonsoft.Json;

namespace Moralis.Moralis.StreamsApi.Api
{
    public  class StreamsApi : IStreamsApi
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		public StreamsApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
		/// </summary>
		public StreamsApi(String basePath)
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
		/// 
		/// </summary>
		/// <value>An instance of the ApiClient</value>
		public ApiClient ApiClient { get; set; }

		/// <summary>
		/// Creates a new stream
		/// </summary>
		/// <param name="req">StreamBindingDto</param>
		/// <returns>StreamBindingDto</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<StreamBindingDto> BindStream(StreamBindingDto req)
        {
			// Verify the required parameter 'req' is set
			if (req == null) throw new ApiException(400, "Missing required parameter 'req' when calling BindStream");

			var headerParams = new Dictionary<String, String>();

			var path = "/settings";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Put, null, bodyData, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairAddress: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Removes a specified atream binding.
		/// </summary>
		/// <param name="streamId">string</param>
		/// <returns>StreamBindingDto</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<StreamBindingDto> DeleteStream(string streamId)
        {
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling UpdateStream");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling UpdateStream");

			var headerParams = new Dictionary<String, String>();

			var path = "/streams/{id}";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Delete, null, null, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairAddress: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Gets a specific stream definition.
		/// </summary>
		/// <param name="streamId"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
        public async Task<StreamBindingDto> GetStream(string streamId)
        {
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling GetStream");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling UpdateStream");

			var headerParams = new Dictionary<String, String>();

			var path = "/streams/{id}";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Authentication Health Check: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Get all the stream definitions for the current project based on the project api-key.
		/// </summary>
		/// <returns>StreamBindingDto List</returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<List<StreamBindingDto>> GetStreams()
        {
			var headerParams = new Dictionary<String, String>();

			var path = "/streams";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (List<StreamBindingDto>)ApiClient.Deserialize(data, typeof(List<StreamBindingDto>), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling Authentication Health Check: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Updates a specific stream.
		/// </summary>
		/// <param name="req">StreamBindingDto</param>
		/// <returns>StreamBindingDto</returns>
		/// <exception cref="ApiException"></exception>
		public async Task<StreamBindingDto> UpdateStream(StreamBindingDto req)
        {
			// Verify the required parameter 'req' is set
			if (req == null) throw new ApiException(400, "Missing required parameter 'req' when calling UpdateStream");
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(req.StreamId)) throw new ApiException(400, "Missing required parameter 'req.streamId' when calling UpdateStream");
			// Validate Id
			if (!ValidateUuid(req.StreamId)) throw new ApiException(400, "Parameter 'req.streamId' must be a valid UUID (RFC_4122) when calling UpdateStream");
			
			var headerParams = new Dictionary<String, String>();

			var path = "/streams/{id}";
			path = path.Replace("{" + "id" + "}", req.StreamId);

			// Make sure the the streamId in the request is null - this is passed in the path only.
			req.StreamId = null;

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Put, null, bodyData, headerParams, null, null, authSettings);

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairAddress: {response.ReasonPhrase}");
			}
		}

		/// <summary>
		/// Validates that the specified value qualifies as valid under [RFC_4122](https://www.rfc-editor.org/rfc/rfc4122)
		/// </summary>
		/// <param name="uuid">string</param>
		/// <returns>bool</returns>
		private static bool ValidateUuid(string uuid)
		{
			Regex regex = new Regex("[0-9A-Fa-f]{8}-[0-9A-Fa-f]{4}-4[0-9A-Fa-f]{3}-[89ABab][0-9A-Fa-f]{3}-[0-9A-Fa-f]{12}");

			return regex.IsMatch(uuid);
		}
	}
}
