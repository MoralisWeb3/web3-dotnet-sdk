using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Integrated.Tests
{
    internal class LoggerTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetLogs");
            if (await GetLogs(streamsApi))
            {
                testResults.PassedTests.Add("GetLogs", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetLogs", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        public async Task<bool> GetLogs(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                LogResponse resp = await streamsApi.LoggerEndpoint.GetLogs(10, "debug", null);

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
