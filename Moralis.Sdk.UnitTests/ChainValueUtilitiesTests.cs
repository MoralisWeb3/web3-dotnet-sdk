using NUnit.Framework;
using Moralis.Unit;
using System.Numerics;
using Moralis.Web3Api.Models;

namespace Moralis.Sdk.UnitTests
{

    internal class ChainValueUtilitiesTests
    {
        // Erc20TokenBalance

        [Test]
        public void Erc20TokenBalance_BalanceAsNativeToken()
        {
            Erc20TokenBalance bal = new Erc20TokenBalance()
            {
                Balance = (BigInteger.Parse("1420000000000000000")).ToString(),
                ChainId = ChainList.eth,
                Decimals = 18,
                Name = "Clem Coin",
                Symbol = "CLEM"
            };

            BigDecimal val = bal.NativeTokenBalance;
            BigDecimal comp = new BigDecimal(1.42);

            Assert.AreEqual(val, comp);
            
        }
    }
}
