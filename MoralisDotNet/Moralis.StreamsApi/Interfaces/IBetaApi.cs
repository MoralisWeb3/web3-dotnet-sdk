using Moralis.StreamsApi.Models;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Interfaces
{
    public interface IBetaApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<StatsDetail> GetStats();
    }
}
