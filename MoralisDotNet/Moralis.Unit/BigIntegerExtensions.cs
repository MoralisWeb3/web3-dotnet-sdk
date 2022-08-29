using System;
using System.Globalization;
using System.Numerics;

namespace Moralis.Unit
{
    /// <summary>
    /// Provides functions for BigInteger
    /// <see cref="Nethereum.Util.BigIntegerExtensions">https://github.com/Nethereum</see>
    /// </summary>
    public static class BigIntegerExtensions
    {
        /// <summary>
        /// Number of digits in a BigInteger value.
        /// </summary>
        /// <param name="value">BigInteger</param>
        /// <returns>int</returns>
        public static int NumberOfDigits(this BigInteger value)
        {
            return (value * value.Sign).ToString().Length;
        }

        /// <summary>
        /// Parse an invariat value.
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>BigInteger</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static BigInteger ParseInvariant(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            return BigInteger.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
