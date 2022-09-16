using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;

namespace Moralis.StreamsApi.Integrated.Tests
{
    internal class HistoryTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetHistory");
            if (await GetHistory(streamsApi))
            {
                testResults.PassedTests.Add("GetHistory", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetHistory", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> GetHistory(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                HistoryResponse resp = await streamsApi.HistoryEndpoint.GetHistory(10, null);

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
