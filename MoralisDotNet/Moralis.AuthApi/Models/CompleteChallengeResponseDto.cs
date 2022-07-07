using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class CompleteChallengeResponseDto
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

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

        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonce")]
        public string Nonce { get; set; }
    }
}
