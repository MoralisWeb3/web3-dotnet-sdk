using System.IO;

namespace Moralis.Network
{
    /// <summary>
    /// Extension utility methods for network objects.
    /// </summary>
    public static class NetworkExtensions
    {
        /// <summary>
        /// Adds a ReadAsBytes function to a standard stream object.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>byte[]</returns>
        public static byte[] ReadAsBytes(this Stream s)
        {
            byte[] buffer = new byte[s.Length];
            s.Read(buffer, 0, buffer.Length);
            s.Position = 0;

            return buffer;
        }
    }
}
