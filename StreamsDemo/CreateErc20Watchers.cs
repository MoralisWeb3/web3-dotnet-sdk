using Moralis;
using Moralis.StreamsApi.Models;

namespace StreamsDemo
{
    internal class CreateErc20Watchers
    {
        public async Task<List<string>> CreateStreamWatchers()
        {
            string watcherOneId = await BindContract();

            Console.WriteLine($"Watcher One Id: {watcherOneId}");

            return new List<string>(new string[] { watcherOneId });
        }

        public async Task<string> BindContract()
        {
            string result = String.Empty;

            StreamBindingDto dto = new StreamBindingDto()
            {
                TokenAddress = "0x286C20972ba4837f806cA92b20E97C0497271a8D",
                ChainIds = new List<string>(new string[] { "0x3", "0x61", "0x13881" }),
                Description = "Morallion ERC20 Token Watcher",
                Type = "contract",
                Tag = "Morallion",
                WebHookUrl = "https://davesmoralisazurefunctions.azurewebsites.net/api/RawStreamsHandler?code=BT-PQKI8vc4hA_EieKWuKgVq_GSLgo9y2cqWD6K0g_jOAzFu46pOTA=="
            };

            StreamBindingDto resp = await MoralisClient.StreamsApi.StreamsEndpoint.BindStream(dto);

            if (resp != null && !String.IsNullOrEmpty(resp.StreamId))
            {
                result = resp.StreamId;

                Console.WriteLine($"{resp.Tag} stream will output to: {resp.WebHookUrl}");
            }

            return result;
        }
    }
}
