using Moralis.AuthApi.Models;

namespace Moralis.AuthApi.Interfaces
{
    public interface IAuthEndpoint
    {
        public ChallengeResponseDto Challenge(ChallengeRequestDto request);

        public CompleteChallengeResponseDto CompleteChallenge(CompleteChallengeRequestDto request);

        public HealthCheckResponse HealthCheck();
    }
}
