using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class StreamsStatusUpdate
    {
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)]

        private string _streamStatus = null;

        [JsonIgnore]
        public StreamStatusTypes Status
        {
            get
            {
                if (_streamStatus == null)
                {
                    return StreamStatusTypes.Error;
                }
                else
                {
                    return _streamStatus.ToStreamStatusTypes();
                }
            }
            set { _streamStatus = value.ToString(); }
        }
    }
}
