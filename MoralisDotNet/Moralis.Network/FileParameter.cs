using System;
using System.IO;

namespace Moralis.Network
{
    /// <summary>
    /// Defines a parameter representing a file stream for nwetwork transfer.
    /// </summary>
    public class FileParameter
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileParameter() { }

        /// <summary>
        /// Length of the data stream.
        /// </summary>
        public long ContentLength { get; set; }

        /// <summary>
        /// Stream Writer object.
        /// </summary>
        public Action<Stream> Writer { get; set; }

        /// <summary>
        /// Name of the file being transfered.
        /// </summary>
        public string FileName { get; set; }
#nullable enable
        /// <summary>
        /// Data ContentType
        /// </summary>
        public string? ContentType { get; set; }
#nullable disable
        /// <summary>
        /// Parameter name
        /// </summary>
        public string Name { get; set; }

#nullable enable
        /// <summary>
        /// Creates a FileParameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <returns>FileParameter</returns>
        public static FileParameter Create(string name, byte[] data, string filename, string? contentType)
#nullable disable
        {
            FileParameter fileParameter = new FileParameter()
            {
                ContentLength = data.Length,
                ContentType = contentType != null ? contentType : "application/json",
                FileName = filename,
                Name = name,
                Writer = s =>
                {
                    using (var file = new StreamReader(new MemoryStream(data)))
                    {
                        file.BaseStream.CopyTo(s);
                    }
                }
            };

            return fileParameter;
        }

        /// <summary>
        /// Creates a FileParameter.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <returns>FileParameter</returns>
        public static FileParameter Create(string name, byte[] data, string filename)
        {
            FileParameter fileParameter = new FileParameter()
            {
                ContentLength = data.Length,
                ContentType = "application/octet-stream",
                FileName = filename,
                Name = name,
                Writer = s =>
                {
                    using (var file = new StreamReader(new MemoryStream(data)))
                    {
                        file.BaseStream.CopyTo(s);
                    }
                }
            };

            return fileParameter;
        }
#nullable enable
        /// <summary>
        /// Creates a FileParameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="writer"></param>
        /// <param name="contentLength"></param>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <returns>FileParameter</returns>
        public static FileParameter Create(string name, Action<Stream> writer, long contentLength, string fileName, string? contentType = null)
#nullable disable
        {
            FileParameter fileParameter = new FileParameter()
            {
                ContentType = contentType != null ? contentType : "application/octet-stream",
                Name = name,
                Writer = writer
            };

            return fileParameter;
        }
    }

}
