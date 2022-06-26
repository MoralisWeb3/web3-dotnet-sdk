using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    internal class InfoTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetWeb3ApiVersion");
            if (await GetWeb3ApiVersion(web3Api))
            {
                testResults.PassedTests.Add("GetWeb3ApiVersion", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetWeb3ApiVersion", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetEndpointWeights");
            if (await GetEndpointWeights(web3Api))
            {
                testResults.PassedTests.Add("GetEndpointWeights", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetEndpointWeights", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> GetWeb3ApiVersion(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                VersionResponse version = await web3Api.Info.GetWeb3ApiVersion();

                result = version is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetEndpointWeights(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                List<EndpointWeights> weights = await web3Api.Info.GetEndpointWeights();

                result = weights is { } && weights.Count > 0;
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
