using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Interfaces
{
    public interface IAccountApi
    {
        UniTask<NativeBalance> Balance(NetworkTypes network, string address);

        UniTask<List<SplTokenBalanace>> GetSplTokens(NetworkTypes network, string address);

        UniTask<List<SplNft>> GetNFTs(NetworkTypes network, string address);

        UniTask<Portfolio> GetPortfolio(NetworkTypes network, string address);
    }
}
