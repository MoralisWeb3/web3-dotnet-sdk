using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
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
        /// The address added to the stream
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public List<Addresses> Result { get; set; }

        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cursor")]
        public string Cursor { get; set; }

        [DataMember(Name = "total", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total")]
        public BigInteger Total { get; set; }
    }
}
