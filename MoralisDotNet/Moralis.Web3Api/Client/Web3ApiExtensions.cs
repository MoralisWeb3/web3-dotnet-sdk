using System.IO;

namespace Moralis.Web3Api.Client
{
    public static class Web3ApiExtension
    {
        public static byte[] ReadAsBytes(this Stream s)
        {
            byte[] buffer = new byte[s.Length];
            s.Read(buffer, 0, buffer.Length);
            s.Position = 0;

            return buffer;
        }
    }
}
