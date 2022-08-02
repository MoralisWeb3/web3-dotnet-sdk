using Moralis.AuthApi.Interfaces;
using Moralis.AuthApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Integrated.Tests
{
    internal class ChallengeTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IAuthClientApi authApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test PerformChallenge");
            if (await PerformChallenge(authApi, address))
            {
                testResults.PassedTests.Add("PerformChallenge", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("PerformChallenge", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> PerformChallenge(IAuthClientApi authApi, string addr)
        {
            bool result = true;

            try
            {
                ChallengeResponseDto resp = await SendChallengeRequest(authApi, addr);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<ChallengeResponseDto> SendChallengeRequest(IAuthClientApi authApi, string addr)
        {
            ChallengeResponseDto resp = null;

            ChallengeRequestDto req = new ChallengeRequestDto()
            {
                // The Ethereum address performing the signing conformant to capitalization encoded
                // checksum specified in EIP-55 where applicable.
                Address = addr,
                // The EIP-155 Chain ID to which the session is bound, and the network where Contract
                // Accounts MUST be resolved.
                ChainId = 80001,
                // The RFC 3986 authority that is requesting the signing
                Domain = "1155project.com",
                // The ISO 8601 datetime string that, if present, indicates when the signed
                // authentication message is no longer valid.
                ExpirationTime = DateTime.UtcNow.AddMinutes(60),
                // The ISO 8601 datetime string that, if present, indicates when the signed
                // authentication message will become valid.
                NotBefore = DateTime.UtcNow,
                // A list of information or references to information the user wishes to have resolved
                // as part of authentication by the relying party. They are expressed as RFC 3986 URIs
                // separated by "\n- " where \n is the byte 0x0a.
                Resources = new string[] { "https://www.moralis.io" },
                // Time is seconds at which point this request becomes invalid.
                Timeout = 120,
                // A human-readable ASCII assertion that the user will sign, and it must not
                // contain '\n' (the byte 0x0a).
                Statement = "Please confirm",
                // An RFC 3986 URI referring to the resource that is the subject of the signing
                // (as in the subject of a claim).
                Uri = "https://1155project.com/"
            };

            resp = await authApi.AuthEndpoint.Challenge(req, ChainNetworkType.evm);

            return resp;
        }
    }
}
