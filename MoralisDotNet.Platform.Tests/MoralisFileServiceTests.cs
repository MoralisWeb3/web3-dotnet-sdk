using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;
using Moralis.Platform.Services.ClientServices;
using Moralis.Platform.Services.Models;

namespace Moralis.Platform.Tests
{
    [TestClass]
    public class MoralisFileServiceTests
    {
        [TestMethod]
        [AsyncStateMachine(typeof(MoralisFileServiceTests))]
        public Task TestFileControllerSaveWithInvalidResult()
        {
            Tuple<HttpStatusCode, string> response = new Tuple<HttpStatusCode, string>(HttpStatusCode.Accepted, null);
            Mock<IMoralisCommandRunner> mockRunner = CreateMockRunner(response);
            MoralisFileState state = new MoralisFileState
            {
                name = "bekti.png",
                mediatype = "image/png"
            };

            ServerConnectionData conData = new ServerConnectionData()
            {
                ApplicationID = "APPLICATION ID",
                ServerURI = "SERVER URI",
                MasterKey = "SERVER MASTER KEY"
            };

            MoralisFileService controller = new MoralisFileService(mockRunner.Object, conData, new NewtonsoftJsonSerializer());
            return controller.SaveAsync(state, dataStream: new MemoryStream(), sessionToken: null, progress: null).ContinueWith(t => Assert.IsTrue(t.IsFaulted));
        }

        [TestMethod]
        [AsyncStateMachine(typeof(MoralisFileServiceTests))]
        public Task TestFileControllerSaveWithEmptyResult()
        {
            Tuple<HttpStatusCode, string> response = new Tuple<HttpStatusCode, string>(HttpStatusCode.Accepted, "{}");
            Mock<IMoralisCommandRunner> mockRunner = CreateMockRunner(response);
            MoralisFileState state = new MoralisFileState
            {
                name = "bekti.png",
                mediatype = "image/png"
            };

            ServerConnectionData conData = new ServerConnectionData()
            {
                ApplicationID = "APPLICATION ID",
                ServerURI = "SERVER URI",
                MasterKey = "SERVER MASTER KEY"
            };

            MoralisFileService controller = new MoralisFileService(mockRunner.Object, conData, new NewtonsoftJsonSerializer());
            return controller.SaveAsync(state, dataStream: new MemoryStream(), sessionToken: null, progress: null).ContinueWith(t => Assert.IsTrue(t.IsFaulted));
        }

        [TestMethod]
        [AsyncStateMachine(typeof(MoralisFileServiceTests))]
        public Task TestFileControllerSaveWithIncompleteResult()
        {
            Tuple<HttpStatusCode, string> response = new Tuple<HttpStatusCode, string>(HttpStatusCode.Accepted, "{\"name\":\"newBekti.png\" }");
            Mock<IMoralisCommandRunner> mockRunner = CreateMockRunner(response);
            MoralisFileState state = new MoralisFileState
            {
                name = "bekti.png",
                mediatype = "image/png"
            };

            ServerConnectionData conData = new ServerConnectionData()
            {
                ApplicationID = "APPLICATION ID",
                ServerURI = "SERVER URI",
                MasterKey = "SERVER MASTER KEY"
            };

            MoralisFileService controller = new MoralisFileService(mockRunner.Object, conData, new NewtonsoftJsonSerializer());
            return controller.SaveAsync(state, dataStream: new MemoryStream(), sessionToken: null, progress: null).ContinueWith(t => Assert.IsTrue(t.IsFaulted));
        }

        [TestMethod]
        [AsyncStateMachine(typeof(MoralisFileServiceTests))]
        public Task TestFileControllerSave()
        {
            MoralisFileState state = new MoralisFileState
            {
                name = "bekti.png",
                mediatype = "image/png"
            };

            ServerConnectionData conData = new ServerConnectionData()
            {
                ApplicationID = "APPLICATION ID",
                ServerURI = "SERVER URI",
                MasterKey = "SERVER MASTER KEY"
            };

            return new MoralisFileService(CreateMockRunner(new Tuple<HttpStatusCode, string>(HttpStatusCode.Accepted, " {\"name\":\"newBekti.png\", \"url\":\"https://www.parse.com/newBekti.png\" }")).Object, conData, new NewtonsoftJsonSerializer()).SaveAsync(state, dataStream: new MemoryStream(), sessionToken: null, progress: null).ContinueWith(t =>
            {
                Assert.IsFalse(t.IsFaulted);
                MoralisFileState newState = t.Result;

                Assert.AreEqual(state.mediatype, newState.mediatype);
                Assert.AreEqual("newBekti.png", newState.name);
                Assert.AreEqual("https://www.parse.com/newBekti.png", newState.SecureLocation.AbsoluteUri);
            });
        }

        private Mock<IMoralisCommandRunner> CreateMockRunner(Tuple<HttpStatusCode, string> response)
        {
            Mock<IMoralisCommandRunner> mockRunner = new Mock<IMoralisCommandRunner>();
            mockRunner.Setup(obj => obj.RunCommandAsync(It.IsAny<MoralisCommand>(), It.IsAny<IProgress<IDataTransferLevel>>(), It.IsAny<IProgress<IDataTransferLevel>>(), It.IsAny<CancellationToken>())).Returns(Task.FromResult(response));

            return mockRunner;
        }
    }
}
