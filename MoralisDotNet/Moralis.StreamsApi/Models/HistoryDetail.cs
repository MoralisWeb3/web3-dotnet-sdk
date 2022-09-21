using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class HistoryDetail
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string HistoryId { get; set; }

        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime HistoryDate { get; set; }

        [DataMember(Name = "payload", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payload")]
        public Webhook Payload { get; set; }

        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "webhookUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "webhookUrl")]
        public string WebhookUrl { get; set; }
    }
}
