using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
	
    public interface IStreamsApi
	{
		/// <summary>
		/// Creates a new stream.
		/// </summary>
		/// <param name="req"></param>
		/// <returns>bool</returns>
		public Task<StreamBindingDto> BindStream(StreamBindingDto req);

		/// <summary>
		/// Delete a specific stream.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Task<StreamBindingDto> DeleteStream(string id);

		/// <summary>
		/// Get a specific stream.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>StreamBindingDto[]</returns>
		public Task<StreamBindingDto> GetStream(string id);

		/// <summary>
		/// Get all the streams for the current project based on the project api-key.
		/// </summary>
		/// <returns>List<StreamBindingDto></returns>
		public Task<StreamsResponse> GetStreams(long limit, string cursor);

		/// <summary>
		/// Updates a specific stream.
		/// </summary>
		/// <param name="req"></param>
		/// <returns></returns>
		public Task<StreamBindingDto> UpdateStream(StreamBindingDto req);

		/// <summary>
		/// Updates the status of specific evm stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="req"></param>
		/// <returns>StreamBindingDto</returns>
		public Task<StreamBindingDto> SetStreamStatus(string streamId, StreamsStatusUpdate req);

		/// <summary>
		/// Get all addresses associated with a specific stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="limit"></param>
		/// <param name="cursor"></param>
		/// <returns></returns>
		public Task<StreamsResponse> GetStreamsAddresses(string streamId, long limit, string cursor="");

		/// <summary>
		/// Add a wallet or contract address to a stream.
		/// </summary>
		/// <param name="streamId">string</param>
		/// <param name="address">StreamsAddressRequest</param>
		/// <returns>AddressResponse</returns>
		public Task<AddressResponse> AddAddressToStream(string streamId, StreamsAddressRequest address);

		/// <summary>
		/// Removes an address from a stream.
		/// </summary>
		/// <param name="streamId"></param>
		/// <param name="address"></param>
		/// <returns>AddressResponse</returns>
		public Task<DeleteAddressResponse> RemoveAddressFromStream(string streamId, StreamsAddressRequest address);

	}
	
}
