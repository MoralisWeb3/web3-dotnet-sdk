using Moralis.StreamsApi.Models;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
    public interface ILoggerApi
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="limit"></param>
		/// <param name="logType"></param>
		/// <param name="cursor"></param>
		/// <returns></returns>
		public Task<LogResponse> GetLogs(double limit, string logType, string cursor);
	}
}
