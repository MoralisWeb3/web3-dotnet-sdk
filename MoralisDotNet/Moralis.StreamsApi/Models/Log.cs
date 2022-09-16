//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Runtime.Serialization;
//using System.Text;

//namespace Moralis.StreamsApi.Models
//{
//    public class Log
//    {
//        private static List<string> logTypes = new List<string>(new string[] { "debug", "info", "warn", "error" });
//        private string logType = logTypes[0];

//        [DataMember(Name = "date", EmitDefaultValue = false)]
//        [JsonProperty(PropertyName = "date")]
//        public string Date { get; set; }

//        [DataMember(Name = "block", EmitDefaultValue = false)]
//        [JsonProperty(PropertyName = "block")]
//        public string Block { get; set; }

//        [DataMember(Name = "message", EmitDefaultValue = false)]
//        [JsonProperty(PropertyName = "message")]
//        public string Message { get; set; }

//        [DataMember(Name = "type", EmitDefaultValue = false)]
//        [JsonProperty(PropertyName = "type")]
//        public string LogType
//        {
//            get { return logType; }
//            set
//            {
//                if (!string.IsNullOrEmpty(value) && logTypes.Contains(value))
//                {
//                    logType = value;
//                }
//                else
//                {
//                    throw new ArgumentException($"Valid values for Log Type are: [{string.Join(',', logTypes)}]");
//                }
//            }
//        }
//    }
//}
