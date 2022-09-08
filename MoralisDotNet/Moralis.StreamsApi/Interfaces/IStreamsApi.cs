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
		/// <returns></returns>
		public Task<StreamBindingDto> GetStream(string id);

		/// <summary>
		/// Get all the streams for the current project based on the project api-key.
		/// </summary>
		/// <returns>List<StreamBindingDto></returns>
		public Task<List<StreamBindingDto>> GetStreams();

		/// <summary>
		/// Updates a specific stream.
		/// </summary>
		/// <param name="req"></param>
		/// <returns></returns>
		public Task<StreamBindingDto> UpdateStream(StreamBindingDto req);
	}
	
}
