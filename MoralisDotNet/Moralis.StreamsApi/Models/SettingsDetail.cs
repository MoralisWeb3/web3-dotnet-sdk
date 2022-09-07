using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    public class SettingsDetail
    {
        private static List<string> clusters = new List<string>(new string[] { "us-east-1", "us-west-2", "eu-central-1", "ap-southeast-1" });
        private string cluster = clusters[0];

        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }

        [DataMember(Name = "cluster", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cluster")]
        //public ClusterType Cluster { get; set; }
        public string Cluster
        {
            get { return cluster; }
            set
            {
                if (!string.IsNullOrEmpty(value) && clusters.Contains(value))
                {
                    cluster = value;
                }
                else
                {
                    throw new ArgumentException($"Valid values for Cluster are: [{string.Join(',', clusters)}]");
                }
            }
        }
    }
}
