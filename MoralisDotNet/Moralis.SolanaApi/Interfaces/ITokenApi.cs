using System.Threading.Tasks;
using Moralis.Network;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Interfaces
{
    public interface ITokenApi
    {
        Task<SplTokenPrice> GetTokenPrice(NetworkTypes network, string address);
    }
}
