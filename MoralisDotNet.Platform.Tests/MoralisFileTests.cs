using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moralis.Platform.Abstractions;
using Moralis.Platform.Objects;
using Moralis.Platform.Services;
using Moralis.Platform.Services.ClientServices;
using Moralis.Platform.Utilities;

namespace Moralis.Platform.Tests
{
    [TestClass]
    public class FileTests
    {
        [TestMethod]
        [AsyncStateMachine(typeof(FileTests))]
        public Task TestFileSave()
        {
            Mock<IFileService> mockController = new Mock<IFileService>();
            mockController.Setup(obj => obj.SaveAsync(It.IsAny<MoralisFileState>(), It.IsAny<Stream>(), It.IsAny<string>(), It.IsAny<IProgress<IDataTransferLevel>>(), It.IsAny<CancellationToken>())).Returns(Task.FromResult(new MoralisFileState { name = "newBekti.png", url = new Uri("https://www.parse.com/newBekti.png"), mediatype = "image/png" }));
            Mock<ICurrentUserService<MoralisUser>> mockCurrentUserController = new Mock<ICurrentUserService<MoralisUser>>();

            MoralisService<MoralisUser> client = new MoralisService<MoralisUser>(new ServerConnectionData { Test = true }, new NewtonsoftJsonSerializer(), new MutableServiceHub<MoralisUser> { FileService = mockController.Object, CurrentUserService = mockCurrentUserController.Object });

            MoralisFile file = new MoralisFile("bekti.jpeg", new MemoryStream { }, "image/jpeg");

            Assert.AreEqual("bekti.jpeg", file.name);
            Assert.AreEqual("image/jpeg", file.MimeType);
            Assert.IsTrue(file.IsDirty);

            return file.SaveAsync(client).ContinueWith(task =>
            {
                Assert.IsFalse(task.IsFaulted);
                Assert.AreEqual("newBekti.png", file.name);
                Assert.AreEqual("image/png", file.MimeType);
                Assert.AreEqual("https://www.parse.com/newBekti.png", file.url.AbsoluteUri);
                Assert.IsFalse(file.IsDirty);
            });
        }

        [TestMethod]
        public void TestSecureUrl()
        {
            Uri unsecureUri = new Uri("http://files.parsetfss.com/yolo.txt");
            Uri secureUri = new Uri("https://files.parsetfss.com/yolo.txt");
            Uri randomUri = new Uri("http://random.server.local/file.foo");

            MoralisFile file = MoralisFileExtensions.Create("Foo", unsecureUri);
            Assert.AreEqual(secureUri, file.url);

            file = MoralisFileExtensions.Create("Bar", secureUri);
            Assert.AreEqual(secureUri, file.url);

            file = MoralisFileExtensions.Create("Baz", randomUri);
            Assert.AreEqual(randomUri, file.url);
        }
    }
}
