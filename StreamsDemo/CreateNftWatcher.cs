using Moralis;
using Moralis.StreamsApi.Models;

namespace StreamsDemo
{
    internal class CreateNftWatcher
    {
        public async Task<List<string>> CreateStreamWatchers()
        {
            string watcherOneId = await BindNftContract();

            Console.WriteLine($"Watcher One Id: {watcherOneId}");

            return new List<string>(new string[] { watcherOneId });
        }

        public async Task<string> BindNftContract()
        {
            string result = String.Empty;

            StreamBindingDto dto = new StreamBindingDto()
            {
                WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA==",
                Description = "Moralis Mug NFT Token Watcher",
                Tag = "MORALIS_MUG_NFT",
                AllAddresses = true,
                IncludeNativeTxs = true,
                IncludeContractLogs = true,
                IncludeInternalTxs = true,
                ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" })


                //TokenAddress = "0x698d7d745b7f5d8ef4fdb59ceb660050b3599ac3",
                //ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" }),
                //Description = "Moralis Mug NFT Token Watcher",
                //Type = "contract",
                //Tag = "MORALIS_MUG_NFT",
                //WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA=="
            };

            StreamBindingDto resp = await MoralisClient.StreamsApi.StreamsEndpoint.BindStream(dto);

            if (resp != null && !String.IsNullOrEmpty(resp.StreamId))
            {
                result = resp.StreamId;

                // Add Token Address
                await MoralisClient.StreamsApi.StreamsEndpoint.AddAddressToStream(result, new StreamsAddressRequest() { Address = "0x698d7d745b7f5d8ef4fdb59ceb660050b3599ac3" });


                Console.WriteLine($"{resp.Tag} stream will output to: {resp.WebHookUrl}");
            }

            return result;
        }
    }
}
