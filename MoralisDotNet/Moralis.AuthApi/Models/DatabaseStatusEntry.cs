using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    /// <summary>
    /// Healthcheck DB status for specific instance.
    /// </summary>
    public class DatabaseStatusEntry
    {
        /// <summary>
        /// Status of the server.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
