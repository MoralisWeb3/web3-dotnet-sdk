using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.Abi
{
    public class AbiParameter
    {
        /// <summary>
        /// True if the field is part of the log’s topics, false if it one of the log’s data segment.
        /// </summary>
        [DataMember(Name = "indexed", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "indexed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Indexed { get; set; }

        /// <summary>
        /// the canonical type of the parameter
        /// </summary>
        [DataMember(Name = "internalType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "internalType", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalType { get; set; }

        /// <summary>
        /// The parameter name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The canonical type of the parameter
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Used for tuple types 
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }

    }
}
