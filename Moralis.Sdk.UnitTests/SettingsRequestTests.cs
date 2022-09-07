using NUnit.Framework;
using Moralis.Unit;
using System.Numerics;
using Moralis.Web3Api.Models;
using System;
using Newtonsoft.Json;
using Moralis.StreamsApi.Models;

namespace Moralis.Sdk.UnitTests
{
    internal class SettingsRequestTests
    {
        [Test]
        public void Json_DeserializesToSettingsRequest()
        {
            string json = "{\"secretKey\":\"0xdeadbeef\", \"cluster\": \"eu-central-1\"}";
            SettingsDetail sr = JsonConvert.DeserializeObject<SettingsDetail>(json);

            Assert.IsNotNull(sr);
            Assert.AreEqual("0xdeadbeef", sr.SecretKey);
            Assert.AreEqual("eu-central-1", sr.Cluster);
        }
    }
}
