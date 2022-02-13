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
using Moralis.Platform.Queries.Live;

namespace Moralis.Platform.Tests
{
    [TestClass]
    public class SubscribableWebSocketTests
    {
        ServerConnectionData connectionData = new ServerConnectionData()
        {
            ApplicationID = "1234",
            LiveQueryServerURI = "wss://test.moralis.io/doesnotexist",
            Test = true
        };

        [TestMethod]
        public void LiveQueryClient_ReturnsExpectedResult()
        {
            byte[] buffer = new byte[256];
            string testValue = "This is a test.";

            IClientWebSocket ws = CreateMockWebSocket(testValue).Object;

            bool eventCalled = false;
            SubscribableWebSocket subClient = new SubscribableWebSocket(new byte[0], connectionData, 1, null, null, new NewtonsoftJsonSerializer());
            subClient.OnGeneralMessage += (string s) =>
            {
                System.Diagnostics.Debug.WriteLine(s);
            };

            subClient.OnEventMessage += (byte[] buffer, int bufferSize) => {
                Assert.IsTrue(buffer.Length == testValue.Length);
                Assert.IsTrue(buffer.Length == bufferSize);

                string s = Encoding.UTF8.GetString(buffer);

                Assert.AreEqual(s, testValue);
                eventCalled = true;

                subClient.ClientStatus = LiveQueryClientStatusTypes.Closed;
            };

            subClient.SetWebsocket(ws);

            subClient.Subscribe();

            Assert.IsTrue(eventCalled);
        }

        [TestMethod]
        public void LiveQueryClient_HandlesLargeResult()
        {
            NewtonsoftJsonSerializer jsonConvert = new NewtonsoftJsonSerializer();
            Dictionary<int, string> x = new Dictionary<int, string>();

            for (int i = 0; i < 50; i++)
            {
                x.Add(i, "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789");
            }
            string testValue = jsonConvert.Serialize(x);

            IClientWebSocket ws = CreateMockWebSocket(testValue).Object;

            bool eventCalled = false;
            SubscribableWebSocket subClient = new SubscribableWebSocket(new byte[0], connectionData, 1, null, null, new NewtonsoftJsonSerializer());
            subClient.OnGeneralMessage += (string s) =>
            {
                System.Diagnostics.Debug.WriteLine(s);
            };

            subClient.OnEventMessage += (byte[] buffer, int bufferSize) => {
                Assert.IsTrue(buffer.Length == testValue.Length);
                Assert.IsTrue(buffer.Length == bufferSize);

                string s = Encoding.UTF8.GetString(buffer);

                Assert.AreEqual(s, testValue);

                Dictionary<int, string> y = (Dictionary<int, string>)jsonConvert.Deserialize<Dictionary<int, string>>(s);

                Assert.AreEqual(y.Keys.Count, x.Keys.Count);

                eventCalled = true;

                subClient.ClientStatus = LiveQueryClientStatusTypes.Closed;
            };

            subClient.SetWebsocket(ws);

            subClient.Subscribe();

            Assert.IsTrue(eventCalled);
        }


        [TestMethod]
        public void LiveQueryClient_SendsConnectionRequestOnSubscribe()
        {
            NewtonsoftJsonSerializer jsonConvert = new NewtonsoftJsonSerializer();
            bool eventCalled = false;
            ConnectRequest msg = new ConnectRequest()
            {
                applicationId = connectionData.ApplicationID
                //,
                //InstallationId = "abcd",
                //SessionToken = "DEADBEEF"
            };

            ActionEvent<MoralisObject> ae = new ActionEvent<MoralisObject>()
            {
                Object = null,
                op = OperationTypes.connect.ToString(),
                requestId = 1
            };

            string json = jsonConvert.Serialize(msg, jsonConvert.DefaultOptions);
            string testValue = jsonConvert.Serialize(ae, jsonConvert.DefaultOptions);

            Mock<IClientWebSocket> mockWsClient = CreateMockWebSocket(testValue);

            mockWsClient.Setup(obj => obj.SendAsync(It.IsAny<ArraySegment<byte>>(),
                It.IsAny<WebSocketMessageType>(),
                It.IsAny<bool>(),
                It.IsAny<CancellationToken>()))
                .Callback<ArraySegment<byte>, WebSocketMessageType, bool, CancellationToken>((a,b,c,d) => {
                    string s = Encoding.UTF8.GetString(a.Array);

                    Assert.AreEqual(json, s);

                    eventCalled = true;
                })
                .Returns(Task.CompletedTask);

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

                QueryEventMessage opMsg = (QueryEventMessage)jsonConvert.Deserialize<QueryEventMessage>(s);

                Assert.AreEqual(opMsg.op, OperationTypes.connect);

                subClient.ClientStatus = LiveQueryClientStatusTypes.Closed;
            };
            subClient.SetWebsocket(mockWsClient.Object);

            subClient.Subscribe();

            Assert.IsTrue(eventCalled);
        }

        private Mock<IClientWebSocket> CreateMockWebSocket(string testValue)
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
                    byte[] buf = Encoding.UTF8.GetBytes(testValue);
                    if (buffIndex >= buf.Length)
                    {
                        wsrr = new WebSocketReceiveResult(0, WebSocketMessageType.Text, true);
                    }

                    int count = 0;

                    for (int i = 0; i < a.Count; i++)
                    {
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
