using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.Moralis.StreamsApi.Models
{
    public enum StateMutabilityTypes
    {
        Pure, 
        View, 
        Nonpayable, 
        Payable
    }

    public enum AbiItemTypes
    {
        Function, 
        Constructor, 
        Event, 
        Fallback
    }

}
