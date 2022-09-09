using Moralis.Abi;
using Moralis.StreamsApi.Interfaces;
using Moralis.StreamsApi.Models;

namespace Moralis.StreamsApi.Integrated.Tests
{
    internal class StreamsTests : IIntegratedTest
    {
        private IntegratedTestResult testResults;

        public async Task<IntegratedTestResult> RunTests(IStreamsApiClient streamsApi, string address)
        {
            testResults = new IntegratedTestResult();

            Console.WriteLine("Running test BindStream");
            string streamId = await BindStream(streamsApi);
            if (!String.IsNullOrEmpty(streamId))
            {
                testResults.PassedTests.Add("BindStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("BindStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetStream");
            if (await GetStream(streamsApi, streamId))
            {
                testResults.PassedTests.Add("GetStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test UpdateStream");
            if (await UpdateStream(streamsApi, streamId))
            {
                testResults.PassedTests.Add("UpdateStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("UpdateStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetStreams");
            if (await GetStreams(streamsApi))
            {
                testResults.PassedTests.Add("GetStreams", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetStreams", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test DeleteStream");
            if (await DeleteStream(streamsApi, streamId))
            {
                testResults.PassedTests.Add("DeleteStream", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("DeleteStream", "FAILED");
                Console.WriteLine("\tFAILED");
            }

            await Task.Delay(250);

            Console.WriteLine("Running test GetStreamsAfterDelerte");
            if (await GetStreamsAfterDelete(streamsApi))
            {
                testResults.PassedTests.Add("GetStreamsAfterDelerte", "PASSED");
            }
            else
            {
                testResults.FailedTests.Add("GetStreamsAfterDelerte", "FAILED");
                Console.WriteLine("\tFAILED");
            }
            return testResults;
        }

        private async Task<string> BindStream(IStreamsApiClient streamsApi)
        {
            string result = String.Empty;

            try
            {
                StreamBindingDto dto = new StreamBindingDto()
                {
                    Address = "0x35ba4825204dcE15C7147eA89b31178a00750f81",
                    ChainIds = new List<string>(new string[] { "0x1" }),
                    IncludeNativeTxs = true,
                    Abi = AbiTools.FunctionAbiFromJson("grantRole", GetAbiJson()),
                    Description = "Bob wuz ere",
                    TokenAddress = "0x62441037E626D6EdeC892838a06DF3C9D43ED482",
                    Topic = "grantRole",
                    Type = "contract",
                    Tag = "my first stream",
                    WebHookUrl = "https://127.0.0.1:8080"
                };

                StreamBindingDto resp = await streamsApi.StreamsEndpoint.BindStream(dto);

                if (resp != null && !String.IsNullOrEmpty(resp.StreamId))
                { 
                    result = resp.StreamId;
                }
            }
            catch (Exception exp)
            {
                result = String.Empty;
            }

            return result;
        }

        private async Task<bool> DeleteStream(IStreamsApiClient streamsApi, string streamId)
        {
            bool result = true;

            try
            {
                StreamBindingDto resp = await streamsApi.StreamsEndpoint.DeleteStream(streamId);

                result = (resp != null && !String.IsNullOrEmpty(resp.StreamId));
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetStream(IStreamsApiClient streamsApi, string streamId)
        {
            bool result = true;

            try
            {
                StreamBindingDto[] resp = await streamsApi.StreamsEndpoint.GetStream(streamId);

                result = (resp != null && resp.Length > 0 &&
                    !String.IsNullOrEmpty(resp[0].StreamId));
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetStreams(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                StreamsResponse resp = await streamsApi.StreamsEndpoint.GetStreams(5, "");

                result = (resp is { } && resp.Total > 0);
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> UpdateStream(IStreamsApiClient streamsApi, string streamId)
        {
            bool result = true;

            try
            {
                StreamBindingDto dto = new StreamBindingDto()
                {
                    Address = "0x35ba4825204dcE15C7147eA89b31178a00750f81",
                    ChainIds = new List<string>(new string[] { "0x1" }),
                    IncludeNativeTxs = true,
                    Abi = AbiTools.FunctionAbiFromJson("grantRole", GetAbiJson()),
                    Description = "OOP",
                    TokenAddress = "0x62441037E626D6EdeC892838a06DF3C9D43ED482",
                    Topic = "grantRole",
                    Type = "contract",
                    Tag = "my first stream",
                    WebHookUrl = "https://127.0.0.1:8080",
                    StreamId = streamId
                };

                StreamBindingDto resp = await streamsApi.StreamsEndpoint.UpdateStream(dto);

                result = (resp != null && resp.Description.Equals("OOP"));
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> GetStreamsAfterDelete(IStreamsApiClient streamsApi)
        {
            bool result = true;

            try
            {
                StreamsResponse resp = await streamsApi.StreamsEndpoint.GetStreams(5, "");

                result = (resp is { } && resp.Total == 0);
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }

        private string GetAbiJson()
        {
            return "[{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"indexed\":true,\"internalType\":\"bytes32\",\"name\":\"previousAdminRole\",\"type\":\"bytes32\"},{\"indexed\":true,\"internalType\":\"bytes32\",\"name\":\"newAdminRole\",\"type\":\"bytes32\"}],\"name\":\"RoleAdminChanged\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"}],\"name\":\"RoleGranted\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"sender\",\"type\":\"address\"}],\"name\":\"RoleRevoked\",\"type\":\"event\"},{\"inputs\":[],\"name\":\"DEFAULT_ADMIN_ROLE\",\"outputs\":[{\"internalType\":\"bytes32\",\"name\":\"\",\"type\":\"bytes32\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"}],\"name\":\"getRoleAdmin\",\"outputs\":[{\"internalType\":\"bytes32\",\"name\":\"\",\"type\":\"bytes32\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"}],\"name\":\"grantRole\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"}],\"name\":\"hasRole\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"}],\"name\":\"renounceRole\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes32\",\"name\":\"role\",\"type\":\"bytes32\"},{\"internalType\":\"address\",\"name\":\"account\",\"type\":\"address\"}],\"name\":\"revokeRole\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"bytes4\",\"name\":\"interfaceId\",\"type\":\"bytes4\"}],\"name\":\"supportsInterface\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";
        }
    }
}
