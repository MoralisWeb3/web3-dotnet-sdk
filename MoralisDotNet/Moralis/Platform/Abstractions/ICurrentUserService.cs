using System.Threading;
using Cysharp.Threading.Tasks;
using Moralis.Platform.Objects;

namespace Moralis.Platform.Abstractions
{
    public interface ICurrentUserService<TUser> : ICurrentObjectService<TUser, TUser> where TUser : MoralisUser
    {
        TUser CurrentUser { get; set; }

        UniTask<string> GetCurrentSessionTokenAsync(IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default);

        UniTask LogOutAsync(IServiceHub<TUser> serviceHub, CancellationToken cancellationToken = default);
    }
}
