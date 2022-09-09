using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class StreamBindingDto
    {
        [DataMember(Name = "webhookUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "webhookUrl")]
        public string WebHookUrl { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "tokenAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenAddress { get; set; }

        [DataMember(Name = "topic0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic0", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [DataMember(Name = "includeNativeTxs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeNativeTxs")]
        public bool IncludeNativeTxs { get; set; }

        [DataMember(Name = "abi", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abi", NullValueHandling = NullValueHandling.Ignore)]
        public object Abi { get; set; }

        [DataMember(Name = "filter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filter", NullValueHandling = NullValueHandling.Ignore)]
        public object Filter { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [DataMember(Name = "chainIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainIds")]
        public List<string> ChainIds { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }
    }
}
