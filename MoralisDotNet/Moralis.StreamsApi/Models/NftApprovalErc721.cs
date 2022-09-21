﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class NftApprovalErc721
    {
        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; set; }

        [DataMember(Name = "tokenAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenAddress")]
        public string TokenAddress { get; set; }

        [DataMember(Name = "logIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "logIndex")]
        public string LogIndex { get; set; }

        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "owner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "spender", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "spender")]
        public string Spender { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
