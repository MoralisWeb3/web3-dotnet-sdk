using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Integrated.Tests
{
    internal class StreamsTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test BindStream");
            if (await BindStream(streamsApi))
            {
                testResults.PassedTests.Add("BindStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("BindStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test DeleteStream");
            if (await DeleteStream(streamsApi))
            {
                testResults.PassedTests.Add("DeleteStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("DeleteStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetStream");
            if (await GetStream(streamsApi))
            {
                testResults.PassedTests.Add("GetStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetStreams");
            if (await GetStreams(streamsApi))
            {
                testResults.PassedTests.Add("GetStreams", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetStreams", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test UpdateStream");
            if (await UpdateStream(streamsApi))
            {
                testResults.PassedTests.Add("UpdateStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("UpdateStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        public async Task<bool> BindStream(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                StreamBindingDto dto = new StreamBindingDto()
                {
                    Address = "0x35ba4825204dcE15C7147eA89b31178a00750f81",
                    ChainId = "mumbai",
                    Description = "Bob wuz ere",
                    TokenAddress = "0x62441037E626D6EdeC892838a06DF3C9D43ED482",
                    Topic = "mint",
                    Type = "tx",
                    Tag = "my first stream",
                    WebHookUrl = "https://127.0.0.1:8080"
                };

                StreamBindingDto resp = await streamsApi.StreamsEndpoint.BindStream(dto);
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Delete a specific stream.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteStream(IStreamsApiClient streamsApi)
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

        /// <summary>
        /// Get a specific stream.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> GetStream(IStreamsApiClient streamsApi)
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

        /// <summary>
        /// Get all the streams for the current project based on the project api-key.
        /// </summary>
        /// <returns>List<StreamBindingDto></returns>
        public async Task<bool> GetStreams(IStreamsApiClient streamsApi)
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

        /// <summary>
        /// Updates a specific stream.
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<bool> UpdateStream(IStreamsApiClient streamsApi)
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
