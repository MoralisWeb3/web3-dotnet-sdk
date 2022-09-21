using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Moralis.Network
{
    public static class Extensions
    {
        public async static Task<string> ExtractContentAsString(this HttpResponseMessage response)
        {
            string content = String.Empty;

            if (response.Content != null)
            { 
                content = await response.Content.ReadAsStringAsync();    
            }

            return content;
        }
    }
}
