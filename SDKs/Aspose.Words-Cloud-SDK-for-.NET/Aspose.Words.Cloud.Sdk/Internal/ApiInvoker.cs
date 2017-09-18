namespace Aspose.Words.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    using Aspose.Words.Cloud.Sdk.Model;
  
    internal class ApiInvoker
    {
        private static readonly ApiInvoker Instance = new ApiInvoker();
        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();
        private string appSid = "appSid";
        private string apiKey = "apiKey";

        public static ApiInvoker GetInstance()
        {
            return Instance;
        }

        public void AddAuthInfo(string apiKey, string appSid)
        {
            this.AddDefaultHeader(this.apiKey, apiKey);
            this.AddDefaultHeader(this.appSid, appSid);
        }

        public void AddDefaultHeader(string key, string value)
        {
            if (!this.defaultHeaderMap.ContainsKey(key))
            {
                this.defaultHeaderMap.Add(key, value);
            }
        }            
        
        public string InvokeApi(
            string host,
            string path,
            string method,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            return this.InvokeInternal(host, path, method, false, body, headerParams, formParams) as string;
        }

        public object InvokeBinaryApi(
            string host,
            string path,
            string method,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            return this.InvokeInternal(host, path, method, true, body, headerParams, formParams);
        }             

        public string ToPathValue(object value)
        {
            return value.ToString();
        }
       
        public FileInfo ToFileInfo(Stream stream, string paramName)
        {
            // TODO: add contenttype
            return new FileInfo { Name = paramName, file = StreamHelper.ReadAsBytes(stream) };
        }

        private static string Sign(string url, string appKey)
        {
            UriBuilder uriBuilder = new UriBuilder(url);

            // Remove final slash here as it can be added automatically.
            uriBuilder.Path = uriBuilder.Path.TrimEnd('/');

            // Compute the hash.
            byte[] privateKey = Encoding.UTF8.GetBytes(appKey);
            HMACSHA1 algorithm = new HMACSHA1(privateKey);

            byte[] sequence = Encoding.ASCII.GetBytes(uriBuilder.Uri.AbsoluteUri);
            byte[] hash = algorithm.ComputeHash(sequence);
            string signature = Convert.ToBase64String(hash);

            // Remove invalid symbols.
            signature = signature.TrimEnd('=');
            signature = HttpUtility.UrlEncode(signature);

            // Convert codes to upper case as they can be updated automatically.
            signature = Regex.Replace(signature, "%[0-9a-f]{2}", e => e.Value.ToUpper());

            // Add the signature to query string.
            return string.Format("{0}&signature={1}", uriBuilder.Uri.AbsoluteUri, signature);
        }

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new MemoryStream();
            bool needsClrf = false;

            if (postParameters.Count > 1)
            {
                foreach (var param in postParameters)
                {
                    // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                    // Skip it on the first parameter, add it to subsequent parameters.
                    if (needsClrf)
                    {
                        formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
                    }

                    needsClrf = true;

                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;
                        string postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                                boundary,
                                param.Key,
                                fileInfo.MimeType);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.file, 0, fileInfo.file.Length);
                    }
                    else
                    {
                        var stringDaa = SerializationHelper.Serialize(param.Value);
                        string postData =
                            string.Format(
                                "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                                boundary,
                                param.Key,
                                stringDaa);
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }

                // Add the end of the request.  Start with a newline
                string footer = "\r\n--" + boundary + "--\r\n";
                formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
            }
            else
            {
                foreach (var param in postParameters)
                {
                    if (param.Value is FileInfo)
                    {
                        var fileInfo = (FileInfo)param.Value;

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.file, 0, fileInfo.file.Length);
                    }
                    else
                    {
                        string postData;
                        if (!(param.Value is string))
                        {
                            postData = SerializationHelper.Serialize(param.Value);
                        }
                        else
                        {
                            postData = (string)param.Value;
                        }

                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                    }
                }
            }

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            byte[] formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }

        private object InvokeInternal(
            string host,
            string path,
            string method,
            bool binaryResponse,
            object body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams)
        {
            path = path.Replace("{appSid}", this.defaultHeaderMap[this.appSid]);

            path = Regex.Replace(path, @"{.+?}", string.Empty);

            host = host.EndsWith("/") ? host.Substring(0, host.Length - 1) : host;

            path = Sign(host + path, this.defaultHeaderMap[this.apiKey]);

            var client = WebRequest.Create(path);
            client.Method = method;

            byte[] formData = null;
            if (formParams.Count > 0)
            {
                if (formParams.Count > 1)
                {
                    string formDataBoundary = "Somthing";
                    client.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }
                else
                {
                    client.ContentType = "multipart/form-data";
                    formData = GetMultipartFormData(formParams, string.Empty);
                }

                client.ContentLength = formData.Length;
            }
            else
            {
                client.ContentType = "application/json";
            }

            foreach (var headerParamsItem in headerParams)
            {
                client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (var defaultHeaderMapItem in this.defaultHeaderMap)
            {
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                {
                    client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
                }
            }

            switch (method)
            {
                case "GET":
                    break;
                case "POST":
                case "PUT":
                case "DELETE":
                    using (Stream requestStream = client.GetRequestStream())
                    {
                        if (formData != null)
                        {
                            requestStream.Write(formData, 0, formData.Length);
                        }

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(requestStream);
                            requestWriter.Write(SerializationHelper.Serialize(body));
                            requestWriter.Close();
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("body is null");
                        }
                    }

                    break;
                default:
                    throw new ApiException(500, "unknown method type " + method);
            }

            try
            {
                var webResponse = (HttpWebResponse)client.GetResponse();
                if (webResponse.StatusCode != HttpStatusCode.OK)
                {
                    this.ThrowApiException(webResponse);
                }

                if (binaryResponse)
                {
                    var memoryStream = new MemoryStream();

                    StreamHelper.CopyTo(webResponse.GetResponseStream(), memoryStream, 81920);
                    return memoryStream;
                }

                using (var responseReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    var responseData = responseReader.ReadToEnd();
                    return responseData;
                }
            }
            catch (WebException ex)
            {
                var response = ex.Response as HttpWebResponse;
                this.ThrowApiException(response);
                throw;
            }
        }

        private void ThrowApiException(HttpWebResponse webResponse)
        {
            try
            {
                using (var responseReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    var responseData = responseReader.ReadToEnd();
                    var errorResponse = (WordsApiErrorResponse)SerializationHelper.Deserialize(responseData, typeof(WordsApiErrorResponse));
                    throw new ApiException((int)webResponse.StatusCode, errorResponse.Message);
                }
            }
            catch (ApiException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
            }
        }               
    }
}
