using System.Collections.Generic;
using Newtonsoft.Json;

namespace Moralis.Abi
{
    /// <summary>
    /// Tools used to process contract ABI
    /// </summary>
    public class AbiTools
    {
        /// <summary>
        /// Converts an ABI Json string to an ABI object.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>List of AbiItem</returns>
        public static List<AbiItem> JsonToAbiObject(string json)
        {
            List<AbiItem> abi = JsonConvert.DeserializeObject<List<AbiItem>>(json);

            return abi;
        }

        public static AbiItem FunctionAbiFromJson(string functionaName, string json)
        {
            AbiItem func = null;
            List<AbiItem> abi = JsonToAbiObject(json);

            foreach (AbiItem item in abi)
            {
                if (functionaName.ToLower().Equals(item.Name.ToLower()))
                {
                    func = item;
                    break;
                }
            }

            return func;
        }
    }
}
