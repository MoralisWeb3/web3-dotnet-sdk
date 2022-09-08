using Moralis.Models;
using Moralis.SolanaApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moralis.SolanaApi.Integrated.Tests
{
    class ProgramTests
    {

        static void Main(string[] args)
        {
            List<IIntegratedTest> testGroups = TestGroups();

            MoralisClient.ConnectionData = new ServerConnectionData()
            {
                ApiKey = "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns"
            };


            foreach (IIntegratedTest test in testGroups)
            {
                string addr = "BmfULm77maxvByX6Yjh4NPV7cou5DVrTDU2uWHxsNkAk"; //.ToLower();

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                ISolanaApi apiClient = MoralisClient.SolanaApi;

                Task<IntegratedTestResult> testTask =
                    Task.Run(() => test.RunTests(apiClient, addr));
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
            //groups.Add(new InfoTests());
            //groups.Add(new DefiTests());
            //groups.Add(new NativeTests());
            //groups.Add(new ResolveTests());
            //groups.Add(new StorageTests());
            //groups.Add(new TokenTests());

            return groups;
        }
    }
}
