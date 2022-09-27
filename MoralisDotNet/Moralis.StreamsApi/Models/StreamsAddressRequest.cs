using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    /// <summary>
    /// Request to add address.
    /// </summary>
    public class StreamsAddressRequest
    {
        /// <summary>
        /// The address to add to the stream
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
    }
}
