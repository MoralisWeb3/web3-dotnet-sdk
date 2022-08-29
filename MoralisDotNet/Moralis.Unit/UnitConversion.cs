using System;
using System.Numerics;

namespace Moralis.Unit
{
    /// <summary>
    /// <see cref="Nethereum.Util.UnitConversion">https://github.com/Nethereum</see>
    /// </summary>
    internal class UnitConversion
    {
        /// <summary>
        /// Define Ethereum divisional units.
        /// </summary>
        public enum EthUnit
        {
            Wei,
            Kwei,
            Ada,
            Femtoether,
            Mwei,
            Babbage,
            Picoether,
            Gwei,
            Shannon,
            Nanoether,
            Nano,
            Szabo,
            Microether,
            Micro,
            Finney,
            Milliether,
            Milli,
            Ether,
            Kether,
            Grand,
            Einstein,
            Mether,
            Gether,
            Tether
        }

        private static UnitConversion _convert;

        /// <summary>
        /// Current unit of conversion
        /// </summary>
        public static UnitConversion Convert
        {
            get
            {
                if (_convert == null) _convert = new UnitConversion();
                return _convert;
            }
        }

        /// <summary>
        ///     Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
        ///     significant digits
        /// </summary>
        public decimal FromWei(BigInteger value, BigInteger toUnit)
        {
            return FromWei(value, GetEthUnitValueLength(toUnit));
        }

        /// <summary>
        ///     Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
        ///     significant digits
        /// </summary>
        public decimal FromWei(BigInteger value, EthUnit toUnit = EthUnit.Ether)
        {
            return FromWei(value, GetEthUnitValue(toUnit));
        }

        /// <summary>
        ///     Converts from wei to a unit, NOTE: When the total number of digits is bigger than 29 they will be rounded the less
        ///     significant digits
        /// </summary>
        public decimal FromWei(BigInteger value, int decimalPlacesToUnit)
        {
            return (decimal)new BigDecimal(value, decimalPlacesToUnit * -1);
        }

        /// <summary>
        /// Convert WEI value to BigDecimal.
        /// </summary>
        /// <param name="value">BigInteger</param>
        /// <param name="decimalPlacesToUnit">int</param>
        /// <returns>BigDecimal</returns>
        public BigDecimal FromWeiToBigDecimal(BigInteger value, int decimalPlacesToUnit)
        {
            return new BigDecimal(value, decimalPlacesToUnit * -1);
        }

        /// <summary>
        /// Convert WEI value to BigDecimal.
        /// </summary>
        /// <param name="value">BigInteger</param>
        /// <param name="toUnit">EthUnit</param>
        /// <returns>BigDecimal</returns>
        public BigDecimal FromWeiToBigDecimal(BigInteger value, EthUnit toUnit = EthUnit.Ether)
        {
            return FromWeiToBigDecimal(value, GetEthUnitValue(toUnit));
        }

        /// <summary>
        /// Convert WEI value to BigDecimal.
        /// </summary>
        /// <param name="value">BigInteger</param>
        /// <param name="toUnit">BigInteger</param>
        /// <returns>BigDecimal</returns>
        public BigDecimal FromWeiToBigDecimal(BigInteger value, BigInteger toUnit)
        {
            return FromWeiToBigDecimal(value, GetEthUnitValueLength(toUnit));
        }

        /// <summary>
        /// returns length of value.
        /// </summary>
        /// <param name="unitValue">BigInteger</param>
        /// <returns>int</returns>
        private int GetEthUnitValueLength(BigInteger unitValue)
        {
            return unitValue.ToStringInvariant().Length - 1;
        }

        /// <summary>
        /// Numeric value of EthUnit
        /// </summary>
        /// <param name="ethUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        /// <exception cref="NotImplementedException"></exception>
        public BigInteger GetEthUnitValue(EthUnit ethUnit)
        {
            switch (ethUnit)
            {
                case EthUnit.Wei:
                    return BigIntegerExtensions.ParseInvariant("1");
                case EthUnit.Kwei:
                    return BigIntegerExtensions.ParseInvariant("1000");
                case EthUnit.Babbage:
                    return BigIntegerExtensions.ParseInvariant("1000");
                case EthUnit.Femtoether:
                    return BigIntegerExtensions.ParseInvariant("1000");
                case EthUnit.Mwei:
                    return BigIntegerExtensions.ParseInvariant("1000000");
                case EthUnit.Picoether:
                    return BigIntegerExtensions.ParseInvariant("1000000");
                case EthUnit.Gwei:
                    return BigIntegerExtensions.ParseInvariant("1000000000");
                case EthUnit.Shannon:
                    return BigIntegerExtensions.ParseInvariant("1000000000");
                case EthUnit.Nanoether:
                    return BigIntegerExtensions.ParseInvariant("1000000000");
                case EthUnit.Nano:
                    return BigIntegerExtensions.ParseInvariant("1000000000");
                case EthUnit.Szabo:
                    return BigIntegerExtensions.ParseInvariant("1000000000000");
                case EthUnit.Microether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000");
                case EthUnit.Micro:
                    return BigIntegerExtensions.ParseInvariant("1000000000000");
                case EthUnit.Finney:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000");
                case EthUnit.Milliether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000");
                case EthUnit.Milli:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000");
                case EthUnit.Ether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000");
                case EthUnit.Kether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000");
                case EthUnit.Grand:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000");
                case EthUnit.Einstein:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000");
                case EthUnit.Mether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000000");
                case EthUnit.Gether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000000000");
                case EthUnit.Tether:
                    return BigIntegerExtensions.ParseInvariant("1000000000000000000000000000000");
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Valdiate that value in paower of 10
        /// </summary>
        /// <param name="ethUnit">BigInteger</param>
        /// <returns>bool</returns>
        /// <exception cref="Exception"></exception>
        public bool TryValidateUnitValue(BigInteger ethUnit)
        {
            if (ethUnit.ToStringInvariant().Trim('0') == "1") return true;
            throw new Exception("Invalid unit value, it should be a power of 10 ");
        }

        /// <summary>
        /// Convert decimal from unit
        /// </summary>
        /// <param name="amount">decimal</param>
        /// <param name="fromUnit">BigInteger</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWeiFromUnit(decimal amount, BigInteger fromUnit)
        {
            return ToWeiFromUnit((BigDecimal)amount, fromUnit);
        }

        /// <summary>
        /// Convert BigDecimal from unit
        /// </summary>
        /// <param name="amount">BigDecimal</param>
        /// <param name="fromUnit">BigInteger</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWeiFromUnit(BigDecimal amount, BigInteger fromUnit)
        {
            TryValidateUnitValue(fromUnit);
            var bigDecimalFromUnit = new BigDecimal(fromUnit, 0);
            var conversion = amount * bigDecimalFromUnit;
            return conversion.Floor().Mantissa;
        }

        /// <summary>
        /// Convert BigDecimal value to WEI
        /// </summary>
        /// <param name="amount">BigDecimal</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(BigDecimal amount, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWeiFromUnit(amount, GetEthUnitValue(fromUnit));
        }

        /// <summary>
        /// Convert BigDecimal value to WEI
        /// </summary>
        /// <param name="amount">BigDecimal</param>
        /// <param name="decimalPlacesFromUnit">int</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(BigDecimal amount, int decimalPlacesFromUnit)
        {
            if (decimalPlacesFromUnit == 0) ToWei(amount, 1);
            return ToWeiFromUnit(amount, BigInteger.Pow(10, decimalPlacesFromUnit));
        }

        /// <summary>
        /// Convert decimal value to WEI
        /// </summary>
        /// <param name="amount">decimal</param>
        /// <param name="decimalPlacesFromUnit">int</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(decimal amount, int decimalPlacesFromUnit)
        {
            if (decimalPlacesFromUnit == 0) ToWei(amount, 1);
            return ToWeiFromUnit(amount, BigInteger.Pow(10, decimalPlacesFromUnit));
        }


        /// <summary>
        /// Convert decimal value to WEI
        /// </summary>
        /// <param name="amount">decinmal</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(decimal amount, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWeiFromUnit(amount, GetEthUnitValue(fromUnit));
        }


        /// <summary>
        /// Convert BigInteger value to WEI
        /// </summary>
        /// <param name="value">BigInteger</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(BigInteger value, EthUnit fromUnit = EthUnit.Ether)
        {
            return value * GetEthUnitValue(fromUnit);
        }

        /// <summary>
        /// Convert int value to WEI
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(int value, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWei(new BigInteger(value), fromUnit);
        }

        /// <summary>
        /// Convert double value to WEI
        /// </summary>
        /// <param name="value">double</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(double value, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWei(System.Convert.ToDecimal(value), fromUnit);
        }

        /// <summary>
        /// Convert float value to WEI
        /// </summary>
        /// <param name="value">float</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(float value, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWei(System.Convert.ToDecimal(value), fromUnit);
        }

        /// <summary>
        /// Convert long value to WEI
        /// </summary>
        /// <param name="value">long</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(long value, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWei(new BigInteger(value), fromUnit);
        }

        /// <summary>
        /// Convert string value to WEI
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="fromUnit">EthUnit</param>
        /// <returns>BigInteger</returns>
        public BigInteger ToWei(string value, EthUnit fromUnit = EthUnit.Ether)
        {
            return ToWei(decimal.Parse(value), fromUnit);
        }

        private BigInteger CalculateNumberOfDecimalPlaces(double value, int maxNumberOfDecimals,
            int currentNumberOfDecimals = 0)
        {
            return CalculateNumberOfDecimalPlaces(System.Convert.ToDecimal(value), maxNumberOfDecimals,
                currentNumberOfDecimals);
        }

        private BigInteger CalculateNumberOfDecimalPlaces(float value, int maxNumberOfDecimals,
            int currentNumberOfDecimals = 0)
        {
            return CalculateNumberOfDecimalPlaces(System.Convert.ToDecimal(value), maxNumberOfDecimals,
                currentNumberOfDecimals);
        }

        private int CalculateNumberOfDecimalPlaces(decimal value, int maxNumberOfDecimals,
            int currentNumberOfDecimals = 0)
        {
            if (currentNumberOfDecimals == 0)
            {
                if (value.ToStringInvariant() == Math.Round(value).ToStringInvariant()) return 0;
                currentNumberOfDecimals = 1;
            }

            if (currentNumberOfDecimals == maxNumberOfDecimals) return maxNumberOfDecimals;
            var multiplied = value * (decimal)BigInteger.Pow(10, currentNumberOfDecimals);
            if (Math.Round(multiplied) == multiplied)
                return currentNumberOfDecimals;
            return CalculateNumberOfDecimalPlaces(value, maxNumberOfDecimals, currentNumberOfDecimals + 1);
        }
    }
}
