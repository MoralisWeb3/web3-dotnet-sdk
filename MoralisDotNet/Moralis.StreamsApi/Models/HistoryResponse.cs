using Moralis.Unit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class HistoryResponse
    {
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "result")]
        public List<HistoryDetail> Result { get; set;}

        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cursor")]
        public string Cursor { get; set; }

        [DataMember(Name = "total", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total")]
        public BigDecimal Total { get; set; }
    }
}
