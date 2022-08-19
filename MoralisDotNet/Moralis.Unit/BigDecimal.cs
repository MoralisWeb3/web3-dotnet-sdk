using System;
using System.Globalization;
using System.Numerics;

namespace Moralis.Unit
{
    /// BigNumber based on the original http://uberscraper.blogspot.co.uk/2013/09/c-bigdecimal-class-from-stackoverflow.html
    /// which was inspired by http://stackoverflow.com/a/4524254
    /// Original Author: Jan Christoph Bernack (contact: jc.bernack at googlemail.com)
    /// Changes JB: Added parse, Fix Normalise, Added Floor, New ToString, Change Equals (normalise to validate first), Change Casting to avoid overflows (even if might be slower), Added Normalise Bigger than zero, test on operations, parsing, casting, and other test coverage for ethereum unit conversions
    /// Changes KJ: Added Culture formatting
    /// http://stackoverflow.com/a/13813535/956364" />
    /// <summary>
    ///     Arbitrary precision Decimal.
    ///     All operations are exact, except for division.
    ///     Division never determines more digits than the given precision of 50.
    /// </summary>
    public struct BigDecimal : IComparable, IComparable<BigDecimal>
    {
        /// <summary>
        ///     Sets the maximum precision of division operations.
        ///     If AlwaysTruncate is set to true all operations are affected.
        /// </summary>
        public const int Precision = 50;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bigDecimal"></param>
        /// <param name="alwaysTruncate"></param>
        public BigDecimal(BigDecimal bigDecimal, bool alwaysTruncate = false) : this(bigDecimal.Mantissa,
            bigDecimal.Exponent, alwaysTruncate)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        /// <param name="alwaysTruncate"></param>
        public BigDecimal(decimal value, bool alwaysTruncate = false) : this((BigDecimal)value, alwaysTruncate)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="mantissa"></param>
        /// <param name="exponent">
        ///     The number of decimal units for example (-18). A positive value will be normalised as 10 ^
        ///     exponent
        /// </param>
        /// <param name="alwaysTruncate">
        ///     Specifies whether the significant digits should be truncated to the given precision after
        ///     each operation.
        /// </param>
        public BigDecimal(BigInteger mantissa, int exponent, bool alwaysTruncate = false) : this()
        {
            Mantissa = mantissa;
            Exponent = exponent;
            NormaliseExponentBiggerThanZero();
            Normalize();
            if (alwaysTruncate)
                Truncate();
        }

        /// <summary>
        /// The significant digits of a floating-point number or a number in scientific notation
        /// </summary>
        public BigInteger Mantissa { get; internal set; }

        /// <summary>
        /// A number denoting the power to which that number, symbol, or expression is to be raised.
        /// </summary>
        public int Exponent { get; internal set; }

        /// <summary>
        /// Defines a general comparison operator.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>int</returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null) || !(obj is BigDecimal))
                throw new ArgumentException();
            return CompareTo((BigDecimal)obj);
        }

        /// <summary>
        /// Defines a comparison operator to compare against other BigDecimals.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>int</returns>
        public int CompareTo(BigDecimal other)
        {
            return this < other ? -1 : (this > other ? 1 : 0);
        }

        /// <summary>
        /// Uses Mantissa to normalize when exponent is greater than zero.
        /// </summary>
        public void NormaliseExponentBiggerThanZero()
        {
            if (Exponent > 0)
            {
                Mantissa = Mantissa * BigInteger.Pow(10, Exponent);
                Exponent = 0;
            }
        }

        /// <summary>
        /// Removes trailing zeros on the mantissa
        /// </summary>
        public void Normalize()
        {
            if (Exponent == 0) return;

            if (Mantissa.IsZero)
            {
                Exponent = 0;
            }
            else
            {
                BigInteger remainder = 0;
                while (remainder == 0)
                {
                    var shortened = BigInteger.DivRem(Mantissa, 10, out remainder);
                    if (remainder != 0)
                        continue;
                    Mantissa = shortened;
                    Exponent++;
                }

                NormaliseExponentBiggerThanZero();
            }
        }

        /// <summary>
        /// Truncate the number to the given precision by removing the least significant digits.
        /// </summary>
        /// <returns>The truncated number</returns>
        internal BigDecimal Truncate(int precision = Precision)
        {
            // copy this instance (remember its a struct)
            var shortened = this;
            // save some time because the number of digits is not needed to remove trailing zeros
            shortened.Normalize();
            // remove the least significant digits, as long as the number of digits is higher than the given Precision
            while (shortened.Mantissa.NumberOfDigits() > precision)
            {
                shortened.Mantissa /= 10;
                shortened.Exponent++;
            }

            return shortened;
        }

        /// <summary>
        /// Rounds the number to the specified amount of significant digits.
        /// Midpoints (like 0.5 or -0.5) are rounded away from 0 (e.g. to 1 and -1 respectively).
        /// </summary>
        public BigDecimal RoundAwayFromZero(int significantDigits)
        {
            if (significantDigits < 0 || significantDigits > 2_000_000_000)
                throw new ArgumentOutOfRangeException(paramName: nameof(significantDigits));

            if (Exponent >= -significantDigits) return this;

            bool negative = this.Mantissa < 0;
            var shortened = negative ? -this : this;
            shortened.Normalize();

            while (shortened.Exponent < -significantDigits)
            {
                shortened.Mantissa = BigInteger.DivRem(shortened.Mantissa, 10, out var rem);
                shortened.Mantissa += rem >= 5 ? +1 : 0;
                shortened.Exponent++;
            }

            return negative ? -shortened : shortened;
        }

        /// <summary>
        /// Truncate the number, removing all decimal digits.
        /// </summary>
        /// <returns>The truncated number</returns>
        public BigDecimal Floor()
        {
            return Truncate(Mantissa.NumberOfDigits() + Exponent);
        }

        private static int NumberOfDigits(BigInteger value)
        {
            return value.NumberOfDigits();
        }

        /// <summary>
        /// Provides a ToString operation
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            Normalize();
            bool isNegative = Mantissa < 0;

            var s = BigInteger.Abs(Mantissa).ToString();
            if (Exponent != 0)
            {
                var decimalPos = s.Length + Exponent;
                if (decimalPos < s.Length)
                    if (decimalPos >= 0)
                        s = s.Insert(decimalPos, decimalPos == 0 ? "0." : ".");
                    else
                        s = "0." + s.PadLeft(decimalPos * -1 + s.Length, '0');
                else
                    s = s.PadRight(decimalPos, '0');
            }

            return isNegative ? $"-{s}" : s;
        }

        /// <summary>
        /// Provides equality operator against other BigDecimal objects.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>bool</returns>
        public bool Equals(BigDecimal other)
        {
            var first = this;
            var second = other;
            first.Normalize();
            second.Normalize();
            return second.Mantissa.Equals(first.Mantissa) && second.Exponent == first.Exponent;
        }

        /// <summary>
        /// Provides a general equality operation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is BigDecimal && Equals((BigDecimal)obj);
        }

        /// <summary>
        /// Provides GetHashCode operation.
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Mantissa.GetHashCode() * 397) ^ Exponent;
            }
        }

        #region Conversions
        /// <summary>
        /// Convert int to BigDecimal
        /// </summary>
        /// <param name="value">int</param>
        public static implicit operator BigDecimal(int value)
        {
            return new BigDecimal(value, 0);
        }

        /// <summary>
        /// Convert BigInteger to BigDecimal
        /// </summary>
        /// <param name="value">BigInteger</param>
        public static implicit operator BigDecimal(BigInteger value)
        {
            return new BigDecimal(value, 0);
        }

        /// <summary>
        /// Convert double to BigDecimal
        /// </summary>
        /// <param name="value">double</param>
        public static implicit operator BigDecimal(double value)
        {
            var mantissa = (long)value;
            var exponent = 0;
            double scaleFactor = 1;
            while (Math.Abs(value * scaleFactor - (double)mantissa) > 0)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = (long)(value * scaleFactor);
            }

            return new BigDecimal(mantissa, exponent);
        }

        /// <summary>
        /// Convert decimal to BigDecimal
        /// </summary>
        /// <param name="value">decimal</param>
        public static implicit operator BigDecimal(decimal value)
        {
            var mantissa = (BigInteger)value;
            var exponent = 0;
            decimal scaleFactor = 1;
            while ((decimal)mantissa != value * scaleFactor)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = (BigInteger)(value * scaleFactor);
            }

            return new BigDecimal(mantissa, exponent);
        }

        /// <summary>
        /// Convert BigDecimal to double - possible data loss
        /// </summary>
        /// <param name="value">BigDecimal</param>
        public static explicit operator double(BigDecimal value)
        {
            return double.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Convert BigDecimal to float - possible data loss
        /// </summary>
        /// <param name="value">BigDecimal</param>
        public static explicit operator float(BigDecimal value)
        {
            return float.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Convert BigDecimal to decimal - possible data loss
        /// </summary>
        /// <param name="value">BigDecimal</param>
        public static explicit operator decimal(BigDecimal value)
        {
            return decimal.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Convert BigDecimal to int - possible data loss
        /// </summary>
        /// <param name="value">BigDecimal</param>
        public static explicit operator int(BigDecimal value)
        {
            return Convert.ToInt32((decimal)value);
        }

        /// <summary>
        /// Convert BigDecimal to uint - possible data loss
        /// </summary>
        /// <param name="value">BigDecimal</param>
        public static explicit operator uint(BigDecimal value)
        {
            return Convert.ToUInt32((decimal)value);
        }

        #endregion

        #region Operators

        /// <summary>
        /// Defines addition operation for two BigDecimal values.
        /// </summary>
        /// <param name="value">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator +(BigDecimal value)
        {
            return value;
        }

        /// <summary>
        /// Defines subtraction operation for two BigDecimal values.
        /// </summary>
        /// <param name="value">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator -(BigDecimal value)
        {
            value.Mantissa *= -1;
            return value;
        }

        /// <summary>
        /// Defines increment operation for BigDecimal value.
        /// </summary>
        /// <param name="value">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator ++(BigDecimal value)
        {
            return value + 1;
        }

        /// <summary>
        /// Defines decrement operation for BigDecimal value.
        /// </summary>
        /// <param name="value">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator --(BigDecimal value)
        {
            return value - 1;
        }

        /// <summary>
        /// Defines addtion operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Defines subtraction operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            return Add(left, -right);
        }

        private static BigDecimal Add(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? new BigDecimal(AlignExponent(left, right) + right.Mantissa, right.Exponent)
                : new BigDecimal(AlignExponent(right, left) + left.Mantissa, left.Exponent);
        }

        /// <summary>
        /// Defines multiplication operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            return new BigDecimal(left.Mantissa * right.Mantissa, left.Exponent + right.Exponent);
        }

        /// <summary>
        /// Defines division operation for two BigDecimal values.
        /// </summary>
        /// <param name="dividend">BigDecimal</param>
        /// <param name="divisor">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal operator /(BigDecimal dividend, BigDecimal divisor)
        {
            var exponentChange = Precision - (NumberOfDigits(dividend.Mantissa) - NumberOfDigits(divisor.Mantissa));
            if (exponentChange < 0)
                exponentChange = 0;
            dividend.Mantissa *= BigInteger.Pow(10, exponentChange);
            return new BigDecimal(dividend.Mantissa / divisor.Mantissa,
                dividend.Exponent - divisor.Exponent - exponentChange);
        }

        /// <summary>
        /// Defines equality operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            return left.Exponent == right.Exponent && left.Mantissa == right.Mantissa;
        }

        /// <summary>
        /// Defines not equal operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent != right.Exponent || left.Mantissa != right.Mantissa;
        }

        /// <summary>
        /// Defines less than operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right) < right.Mantissa
                : left.Mantissa < AlignExponent(right, left);
        }

        /// <summary>
        /// Defines greater than operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right) > right.Mantissa
                : left.Mantissa > AlignExponent(right, left);
        }

        /// <summary>
        /// Defines less than or equal to operation for two BigDecimal values.
        /// </summary>
        /// <param name="left">BigDecimal</param>
        /// <param name="right">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right) <= right.Mantissa
                : left.Mantissa <= AlignExponent(right, left);
        }

        /// <summary>
        /// Defines greater than or equal to operation for two BigDecimal values.
        /// </summary>
        /// <param name="value">BigDecimal</param>
        /// <returns>BigDecimal</returns>
        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right) >= right.Mantissa
                : left.Mantissa >= AlignExponent(right, left);
        }

        /// <summary>
        /// Provide a way to convert valid numeric strings to BigDecimal
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal Parse(string value)
        {
            //todo culture format
            var decimalCharacter = ".";
            var indexOfDecimal = value.IndexOf(".");
            var exponent = 0;
            if (indexOfDecimal != -1)
                exponent = (value.Length - (indexOfDecimal + 1)) * -1;
            var mantissa = BigInteger.Parse(value.Replace(decimalCharacter, ""));
            return new BigDecimal(mantissa, exponent);
        }

        /// <summary>
        ///     Returns the mantissa of value, aligned to the exponent of reference.
        ///     Assumes the exponent of value is larger than of value.
        /// </summary>
        private static BigInteger AlignExponent(BigDecimal value, BigDecimal reference)
        {
            return value.Mantissa * BigInteger.Pow(10, value.Exponent - reference.Exponent);
        }

        #endregion

        #region Additional mathematical functions

        /// <summary>
        /// Applies exponent to BigDecimal.
        /// </summary>
        /// <param name="exponent">double</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal Exp(double exponent)
        {
            var tmp = (BigDecimal)1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Exp(diff);
                exponent -= diff;
            }

            return tmp * Math.Exp(exponent);
        }

        /// <summary>
        /// Provide a Power operation
        /// </summary>
        /// <param name="basis">double</param>
        /// <param name="exponent">double</param>
        /// <returns>BigDecimal</returns>
        public static BigDecimal Pow(double basis, double exponent)
        {
            var tmp = (BigDecimal)1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Pow(basis, diff);
                exponent -= diff;
            }

            return tmp * Math.Pow(basis, exponent);
        }

        #endregion

        #region Formatting

        /// <summary>
        /// Formated string
        /// </summary>
        /// <param name="formatSpecifier">string</param>
        /// <param name="format">IFormatProvider</param>
        /// <returns>string</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ToString(string formatSpecifier, IFormatProvider format)
        {
            char fmt = NumberFormatting.ParseFormatSpecifier(formatSpecifier, out int digits);
            if (fmt != 'c' && fmt != 'C')
                throw new NotImplementedException();

            Normalize();
            if (Exponent == 0)
                return Mantissa.ToString(formatSpecifier, format);

            var numberFormatInfo = NumberFormatInfo.GetInstance(format);
            return BigDecimalFormatter.ToCurrencyString(this, digits, numberFormatInfo);
        }

        #endregion
    }
}
