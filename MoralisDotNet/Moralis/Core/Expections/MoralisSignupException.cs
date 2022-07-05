using System;

namespace Moralis.Core.Exceptions
{
    public class MoralisSignupException : Exception
    {
        public MoralisSignupException() { }

        public MoralisSignupException(string message) : base(message) { }
    }
}