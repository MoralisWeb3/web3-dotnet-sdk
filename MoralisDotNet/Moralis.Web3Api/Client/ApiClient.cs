//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Text.RegularExpressions;
//using System.IO;
//using System.Web;
//using System.Linq;
//using System.Net;
//using System.Text;
//using Newtonsoft.Json;
////using RestSharp;
////using RestSharp.Extensions;
//using Moralis.Web3Api.Models;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Moralis.Web3Api.Core;
//using System.Net.Http.Headers;

//namespace Moralis.Web3Api.Client
//{
//    /// <summary>
//    /// API client is mainly responible for making the HTTP call to the API backend.
//    /// </summary>
//    public class ApiClient
//    {
//        private readonly Dictionary<String, String> _defaultHeaderMap = new Dictionary<String, String>();
  
//        /// <summary>
//        /// Initializes a new instance of the <see cref="ApiClient" /> class.
//        /// </summary>
//        /// <param name="basePath">The base path.</param>
//        public ApiClient(String basePath="http://localhost:3063/api/v2")
//        {
//            BasePath = basePath;
//            //HttpClient = new HttpClient()
//        }
    
//        /// <summary>
//        /// Gets or sets the base path.
//        /// </summary>
//        /// <value>The base path</value>
//        public string BasePath { get; set; }
    
//        /// <summary>
//        /// Gets or sets the RestClient.
//        /// </summary>
//        /// <value>An instance of the RestClient</value>
//        //public HttpClient RestClient { get; set; }
    
//        /// <summary>
//        /// Gets the default header.
//        /// </summary>
//        public Dictionary<String, String> DefaultHeader
//        {
//            get { return _defaultHeaderMap; }
//        }
    
//        /// <summary>
//        /// Makes the HTTP request (Sync).
//        /// </summary>
//        /// <param name="path">URL path.</param>
//        /// <param name="method">HTTP method.</param>
//        /// <param name="queryParams">Query parameters.</param>
//        /// <param name="postBody">HTTP body (POST request).</param>
//        /// <param name="headerParams">Header parameters.</param>
//        /// <param name="formParams">Form parameters.</param>
//        /// <param name="fileParams">File parameters.</param>
//        /// <param name="authSettings">Authentication settings.</param>
//        /// <returns>Object</returns>
//        public async Task<HttpResponseMessage> CallApi(String path, HttpMethod method, Dictionary<String, String> queryParams, String postBody,
//            Dictionary<String, String> headerParams, Dictionary<String, String> formParams, 
//            Dictionary<String, Models.FileParameter> fileParams, String[] authSettings)
//        {
//            HttpResponseMessage response = null;
//            string url = path;
//            bool firstParam = true;

//            UpdateParamsForAuth(queryParams, headerParams, authSettings);

//            if (queryParams != null && queryParams.Keys.Count > 0)
//            {
//                foreach (string k in queryParams.Keys)
//                {
//                    if (firstParam)
//                    {
//                        url = $"{url}?";
//                        firstParam = false;
//                    }
//                    else
//                    {
//                        url = $"{url}&";
//                    }

//                    url = $"{url}{k}={queryParams[k]}";
//                }
//            }

//            if (formParams != null && formParams.Keys.Count > 0)
//            {
//                foreach (string k in formParams.Keys)
//                {
//                    if (firstParam)
//                    {
//                        url = $"{url}?";
//                        firstParam = false;
//                    }
//                    else
//                    {
//                        url = $"{url}&";
//                    }

//                    url = $"{url}{k}={formParams[k]}";
//                }
//            }

//            HttpClient client = new HttpClient();
//            client.BaseAddress = new Uri(BasePath);

//            if (DefaultHeader != null)
//            {
//                foreach (string k in DefaultHeader.Keys)
//                {
//                    client.DefaultRequestHeaders.Add(k, DefaultHeader[k]);
//                }
//            }

//            if (headerParams != null)
//            {
//                foreach (string k in headerParams.Keys)
//                { 
//                    client.DefaultRequestHeaders.Add(k, headerParams[k]);
//                }
//            }

//            // The HttpClient strips out the Local path from domain. 
//            // Re-add this to the url so it is included properly.
//            if (!client.BaseAddress.LocalPath.Equals("/"))
//            {
//                url = $"{client.BaseAddress.LocalPath}{url}";
//            }

//            if (HttpMethod.Get.Equals(method))
//            {
//                response = await client.GetAsync(url);
//            }
//            else if (HttpMethod.Post.Equals(method))
//            {
//                var data = new StringContent(postBody, Encoding.UTF8, "application/json");
//                response = await client.PostAsync(url, data);
//            }
//            else if (HttpMethod.Delete.Equals(method))
//            {
//                response = await client.DeleteAsync(url);
//            }
//            else if (HttpMethod.Put.Equals(method))
//            {
//                var data = new StringContent(postBody, Encoding.UTF8, "application/json");
//                response = await client.PutAsync(url, data);
//            }
//            else if (HttpMethod.Patch.Equals(method))
//            {
//                var data = new StringContent(postBody, Encoding.UTF8, "application/json");
//                response = await client.PatchAsync(url, data);
//            }

//            return response;
//        }
    
//        /// <summary>
//        /// Add default header.
//        /// </summary>
//        /// <param name="key">Header field name.</param>
//        /// <param name="value">Header field value.</param>
//        /// <returns></returns>
//        public void AddDefaultHeader(string key, string value)
//        {
//            _defaultHeaderMap.Add(key, value);
//        }
    
//        /// <summary>
//        /// Escape string (url-encoded).
//        /// </summary>
//        /// <param name="str">String to be escaped.</param>
//        /// <returns>Escaped string.</returns>
//        public string EscapeString(string str)
//        {
//            return HttpUtility.UrlEncode(str); 
//            //return RestSharp.Contrib.HttpUtility.UrlEncode(str);
//        }
    
//        /// <summary>
//        /// Create FileParameter based on Stream.
//        /// </summary>
//        /// <param name="name">Parameter name.</param>
//        /// <param name="stream">Input stream.</param>
//        /// <returns>FileParameter.</returns>
//        public Models.FileParameter ParameterToFile(string name, Stream stream)
//        {
//            if (stream is FileStream)
//                return Models.FileParameter.Create(name, stream.ReadAsBytes(), Path.GetFileName(((FileStream)stream).Name));
//            else
//                return Models.FileParameter.Create(name, stream.ReadAsBytes(), "no_file_name_provided");
//        }
    
//        /// <summary>
//        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
//        /// If parameter is a list of string, join the list with ",".
//        /// Otherwise just return the string.
//        /// </summary>
//        /// <param name="obj">The parameter (header, path, query, form).</param>
//        /// <returns>Formatted string.</returns>
//        public string ParameterToString(object obj)
//        {
//            if (obj is DateTime)
//                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
//                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
//                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
//                // For example: 2009-06-15T13:45:30.0000000
//                return ((DateTime)obj).ToString(Configuration.DateTimeFormat);
//            else if (obj is List<string>)
//                return String.Join(",", (obj as List<string>).ToArray());
//            else if (obj is string || obj is int || obj is long || obj is decimal || obj is bool || obj is float || obj is double || obj is byte || obj is char)
//            {
//                return obj.ToString();
//            }
//            else
//                return JsonConvert.SerializeObject(obj);
//        }
    
//        /// <summary>
//        /// Convert a number to a HEX string.
//        /// </summary>
//        /// <param name="val">Value to convert</param>
//        /// <returns>Hex string.</returns>
//        public string ParameterToHex(long val)
//        {
//            string resp = $"0x{val.ToString("X")}";

//            return resp;
//        }

//        /// <summary>
//        /// Deserialize the JSON string into a proper object.
//        /// </summary>
//        /// <param name="content">HTTP body (e.g. string, JSON).</param>
//        /// <param name="type">Object type.</param>
//        /// <param name="headers">HTTP headers.</param>
//        /// <returns>Object representation of the JSON string.</returns>
//        public object Deserialize(string content, Type type, IList<Parameter> headers=null)
//        {
//            if (type == typeof(Object)) // return an object
//            {
//                return content;
//            }

//            if (type == typeof(Stream))
//            {
//                var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
//                    ? Path.GetTempPath()
//                    : Configuration.TempFolderPath;

//                var fileName = filePath + Guid.NewGuid();
//                if (headers != null)
//                {
//                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
//                    var match = regex.Match(headers.ToString());
//                    if (match.Success)
//                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
//                }
//                File.WriteAllText(fileName, content);
//                return new FileStream(fileName, FileMode.Open);

//            }

//            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
//            {
//                return DateTime.Parse(content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
//            }

//            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
//            {
//                return ConvertType(content, type); 
//            }
    
//            // at this point, it must be a model (json)
//            try
//            {
//                return JsonConvert.DeserializeObject(content, type);
//            }
//            catch (IOException e)
//            {
//                throw new ApiException(500, e.Message);
//            }
//        }
    
//        /// <summary>
//        /// Serialize an object into JSON string.
//        /// </summary>
//        /// <param name="obj">Object.</param>
//        /// <returns>JSON string.</returns>
//        public string Serialize(object obj)
//        {
//            try
//            {
//                return obj != null ? JsonConvert.SerializeObject(obj) : null;
//            }
//            catch (Exception e)
//            {
//                throw new ApiException(500, e.Message);
//            }
//        }
    
//        /// <summary>
//        /// Get the API key with prefix.
//        /// </summary>
//        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
//        /// <returns>API key with prefix.</returns>
//        public string GetApiKeyWithPrefix (string apiKeyIdentifier)
//        {
//            var apiKeyValue = "";
//            Configuration.ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
//            var apiKeyPrefix = "";
//            if (Configuration.ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
//                return apiKeyPrefix + " " + apiKeyValue;
//            else
//                return apiKeyValue;
//        }
    
//        /// <summary>
//        /// Update parameters based on authentication.
//        /// </summary>
//        /// <param name="queryParams">Query parameters.</param>
//        /// <param name="headerParams">Header parameters.</param>
//        /// <param name="authSettings">Authentication settings.</param>
//        public void UpdateParamsForAuth(Dictionary<String, String> queryParams, Dictionary<String, String> headerParams, string[] authSettings)
//        {
//            if (authSettings == null || authSettings.Length == 0)
//                return;

//            foreach (string auth in authSettings)
//            {
//                // determine which one to use
//                switch(auth)
//                {
//                    case "ApiKeyAuth":
//                        headerParams["X-API-Key"] = GetApiKeyWithPrefix("X-API-Key");
                        
//                        break;
//                    default:
//                        //TODO show warning about security definition not found
//                        break;
//                }
//            }
//        }
 
//        /// <summary>
//        /// Encode string in base64 format.
//        /// </summary>
//        /// <param name="text">String to be encoded.</param>
//        /// <returns>Encoded string.</returns>
//        public static string Base64Encode(string text)
//        {
//            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
//            return System.Convert.ToBase64String(textByte);
//        }
    
//        /// <summary>
//        /// Dynamically cast the object into target type.
//        /// </summary>
//        /// <param name="fromObject">Object to be casted</param>
//        /// <param name="toObject">Target type</param>
//        /// <returns>Casted object</returns>
//        public static Object ConvertType(Object fromObject, Type toObject) {
//            return Convert.ChangeType(fromObject, toObject);
//        }

//        public List<Parameter> ResponHeadersToParameterList(HttpResponseHeaders source)
//        {
//            IEnumerator<KeyValuePair<string, IEnumerable<string>>> headerEnumerator = source.GetEnumerator();
//            List<Parameter> headers = new List<Parameter>();

//            while (headerEnumerator.MoveNext())
//            {
//                KeyValuePair<string, IEnumerable<string>> kp = headerEnumerator.Current;
//                Parameter header = new Parameter(kp.Key, kp.Value, ParameterType.HttpHeader);
//                headers.Add(header);
//            }

//            return headers;
//        }
//    }
//}
