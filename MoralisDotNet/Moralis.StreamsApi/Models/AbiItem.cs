using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.Moralis.StreamsApi.Models
{
    public class AbiItem
    {
        [DataMember(Name = "stateMutability", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stateMutability")]
        private string _stateMutability = StateMutabilityTypes.Pure.ToString();

        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        private string _abiType = AbiItemTypes.Event.ToString();

        [DataMember(Name = "anonymous", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "anonymous")]
        public bool Anonymous { get; set; }

        [DataMember(Name = "constant", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "constant")]
        public bool Constant { get; set; }

        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inputs")]
        public List<AbiInput> Inputs { get; set; }

        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outputs")]
        public List<AbiOutput> Outputs { get; set; }

        [DataMember(Name = "payable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payable")]
        public bool Payable { get; set; }

        [JsonIgnore]
        public StateMutabilityTypes StateMutability
        {
            get { return _stateMutability.ToStateMutabilityTypes(); }
            set { _stateMutability = value.ToString(); }
        }

        [JsonIgnore]
        public AbiItemTypes Type
        {
            get { return _abiType.ToAbiItemTypes(); }
            set { _abiType = value.ToString(); }
        }

        [DataMember(Name = "gas", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gas")]
        public BigInteger Gas { get; set; }
    }
}
