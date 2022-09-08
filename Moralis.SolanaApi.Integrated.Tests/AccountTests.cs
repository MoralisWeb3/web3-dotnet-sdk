using Moralis.Network;
using Moralis.SolanaApi.Interfaces;
using Moralis.SolanaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.SolanaApi.Integrated.Tests
{
    internal class AccountTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(ISolanaApi solanaApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetNativeBalance");
            if (await GetNativeBalance(solanaApi, address))
            {
                testResults.PassedTests.Add("GetNativeBalance", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNativeBalance", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetNfts");
            if (await GetNfts(solanaApi, address))
            {
                testResults.PassedTests.Add("GetNfts", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNfts", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> GetNativeBalance(ISolanaApi solanaApi, string address)
        {
            bool result = true;

            try
            {
                NativeBalance bal = await solanaApi.Account.Balance(NetworkTypes.mainnet, address);

                result = bal is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNfts(ISolanaApi solanaApi, string address)
        {
            bool result = true;

            try
            {
                List<SplNft> splNfts =
                    await solanaApi.Account.GetNFTs(NetworkTypes.mainnet, address);

                result = splNfts is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
