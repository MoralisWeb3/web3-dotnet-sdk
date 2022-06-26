using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Moralis.Web3Api.Models;

namespace Moralis.Web3Api.Interfaces
{
    public interface IInfoApi
    {
        Task<VersionResponse> GetWeb3ApiVersion();

        Task<EndpointWeights> GetEndpointWeights();
    }
}
