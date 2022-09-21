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

            await Task.Delay(250);

            Console.WriteLine("Running test ReplayHistory");
            if (await ReplayHistory(streamsApi))
            {
                testResults.PassedTests.Add("ReplayHistory", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("ReplayHistory", "FAILED");
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

        private async Task<bool> ReplayHistory(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                HistoryDetail resp = await streamsApi.HistoryEndpoint.ReplayHistory("76d23139-ea6b-4231-a202-1a341fabbd4c");

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
