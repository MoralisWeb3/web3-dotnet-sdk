using Moralis.StreamsApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moralis.StreamsApi.Models
{
    /// <summary>
    /// Response returned by a streams lookup.
    /// </summary>
    public class StreamsResponse
    {
        /// <summary>
        /// The list of stream definitions 
        /// </summary>
        public List<StreamBindingDto> Result { get; set; }

        public string Cursor { get; set; }

        /// <summary>
        /// Total number of streams returned.
        /// </summary>
        public long Total { get; set; }
    }
}
