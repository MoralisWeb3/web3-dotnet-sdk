using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class Erc20Transfer
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

        [DataMember(Name = "from", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [DataMember(Name = "to", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [DataMember(Name = "tokenDecimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenDecimals")]
        public string TokenDecimals { get; set; }

        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenName")]
        public string TokenName { get; set; }

        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tokenSymbol")]
        public string TokenSymbol { get; set; }

        [DataMember(Name = "valueWithDecimals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "valueWithDecimals")]
        public string ValueWithDecimals { get; set; }

    }
}
