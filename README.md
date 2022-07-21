# Moralis-.NET-SDK
Final Moralis C# .NET SDK that supports the original Moralis Parse-based Server

## Setup
Before accessing Moralis functionalit, Moralis must be initialized.
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