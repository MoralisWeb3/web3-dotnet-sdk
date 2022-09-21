using Moralis;
using Moralis.Web3Api.Models;
using StreamsDemo;

// See https://aka.ms/new-console-template for more information
string apiKey = String.Empty;
ChainList chain = ChainList.eth;

using (StreamReader sr = new StreamReader("apikey.txt"))
{
    apiKey = sr.ReadToEnd();
}

MoralisClient.ConnectionData = new Moralis.Models.ServerConnectionData()
{
    ApiKey = apiKey
};

CreateWalletWatchers walletWatchers = new CreateWalletWatchers();
CreateErc20Watchers erc20Watchers = new CreateErc20Watchers();
CreateNftWatcher nftWatchers = new CreateNftWatcher();

List<string> watchers = new List<string>();

Task.Run(async () => {
    watchers.AddRange(await walletWatchers.CreateStreamWatchers());

    watchers.AddRange(await erc20Watchers.CreateStreamWatchers());

    watchers.AddRange(await nftWatchers.CreateStreamWatchers());
}).Wait();

Console.WriteLine("Hit return to cleanup to stop watching.");

Console.ReadLine();

Task.Run(async () => {
    foreach (string w in watchers)
    {
        Console.WriteLine($"Removing watcher: {w}");

        await MoralisClient.StreamsApi.StreamsEndpoint.DeleteStream(w);
    }
}).Wait();
