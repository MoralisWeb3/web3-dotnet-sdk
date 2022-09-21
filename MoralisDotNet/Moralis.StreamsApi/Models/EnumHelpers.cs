using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public static class EnumHelpers
    {
        private static List<string> stateMultabilityValues = new List<string>(new string[] { "pure", "view", "nonpayable", "payable" });
        private static List<string> abiTypeValues = new List<string>(new string[] { "function", "constructor", "event", "fallback" });
        private static List<string> statusTypeValues = new List<string>(new string[] { "active", "paused", "error" });

        public static string ToString(this StateMutabilityTypes n)
        {
            string result = stateMultabilityValues[(int)n];

            return result;
        }

        public static string ToString(this AbiItemTypes n)
        {
            string result = abiTypeValues[(int)n];

            return result;
        }

        public static string ToString(this StreamStatusTypes n)
        {
            string result = statusTypeValues[(int)n];

            return result;
        }

        public static StateMutabilityTypes ToStateMutabilityTypes (this string s)
        { 
            int n = stateMultabilityValues.IndexOf(s);

            if (n == -1)
            {
                throw new ArgumentException($"{s} is not a recognized StateMutabilityType");
            }

            return (StateMutabilityTypes)n;
        }

        public static AbiItemTypes ToAbiItemTypes(this string s)
        {
            int n = abiTypeValues.IndexOf(s);

            if (n == -1)
            {
                throw new ArgumentException($"{s} is not a recognized AbiItemType");
            }

            return (AbiItemTypes)n;
        }

        public static StreamStatusTypes ToStreamStatusTypes(this string s)
        {
            int n = statusTypeValues.IndexOf(s);

            if (n == -1)
            {
                throw new ArgumentException($"{s} is not a recognized StreamStatusType");
            }

            return (StreamStatusTypes)n;
        }
    }
}
