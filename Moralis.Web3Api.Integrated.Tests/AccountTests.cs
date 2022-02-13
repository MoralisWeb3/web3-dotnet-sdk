using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moralis.Web3Api.Api;
using Moralis.Web3Api.CloudApi;
using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;

namespace Moralis.Web3Api.Integrated.Tests
{
    class AccountTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetNativeBalance");
            if (await GetNativeBalance (web3Api, address))
            {
                testResults.PassedTests.Add("GetNativeBalance", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNativeBalance", "FAILED");
            }

            Console.WriteLine("Running test GetNFTTransfers");
            if (await GetNFTTransfers(web3Api, address))
            {
                testResults.PassedTests.Add("GetNFTTransfers", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTTransfers", "FAILED");
            }

            Console.WriteLine("Running test GetTokenBalances");
            if (await GetTokenBalances(web3Api, address))
            {
                testResults.PassedTests.Add("GetTokenBalances", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenBalances", "FAILED");
            }

            Console.WriteLine("Running test GetTokenTransfers");
            if (await GetTokenTransfers(web3Api, address))
            {
                testResults.PassedTests.Add("GetTokenTransfers", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenTransfers", "FAILED");
            }

            Console.WriteLine("Running test GetTransactions");
            if (await GetTransactions(web3Api, address))
            {
                testResults.PassedTests.Add("GetTransactions", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTransactions", "FAILED");
            }

            Console.WriteLine("Running test GetNFTs");
            if (await GetNFTs(web3Api, address))
            {
                testResults.PassedTests.Add("GetNFTs", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTs", "FAILED");
            }

            Console.WriteLine("Running test GetNFTsForContract");
            if (await GetNFTsForContract(web3Api, address))
            {
                testResults.PassedTests.Add("GetNFTsForContract", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTsForContract", "FAILED");
            }
            return testResults;
        }

        private async Task<bool> GetNativeBalance(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                NativeBalance balance = await web3Api.Account.GetNativeBalance(address.ToLower(), ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTTransfers(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                NftTransferCollection balance = await web3Api.Account.GetNFTTransfers(address.ToLower(), ChainList.eth);

                result = balance is { } && balance.Result is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenBalances(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                List<Erc20TokenBalance> balance = await web3Api.Account.GetTokenBalances(address.ToLower(), ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenTransfers(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                Erc20TransactionCollection balance = await web3Api.Account.GetTokenTransfers(address.ToLower(), ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTransactions(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                TransactionCollection balance = await web3Api.Account.GetTransactions(address.ToLower(), ChainList.eth);

                result = balance is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTs(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                NftOwnerCollection resp = await web3Api.Account.GetNFTs(address.ToLower(), ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTsForContract(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                NftOwnerCollection resp = await web3Api.Account.GetNFTsForContract(address.ToLower(), "0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth);

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
