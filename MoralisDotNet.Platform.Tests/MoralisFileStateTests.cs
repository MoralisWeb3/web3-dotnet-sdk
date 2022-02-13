using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moralis.Platform.Objects;
using Moralis.Platform.Services;

namespace Moralis.Platform.Tests
{
    [TestClass]
    public class MoralisFileStateTests
    {
        [TestMethod]
        public void TestSecureUrl()
        {
            Uri unsecureUri = new Uri("http://files.parsetfss.com/yolo.txt");
            Uri secureUri = new Uri("https://files.parsetfss.com/yolo.txt");
            Uri randomUri = new Uri("http://random.server.local/file.foo");

            MoralisFileState state = new MoralisFileState
            {
                name = "A",
                url = unsecureUri,
                mediatype = null
            };

            Assert.AreEqual(unsecureUri, state.url);
            Assert.AreEqual(secureUri, state.SecureLocation);

            // Make sure the proper port was given back.
            Assert.AreEqual(443, state.SecureLocation.Port);

            state = new MoralisFileState
            {
                name = "B",
                url = randomUri,
                mediatype = null
            };

            Assert.AreEqual(randomUri, state.url);
            Assert.AreEqual(randomUri, state.url);
        }
    }
}
