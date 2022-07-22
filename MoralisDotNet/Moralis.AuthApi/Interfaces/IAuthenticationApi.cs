using Moralis.AuthApi.Models;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Interfaces
{
    public interface IAuthenticationApi
    {
        public Task<ChallengeResponseDto> Challenge(ChallengeRequestDto request, ChainNetworkType network);

        public Task<CompleteChallengeResponseDto> CompleteChallenge(CompleteChallengeRequestDto request, ChainNetworkType network);

        public Task<HealthCheckResponse> HealthCheck();
    }
}
