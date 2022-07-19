using Moralis.Models;
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

            MoralisClient.ConnectionData = new ServerConnectionData()
            {
                AuthenticationApiUrl = "https://auth-api.do-prod-1.moralis.io/",
                ApplicationID = "foCDSL08ibUWfLHunP6RrCxPGKE6HpwYiiLa5QPV",
                DappUrl = "https://ltvaqg1whdgl.usemoralis.com:2053/server",
                ApiKey = "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns",
                MasterKey = "RU70zK1m50qEuaLNHBTM2PlqOQ7OzYuVeImcMq4w",
                Web3ApiUrl = "https://deep-index.moralis.io/api/v2"
            };


            foreach (IIntegratedTest test in testGroups)
            {
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7".ToLower();

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                IWeb3Api apiClient = MoralisClient.Web3Api;

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
            groups.Add(new InfoTests());
            groups.Add(new DefiTests());
            groups.Add(new NativeTests());
            groups.Add(new ResolveTests());
            groups.Add(new StorageTests());
            groups.Add(new TokenTests());

            return groups;
        }
    }
}
