using Moralis.AuthApi.Models;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Interfaces
{
    /// <summary>
    /// Defines properties and methods of an Authentication Api Endpoint.
    /// </summary>
    public interface IAuthenticationApi
    {
        /// <summary>
		/// Calls the Moralis Authentication Api Challenge operation to generate an authentication message.
		/// </summary>
		/// <param name="request"></param>
		/// <param name="network"></param>
		/// <returns>ChallengeResponseDto</returns>
		/// <exception cref="ApiException"></exception>
		public Task<ChallengeResponseDto> Challenge(ChallengeRequestDto request, ChainNetworkType network);

        /// <summary>
		/// After a message is signed this operation is used to call the Moralis Authentication Challenge Verify operation to validate the signature.
		/// </summary>
		/// <param name="request"></param>
		/// <param name="network"></param>
		/// <returns>CompleteChallengeResponseDto</returns>
		/// <exception cref="ApiException"></exception>
		public Task<CompleteChallengeResponseDto> CompleteChallenge(CompleteChallengeRequestDto request, ChainNetworkType network);

        /// <summary>
        /// Exposes the HealthCheck operation of the Moralis Authentication API which enables client applications a way to determine that the Moralis Authentrication Api is available.
        /// </summary>
        /// <returns>HealthCheckResponse</returns>
        /// <exception cref="ApiException"></exception>
        public Task<HealthCheckResponse> HealthCheck();
    }
}
