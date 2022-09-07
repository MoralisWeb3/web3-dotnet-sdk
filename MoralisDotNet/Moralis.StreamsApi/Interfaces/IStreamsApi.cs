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
		/// 
		/// </summary>
		/// <param name="req"></param>
		/// <returns>bool</returns>
		public Task<StreamBindingDto> BindStream(StreamBindingDto req);

		public Task<StreamBindingDto> DeleteStream(string id);

		public Task<StreamBindingDto> GetStream(string id);

		/// <summary>
		/// 
		/// </summary>
		/// <returns>List<StreamBindingDto></returns>
		public Task<List<StreamBindingDto>> GetStreams();

		public Task<StreamBindingDto> UpdateStream(StreamBindingDto req);
	}
	
}
