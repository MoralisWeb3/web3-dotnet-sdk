using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Integrated.Tests
{
    internal class SettingsTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test PostSettings");
            if (await PostSettings(streamsApi))
            {
                testResults.PassedTests.Add("PostSettings", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("PostSettings", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetSettings");
            if (await GetSettings(streamsApi))
            {
                testResults.PassedTests.Add("GetSettings", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetSettings", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        public async Task<bool> GetSettings(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                SettingsDetail resp = await streamsApi.SettingsEndpoint.GetSettings();
                result = (resp is { } &&
                    resp.SecretKey.Equals(MoralisClient.ConnectionData.MasterKey) &&
                    resp.Region.Equals("eu-central-1"));
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
        public async Task<bool> PostSettings(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                SettingsDetail settings = new SettingsDetail()
                { 
                    Region = "eu-central-1",
                    SecretKey = MoralisClient.ConnectionData.MasterKey
                };
                
                result = await streamsApi.SettingsEndpoint.PostSettings(settings);
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
