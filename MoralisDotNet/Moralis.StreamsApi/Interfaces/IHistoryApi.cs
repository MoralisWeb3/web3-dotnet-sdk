using Moralis.StreamsApi.Models;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
    public interface IHistoryApi
    {
        /// <summary>
        /// Returns Webhook information - currently only Failed webhook information returned.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <returns></returns>
        Task<HistoryResponse> GetHistory(long limit, string cursor = "");
    }
}
