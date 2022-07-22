using Moralis.Platform.Objects;

namespace Moralis.Platform.Integrated.Tests
{
    public class UserTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(MoralisClient moralisClient)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test Login Test");

            if (await LoginTest(moralisClient))
            {
                testResults.PassedTests.Add("Login", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("Login", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            return testResults;
        }

        public async Task<bool> LoginTest(MoralisClient moralisClient)
        {
            bool result = true;

            try
            {
                string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7";

                Dictionary<string, object> authData = new Dictionary<string, object>
                {
                    { "id", addr }
                };

                MoralisUser user = await moralisClient.LogInAsync(authData);

                result = user is { } && !string.IsNullOrEmpty(user.sessionToken);
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}
