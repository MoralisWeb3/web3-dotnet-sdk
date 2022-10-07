using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class NftApprovalErc1155
    {
        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "contract", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contract")]
        public string Contract { get; set; }

        [DataMember(Name = "logIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logIndex")]
        public string LogIndex { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "account", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        [DataMember(Name = "operator", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "approved", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "approved")]
        public string Approved { get; set; }

        [DataMember(Name = "tokenContractType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenContractType")]
        public string TokenContractType { get; set; }

        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenName")]
        public string TokenName { get; set; }

        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenSymbol")]
        public string TokenSymbol { get; set; }
    }
}
