using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moralis.Platform;
using Moralis.Platform.Exceptions;
using Moralis.Platform.Queries;
using Moralis.Platform.Services;
using Moralis.Platform.Services.ClientServices;
using Moralis.Platform.Utilities;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;

namespace Moralis.Platform
{
    public class MoralisCloud<TUser> where TUser : MoralisUser
    {
        public IServiceHub<TUser> ServiceHub;

        public MoralisCloud(IServiceHub<TUser> serviceHub) => (ServiceHub) = (serviceHub);
        public async Task<T> RunAsync<T>(string name, IDictionary<string, object> parameters)
        {
            MoralisUser user = await this.ServiceHub.GetCurrentUserAsync();

            T result = await this.ServiceHub.CloudFunctionService.CallFunctionAsync<T>(name, parameters, user is { } ? user.sessionToken : "");

            return result;
        }
    }
}
