using Moralis.AuthApi.Interfaces;
using Moralis.AuthApi.Models;
using System;
using System.Threading.Tasks;

namespace Moralis.AuthApi.Integrated.Tests
{
    internal class HealthCheckTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IAuthClientApi authApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test PerformHealthChek");
            if (await PerformHealthChek(authApi))
            {
                testResults.PassedTests.Add("PerformHealthChek", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("PerformHealthChek", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> PerformHealthChek(IAuthClientApi authApi)
        {
            bool result = true;

            try
            {
                HealthCheckResponse resp = await authApi.AuthEndpoint.HealthCheck();

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
