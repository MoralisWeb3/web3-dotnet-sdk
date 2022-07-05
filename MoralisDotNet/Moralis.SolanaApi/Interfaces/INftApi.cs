using System.Threading.Tasks;
using Moralis.SolanaApi.Models;

namespace Moralis.SolanaApi.Interfaces
{
    public interface INftApi
    {
        Task<NftMetadata> GetNFTMetadata(NetworkTypes network, string address);
    }
}
