using Moralis;
using Moralis.Platform;
using Moralis.SolanaApi.Client;
using Moralis.Web3Api.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoralisDotNet.Platform.Integrated.Tests
{
    class ProgramTests
    {
        static void Main(string[] args)
        {
            List<IIntegratedTest> testGroups = TestGroups();

            foreach (IIntegratedTest test in testGroups)
            {
                MoralisClient moralis = new MoralisClient(new ServerConnectionData() { ApplicationID = "tNJatzsHirx4V2VAep6sc923OYGxvkpBeJttR7Ks", ServerURI = "https://arw2wxg84h6b.moralishost.com:2053/server" }, new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());

                Console.WriteLine($"Executing test set: {test.GetType().Name} ...\n-----------------------------------------");

                Task<IntegratedTestResult> testTask =
                    Task.Run(() => test.RunTests(moralis));
                testTask.Wait();
                IntegratedTestResult result = testTask.Result;

                Console.WriteLine($"Tests run: {result.TestCount()}, {result.PassedTests.Count} passed, {result.FailedTests.Count} failed.");

                Console.WriteLine("\n\n");
            }
        }

        static List<IIntegratedTest> TestGroups()
        {
            List<IIntegratedTest> groups = new List<IIntegratedTest>();

            groups.Add(new UserServiceTests());

            return groups;
        }
    }
}
