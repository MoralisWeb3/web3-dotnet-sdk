using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Moralis.Abi
{
    /// <summary>
    /// Defines a component type used for tuple types.
    /// </summary>
    public class Component
    {
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
