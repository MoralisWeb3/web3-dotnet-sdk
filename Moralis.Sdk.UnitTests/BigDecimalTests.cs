using NUnit.Framework;
using Moralis.Unit;
using System.Numerics;

namespace Moralis.Sdk.UnitTests
{
    public class BigDecimalTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateFromBigNumber_Succeeds()
        {
            BigInteger n = new BigInteger(10042);
            BigDecimal x = new BigDecimal(n, -2);
            
            Assert.AreEqual(x.ToString(), "100.42");
        }
    }
}