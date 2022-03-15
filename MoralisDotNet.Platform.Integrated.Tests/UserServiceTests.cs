using Moralis;
using Moralis.Platform.Objects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MoralisDotNet.Platform.Integrated.Tests
{

    public class UserServiceTests : IIntegratedTest
    {

        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(MoralisClient moralis)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test User_SaveAsync_Succeeds");
            if (await User_SaveAsync_Succeeds(moralis))
            {
                testResults.PassedTests.Add("User_SaveAsync_Succeeds", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("User_SaveAsync_Succeeds", "FAILED");
            }

            return testResults;
        }
        public async Task<bool> User_SaveAsync_Succeeds(MoralisClient moralis)
        {
            try
            {
                Dictionary<string, object> authData = new Dictionary<string, object> { { "id", "0x26841E928b5b89BB257CCCeC06d8d63951f2507b".ToLower() }, { "signature", "0x7589245bd712ccdcaa9f946c1052b169569fecaf5beed44d916acc0361be16b63f9ad8fb8526c276a1869a314ca7f9a0becee334aadca2e62ccd656cd1379c041b" }, { "data", "Moralis Authentication" } };

                MoralisUser user = await moralis.LogInAsync(authData, CancellationToken.None);

                // User is logged in
                if (user == null) throw new Exception("Login failed for test user.");

                string username = user.username;

                string testName = GetTestName(username);

                await user.SaveAsync();

                user = await moralis.UserFromSession(user.sessionToken);

                if(!testName.Equals(user.username)) throw new Exception("Username was not updated.");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }

            return true;
        }

        private string GetTestName(string currentName)
        {
            string[] names = { "Clem the Great", "Sion the Bold", "Bob", "D@ve", "Oogmar the Deft", "Alesdair the Blessed", "Seviel the Mighty", "Master Adept Xactant", "Semaphore the Beautiful", "Gamemaster Nexnang"};

            Random rand = new Random((int)DateTime.Now.Ticks);

            int x = rand.Next(names.Length);

            while (names[x].Equals(currentName))
            {
                x = rand.Next(names.Length);
            }

            return names[x];
        }
    }
}
