using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
    public class EndpointWeights
    {
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [DataMember(Name = "rateLimitWeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rateLimitWeight")]
        public string RateLimitWeight { get; set; }

        [DataMember(Name = "price", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }
    }
}
