using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class DefiTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetPairAddress");
            if (await GetPairAddress(web3Api))
            {
                testResults.PassedTests.Add("GetPairAddress", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetPairAddress", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetPairReserves");
            if (await GetPairReserves(web3Api))
            {
                testResults.PassedTests.Add("GetPairReserves", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetPairReserves", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> GetPairAddress(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                ReservesCollection balance = await web3Api.Defi.GetPairAddress("uniswapv2", "0x2b591e99afe9f32eaa6214f7b7629768c40eeb39", "0xdac17f958d2ee523a2206206994597c13d831ec7", ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetPairReserves(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                ReservesCollection balance = await web3Api.Defi.GetPairReserves("0xa2107fa5b38d9bbd2c461d6edf11b11a50f6b974", ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

    }
}
