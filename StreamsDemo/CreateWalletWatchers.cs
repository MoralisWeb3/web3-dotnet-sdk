using Moralis;
using Moralis.StreamsApi.Models;

namespace StreamsDemo
{
    internal class CreateWalletWatchers
    {
        public async Task<List<string>> CreateStreamWatchers()
        {
            string watcherOneId = await BindAddressOne();

            Console.WriteLine($"Wallet Watcher One Id: {watcherOneId}");

            string watcherTwoId = await BindAddressTwo();

            Console.WriteLine($"Wallet Watcher Two Id: {watcherTwoId}");

            await AddAddressToStream(watcherOneId, "0xc539a39719Ad4D2DE7bf6f1e16F86383B6FF59C6");

            return new List<string>(new string[] { watcherOneId, watcherTwoId});
        }

        public async Task<string> BindAddressOne()
        {
            string result = String.Empty;

            StreamBindingDto dto = new StreamBindingDto()
            {
                WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA==",
                Description = "Wallet 1 Native Token Watcher",
                Tag = "WALLET_1",
                AllAddresses = true,
                IncludeNativeTxs = true,
                IncludeContractLogs = true,
                IncludeInternalTxs = true,
                ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" })

                //Address = "0x35ba4825204dcE15C7147eA89b31178a00750f81",
                //ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" }),
                //Description = "Wallet 1 Native Token Watcher",
                //IncludeNativeTxs = true,
                //Type = "wallet",
                //Tag = "WALLET_1",
                //WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA=="
            };

            StreamBindingDto resp = await MoralisClient.StreamsApi.StreamsEndpoint.BindStream(dto);

            if (resp != null && !String.IsNullOrEmpty(resp.StreamId))
            {
                result = resp.StreamId;

                // Add wallet Address
                await MoralisClient.StreamsApi.StreamsEndpoint.AddAddressToStream(result, new StreamsAddressRequest() { Address = "0x35ba4825204dcE15C7147eA89b31178a00750f81" });

                Console.WriteLine($"{resp.Tag} stream will output to: {resp.WebHookUrl}");
            }

            return result;
        }

        public async Task<string> BindAddressTwo()
        {
            string result = String.Empty;

            StreamBindingDto dto = new StreamBindingDto()
            {
                WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA==",
                Description = "Wallet 2 Native Token Watcher",
                Tag = "WALLET_2",
                AllAddresses = true,
                IncludeNativeTxs = true,
                IncludeContractLogs = true,
                IncludeInternalTxs = true,
                ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" })

                //Address = "0x0E1358C4b529F564a14eC8fc3Ae7369786A1625d",
                //ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" }),
                //Description = "Wallet 2 Native Token Watcher",
                //IncludeNativeTxs = true,
                //Type = "wallet",
                //Tag = "WALLET_2",
                //WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA=="
            };

            StreamBindingDto resp = await MoralisClient.StreamsApi.StreamsEndpoint.BindStream(dto);

            if (resp != null && !String.IsNullOrEmpty(resp.StreamId))
            {
                result = resp.StreamId;

                // Add wallet Address
                await MoralisClient.StreamsApi.StreamsEndpoint.AddAddressToStream(result, new StreamsAddressRequest() { Address = "0x0E1358C4b529F564a14eC8fc3Ae7369786A1625d" });


                Console.WriteLine($"{resp.Tag} stream will output to: {resp.WebHookUrl}");
            }

            return result;
        }

        public async Task<bool> AddAddressToStream(string streamId, string address)
        { 
            bool result = false;

            StreamsAddressRequest sar = new StreamsAddressRequest()
            {
                Address = address
            };

            AddressResponse resp = await MoralisClient.StreamsApi.StreamsEndpoint.AddAddressToStream(streamId, sar);

            result = resp != null && resp.Result != null && resp.Result.Count > 0;

            return result;
        }
    }
}
