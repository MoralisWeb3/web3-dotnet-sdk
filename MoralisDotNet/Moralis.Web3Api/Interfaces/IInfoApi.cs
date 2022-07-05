using System.Collections.Generic;
using System.Threading.Tasks;
using Moralis.Web3Api.Models;

namespace Moralis.Web3Api.Interfaces
{
    public interface IInfoApi
    {
        Task<VersionResponse> GetWeb3ApiVersion();

        Task<List<EndpointWeights>> GetEndpointWeights();
    }
}
