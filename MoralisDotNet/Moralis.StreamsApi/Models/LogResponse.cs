using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class LogResponse
    {
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public Log Data { get; set; }

        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cursor")]
        public string Cursor { get; set; }
    }
}
