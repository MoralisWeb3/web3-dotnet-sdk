using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class TokenTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test GetAllTokenIds");
            if (await GetAllTokenIds(web3Api))
            {
                testResults.PassedTests.Add("GetAllTokenIds", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetAllTokenIds", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetContractNFTTransfers");
            if (await GetContractNFTTransfers(web3Api))
            {
                testResults.PassedTests.Add("GetContractNFTTransfers", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetContractNFTTransfers", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetNFTLowestPrice");
            if (await GetNFTLowestPrice(web3Api))
            {
                testResults.PassedTests.Add("GetNFTLowestPrice", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTLowestPrice", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetNFTMetadata");
            if (await GetNFTMetadata(web3Api))
            {
                testResults.PassedTests.Add("GetNFTMetadata", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTMetadata", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetNFTOwners");
            if (await GetNFTOwners(web3Api))
            {
                testResults.PassedTests.Add("GetNFTOwners", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTOwners", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetNFTTrades");
            if (await GetNFTTrades(web3Api))
            {
                testResults.PassedTests.Add("GetNFTTrades", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNFTTrades", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetNftTransfersFromToBlock");
            if (await GetNftTransfersFromToBlock(web3Api))
            {
                testResults.PassedTests.Add("GetNftTransfersFromToBlock", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetNftTransfersFromToBlock", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenAdressTransfers");
            if (await GetTokenAdressTransfers(web3Api))
            {
                testResults.PassedTests.Add("GetTokenAdressTransfers", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenAdressTransfers", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenIdMetadata");
            if (await GetTokenIdMetadata(web3Api))
            {
                testResults.PassedTests.Add("GetTokenIdMetadata", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenIdMetadata", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenIdOwners");
            if (await GetTokenIdOwners(web3Api))
            {
                testResults.PassedTests.Add("GetTokenIdOwners", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenIdOwners", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenMetadata");
            if (await GetTokenMetadata(web3Api))
            {
                testResults.PassedTests.Add("GetTokenMetadata", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenMetadata", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenMetadataBySymbol");
            if (await GetTokenMetadataBySymbol(web3Api))
            {
                testResults.PassedTests.Add("GetTokenMetadataBySymbol", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenMetadataBySymbol", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenPrice");
            if (await GetTokenPrice(web3Api))
            {
                testResults.PassedTests.Add("GetTokenPrice", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenPrice", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetWalletTokenIdTransfers");
            if (await GetWalletTokenIdTransfers(web3Api))
            {
                testResults.PassedTests.Add("GetWalletTokenIdTransfers", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetWalletTokenIdTransfers", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test SearchNFTs");
            if (await SearchNFTs(web3Api))
            {
                testResults.PassedTests.Add("SearchNFTs", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("SearchNFTs", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(500);

            Console.WriteLine("Running test GetTokenAllowance");
            if (await GetTokenAllowance(web3Api))
            {
                testResults.PassedTests.Add("GetTokenAllowance", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetTokenAllowance", "FAILED");
                Console.WriteLine("\tFAILED");
            }
            
            return testResults;
        }

        private async Task<bool> GetAllTokenIds(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftCollection resp = await web3Api.Token.GetAllTokenIds("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, "", 10);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetContractNFTTransfers(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftTransferCollection resp = await web3Api.Token.GetContractNFTTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, "", 10);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTLowestPrice(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Trade resp = await web3Api.Token.GetNFTLowestPrice("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, 2000);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTMetadata(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftContractMetadata resp = await web3Api.Token.GetNFTMetadata("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTOwners(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftOwnerCollection resp = await web3Api.Token.GetNFTOwners("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, "", 10);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetNFTTrades(IWeb3Api web3Api)
        {
            bool result = true;
            try
            {
                TradeCollection resp = await web3Api.Token.GetNFTTrades("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, null, null, null, null, null, "", 10);
                result = resp is { };
            }
            catch (Exception exp) { result = false; }
            return result;
        }

        private async Task<bool> GetNftTransfersFromToBlock(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                // Fails same in Admin Consel - Invalid HEX values
                NftTransferCollection resp = await web3Api.Token.GetNftTransfersFromToBlock(ChainList.eth, 99999, 25999999, null, null, null, "", 10);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenAdressTransfers(IWeb3Api web3Api)
        {
            bool result = true;
            try
            {
                Erc20TransactionCollection resp = await web3Api.Token.GetTokenAddressTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, null, null, null, null, 0, 10);
                result = resp is { };
            }
            catch (Exception exp) { result = false; }
           return result;
        } 

        private async Task<bool> GetTokenAllowance(IWeb3Api web3Api)
        {
            bool result = true;
            try
            {
                Erc20Allowance resp = await web3Api.Token.GetTokenAllowance("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth);
                result = resp is { };
            }
            catch (Exception exp) { result = false; }
            return result;
        }

        private async Task<bool> GetTokenIdMetadata(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Nft resp = await web3Api.Token.GetTokenIdMetadata("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenIdOwners(IWeb3Api web3Api)
        {
            bool result = true;
            try
            {
                NftOwnerCollection resp = await web3Api.Token.GetTokenIdOwners("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth, null, "", 10);
                result = resp is { };
            }
            catch (Exception exp) { result = false; }
            return result;
        }

        private async Task<bool> GetTokenMetadata(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                List<string> addresses = new List<string>();
                addresses.Add("0x6b175474e89094c44da98b954eedeac495271d0f");
                List<Erc20Metadata> resp = await web3Api.Token.GetTokenMetadata(addresses, ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenMetadataBySymbol (IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                List<string> symbols = new List<string>();
                symbols.Add("DAI");
                List<Erc20Metadata> resp = await web3Api.Token.GetTokenMetadataBySymbol(symbols, ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetTokenPrice(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                Erc20Price resp = await web3Api.Token.GetTokenPrice("0x6b175474e89094c44da98b954eedeac495271d0f", ChainList.eth);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetWalletTokenIdTransfers(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                NftTransferCollection resp = await web3Api.Token.GetWalletTokenIdTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth, null, "", 10);

                result = resp is { };
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> SearchNFTs(IWeb3Api web3Api)
        {
            bool result = true;
            try
            {
                NftMetadataCollection resp = await web3Api.Token.SearchNFTs("Apes", ChainList.eth, null, null, null, null, null, null, "", 10);
                result = resp is { };
            }
            catch (Exception exp) { result = false; }
            return result;
        }

    }
}
