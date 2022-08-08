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
        public static int NumberOfDigits(this BigInteger value)
        {
            return (value * value.Sign).ToString().Length;
        }

        public static BigInteger ParseInvariant(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            return BigInteger.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
