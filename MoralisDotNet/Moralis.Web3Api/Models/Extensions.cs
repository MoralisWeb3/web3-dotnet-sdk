using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Moralis.Models;
using Moralis.Unit;
using Moralis.Web3Api.Models;

namespace Moralis.Web3Api.Models
{
    public static class Extensions
    {
        /// <summary>
        /// Returns the ChainEntry associated with the ChainId of the target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static ChainEntry GetChainEntry(this NativeTokenBalanceBase target)
        {
            ChainEntry resp = SupportedEvmChains.FromChainList(target.ChainId);

            return resp;
        }

        /// <summary>
        /// Returns the symbol for the target Chain Id
        /// </summary>
        /// <param name="target"></param>
        /// <returns>string</returns>
        public static string TokenSymbol(this ChainList target)
        {
            ChainEntry resp = SupportedEvmChains.FromChainList(target);

            return resp.Symbol;
        }

        /// <summary>
        /// Converts a numeric string to a BigIntegrer. If val is not a valid integer
        /// result is 0
        /// </summary>
        /// <param name="val">Must be numeric</param>
        /// <returns>BigInteger</returns>
        public static BigInteger ToBigNumber(this string val)
        {
            BigInteger result = 0;

            BigInteger.TryParse(val, out result);

            return result;
        }
    }
}
