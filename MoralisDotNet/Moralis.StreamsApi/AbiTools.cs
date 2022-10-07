using Moralis.StreamsApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.StreamsApi
{
    public class AbiTools
    {
        public static List<AbiItem> JsonToStreamsAbi(string json)
        {
            List<AbiItem> abi = JsonConvert.DeserializeObject<List<AbiItem>>(json);

            return abi;
        }

        public static AbiItem FunctionAbiFromJson(string functionaName, string json)
        {
            AbiItem func = null;
            List<AbiItem> abi = JsonToStreamsAbi(json);

            foreach (AbiItem item in abi)
            {
                if (!String.IsNullOrEmpty(item.Name) && functionaName.ToLower().Equals(item.Name.ToLower()))
                {
                    func = item;
                    break;
                }
            }

            return func;
        }
    }
}
