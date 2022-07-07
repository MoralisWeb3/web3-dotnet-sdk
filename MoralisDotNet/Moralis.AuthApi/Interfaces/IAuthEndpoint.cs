using Moralis.AuthApi.Models;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Interfaces
{
    public interface IAuthEndpoint
    {
        public Task<ChallengeResponseDto> Challenge(ChallengeRequestDto request);

        public Task<CompleteChallengeResponseDto> CompleteChallenge(CompleteChallengeRequestDto request);

        public Task<HealthCheckResponse> HealthCheck();
    }
}
