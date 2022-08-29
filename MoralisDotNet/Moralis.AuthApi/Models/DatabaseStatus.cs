using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Moralis.AuthApi.Models
{
    /// <summary>
    /// Helathcheck DB status
    /// </summary>
    public class DatabaseStatus
    {
        /// <summary>
        /// Redis entry response.
        /// </summary>
        [DataMember(Name = "redis", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "redis")]
        public DatabaseStatusEntry Redis { get; set; }
    }
}
