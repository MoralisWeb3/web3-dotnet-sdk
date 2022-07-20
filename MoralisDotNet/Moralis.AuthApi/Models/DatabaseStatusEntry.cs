using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class DatabaseStatusEntry
    {
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
