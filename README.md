# Moralis-.NET-SDK
Final Moralis C# .NET SDK that supports the original Moralis Parse-based Server

## Moralis Configuration
Configuration for server connection information is handled in the `ServerConnectionData` object. Before using Moralis, create an instance of this object to pass into the moralis initialization method.

#### General Configuration Parameters.
- ApplicationID `string`: The Moralis DappID or Parse Application Id. This value must be supplied if using either Moralis Server or Parse Server functionality. 
- ApiKey `string`: The Web3Api key, must be supplied to initialize Web3Api to use standard REST server. Required if you are going to use the Authentication API, Web3Api, or Solana API.
- AuthenticationApiUrl `string`: Moralis Authentication 2.0 server endpoint URL. Required if you are going to use the Authentication API
- Headers `IDictionary<string, string>`:  Additional HTTP headers to be sent with network requests from the SDK.
- LiveQueryServerURI `string`: A URI pointing to the target Moralis / Parser WS/WSS server.
- MasterKey `string`: The Master Key for the Moralis / Parser app. _Important, must be kept secret!_. This value must be supplied if using either Moralis Server or Parse Server functionality. 
- ServerURI `string`: A URI pointing to the target Moralis / Parse Server instance hosting the app. This value must be supplied if using either Moralis Server or Parse Server functionality. 

#### Parse Server Specific Parameters
These values only need to be set if you are using your own instance of Parse Server. If you are using Moralis Server these can be left with their default values.
- ParseEndpointBase `string`: Base endpoint for a Parse server backend
- ParseAuthenticationHandler 'string':module must be defined in Parse node_modules/parse-server/lib/Adapters/Auth

Generally the following setting can be left with their default values.
- ParseEndpointCloudfunctions `string`: Cloud Functions endpoint for a Parse Backend
- ParseEndpointFileService `string`: File Service endpoint for Parse backend
- ParseEndpointClasses `string`: Classes endpoint for a Parse Backend

## Starting Up Moralis
Starting Moralis is as simple as setting up configuration and creating an instance of the MoralisClient.

*Example*
```
ServerConnectionData conData = new ServerConnectionData()
{
    ApplicationID = "APPLICATION_ID",
    ServerURI = "http://localhost:1337",
    MasterKey = "MASTER_KEY",
    LiveQueryServerURI = "LIVE QUERY SERVER URI",
    ParseEndpointBase = "parse",
    ParseAuthenticationHandler = "anonymous"
};

MoralisClient moralis = new MoralisClient(conData, new AuthApiClient(), new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());
```

## Parse Server
The Moralis Server is based on [Parse Server](https://parseplatform.org/). Due to this you can configure the Moralis SDK to use your own Parse Server instance instead of the Moralis Server.

After setting up and running your parse server, create a console application. For the example code below I used MongoDB and the following startup:

`parse-server --appId APPLICATION_ID --masterKey MASTER_KEY --databaseURI mongodb://localhost:27017/parse --verbose true'

Import the latest Nuget Package (less than 1.1 - the versions starting 1.1 or greater do not support Parse Server)

Start parse server. 

Test your setup with the example code below. Note the values in _ServerConnectionData_ are set for my setup as described above,
using the _anonymous_ Parse Authentication Handler.

Example
```
ServerConnectionData conData = new ServerConnectionData()
{
    ApplicationID = "APPLICATION_ID",
    ServerURI = "http://localhost:1337",
    MasterKey = "MASTER_KEY",
    LiveQueryServerURI = "LIVE QUERY SERVER URI",
    ParseEndpointBase = "parse",
    ParseAuthenticationHandler = "anonymous"
};

MoralisClient moralis = new MoralisClient(conData, new AuthApiClient(), new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());

string addr = "0xBa878d88c71E0091613798C53B6c72aDd9b9A6a7";

Dictionary<string, object> authData = new Dictionary<string, object>
    {
        { "id", addr }
    };

MoralisUser user = await moralis.LogInAsync(authData);
```

The response should be a normal Moralis User.



## `Queries`
Queries provide a way to retrieve information from your Moralis database.

The following examples assume you have a moralis client initialized as described [here](#starting-ip-moralis)

The following example will return all Hero records where 'Level' is equal to 3.
### Query Example
```
MoralisQuery<Hero> q = await moralis.Query<Hero>();
q = q.WhereEqualTo("Level", 3);
IEnumerable<Hero> result = await q.FindAsync();
```

The Moralis Web3 for Unity SDK supports the same query methods as the JS SDK. For example creating 'OR', 'AND', and 'NOR' queries.
For this example we will take a base query and construct an 'OR' query that returns records where Level is greater or equal to '3' OR the hero's name is 'Zuko'.
Furthermore we will sort (order) the result set by the hero's strength, descending.
### Compound Query Example
```
MoralisQuery<PlayerData> q = await moralis.Query<PlayerData>();
MoralisQuery<PlayerData> q1 = q.WhereGreaterThanOrEqualTo("Level", 2);
MoralisQuery<PlayerData> q2 = q.WhereEqualTo("Name", "Zuko");
MoralisQuery<PlayerData> q3 = moralis.BuildOrQuery<PlayerData>(new MoralisQuery<PlayerData>[] { q1, q2 }).OrderByDescending("Strength");
IEnumerable<PlayerData> result = await q3.FindAsync();
```

## `Live Queries`
Live Queries are queries that include a subscription that provide updates whenever the data targeted by the query are updated.
A Live Query subscription emits events that indicate the state of the client and changes to the data. For more information please see
the [docs](https://docs.moralis.io/moralis-server/database/live-queries).

The following examples use the [query example from above](#queries)
### Live Query Example
Since Unity3d is mainly used to create games, Unity3D apps generaly have life cycle events you do not usually need to worray about in a normal program.
We have created a special Live Query wrapper object that automatically handles your subscriptions for pause, unpause, close, etc.
This example shows how to create your subscription using this wrapper class.
```
MoralisQuery<Hero> q = moralis.Query<Hero>();
MoralisLiveQueryController.AddSubscription<Hero>("Hero", q, callbacks);
```
_note: the **callbacks** parameter is optional. Please see [Callbacks Explained](#live-query-callbacks-explained) bellow.

The _**MoralisLiveQueryController**_ is a singleton object and so is available anywhere within your application.
The first parameter ("Hero" above") is a key that you can use to retrieve a subscription (to check its status for example) or to remove a subscription.

By using the The _**MoralisLiveQueryController**_ object you do not need to worry about properly closing or disposing of your subscriptions as this wrapper object handles all of that for you.

### Live Query Callbacks Explained.
Callbacks are used to handle the events emitted by a subscription. You can set the callbacks directly against a subscription. However it is usually cleaner to 
separate these from the main code. To facilitate this we have included the _**MoralisLiveQueryCallbacks**_ object. This optional object can be passed to the subscription.
#### Example MoralisLiveQueryCallbacks Use
```
MoralisLiveQueryCallbacks<Hero> callbacks = new MoralisLiveQueryCallbacks<Hero>();
callbacks.OnConnectedEvent += (() => { Console.WriteLine("Connection Established."); });
callbacks.OnSubscribedEvent += ((requestId) => { Console.WriteLine($"Subscription {requestId} created."); });
callbacks.OnUnsubscribedEvent += ((requestId) => { Console.WriteLine($"Unsubscribed from {requestId}."); });
callbacks.OnErrorEvent += ((ErrorMessage em) =>
{
    Console.WriteLine($"ERROR: code: {em.code}, msg: {em.error}, requestId: {em.requestId}");
});
callbacks.OnCreateEvent += ((item, requestId) =>
{
    Console.WriteLine($"Created hero: name: {item.Name}, level: {item.Level}, strength: {item.Strength} warcry: {item.Warcry}");
});
callbacks.OnUpdateEvent += ((item, requestId) =>
{
    Console.WriteLine($"Updated hero: name: {item.Name}, level: {item.Level}, strength: {item.Strength} warcry: {item.Warcry}");
});
callbacks.OnDeleteEvent += ((item, requestId) =>
{
    Console.WriteLine($"Hero {item.Name} has been defeated and removed from the roll!");
});
callbacks.OnGeneralMessageEvent += ((text) =>
{
    DConsole.WriteLine($"Websocket message: {text}");
});
```

## `Custom Object`
Creating your own objects to support NPCs, characters, and game objects is as simple as creating a Plain Old C# Object (POCO). The only stipulation is that your custom object must be a child of Moralis Object and when you create an instance of the object it should be made via _**moralis.Create**_ method. This associates some extensions to your object that enable you to perform Moralis functions such as _Save_ directly on the object.
**Note:** Inclusion of _base([OBJECT NAME]) is important for proper database handling.
#### Sample Object
``` 
public class Hero : MoralisObject
{
    public int Strength { get; set; }
    public int Level { get; set; }
    public string Name { get; set; }
    public string Warcry { get; set; }
    public List<string> Bag { get; set; }

    public Hero() : base("Hero") 
    {
        Bag = new List<string>();
    }
}
```
#### Create and Save Instance of Object
```
Hero h = moralis.Create<Hero>();
h.Name = "Zuko";
h.Strength = 50;
h.Level = 15;
h.Warcry = "Honor!!!";
h.Bag.Add("Leather Armor");
h.Bag.Add("Crown Prince Hair clip.");

await h.SaveAsync();
```

## `User Object`
The user object contains information about the currently logged in user. Upon successful login, the user is stored in local storage until logout. This allows a user to log in once and not login again until their session expires or they logout.

If you need to create an instance of MoralisUser for any reason (**example**: to SignUp with _username_ and _password_) you should do so in this manner:
```
MoralisUser user = moralis.Create<MoralisUser>();
```
Using this method instead of the default constructor of MoralisUser ensures that the MoralisUser object created is associated with the Moralis instance. This means that several methods of the object will not work problerly (such as _SaveAsync_, _SignUpAsync_, etc.).

If you create a custom user object it must inherit from MoralisUser.

Since C# is a typed language the compiler must know what types are used at compile time. Due to this, since the MoralisUser is integral to internal functions in the Moralis Web3 Unity SDK, when you create a custom User Object you must initialize the Moralis client using your custom User Object. After this step you can use the Moralis Client as usual.

## `Authentication Data`
*NOTE*: This information is for Moralis 1.0 / Parse Server authentication data only.
Authentication data is a _**Dictionary<string, string>**_ object that contains the information required by Moralis to authenticate a user.
As a minimum the authentication data dictionary must contain the following entries:
1. **id** The wallet address of the wallet used to sign the message.
2. **signature** The signature data returned by the Sign request sent to the wallet.
3. **data** The message that was sent to the wallet to be signed.
#### Example
```
Dictionary<string, object> authData = new Dictionary<string, object> { { "id", "ADDRESS_HERE".ToLower() }, { "signature", "SIGNATURE_DATA_HERE" }, { "data", "MESSAGE_HERE" } };
```

## `HostManifestData`
In Unity3D applications the HostManifestData object is used to pass information to Moralis that is usually autogenerated from Windows system variables. Since Unity3D supports multiple platforms this information is not always available. 

# 🏗 Ethereum Web3Api Methods

## `Web3Api Notes`
The complete Moralis Web3API schema including endpoints, operations and models, can be found by logging in to your Moralis Server and selecting **Web3 API***

For use with either Moralis Web3 Unity SDK or in Unity3d, the following using statements are required:

## `Chains`
Supported EVM chains are currently:
eth = 0x1,
ropsten = 0x3,
rinkeby = 0x4,
goerli = 0x5,
kovan = 0x2a,
polygon = 0x89,
mumbai = 0x13881,
bsc = 0x38,
bsc_testnet = 0x61,
avalanche = 0xa86a,
avalanche_testnet = 0xa869,
fantom = 0xfa,
cronos = 0x19,
cronos_testnet = 0x152

These values on in an Enum named _ChainList_ under _Moralis.Web3Api.Models_.


## `Account`
Code examples demonstrating how to use the Moralis Web3API Account endpoint and operations.

### `GetNativeBalance`
Gets native balance for a specific address
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
#### Example
```
NativeBalance balance = await moralis.Web3Api.Account.GetNativeBalance(address.ToLower(), ChainList.eth);
Debug.Log($"GetNativeBalance Balance: {balance.Balance}");
```

### `GetNFTs`
Gets NFTs owned by the given address
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **format** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL The field(s) to order on and if it should be ordered in ascending or descending order. Specified by: fieldName1.order,fieldName2.order. Example 1: "name", "name.ASC", "name.DESC", Example 2: "Name and Symbol", "name.ASC,symbol.DESC"
#### Example
```
NftOwnerCollection nftCollection = await moralis.Web3Api.Account.GetNFTs(userAddress, chainId);

if (nftCollection.Total < 1)
{
    Debug.Log($"User {userAddress} does not have any NFTs on chain {chainId.ToString()}");
}
else
{
    Debug.Log($"Nfts for User {userAddress}");

    foreach (NftOwner nft in nftCollection.Result)
    {
        Debug.Log($"TokenId: {nft.TokenId}, Name: {nft.Name}, Balance: {nft.Amount}");
    }
}
```

### `GetNFTsForContract`
Gets NFTs owned by the given address
- **address** _string_ REQUIRED Target address
- **tokenAddress** _string_ REQUIRED Address of the contract
- **chain** _ChainList_ REQUIRED The chain to query
- **format** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL The field(s) to order on and if it should be ordered in ascending or descending order. Specified by: fieldName1.order,fieldName2.order. Example 1: "name", "name.ASC", "name.DESC", Example 2: "Name and Symbol", "name.ASC,symbol.DESC"
#### Example
```
NftOwnerCollection resp = await moralis.Web3Api.Account.GetNFTsForContract(address.ToLower(), "0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth);
Debug.Log($"GetNFTsForContract Count: {resp.Total}");
```

### `GetNFTTransfers`
Gets the transfers of the tokens matching the given parameters
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **format** _string_ OPTIONAL The format of the token id
- **direction** _string_ OPTIONAL The transfer direction
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL The field(s) to order on and if it should be ordered in ascending or descending order. Specified by: fieldName1.order,fieldName2.order. Example 1: "name", "name.ASC", "name.DESC", Example 2: "Name and Symbol", "name.ASC,symbol.DESC"
#### Example
```
NftTransferCollection balance = await moralis.Web3Api.Account.GetNFTTransfers(address.ToLower(), ChainList.eth);
Debug.Log($"GetNFTTransfers Matches: {balance.Total}");
```

### `GetTokenBalances`
Gets token balances for a specific address
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
#### Example
```
List<Erc20TokenBalance> balance = await moralis.Web3Api.Account.GetTokenBalances(address.ToLower(), ChainList.eth);
Debug.Log($"GetTokenBalances Count: {balance.Count}");
```

### `GetTokenTransfers`
Gets ERC20 token transactions in descending order based on block number
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
Erc20TransactionCollection balance = await moralis.Web3Api.Account.GetTokenTransfers(address.ToLower(), ChainList.eth);
Debug.Log($"GetTokenTransfers Count: {balance.Total}");
```

### `GetTransactions`
Gets native transactions in descending order based on block number
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
TransactionCollection balance = await moralis.Web3Api.Account.GetTransactions(address.ToLower(), ChainList.eth);
Debug.Log($"GetTransactions Count: {balance.Total}");
```

## `Defi`
Code examples demonstrating how to use the Moralis Web3API Defi endpoint and operations.

### `GetPairAddress`
Fetches and returns pair data of the provided token0+token1 combination. The token0 and token1 options are interchangable (ie. there is no different outcome in "token0=WETH and token1=USDT" or "token0=USDT and token1=WETH")
- **exchange** _string_ REQUIRED The factory name or address of the token exchange
- **token0Address** _string_ REQUIRED Token0 address
- **token1Address** _string_ REQUIRED Token1 address
- **chain** _ChainList_ REQUIRED The chain to query
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
#### Example
```
ReservesCollection nftTransers = moralis.Web3Api.Defi.GetPairAddress(exchange, token0Address, token1Address, ChainList.eth);
```

### `GetPairReserves`
Get the liquidity reserves for a given pair address
- **pairAddress** _string_ REQUIRED Liquidity pair address
- **chain** _ChainList_ REQUIRED The chain to query
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
#### Example
```
ReservesCollection nftTransers = moralis.Web3Api.Defi.GetPairReserves(pairAddress, ChainList.eth);
```

## `Native`
Code examples demonstrating how to use the Moralis Web3API Native endpoint and operations.

### `GetBlock`
Gets the contents of a block by block hash
- **blockNumberOrHash** _string_ REQUIRED The block hash or block number
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
#### Example
```
Block block = moralis.Web3Api.Native.GetBlock(blockNumberOrHash, ChainList.eth);
```

### `GetContractEvents`
Gets events in descending order based on block number
- **address** _string_ REQUIRED Target address
- **topic** _string_ REQUIRED The topic of the event. This is the hash of the function
- **abi** _object_ REQUIRED ABI of the event being searched for. See example below for object format.
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
    // Event ABI input parameters
    object[] inputParams = new object[3];
    inputParams[0] = new { indexed = true, internalType = "bytes32", name = "role", type = "bytes32" };
    inputParams[1] = new { indexed = true, internalType = "address", name = "account", type = "address" };
    inputParams[2] = new { indexed = true, internalType = "address", name = "sender", type = "address" };
    // Event ABI
    object abi = new { anonymous = false, inputs = inputParams, name = "RoleGranted", type = "event" };

    List<LogEvent> logEvents = await moralis.Web3Api.Native.GetContractEvents("0x698d7D745B7F5d8EF4fdB59CeB660050b3599AC3", "0x2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d", abi, ChainList.mumbai);

    Debug.Log($"Contract Function returned {logEvents.Count} events");
```

### `GetDateToBlock`
Gets the closest block of the provided date
- **data** _string_ REQUIRED Unix date in miliseconds or a datestring (any format that is accepted by momentjs)
- **chain** _ChainList_ REQUIRED The chain to query
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
#### Example
```
string blockNumberOrHash = "25509457";
Block block = await moralis.Web3Api.Native.GetBlock(blockNumberOrHash, chainId);
Debug.Log($"GetBlock BlockNumber: {block.Number}, Transaction Count: {block.TransactionCount}");
```

### `GetLogsByAddress`
Gets the logs from an address
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **blockNumber** _string_ OPTIONAL The block number.
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **topic0** _string_ OPTIONAL 
- **topic1** _string_ OPTIONAL 
- **topic2** _string_ OPTIONAL 
- **topic3** _string_ OPTIONAL 
#### Example
```
LogEventByAddress logEvents = await moralis.Web3Api.Native.GetLogsByAddress(userAddress, chainId);
Debug.Log($"GetLogsByAddress BlockNumber: {logEvents.BlockNumber}, Transaction Count: {logEvents.Data}");
```

### `GetNFTTransfersByBlock`
Gets NFT transfers by block number or block hash
- **blockNumberOrHash** _string_ REQUIRED The block hash or block number
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
#### Example
```
NftTransferCollection nftTransfers = await moralis.Web3Api.Native.GetNFTTransfersByBlock("500000", chainId);
Debug.Log($"GetNFTTransfersByBlock Nfts returned: {nftTransfers.Result.Count}");
```

### `GetTransaction`
Gets the contents of a block transaction by hash
- **transactionHash** _string_ REQUIRED The transaction hash
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
#### Example
```
string transactionHash = "0xe1ec2dd9964f4dc59b53dce083917abfb5ab5191a37cb1e21566969caa614fcd";
BlockTransaction blockTransaction = await moralis.Web3Api.Native.GetTransaction(transactionHash, ChainList.mumbai);
Debug.Log($"Block transaction BlackNumber: {blockTransaction.BlockNumber}, from Address: {blockTransaction.FromAddress}");
```

### `RunContractFunction`
Runs a given function of a contract abi and returns readonly data
- **address** _string_ REQUIRED Target address
- **abi** _object_ REQUIRED Abi of the Function being called - see example for format.
- **chain** _ChainList_ REQUIRED The chain to query
- **functionName** _string_ REQUIRED Function name of the target function.
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
#### Example
```
// Function ABI input parameters
object[] inputParams = new object[1];
inputParams[0] = new { internalType = "uint256", name = "id", type = "uint256" };
// Function ABI Output parameters
object[] outputParams = new object[1];
outputParams[0] = new { internalType = "string", name = "", type = "string" };
// Function ABI
object[] abi = new object[1];
abi[0] = new { inputs = inputParams, name = "uri", outputs = outputParams, stateMutability = "view", type = "function" };

// Define request object
RunContractDto rcd = new RunContractDto()
{
    Abi = abi,
    Params = new { id = "15310200874782" }
};

string resp = await moralis.Web3Api.Native.RunContractFunction("0x698d7D745B7F5d8EF4fdB59CeB660050b3599AC3", "uri", rcd, ChainList.mumbai);

Debug.Log($"Contract Function returned: {resp}");
```

## `Resolve`
Code examples demonstrating how to use the Moralis Web3API Resolve endpoint and operations.

### `ResolveDomain`
Resolves an Unstoppable domain and returns the address
- **domain** _string_ REQUIRED Domain to be resolved
- **currency** _string_ OPTIONAL The currency to query.
#### Example
```
Resolve resp = await moralis.Web3Api.Resolve.ResolveDomain("brad.crypto");
Debug.Log($"ResolveDomain Address: {resp.Address}");
```

### `ResolveAddress`
Resolves an ETH address and find the ENS name
- **address** _string_ REQUIRED The wallet address to perform reverse lookup on.
#### Example
```
Ens resp = await moralis.Web3Api.Resolve.ResolveAddress("0xd8dA6BF26964aF9D7eEd9e03E53415D37aA96045");
Debug.Log($"ResolveAddress Name: {resp.Name}");
```

## `Storage`
Code examples demonstrating how to use the Moralis Web3API Storage endpoint and operations.

### UploadFolder
Resolves an ETH address and find the ENS name
- **request** _List<IpfsFileRequest>_ REQUIRED Upload Data
#### Example
``` 
// Define file information.
IpfsFileRequest req = new IpfsFileRequest()
{
	Path = "moralis/logo.jpg",
	Content = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAApgAAAKYB3X3"
};

// Multiple requests can be sent via a List so define the request list.
List<IpfsFileRequest> reqs = new List<IpfsFileRequest>();

// Add requests to request list.
reqs.Add(req);

List<IpfsFile> resp = moralis.Web3Api.Storage.UploadFolder(reqs);
```

## `Token`
Code examples demonstrating how to use the Moralis Web3API Token endpoint and operations.

### `GetAllTokenIds`
Gets data, including metadata (where available), for all token ids for the given contract address.
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftCollection resp = await moralis.Web3Api.Token.GetAllTokenIds("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, 0, 10);
Debug.Log($"GetAllTokenIds returned {resp.Total} Nfts");
```

### `GetContractNFTTransfers`
Gets the transfers of the tokens matching the given parameters
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftTransferCollection resp = await moralis.Web3Api.Token.GetContractNFTTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, 0, 10);
Debug.Log($"GetContractNFTTransfers returned {resp.Total} Nft transfer entries");
```

### `GetNFTLowestPrice`
Get the lowest price found for a nft token contract for the last x days (only trades paid in ETH)
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **days** _integer_ OPTIONAL Offset
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
- **marketplace** _string_ OPTIONAL web3 marketplace from where to get the trades (only opensea is supported at the moment)
#### Example
```
Trade resp = await moralis.Web3Api.Token.GetNFTLowestPrice("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, 2000);
Debug.Log($"GetNFTLowestPrice Price: {resp.Price}");
```

### `GetNFTMetadata`
Gets the contract level metadata (name, symbol, base token uri) for the given contract
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
#### Example
```
NftContractMetadata resp = await moralis.Web3Api.Token.GetNFTMetadata("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth);
Debug.Log($"GetNFTMetadata Name: {resp.Name}, TokenAddress: {resp.TokenAddress}");
```

### `GetNFTOwners`
Gets all owners of NFT items within a given contract collection
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **format** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftOwnerCollection resp = await moralis.Web3Api.Token.GetNFTOwners("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, 0, 10);
Debug.Log($"GetNFTOwners returned {resp.Total} Nft Owner records");
```

### `GetNFTTrades`
Get the nft trades for a given contracts and marketplace
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
- **marketplace** _string_ OPTIONAL web3 marketplace from where to get the trades (only opensea is supported at the moment)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
TradeCollection resp = await moralis.Web3Api.Token.GetNFTTrades("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, null, null, null, null, null, 0, 10);
Debug.Log($"GetNFTTrades returned {resp.Total} Nft trades");
```

### `GetNftTransfersFromToBlock`
Gets the transfers of the tokens from a block number to a block number
- **chain** _ChainList_ REQUIRED The chain to query
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **format** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftTransferCollection resp = await moralis.Web3Api.Token.GetNftTransfersFromToBlock(ChainList.eth, 99999, 25999999, null, null, null, 0, 10);
Debug.Log($"GetNftTransfersFromToBlock returned {resp.Total} Nft Transfers");
```

### `GetTokenAddressTransfers`
Gets ERC20 token contract transactions in descending order based on block number
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
Erc20TransactionCollection resp = await moralis.Web3Api.Token.GetTokenAddressTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", ChainList.eth, null, null, null, null, null, 0, 10);
Debug.Log($"GetTokenAddressTransfers returned {resp.Total} transfer entries");
```

### `GetTokenAllowance`
Gets the amount which the spender is allowed to withdraw from the spender
- **address** _string_ REQUIRED Target address
- **ownerAddress** _string_ REQUIRED Target address
- **spenderAddress** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
#### Example
```
Erc20Allowance allowance = moralis.Web3Api.Token.GetTokenAllowance(address, ownerAddress, spenderAddress, ChainList.eth);
```

### `GetTokenIdMetadata`
Gets data, including metadata (where available), for the given token id of the given contract address.
- **address** _string_ REQUIRED Target address
- **tokenId** _string_ REQUIRED The id of the token
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
#### Example
```
Nft resp = await moralis.Web3Api.Token.GetTokenIdMetadata("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth);
Debug.Log($"GetTokenIdMetadata Name: {resp.Name}, Amount: {resp.Amount}");
```

### `GetTokenIdOwners`
Gets all owners of NFT items within a given contract collection
- **address** _string_ REQUIRED Target address
- **tokenId** _string_ REQUIRED The id of the token
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftOwnerCollection resp = await moralis.Web3Api.Token.GetTokenIdOwners("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth, null, 0, 10);
Debug.Log($"GetTokenIdOwners returned {resp.Total} Nfts");
```

### `GetTokenMetadata`
Returns metadata (name, symbol, decimals, logo) for a given token contract address.
- **address** _List<string>_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
#### Example
```
List<string> addresses = new List<string>();
addresses.Add("0x6b175474e89094c44da98b954eedeac495271d0f");
List<Erc20Metadata> resp = await moralis.Web3Api.Token.GetTokenMetadata(addresses, ChainList.eth);
Debug.Log($"GetTokenMetadata returned {resp.Count} entries.");
```

### `GetTokenMetadataBySymbol`
Returns metadata (name, symbol, decimals, logo) for a given token contract address.
- **symbols** _List<string>_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The symbols to get metadata for
- **subdomain** _string_ OPTIONAL The subdomain of the moralis server to use (Only use when selecting local devchain as chain)
#### Example
```
List<string> symbols = new List<string>();
symbols.Add("DAI");
List<Erc20Metadata> resp = await moralis.Web3Api.Token.GetTokenMetadataBySymbol(symbols, ChainList.eth);
Debug.Log($"GetTokenMetadataBySymbol returned {resp.Count} entries.");
```

### `GetTokenPrice`
Returns the price nominated in the native token and usd for a given token contract address.
- **address** _string_ REQUIRED Target address
- **chain** _ChainList_ REQUIRED The chain to query
- **providerUrl** _string_ OPTIONAL web3 provider url to user when using local dev chain
- **exchange** _string_ OPTIONAL The factory name or address of the token exchange
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
#### Example
```
Erc20Price resp = await moralis.Web3Api.Token.GetTokenPrice("0x6b175474e89094c44da98b954eedeac495271d0f", ChainList.eth);
Debug.Log($"GetTokenPrice Price: {resp.UsdPrice} USD");
```

### `GetWalletTokenIdTransfers`
Gets the transfers of the tokens matching the given parameters
- **address** _string_ REQUIRED Target address
- **tokenId** _string_ REQUIRED The id of the token
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
- **order** _string_ OPTIONAL If the order should be Ascending or Descending based on the blocknumber on which the NFT was minted. Allowed values: "ASC", "DESC"
#### Example
```
NftTransferCollection resp = await moralis.Web3Api.Token.GetWalletTokenIdTransfers("0x06012c8cf97BEaD5deAe237070F9587f8E7A266d", "10", ChainList.eth, null, 0, 10);
Debug.Log($"GetWalletTokenIdTransfers returned {resp.Total} Nfts");
```

### `SearchNFTs`
Gets NFTs that match a given metadata search.
- **q** _string_ REQUIRED The search string
- **chain** _ChainList_ REQUIRED The chain to query
- **foramt** _string_ OPTIONAL The format of the token id
- **filter** _string_ OPTIONAL What fields the search should match on. To look into the entire metadata set the value to 'global'. To have a better response time you can look into a specific field like name. Available values : name, description, attributes, global, name,description, name,attributes, description,attributes, name,description,attributes
- **fromBlock** _string_ OPTIONAL The minimum block number from where to get the logs.
- **toBlock** _string_ OPTIONAL The maximum block number from where to get the logs.
- **fromDate** _string_ OPTIONAL The date from where to get the logs (any format that is accepted by momentjs).
- **toDate** _string_ OPTIONAL Get the logs to this date (any format that is accepted by momentjs)
- **offset** _integer_ OPTIONAL Offset
- **limit** _integer_ OPTIONAL Limit
#### Example
```
NftMetadataCollection resp = await moralis.Web3Api.Token.SearchNFTs("Apes", ChainList.eth, null, null, null, null, null, null, 0, 10);
Debug.Log($"SearchNFTs returned {resp.Total} Nfts");
```

# 🏗 Solana Api Methods

## Solana Account

### `Solana Balance`
```
NativeBalance bal = await moralis.SolanaApi.Account.Balance(NetworkTypes.mainnet, "6XU36wCxWobLx5Rtsb58kmgAJKVYmMVqy4SHXxENAyAe");
```

### `Solana GetNFTs`
```
List<SplNft> bal = await moralis.SolanaApi.Account.GetNFTs(NetworkTypes.mainnet, "6XU36wCxWobLx5Rtsb58kmgAJKVYmMVqy4SHXxENAyAe");
```

### `Solana GetPortfolio`
```
Portfolio bal = await moralis.SolanaApi.Account.GetPortfolio(NetworkTypes.mainnet, "6XU36wCxWobLx5Rtsb58kmgAJKVYmMVqy4SHXxENAyAe");
```

### `Solana GetSplTokens`
```
List<SplTokenBalanace> bal = await moralis.SolanaApi.Account.GetSplTokens(NetworkTypes.mainnet, "6XU36wCxWobLx5Rtsb58kmgAJKVYmMVqy4SHXxENAyAe");
```

## Solana NFT

### `Solana GetNFTMetadata`
```
NftMetadata bal = await moralis.SolanaApi.Nft.GetNFTMetadata(NetworkTypes.mainnet, "6XU36wCxWobLx5Rtsb58kmgAJKVYmMVqy4SHXxENAyAe");
```
