using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    /// <summary>
    /// Request used to call the Challenge verify operation of the Authentication Api.
    /// </summary>
    public class CompleteChallengeRequestDto
    {
        /// <summary>
        /// Original message that was generated to be signed.
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The crypotgraphic signature of the message.
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }
    }
}
