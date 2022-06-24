using Moralis.Web3Api.Interfaces;
using Moralis.Web3Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class StorageTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IWeb3Api web3Api, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test UploadFolder");
            if (await UploadFolder(web3Api))
            {
                testResults.PassedTests.Add("UploadFolder", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("UploadFolder", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> UploadFolder(IWeb3Api web3Api)
        {
            bool result = true;

            try
            {
                IpfsFileRequest req = new IpfsFileRequest()
                {
                    Path = "moralis/logo.jpg",
                    Content = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3"
                };

                List<IpfsFileRequest> reqs = new List<IpfsFileRequest>();
                reqs.Add(req);
                List<IpfsFile> resp = await web3Api.Storage.UploadFolder(reqs);

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
