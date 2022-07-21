# Moralis-.NET-SDK
Final Moralis C# .NET SDK that supports the original Moralis Parse-based Server

## Setup

                ServerConnectionData conData = new ServerConnectionData()
                {
                    ApplicationID = "APPLICATION ID",
                    ServerURI = "SERVER URI",
                    MasterKey = "SERVER MASTER KEY",
                    ApiKey = "WEB3 API KEY",
                    AuthenticationApiUrl = "AUTH 2.0 API URL"
                };

                //MoralisClient.Initialize(true, "1kXrzei19HNrb3YvkLaBbOAuRo6SGcmGqmlZ2E6FYFZ2QnqO46rn3xsAX6eRMBns"); // "https://arw2wxg84h6b.moralishost.com:2053/server");
                MoralisClient moralis = new MoralisClient(conData, new AuthApiClient(), new Web3ApiClient(), new SolanaApiClient(), new NewtonsoftJsonSerializer());
