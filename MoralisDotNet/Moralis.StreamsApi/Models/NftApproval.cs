using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.StreamsApi.Models
{
    public class NftApproval
    {
        [DataMember(Name = "ERC721", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ERC721")]
        public List<NftApprovalErc721> ERC721 { get; set; }

        [DataMember(Name = "ERC1155", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ERC1155")]
        public List<NftApprovalErc1155> ERC1155 { get; set; }
    }
}
