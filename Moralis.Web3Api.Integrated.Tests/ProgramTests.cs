using Moralis.Web3Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moralis.Web3Api.Integrated.Tests
{
    class ProgramTests
    {

        static void Main(string[] args)
        {
            List<IIntegratedTest> testGroups = TestGroups();

            foreach (IIntegratedTest test in testGroups)
            {
                //MoralisClient.Initialize(true, "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns"); // "https://arw2wxg84h6b.moralishost.com:2053/server");
                MoralisClient.Initialize("https://arw2wxg84h6b.moralishost.com:2053/server");
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7".ToLower();

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                Task<IntegratedTestResult> testTask =
                    Task.Run(() => test.RunTests(MoralisClient.Web3Api, addr));
                testTask.Wait();
                IntegratedTestResult result = testTask.Result;

                Console.WriteLine($"Tests run: {result.TestCount()}, {result.PassedTests.Count} passed, {result.FailedTests.Count} failed.");

                Console.WriteLine("\n\n");
            }
        }

        static List<IIntegratedTest> TestGroups()
        {
            List<IIntegratedTest> groups = new List<IIntegratedTest>();

            groups.Add(new AccountTests());
            groups.Add(new DefiTests());
            groups.Add(new NativeTests());
            groups.Add(new ResolveTests());
            groups.Add(new StorageTests());
            groups.Add(new TokenTests());

            return groups;
        }
    }
}
