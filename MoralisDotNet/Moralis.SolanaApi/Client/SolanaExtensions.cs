using System.IO;

namespace Moralis.SolanaApi.Client
{
    public static class SolanaExtension
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
