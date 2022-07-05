using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moralis;
using Moralis.Platform;
using Moralis.Web3Api.Client;
using Moralis.SolanaApi.Client;

namespace Moralis.Platform.Integrated.Tests
{
    class ProgramTests
    {
        static void Main(string[] args)
        {
            List<IIntegratedTest> testGroups = TestGroups();

            foreach (IIntegratedTest test in testGroups)
            {
                ServerConnectionData conData = new ServerConnectionData()
                {
                    ApplicationID = "APPLICATION ID",
                    ServerURI = "SERVER URI",
                    MasterKey = "SERVER MASTER KEY"
                };

                //MoralisClient.Initialize(true, "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns"); // "https://arw2wxg84h6b.moralishost.com:2053/server");
                MoralisClient moralis = new MoralisClient(conData, new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7".ToLower();

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

            groups.Add(new CreateObjectTests());
            groups.Add(new QueryTests());
            groups.Add(new LiveQueryTests());

            return groups;
        }
    }
}
