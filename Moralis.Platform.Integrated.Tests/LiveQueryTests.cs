using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moralis;
using Moralis.Platform.Objects;
using Moralis.Platform.Queries;
using Moralis.Platform.Queries.Live;
using Moralis.Platform.Services.ClientServices;

namespace Moralis.Platform.Integrated.Tests
{
    class LiveQueryTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        int OnConnectedEventCounter = 0;
        int OnSubscribedEventCounter = 0;
        int OnUnsubscribedEventCounter = 0;
        int OnErrorEventCounter = 0;
        int OnCreateEventCounter = 0;
        int OnUpdateEventCounter = 0;
        int OnDeleteEventCounter = 0;

        public async Task<IntegratedTestResult> RunTests(MoralisClient moralisClient)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test TestLiveQuery");

            if (await TestLiveQuery(moralisClient))
            {
                testResults.PassedTests.Add("TestLiveQuery", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("TestLiveQuery", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        public async Task<bool> TestLiveQuery(MoralisClient moralisClient)
        {
            bool result = true;

            try
            {
                var moralisQueryPlayerData = await moralisClient.Query<PlayerData>();

                // Setup subscription
                MoralisLiveQueryCallbacks<PlayerData> callbacks = setupLiveQuerySubscription(moralisQueryPlayerData);
                MoralisLiveQueryClient<PlayerData> lqc = moralisQueryPlayerData.Subscribe<PlayerData>(callbacks);

                Thread.Sleep(2000);

                System.Random rand = new System.Random((int)DateTime.Now.Ticks);

                int x = rand.Next(25) + 3;

                PlayerData p1 = moralisClient.Create<PlayerData>();
                p1.Name = GetTestName();
                p1.TokenCount = x;
                await p1.SaveAsync();

                x = rand.Next(25) + 3;

                PlayerData p2 = moralisClient.Create<PlayerData>();
                p2.Name = GetTestName();
                p2.TokenCount = x;
                await p2.SaveAsync();

                // Get the records created
                IEnumerable<PlayerData> recs = await moralisQueryPlayerData.FindAsync();

                // Update data
                foreach (PlayerData pd in recs)
                {
                    x = rand.Next(25) + 3;
                    pd.TokenCount = x;
                    await pd.SaveAsync();
                }

                // Get the records created
                recs = await moralisQueryPlayerData.FindAsync();

                // Delete data
                foreach (PlayerData pd in recs)
                {
                    await pd.DeleteAsync();
                }

                if (OnConnectedEventCounter != 1) result = false;
                else if (OnSubscribedEventCounter != 1) result = false;
                else if (OnErrorEventCounter != 0) result = false;
                else if (OnCreateEventCounter != 2) result = false;
                else if (OnUpdateEventCounter != 2) result = false;
                else if (OnDeleteEventCounter != 2) result = false;
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;

        }

        private MoralisLiveQueryCallbacks<PlayerData> setupLiveQuerySubscription(MoralisQuery<PlayerData> playerData)
        {
            MoralisLiveQueryCallbacks<PlayerData> moralisLiveQueryCallbacks = new MoralisLiveQueryCallbacks<PlayerData>();

            moralisLiveQueryCallbacks.OnConnectedEvent += (() => { OnConnectedEventCounter++; });
            moralisLiveQueryCallbacks.OnSubscribedEvent += ((requestId) => { OnSubscribedEventCounter++; });
            moralisLiveQueryCallbacks.OnUnsubscribedEvent += ((requestId) => { OnUnsubscribedEventCounter++; });
            moralisLiveQueryCallbacks.OnErrorEvent += ((ErrorMessage em) =>
            {
                OnErrorEventCounter++;
            });
            moralisLiveQueryCallbacks.OnCreateEvent += ((item, requestId) =>
            {
                OnCreateEventCounter++;
            });
            moralisLiveQueryCallbacks.OnUpdateEvent += ((item, requestId) =>
            {
                OnUpdateEventCounter++;
            });
            moralisLiveQueryCallbacks.OnDeleteEvent += ((item, requestId) =>
            {
                OnDeleteEventCounter++;
            });

            return moralisLiveQueryCallbacks;
        }

        private static string GetTestName()
        {
            string[] names = { "Clem the Great", "Sion the Bold", "Bob", "D@ve", "Oogmar the Deft", "Alesdair the Blessed", "Seviel the Mighty", "Master Adept Xactant", "Semaphore the Beautiful", "Gamemaster Nexnang" };

            System.Random rand = new System.Random((int)DateTime.Now.Ticks);

            int x = rand.Next(names.Length);

            x = rand.Next(names.Length);

            return names[x];
        }
    }
}
