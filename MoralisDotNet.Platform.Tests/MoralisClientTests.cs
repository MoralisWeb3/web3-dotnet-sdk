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
    public class MoralisClientTests
    {
        [TestMethod]
        public void LiveQueryServerUri_isSet()
        {
            MoralisService<MoralisUser> client = new MoralisService<MoralisUser>("1234", "https://api.moralis.com/server", "1234", new NewtonsoftJsonSerializer());

            Assert.AreEqual("wss://api.moralis.com/server", client.ServerConnectionData.LiveQueryServerURI);
        }

    }
}
