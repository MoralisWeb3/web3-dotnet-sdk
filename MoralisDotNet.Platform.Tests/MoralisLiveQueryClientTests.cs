using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;
using Moralis.Platform.Queries;
using Moralis.Platform.Queries.Live;
using Moralis.Platform.Services.ClientServices;

namespace Moralis.Platform.Tests
{
    [TestClass]
    public class MoralisLiveQueryClientTests
    {


        ServerConnectionData connectionData = new ServerConnectionData()
        {
            ApplicationID = "1234",
            LiveQueryServerURI = "wss://test.moralis.io/doesnotexist",
            Test = true
        };

        [TestMethod]
        public void MoralisLiveQueryClient_ReceivesConnectResponseOnSubscribe()
        {
            NewtonsoftJsonSerializer serializer = new NewtonsoftJsonSerializer();

            bool onConnectedCalled = false;
            ConnectRequest msg = new ConnectRequest()
            {
                applicationId = connectionData.ApplicationID
            };

            ActionEvent<MoralisObject> ae = new ActionEvent<MoralisObject>()
            {
                Object = null,
                op = OperationTypes.connected.ToString(),
                requestId = 1
            };

            string json = serializer.Serialize(msg, serializer.DefaultOptions);
            string testValue = serializer.Serialize(ae, serializer.DefaultOptions);

            Mock<IClientWebSocket> mockWsClient = CreateMockWebSocket(testValue);

            SubscribableWebSocket subClient = new SubscribableWebSocket(new byte[0], connectionData, 1, "abcd", "DEADBEEF", new NewtonsoftJsonSerializer());
            subClient.OnGeneralMessage += (string s) =>
            {
                System.Diagnostics.Debug.WriteLine(s);
            };

            subClient.OnEventMessage += (byte[] buffer, int bufferSize) => {
                Assert.IsTrue(buffer.Length == testValue.Length);
                Assert.IsTrue(buffer.Length == bufferSize);

                string s = Encoding.UTF8.GetString(buffer);

                Assert.AreEqual(s, testValue);

                QueryEventMessage opMsg = (QueryEventMessage)serializer.Deserialize<QueryEventMessage>(s);

                Assert.AreEqual(opMsg.op, OperationTypes.connected.ToString());

                
            };
            subClient.SetWebsocket(mockWsClient.Object);

            ILiveQueryCallbacks<MoralisObject> callbacks = new LiveQueryCallbacks<MoralisObject>();

            MoralisQuery<MoralisObject> query = new MoralisQuery<MoralisObject>(default, default, default, serializer, "MoralisObject");

            MoralisLiveQueryClient<MoralisObject> mlqc =
                new MoralisLiveQueryClient<MoralisObject>(query, connectionData,
                callbacks, subClient, "DEADBEEF", "abcd");

            mlqc.OnConnected += () => { 
                onConnectedCalled = true;
                subClient.ClientStatus = LiveQueryClientStatusTypes.Closed;
            };

            mlqc.Subscribe();

            long ticks = DateTime.Now.Ticks;
            Task.Run(() => { while ( (DateTime.Now.Ticks - ticks) < 2000 || !mlqc.ClientStatus.Equals(LiveQueryClientStatusTypes.Closed)) ; })
                .Wait();

            Assert.IsTrue(onConnectedCalled);
        }

        private Mock<IClientWebSocket> CreateMockWebSocket(string responseMessage)
        {
            int buffIndex = 0;

            Mock<IClientWebSocket> mockWsClient = new Mock<IClientWebSocket>();
            mockWsClient.SetupGet(obj => obj.State).Returns(WebSocketState.Open);
            mockWsClient.Setup(obj => obj.ConnectAsync(It.IsAny<Uri>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
            mockWsClient.Setup(obj => obj.SendAsync(It.IsAny<ArraySegment<byte>>(),
                It.IsAny<WebSocketMessageType>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
            mockWsClient.Setup(obj => obj.ReceiveAsync(It.IsAny<ArraySegment<byte>>(),
                It.IsAny<CancellationToken>()))
                .Returns((ArraySegment<byte> a, CancellationToken b) =>
                {
                    WebSocketReceiveResult wsrr = new WebSocketReceiveResult(a.Count, WebSocketMessageType.Text, false);
                    byte[] buf = Encoding.UTF8.GetBytes(responseMessage);

                    if (buf.Length < 1) return Task.FromResult(new WebSocketReceiveResult(0, WebSocketMessageType.Text, true) );

                    if (buffIndex >= buf.Length)
                    {
                        wsrr = new WebSocketReceiveResult(0, WebSocketMessageType.Text, true);
                    }

                    int count = 0;

                    for (int i = 0; i < a.Count; i++)
                    {
                        if (buffIndex >= buf.Length)
                        {
                            wsrr = new WebSocketReceiveResult(count, WebSocketMessageType.Text, true);
                            break;
                        }

                        if (buf[buffIndex] == 0) break;

                        a[i] = buf[buffIndex];
                        buffIndex++;
                        count++;
                        if (buffIndex >= buf.Length)
                        {
                            wsrr = new WebSocketReceiveResult(count, WebSocketMessageType.Text, true);
                            break;
                        }
                    }
                    a = new ArraySegment<byte>(a.Array, 0, count);

                    return Task.FromResult(wsrr);
                });
            return mockWsClient;
        }
    }
}
