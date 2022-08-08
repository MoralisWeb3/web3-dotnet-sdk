using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Moralis.Network;
using Moralis.SolanaApi.Interfaces;
using Moralis.SolanaApi.Models;

namespace Moralis.Moralis.SolanaApi.Api
{
    public class TokenApi : ITokenApi
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="TokenApi"/> class.
		/// </summary>
		/// <param name="apiClient"> an instance of ApiClient (optional)</param>
		/// <returns></returns>
		public TokenApi(ApiClient apiClient = null)
		{
			if (apiClient == null) // use the default one in Configuration
				this.ApiClient = Configuration.DefaultApiClient;
			else
				this.ApiClient = apiClient;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TokenApi"/> class.
		/// </summary>
		/// <returns></returns>
		public TokenApi(string basePath)
		{
			this.ApiClient = new ApiClient(basePath);
		}

		/// <summary>
		/// Sets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public void SetBasePath(string basePath)
		{
			this.ApiClient.BasePath = basePath;
		}

		/// <summary>
		/// Gets the base path of the API client.
		/// </summary>
		/// <param name="basePath">The base path</param>
		/// <value>The base path</value>
		public string GetBasePath(string basePath)
		{
			return this.ApiClient.BasePath;
		}

		/// <summary>
		/// Gets or sets the API client.
		/// </summary>
		/// <value>An instance of the ApiClient</value>
		public ApiClient ApiClient { get; set; }

		public async Task<SplTokenPrice> GetTokenPrice(NetworkTypes network, string address)
        {
			// Verify the required parameter 'pairAddress' is set
			if (address == null) throw new ApiException(400, "Missing required parameter 'address' when calling GetNFTMetadata");

			var headerParams = new Dictionary<string, string>();

			var path = "/token/{network}/{address}/price";
			path = path.Replace("{" + "network" + "}", ApiClient.ParameterToString(network.ToString()));
			path = path.Replace("{" + "address" + "}", ApiClient.ParameterToString(address));

			// Authentication setting, if any
			string[] authSettings = new string[] { "ApiKeyAuth" };

			HttpResponseMessage response =
				await ApiClient.CallApi(path, HttpMethod.Get, null, null, headerParams, null, null, authSettings);

			if (HttpStatusCode.OK.Equals(response.StatusCode))
			{
				string data = await response.Content.ReadAsStringAsync();
				List<Parameter> headers = ApiClient.ResponHeadersToParameterList(response.Headers);

				return (SplTokenPrice)ApiClient.Deserialize(data, typeof(SplTokenPrice), headers);
			}
			else
			{
				throw new ApiException((int)response.StatusCode, $"Error calling GetTokenPrice: {response.ReasonPhrase}");
			}
		}
    }
}
