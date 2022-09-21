using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class InternalTransaction
    {
        [DataMember(Name = "from", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Gas { get; set; }
    }
}
