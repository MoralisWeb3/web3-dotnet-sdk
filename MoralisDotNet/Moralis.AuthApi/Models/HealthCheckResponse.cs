using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    public class HealthCheckResponse
    {
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [DataMember(Name = "info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "info")]
        public DatabaseStatus Info { get; set; }

        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public DatabaseStatus Error { get; set; }

        [DataMember(Name = "details", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "details")]
        public DatabaseStatus Details { get; set; }
    }
}
