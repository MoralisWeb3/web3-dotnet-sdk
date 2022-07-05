using System;

namespace Moralis.Core.Exceptions
{
    public class MoralisSaveException : Exception
    {
        public MoralisSaveException() { }

        public MoralisSaveException(string message) : base(message) { }
    }
}