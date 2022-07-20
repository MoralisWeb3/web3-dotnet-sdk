using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class DatabaseStatus
    {
        [DataMember(Name = "redis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redis")]
        public DatabaseStatusEntry Redis { get; set; }
    }
}
