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
                AuthenticationApiUrl = "AUTHENTICATION API URL",
                ApplicationID = "APPLICATION ID",
                DappUrl = "SERVER UL",
                ApiKey = "WEB3 API",
                MasterKey = "MASTER KEY"
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
