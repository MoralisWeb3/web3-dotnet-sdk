using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    /// <summary>
    /// Authentication Api Server Healthcheck response.
    /// </summary>
    public class HealthCheckResponse
    {
        /// <summary>
        /// Overall status of the endpoint.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Server information if successfull
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "info")]
        public DatabaseStatus Info { get; set; }

        /// <summary>
        /// Error detail if healthcheck fails.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public DatabaseStatus Error { get; set; }

        /// <summary>
        /// Database status details.
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "details")]
        public DatabaseStatus Details { get; set; }
    }
}
