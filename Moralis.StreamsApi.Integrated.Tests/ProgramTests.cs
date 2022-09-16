using Moralis.Models;
using Moralis.StreamsApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Moralis.StreamsApi.Integrated.Tests
{
    class ProgramTests
    {

        static void Main(string[] args)
        {
            List<IIntegratedTest> testGroups = TestGroups();

            MoralisClient.ConnectionData = new ServerConnectionData()
            {
                ApiKey = "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns",
                MasterKey = "RU70zK1m50qEuaLNHBTM2PlqOQ7OzYuVeImcMq4w"
            };


            foreach (IIntegratedTest test in testGroups)
            {
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7".ToLower();

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                IStreamsApiClient apiClient = MoralisClient.StreamsApi;

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

            groups.Add(new HistoryTests());
            groups.Add(new SettingsTests());
            groups.Add(new StreamsTests());

            return groups;
        }
    }
}
