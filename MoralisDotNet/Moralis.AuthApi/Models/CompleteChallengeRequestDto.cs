using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class CompleteChallengeRequestDto
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [DataMember(Name = "signature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }
    }
}
