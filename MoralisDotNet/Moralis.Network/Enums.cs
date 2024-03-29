﻿
namespace Moralis.Network
{
    /// <summary>
    /// Indicates Main or test networks.
    /// </summary>
    public enum NetworkTypes { mainnet, testnet };

    /// <summary>
    /// REST Verbs
    /// </summary>
    public enum Method
    {
        GET = 0,
        POST = 1,
        PUT = 2,
        DELETE = 3,
        HEAD = 4,
        OPTIONS = 5,
        PATCH = 6,
        MERGE = 7,
        COPY = 8
    }

    /// <summary>
    /// Parmeters types
    /// </summary>
    public enum ParameterType
    {
        Cookie = 0,
        GetOrPost = 1,
        UrlSegment = 2,
        HttpHeader = 3,
        RequestBody = 4,
        QueryString = 5,
        QueryStringWithoutEncode = 6
    }

    /// <summary>
    /// Expected / supported format
    /// </summary>
    public enum DataFormat
    {
        Json = 0,
        Xml = 1,
        None = 2
    }
}
