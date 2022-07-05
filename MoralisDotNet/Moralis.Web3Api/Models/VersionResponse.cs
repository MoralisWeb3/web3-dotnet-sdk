using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Moralis.Web3Api.Models
{
    public class VersionResponse
    {
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
