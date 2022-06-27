using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moralis.Platform.Integrated.Tests
{
    class CreateObjectTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;
        public async Task<IntegratedTestResult> RunTests(MoralisClient moralisClient)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test CreateHero");

            if (await CreateHero(moralisClient))
            {
                testResults.PassedTests.Add("CreateHero", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("CreateHero", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        private async Task<bool> CreateHero(MoralisClient moralisClient)
        {
            bool result = true;

            try
            {
                Hero h1 = moralisClient.Create<Hero>();
                h1.Name = GetTestName();

                System.Random rand = new System.Random((int)DateTime.Now.Ticks);
                h1.Strength = rand.Next(20) + 3;
                h1.Level = rand.Next(10) + 1;
                h1.Warcry = "Decaf is a lie!";

                await h1.SaveAsync();
            }
            catch (Exception exp)
            {
                result = false;
            }
            
            return result;
        }

        private static string GetTestName()
        {
            string[] names = { "Clem the Great", "Sion the Bold", "Bob", "D@ve", "Oogmar the Deft", "Alesdair the Blessed", "Seviel the Mighty", "Master Adept Xactant", "Semaphore the Beautiful", "Gamemaster Nexnang" };

            System.Random rand = new System.Random((int)DateTime.Now.Ticks);

            int x = rand.Next(names.Length);

            return names[x];
        }
    }
}
