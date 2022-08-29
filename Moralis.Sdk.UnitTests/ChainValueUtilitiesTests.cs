using NUnit.Framework;
using Moralis.Unit;
using System.Numerics;
using Moralis.Web3Api.Models;
using System;

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

        [Test]
        public void Erc20TokenBalance_HandlesNulInput()
        {
            Erc20TokenBalance bal = new Erc20TokenBalance()
            {
                Balance = (BigInteger.Parse("1420000000000000000")).ToString(),
                ChainId = ChainList.eth,
                Decimals = null,
                Name = null,
                Symbol = null
            };

            BigDecimal val = bal.NativeTokenBalance;
            BigDecimal comp = new BigDecimal(1.42);

            Assert.AreEqual(val, comp);

        }

        [Test]
        public void Erc20TokenBalance_NullBalanceReturnsZeroNativeTokenBalance()
        {
            Erc20TokenBalance bal = new Erc20TokenBalance()
            {
                Balance = null, 
                ChainId = ChainList.eth,
                Decimals = null,
                Name = null,
                Symbol = null
            };

            Assert.AreEqual(new BigDecimal(0), bal.NativeTokenBalance);
        }
    }
}
