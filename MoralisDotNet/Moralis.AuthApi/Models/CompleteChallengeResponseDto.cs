using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    /// <summary>
    /// The response returned by the Challenge Verify when the a signature/message is verified successfully.
    /// </summary>
    public class CompleteChallengeResponseDto
    {
        /// <summary>
        /// Internal Identifier
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The RFC 3986 authority that is requesting the signing
        /// </summary>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The EIP-155 Chain ID to which the session is bound, and the network where Contract Accounts MUST be resolved.
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chainId")]
        public long ChainId { get; set; }

        /// <summary>
        /// The Ethereum address performing the signing conformant to capitalization encoded checksum specified in EIP-55 where applicable.
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// A human-readable ASCII assertion that the user will sign, and it must not contain '\n' (the byte 0x0a).
        /// </summary>
        [DataMember(Name = "statement", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "statement")]
        public string Statement { get; set; }

        /// <summary>
        /// An RFC 3986 URI referring to the resource that is the subject of the signing (as in the subject of a claim).
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The ISO 8601 datetime string that, if present, indicates when the signed authentication message is no longer valid.
        /// </summary>
        [DataMember(Name = "expirationTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// The ISO 8601 datetime string that, if present, indicates when the signed authentication message will become valid.
        /// </summary>
        [DataMember(Name = "notBefore", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notBefore")]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// A list of information or references to information the user wishes to have resolved as part of authentication by the relying party. They are expressed as RFC 3986 URIs separated by "\n- " where \n is the byte 0x0a.
        /// </summary>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resources")]
        public string[] Resources { get; set; }

        /// <summary>
        /// Api version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Nonce used to make message unique
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// Moralis Profile Id
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }
    }
}
