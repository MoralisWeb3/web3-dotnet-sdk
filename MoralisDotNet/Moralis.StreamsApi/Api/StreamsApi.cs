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

namespace Moralis.StreamsApi.Api
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

			var path = "/streams/evm";

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Put, null, bodyData, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling BindStream: {response.ReasonPhrase} {data}");
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

			var path = "/streams/evm/{id}";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Delete, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetPairAddress: {response.ReasonPhrase} {data}");
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

			var path = "/streams/evm/{id}";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling DeleteStream: {response.ReasonPhrase} {data}");
			}
		}

		/// <summary>
		/// Get all the stream definitions for the current project based on the project api-key.
		/// </summary>
		/// <returns>StreamBindingDto List</returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<StreamsResponse> GetStreams(long limit, string cursor = "")
        {
			var headerParams = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();

			var path = "/streams/evm";

			queryParams.Add("limit", ApiClient.ParameterToString(limit));
			if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (StreamsResponse)ApiClient.Deserialize(data, typeof(StreamsResponse), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetStreams: {response.ReasonPhrase} {data}");
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

			var path = "/streams/evm/{id}";
			path = path.Replace("{" + "id" + "}", req.StreamId);

			// Make sure the the streamId in the request is null - this is passed in the path only.
			req.StreamId = null;

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling UpdateStream: {response.ReasonPhrase} {data}");
			}
		}



		/// <summary>
		/// Updates the status of specific evm stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="req"></param>
		/// <returns>StreamBindingDto</returns>
		public async Task<StreamBindingDto> SetStreamStatus(string streamId, StreamsStatusUpdate req)
		{
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling SetStreamStatus");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling SetStreamStatus");

			var headerParams = new Dictionary<String, String>();

			var path = "/streams/evm/{id}/status";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(req);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				StreamBindingDto resp = (StreamBindingDto)ApiClient.Deserialize(data, typeof(StreamBindingDto), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling SetStreamStatus: {response.ReasonPhrase} {data}");
			}
		}

		/// <summary>
		/// Get all addresses associated with a specific stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="limit"></param>
		/// <param name="cursor"></param>
		/// <returns></returns>
		public async Task<StreamsResponse> GetStreamsAddresses(string streamId, long limit, string cursor = "")
		{
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling GetStreamsAddresses");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling GetStreamsAddresses");

			var headerParams = new Dictionary<String, String>();
			var queryParams = new Dictionary<String, String>();

			var path = "/streams/evm/{id}/address";
			path = path.Replace("{" + "id" + "}", streamId);

			queryParams.Add("limit", ApiClient.ParameterToString(limit));
			if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor));

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, queryParams, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (StreamsResponse)ApiClient.Deserialize(data, typeof(StreamsResponse), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetStreamsAddresses: {response.ReasonPhrase} {data}");
			}
		}

		/// <summary>
		/// Add a wallet or contract address to a stream.
		/// </summary>
		/// <param name="streamId">string</param>
		/// <param name="address">StreamsAddressRequest</param>
		/// <returns>AddressResponse</returns>
		public async Task<AddressResponse> AddAddressToStream(string streamId, StreamsAddressRequest address)
		{
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling AddAddressToStream");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling AddAddressToStream");

			var headerParams = new Dictionary<String, String>();

			var path = "/streams/evm/{id}/address";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			string bodyData = JsonConvert.SerializeObject(address);

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Post, null, bodyData, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				AddressResponse resp = (AddressResponse)ApiClient.Deserialize(data, typeof(AddressResponse), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling AddAddressToStream: {response.ReasonPhrase} {data}");
			}
		}

		/// <summary>
		/// Removes an address from a stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="address"></param>
		/// <returns>AddressResponse</returns>
		public async Task<DeleteAddressResponse> RemoveAddressFromStream(string streamId, StreamsAddressRequest address)
		{
			// Verify stream Id is set.
			if (string.IsNullOrEmpty(streamId)) throw new ApiException(400, "Missing required parameter 'streamId' when calling RemoveAddressFromStream");
			// Validate Id
			if (!ValidateUuid(streamId)) throw new ApiException(400, "Parameter 'streamId' must be a valid UUID (RFC_4122) when calling RemoveAddressFromStream");

			var headerParams = new Dictionary<String, String>();

			var path = "/streams/evm/{id}/address";
			path = path.Replace("{" + "id" + "}", streamId);

			// Authentication setting, if any
			String[] authSettings = new String[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Delete, null, null, headerParams, null, null, authSettings);

			string data = await response.ExtractContentAsString();

			if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
			{
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				DeleteAddressResponse resp = (DeleteAddressResponse)ApiClient.Deserialize(data, typeof(DeleteAddressResponse), headers);
				return resp;
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling RemoveAddressFromStream: {response.ReasonPhrase} {data}");
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
