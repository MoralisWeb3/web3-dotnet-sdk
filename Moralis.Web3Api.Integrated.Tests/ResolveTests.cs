using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class ResolveTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test ResolveDomain");
            if (await ResolveDomain(web3Api))
            {
                testResults.PassedTests.Add("ResolveDomain", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("ResolveDomain", "FAILED");
            }

            Console.WriteLine("Running test ResolveAddress");
            if (await ResolveAddress(web3Api))
            {
                testResults.PassedTests.Add("ResolveAddress", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("ResolveAddress", "FAILED");
            }

            return testResults;
        }

        private async Task<bool> ResolveDomain(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Resolve resp = await web3Api.Resolve.ResolveDomain(WebUtility.UrlEncode ("brad.crypto") );

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> ResolveAddress(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Ens resp = await web3Api.Resolve.ResolveAddress("0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045");

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
