using System;
using Moralis.Unit;

namespace Moralis.Web3Api.Models
{
    /// <summary>
    /// Abstract class used to provide basic value utilities.
    /// </summary>
    public abstract class NativeTokenBalanceBase
    {
        private int _decimals = -18;

        /// <summary>
        /// The number of decimals to express WEI as Native Token.
        /// </summary>
        public virtual int Decimals
        {
            get
            {
                return _decimals;
            }
            set
            {
                _decimals = value;

                if (_decimals > 0)
                {
                    _decimals = _decimals * -1;
                }
            }
        }

        /// <summary>
        /// Returns the Native Token balance as derived from WEI value and Decinmals.
        /// </summary>
        public BigDecimal NativeTokenBalance
        {
            get
            {
                BigDecimal balance = 0;

                try
                {
                    string rawBalance = this.RawBalance();

                    // Convert Balance to BigDecimal value.
                    balance = new BigDecimal(rawBalance.ToBigNumber(), _decimals);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Token balance must be numeric.");
                }

                return balance;
            }
        }

        /// <summary>
        /// Chain Associated with this object.
        /// </summary>
        public virtual ChainList ChainId { get; set; }

        /// <summary>
        /// Derived class should override and return target value amount.
        /// </summary>
        /// <returns></returns>
        protected virtual string RawBalance()
        {
            return "0";
        }
    }
}
