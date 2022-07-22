# Moralis-.NET-SDK
Final Moralis C# .NET SDK that supports the original Moralis Parse-based Server

## Setup
Before accessing Moralis functionality, Moralis must be initialized.
```
ServerConnectionData conData = new ServerConnectionData()
{
    ApplicationID = "APPLICATION ID",
    ServerURI = "SERVER URI",
    MasterKey = "SERVER MASTER KEY",
    ApiKey = "WEB3 API KEY",
    AuthenticationApiUrl = "AUTH 2.0 API URL"
};

MoralisClient moralis = new MoralisClient(conData, new AuthApiClient(), new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());
```

## Parse Server
The Moralis Server is based on [Parser Server](https://parseplatform.org/) becuase of this you can configure the Moralis SDK to use your own Parse Server instance instead of the Moralis Server.

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