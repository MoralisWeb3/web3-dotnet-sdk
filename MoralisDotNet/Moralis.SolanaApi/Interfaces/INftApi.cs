using Cysharp.Threading.Tasks;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Interfaces
{
    public interface INftApi
    {
        UniTask<NftMetadata> GetNFTMetadata(NetworkTypes network, string address);
    }
}
