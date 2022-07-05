using System.Threading;
using Moralis.Platform.Objects;
using System.Threading.Tasks;

namespace Moralis.Platform.Abstractions
{
    public interface ISessionService<TUser> where TUser : MoralisUser
    {
        Task<MoralisSession> GetSessionAsync(string sessionToken, IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default);

        Task RevokeAsync(string sessionToken, CancellationToken cancellationToken = default);

        Task<MoralisSession> UpgradeToRevocableSessionAsync(string sessionToken, IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default);

        bool IsRevocableSessionToken(string sessionToken);
    }
}
