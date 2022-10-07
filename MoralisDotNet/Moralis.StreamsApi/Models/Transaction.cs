using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Moralis.StreamsApi.Models
{
    public class Transaction
    {
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "streamId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        [DataMember(Name = "hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        public string Gas { get; set; }

        [DataMember(Name = "gasPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gasPrice")]
        public string GasPrice { get; set; }

        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "nonce")]
        public string Nonce { get; set; }

        [DataMember(Name = "input", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "input")]
        public string Input { get; set; }

        [DataMember(Name = "transactionIndex", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionIndex")]
        public string TransactionIndex { get; set; }

        [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fromAddress")]
        public string FromAddress { get; set; }

        [DataMember(Name = "toAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "toAddress")]
        public string ToAddress { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [DataMember(Name = "v", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "v")]
        public string v { get; set; }

        [DataMember(Name = "r", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "r")]
        public string r { get; set; }

        [DataMember(Name = "s", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "s")]
        public string s { get; set; }

        [DataMember(Name = "receiptCumulativeGasUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptCumulativeGasUsed")]
        public string ReceiptCumulativeGasUsed { get; set; }

        [DataMember(Name = "receiptGasUsed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptGasUsed")]
        public string ReceiptGasUsed { get; set; }

        [DataMember(Name = "receiptContractAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptContractAddress")]
        public string ReceiptContractAddress { get; set; }

        [DataMember(Name = "receiptRoot", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptRoot")]
        public string ReceiptRoot { get; set; }

        [DataMember(Name = "receiptStatus", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "receiptStatus")]
        public string ReceiptStatus { get; set; }
    }
}
