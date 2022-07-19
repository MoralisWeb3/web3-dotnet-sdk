using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moralis;
using Moralis.AuthApi.Client;
using Moralis.AuthApi.Interfaces;
using Moralis.Models;

namespace Moralis.AuthApi.Integrated.Tests
{
    internal class Program
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
                MasterKey = "RU70zK1m50qEuaLNHBTM2PlqOQ7OzYuVeImcMq4w"
            };

            foreach (IIntegratedTest test in testGroups)
            {
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7";

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                IAuthClientApi authClient = MoralisClient.AuthenticationApi;

                Task<IntegratedTestResult> testTask =
                    Task.Run(() => test.RunTests(authClient, addr));
                
                testTask.Wait();

                IntegratedTestResult result = testTask.Result;

                Console.WriteLine($"Tests run: {result.TestCount()}, {result.PassedTests.Count} passed, {result.FailedTests.Count} failed.");

                Console.WriteLine("\n\n");
            }
        }

        static List<IIntegratedTest> TestGroups()
        {
            List<IIntegratedTest> groups = new List<IIntegratedTest>();

            groups.Add(new HealthCheckTests());
            groups.Add(new ChallengeTests());

            return groups;
        }
    }
}
