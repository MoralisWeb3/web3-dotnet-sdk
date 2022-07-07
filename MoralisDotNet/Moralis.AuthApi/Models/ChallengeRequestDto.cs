using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class ChallengeRequestDto
    {
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainId")]
        public long ChainId { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [DataMember(Name = "statement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statement")]
        public string Statement { get; set; }

        [DataMember(Name = "uri", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "expirationTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        [DataMember(Name = "notBefore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notBefore")]
        public DateTime? NotBefore { get; set; }

        [DataMember(Name = "resources", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resources")]
        public string[] Resources { get; set; }

        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeout")]
        public long Timeout { get; set; }
    }
}
