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
                Address = addr,
                ChainId = 80001,
                Domain = "1155project.com",
                ExpirationTime = DateTime.UtcNow.AddMinutes(60),
                NotBefore = DateTime.UtcNow,
                Resources = new string[] { "Boy Howdy" },
                Timeout = 15,
                Statement = "Please confirm",
                Uri = "https://1155project.com/"
            };

            resp = await authApi.AuthEndpoint.Challenge(req);

            return resp;
        }
    }
}
