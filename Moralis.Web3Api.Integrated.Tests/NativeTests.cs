using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class NativeTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetBlock");
            if (await GetBlock(web3Api))
            {
                testResults.PassedTests.Add("GetBlock", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetBlock", "FAILED");
            }

            Console.WriteLine("Running test GetContractEvents");
            if (await GetContractEvents(web3Api))
            {
                testResults.PassedTests.Add("GetContractEvents", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetContractEvents", "FAILED");
            }

            Console.WriteLine("Running test GetDateToBlock");
            if (await GetDateToBlock(web3Api))
            {
                testResults.PassedTests.Add("GetDateToBlock", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetDateToBlock", "FAILED");
            }

            Console.WriteLine("Running test GetLogsByAddress");
            if (await GetLogsByAddress(web3Api, address))
            {
                testResults.PassedTests.Add("GetLogsByAddress", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetLogsByAddress", "FAILED");
            }

            Console.WriteLine("Running test GetNFTTransfersByBlock");
            if (await GetNFTTransfersByBlock(web3Api))
            {
                testResults.PassedTests.Add("GetNFTTransfersByBlock", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTTransfersByBlock", "FAILED");
            }

            Console.WriteLine("Running test GetTransaction");
            if (await GetTransaction(web3Api))
            {
                testResults.PassedTests.Add("GetTransaction", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTransaction", "FAILED");
            }

            Console.WriteLine("Running test RunContractFunction");
            if (await RunContractFunction(web3Api))
            {
                testResults.PassedTests.Add("RunContractFunction", "PASSED");
            }
            else
            {              
                testResults.FailedTests.Add("RunContractFunction", "FAILED");
            }

            Console.WriteLine("Running test RunContractFunction1");
            if (await RunContractFunction1(web3Api))
            {
                testResults.PassedTests.Add("RunContractFunction1", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("RunContractFunction1", "FAILED");
            }

            return testResults;
        }

        private async Task<bool> GetBlock(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Block block = await web3Api.Native.GetBlock("500000", ChainList.eth);

                result = block is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetContractEvents(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                // Function ABI input parameters
                object[] inputParams = new object[3];
                inputParams[0] = new { index = true, internalType = "bytes32", name = "role", type = "bytes32" };
                inputParams[1] = new { index = true, internalType = "address", name = "account", type = "address" };
                inputParams[2] = new { index = true, internalType = "address", name = "sender", type = "address" };
                // Function ABI
                object abi = new { anonymous = false, inputs = inputParams, name = "RoleGranted", type = "event" };

                List<LogEvent> logEvents = await web3Api.Native.GetContractEvents("0x698d7D745B7F5d8EF4fdB59CeB660050b3599AC3", "uri", abi, ChainList.mumbai);

                result = logEvents is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetDateToBlock(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                long unixTicks = ConvertDatetimeToUnixTimeStamp(DateTime.Now.AddDays(-1));

            // Fails due to schema def:
            // date*	number
            //            example: 2020 - 01 - 01T00: 00:00 + 00:00
            //The date of the block
                BlockDate blockDate = await web3Api.Native.GetDateToBlock(unixTicks.ToString(), ChainList.eth);

                result = blockDate is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetLogsByAddress(IWeb3Api web3Api, string address)
        {
            bool result = true;

            try
            {
                LogEventByAddress logEvents = await web3Api.Native.GetLogsByAddress(address, ChainList.eth);

                result = logEvents is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTTransfersByBlock(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftTransferCollection nftTransfers = await web3Api.Native.GetNFTTransfersByBlock("500000", ChainList.eth);

                result = nftTransfers is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTransaction(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                BlockTransaction blockTransaction = await web3Api.Native.GetTransaction("0xdc85cb1b75fd09c2f6d001fea4aba83764193cbd7881a1fa8ccde350a5681109", ChainList.eth);

                result = blockTransaction is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> RunContractFunction(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                // Function ABI input parameters
                object[] inputParams = new object[1];
                inputParams[0] = new { internalType = "uint256", name = "id", type = "uint256" };
                // Function ABI Output parameters
                object[] outputParams = new object[1];
                outputParams[0] = new { internalType = "string", name = "", type = "string" };
                // Function ABI
                object[] abi = new object[1];
                abi[0] = new { inputs = inputParams, name = "uri", outputs = outputParams, stateMutability = "view", type = "function" };

                // Define request object
                RunContractDto rcd = new RunContractDto()
                {
                    Abi = abi,
                    Params = new { id = "15310200874782" }
                };

                string resp  = await web3Api.Native.RunContractFunction("0x698d7D745B7F5d8EF4fdB59CeB660050b3599AC3", "uri", rcd, ChainList.mumbai);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
        private async Task<bool> RunContractFunction1(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                // Function ABI input parameters
                object[] inputParams = new object[1];
                inputParams[0] = new { internalType = "uint256", name = "id", type = "uint256" };

                // Function ABI Output parameters
                object[] outputParams = new object[5];
                outputParams[0] = new { internalType = "uint256", name = "offerId", type = "uint256" };
                outputParams[1] = new { internalType = "uint256", name = "id", type = "uint256" };
                outputParams[2] = new { internalType = "address", name = "user", type = "address" };
                outputParams[3] = new { internalType = "uint256", name = "price", type = "uint256" };
                outputParams[4] = new { internalType = "bool", name = "fulfilled", type = "bool" };

                // Function ABI
                object[] abi = new object[1];
                abi[0] = new { inputs = inputParams, name = "offers", outputs = outputParams, stateMutability = "view", type = "function" };


                // Define request object
                RunContractDto rcd = new RunContractDto()
                {
                    Abi = abi,
                    Params = new { id="1" }
                };

                string resp = await web3Api.Native.RunContractFunction("0x383cAe6B39ad82305242EFcfDa6EC5B2a52B4620", "offers", rcd, ChainList.mumbai);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private static long ConvertDatetimeToUnixTimeStamp(DateTime date)
        {
            DateTime originDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan dif = date.ToUniversalTime() - originDate;
            return (long)Math.Floor(dif.TotalSeconds);
        }
    }
}
