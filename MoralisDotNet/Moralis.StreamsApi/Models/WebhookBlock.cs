using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class WebhookBlock
    {
        [DataMember(Name = "number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; set; }
    }
}
