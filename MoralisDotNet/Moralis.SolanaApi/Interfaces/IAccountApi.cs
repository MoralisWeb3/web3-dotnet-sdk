using System.Collections.Generic;
using System.Threading.Tasks;
using Moralis.Network;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Interfaces
{
    public interface IAccountApi
    {
        Task<NativeBalance> Balance(NetworkTypes network, string address);

        Task<List<SplTokenBalanace>> GetSplTokens(NetworkTypes network, string address);

        Task<List<SplNft>> GetNFTs(NetworkTypes network, string address);

        Task<Portfolio> GetPortfolio(NetworkTypes network, string address);
    }
}
