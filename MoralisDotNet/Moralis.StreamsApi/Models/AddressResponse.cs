using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    /// <summary>
    /// Response returned when an address is added to a stream.
    /// </summary>
    public class AddressResponse
    {
        /// <summary>
        /// The id of the stream the address was added to
        /// </summary>
        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        /// <summary>
        /// The address added to the stream
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; } 
    }
}
