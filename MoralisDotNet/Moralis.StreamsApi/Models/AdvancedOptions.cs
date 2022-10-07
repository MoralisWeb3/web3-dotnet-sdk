using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.StreamsApi.Models
{
    public class AdvancedOptions
    {
        [DataMember(Name = "topic0", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "topic0")]
        public string Topic0 { get; set; }

        [DataMember(Name = "filter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filter")]
        public Dictionary<string, object> Filter { get; set; }

        [DataMember(Name = "includeNativeTxs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "includeNativeTxs")]
        public bool IncludeNativeTxs { get; set; }
    }
}
