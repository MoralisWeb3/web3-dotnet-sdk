using System.IO;

namespace Moralis.Network
{
    public static class NetworkExtensions
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
