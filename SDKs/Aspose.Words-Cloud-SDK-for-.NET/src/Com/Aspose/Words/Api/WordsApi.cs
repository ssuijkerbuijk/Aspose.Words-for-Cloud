using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Com.Aspose.Storage;
using Com.Aspose.Words.Model;

namespace Com.Aspose.Words.Api
{
    public class WordsApi
    {
        string basePath;
        private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

        public WordsApi(string apiKey, string appSid, string basePath)
        {
            apiInvoker.addDefaultHeader(apiInvoker.API_KEY,apiKey);
            apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
            this.basePath = basePath;
        }
    
        public ApiInvoker getInvoker() {
            return apiInvoker;
        }

        // Sets the endpoint base url for the services being accessed
        public void setBasePath(string basePath)
        {
            this.basePath = basePath;
        }
    
        // Gets the endpoint base url for the services being accessed
        public string getBasePath()
        {
            return basePath;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>RevisionsModificationResponse</returns>            
        public RevisionsModificationResponse AcceptAllRevisions (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/revisions/acceptAll?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisions");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(RevisionsModificationResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as RevisionsModificationResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RevisionsModificationResponse)ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BorderResponse</returns>            
        public BorderResponse DeleteBorder (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorder");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteBorder");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BorderResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as BorderResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BorderResponse)ApiInvoker.deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BordersResponse</returns>            
        public BordersResponse DeleteBorders (string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/borders?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorders");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BordersResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as BordersResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BordersResponse)ApiInvoker.deserialize(response, typeof(BordersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="commentIndex"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteComment (string name, int? commentIndex, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling DeleteComment");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (commentIndex == null || string.IsNullOrEmpty(commentIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "commentIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteDocumentMacros (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/macros?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentMacros");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteDocumentProperty (string name, string propertyName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteDocumentProperty");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (propertyName == null || string.IsNullOrEmpty(propertyName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "propertyName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse DeleteDocumentWatermark (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/watermark?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentWatermark");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteDrawingObject (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteField (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteFields (string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFields");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteFields");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteFootnote (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnote");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnote");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteFormField (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteFormField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteHeaderFooter (string name, string sectionPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{sectionPath}/headersfooters/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeaderFooter");
            }
            
            // verify the required parameter 'sectionPath' is set
            if (sectionPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionPath' when calling DeleteHeaderFooter");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteHeaderFooter");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionPath == null || string.IsNullOrEmpty(sectionPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionPath" + "}", apiInvoker.ToPathValue(sectionPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionPath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="headersFootersTypes"></param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteHeadersFooters (string name, string sectionPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, string headersFootersTypes = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;headersFootersTypes=[headersFootersTypes]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeadersFooters");
            }
            
            // verify the required parameter 'sectionPath' is set
            if (sectionPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionPath' when calling DeleteHeadersFooters");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionPath == null || string.IsNullOrEmpty(sectionPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionPath" + "}", apiInvoker.ToPathValue(sectionPath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (headersFootersTypes == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])headersFootersTypes=\[headersFootersTypes\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "headersFootersTypes" + "]", apiInvoker.ToPathValue(headersFootersTypes));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteOfficeMathObject (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteParagraph (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/paragraphs/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraph");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteRun (string name, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling DeleteRun");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteRun");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteTable (string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteTable");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTable");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tableRowPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteTableCell (string name, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tableRowPath}/cells/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableCell");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tableRowPath == null || string.IsNullOrEmpty(tableRowPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tableRowPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tableRowPath" + "}", apiInvoker.ToPathValue(tableRowPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tablePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse DeleteTableRow (string name, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tablePath}/rows/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableRow");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tablePath == null || string.IsNullOrEmpty(tablePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tablePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tablePath" + "}", apiInvoker.ToPathValue(tablePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="protectionRequest"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ProtectionDataResponse</returns>            
        public ProtectionDataResponse DeleteUnprotectDocument (string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnprotectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling DeleteUnprotectDocument");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if(typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ProtectionDataResponse)ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BorderResponse</returns>            
        public BorderResponse GetBorder (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorder");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetBorder");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BorderResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as BorderResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BorderResponse)ApiInvoker.deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BordersResponse</returns>            
        public BordersResponse GetBorders (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/borders?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorders");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BordersResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as BordersResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BordersResponse)ApiInvoker.deserialize(response, typeof(BordersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="commentIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>CommentResponse</returns>            
        public CommentResponse GetComment (string name, int? commentIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling GetComment");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (commentIndex == null || string.IsNullOrEmpty(commentIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "commentIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(CommentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as CommentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (CommentResponse)ApiInvoker.deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>CommentsResponse</returns>            
        public CommentsResponse GetComments (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/comments?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComments");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(CommentsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as CommentsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (CommentsResponse)ApiInvoker.deserialize(response, typeof(CommentsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="documentName"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse GetDocument (string documentName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{documentName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'documentName' is set
            if (documentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling GetDocument");
            }
            
            if (documentName == null || string.IsNullOrEmpty(documentName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "documentName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "documentName" + "}", apiInvoker.ToPathValue(documentName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="bookmarkName"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BookmarkResponse</returns>            
        public BookmarkResponse GetDocumentBookmarkByName (string name, string bookmarkName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/bookmarks/{bookmarkName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarkByName");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (bookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling GetDocumentBookmarkByName");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (bookmarkName == null || string.IsNullOrEmpty(bookmarkName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "bookmarkName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "bookmarkName" + "}", apiInvoker.ToPathValue(bookmarkName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BookmarkResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as BookmarkResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BookmarkResponse)ApiInvoker.deserialize(response, typeof(BookmarkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BookmarksResponse</returns>            
        public BookmarksResponse GetDocumentBookmarks (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/bookmarks?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarks");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(BookmarksResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as BookmarksResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BookmarksResponse)ApiInvoker.deserialize(response, typeof(BookmarksResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DrawingObjectResponse</returns>            
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndex");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentDrawingObjectByIndex");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndex");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DrawingObjectResponse)ApiInvoker.deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetDocumentDrawingObjectImageData (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/imageData?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageData");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentDrawingObjectImageData");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageData");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetDocumentDrawingObjectOleData (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/oleData?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleData");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentDrawingObjectOleData");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleData");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DrawingObjectsResponse</returns>            
        public DrawingObjectsResponse GetDocumentDrawingObjects (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjects");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentDrawingObjects");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DrawingObjectsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as DrawingObjectsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DrawingObjectsResponse)ApiInvoker.deserialize(response, typeof(DrawingObjectsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="useNonMergeFields"></param> 
        /// <returns>FieldNamesResponse</returns>            
        public FieldNamesResponse GetDocumentFieldNames (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null, bool? useNonMergeFields = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/mailMergeFieldNames?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;useNonMergeFields=[useNonMergeFields]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFieldNames");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (useNonMergeFields == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useNonMergeFields=\[useNonMergeFields\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useNonMergeFields" + "]", apiInvoker.ToPathValue(useNonMergeFields));
            }
                                    try 
            {                
                if(typeof(FieldNamesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FieldNamesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldNamesResponse)ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="hyperlinkIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>HyperlinkResponse</returns>            
        public HyperlinkResponse GetDocumentHyperlinkByIndex (string name, int? hyperlinkIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/hyperlinks/{hyperlinkIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinkByIndex");
            }
            
            // verify the required parameter 'hyperlinkIndex' is set
            if (hyperlinkIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'hyperlinkIndex' when calling GetDocumentHyperlinkByIndex");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (hyperlinkIndex == null || string.IsNullOrEmpty(hyperlinkIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "hyperlinkIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "hyperlinkIndex" + "}", apiInvoker.ToPathValue(hyperlinkIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(HyperlinkResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as HyperlinkResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HyperlinkResponse)ApiInvoker.deserialize(response, typeof(HyperlinkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>HyperlinksResponse</returns>            
        public HyperlinksResponse GetDocumentHyperlinks (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/hyperlinks?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinks");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(HyperlinksResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as HyperlinksResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HyperlinksResponse)ApiInvoker.deserialize(response, typeof(HyperlinksResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ParagraphResponse</returns>            
        public ParagraphResponse GetDocumentParagraph (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/paragraphs/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraph");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraph");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(ParagraphResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as ParagraphResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ParagraphResponse)ApiInvoker.deserialize(response, typeof(ParagraphResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>RunResponse</returns>            
        public RunResponse GetDocumentParagraphRun (string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRun");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(RunResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as RunResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RunResponse)ApiInvoker.deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FontResponse</returns>            
        public FontResponse GetDocumentParagraphRunFont (string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs/{index}/font?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRunFont");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FontResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FontResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FontResponse)ApiInvoker.deserialize(response, typeof(FontResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>RunsResponse</returns>            
        public RunsResponse GetDocumentParagraphRuns (string name, string paragraphPath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRuns");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRuns");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(RunsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as RunsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RunsResponse)ApiInvoker.deserialize(response, typeof(RunsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ParagraphLinkCollectionResponse</returns>            
        public ParagraphLinkCollectionResponse GetDocumentParagraphs (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/paragraphs?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphs");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetDocumentParagraphs");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(ParagraphLinkCollectionResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as ParagraphLinkCollectionResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ParagraphLinkCollectionResponse)ApiInvoker.deserialize(response, typeof(ParagraphLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentPropertiesResponse</returns>            
        public DocumentPropertiesResponse GetDocumentProperties (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/documentProperties?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DocumentPropertiesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as DocumentPropertiesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentPropertiesResponse)ApiInvoker.deserialize(response, typeof(DocumentPropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentPropertyResponse</returns>            
        public DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetDocumentProperty");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (propertyName == null || string.IsNullOrEmpty(propertyName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "propertyName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentPropertyResponse)ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ProtectionDataResponse</returns>            
        public ProtectionDataResponse GetDocumentProtection (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/protection?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProtection");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ProtectionDataResponse)ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="includeComments"></param> 
        /// <param name="includeFootnotes"></param> 
        /// <param name="includeTextInShapes"></param> 
        /// <returns>StatDataResponse</returns>            
        public StatDataResponse GetDocumentStatistics (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/statistics?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;includeComments=[includeComments]&amp;includeFootnotes=[includeFootnotes]&amp;includeTextInShapes=[includeTextInShapes]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentStatistics");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (includeComments == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeComments=\[includeComments\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "includeComments" + "]", apiInvoker.ToPathValue(includeComments));
            }
            if (includeFootnotes == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeFootnotes=\[includeFootnotes\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "includeFootnotes" + "]", apiInvoker.ToPathValue(includeFootnotes));
            }
            if (includeTextInShapes == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeTextInShapes=\[includeTextInShapes\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "includeTextInShapes" + "]", apiInvoker.ToPathValue(includeTextInShapes));
            }
                                    try 
            {                
                if(typeof(StatDataResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as StatDataResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (StatDataResponse)ApiInvoker.deserialize(response, typeof(StatDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TextItemsResponse</returns>            
        public TextItemsResponse GetDocumentTextItems (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/textItems?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentTextItems");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TextItemsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TextItemsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TextItemsResponse)ApiInvoker.deserialize(response, typeof(TextItemsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="outPath"></param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetDocumentWithFormat (string name, string format, string storage = null, string folder = null, string loadEncoding = null, string password = null, string outPath = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;outPath=[outPath]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentWithFormat");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetDocumentWithFormat");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (outPath == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=\[outPath\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "outPath" + "]", apiInvoker.ToPathValue(outPath));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FieldResponse</returns>            
        public FieldResponse GetField (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldResponse)ApiInvoker.deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FieldsResponse</returns>            
        public FieldsResponse GetFields (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFields");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetFields");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FieldsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FieldsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldsResponse)ApiInvoker.deserialize(response, typeof(FieldsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FootnoteResponse</returns>            
        public FootnoteResponse GetFootnote (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnote");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnote");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FootnoteResponse)ApiInvoker.deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FootnotesResponse</returns>            
        public FootnotesResponse GetFootnotes (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/footnotes?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotes");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetFootnotes");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FootnotesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FootnotesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FootnotesResponse)ApiInvoker.deserialize(response, typeof(FootnotesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FormFieldResponse</returns>            
        public FormFieldResponse GetFormField (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetFormField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FormFieldResponse)ApiInvoker.deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FormFieldsResponse</returns>            
        public FormFieldsResponse GetFormFields (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/formfields?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFields");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetFormFields");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(FormFieldsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as FormFieldsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FormFieldsResponse)ApiInvoker.deserialize(response, typeof(FormFieldsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="headerFooterIndex"></param> 
        /// <param name="sectionIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="filterByType"></param> 
        /// <returns>HeaderFooterResponse</returns>            
        public HeaderFooterResponse GetHeaderFooter (string name, int? headerFooterIndex, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null, string filterByType = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/sections/{sectionIndex}/headersfooters/{headerFooterIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;filterByType=[filterByType]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (headerFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetHeaderFooter");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (headerFooterIndex == null || string.IsNullOrEmpty(headerFooterIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "headerFooterIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "headerFooterIndex" + "}", apiInvoker.ToPathValue(headerFooterIndex));
            }
            if (sectionIndex == null || string.IsNullOrEmpty(sectionIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (filterByType == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])filterByType=\[filterByType\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "filterByType" + "]", apiInvoker.ToPathValue(filterByType));
            }
                                    try 
            {                
                if(typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HeaderFooterResponse)ApiInvoker.deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="headerFooterIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="sectionIndex"></param> 
        /// <param name="filterByType"></param> 
        /// <returns>HeaderFooterResponse</returns>            
        public HeaderFooterResponse GetHeaderFooter_1 (string name, int? headerFooterIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null, int? sectionIndex = null, string filterByType = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/headersfooters/{headerFooterIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;sectionIndex=[sectionIndex]&amp;filterByType=[filterByType]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter_1");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (headerFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter_1");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (headerFooterIndex == null || string.IsNullOrEmpty(headerFooterIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "headerFooterIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "headerFooterIndex" + "}", apiInvoker.ToPathValue(headerFooterIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (sectionIndex == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=\[sectionIndex\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "sectionIndex" + "]", apiInvoker.ToPathValue(sectionIndex));
            }
            if (filterByType == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])filterByType=\[filterByType\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "filterByType" + "]", apiInvoker.ToPathValue(filterByType));
            }
                                    try 
            {                
                if(typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HeaderFooterResponse)ApiInvoker.deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionPath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="filterByType"></param> 
        /// <returns>HeaderFootersResponse</returns>            
        public HeaderFootersResponse GetHeaderFooters (string name, string sectionPath, string storage = null, string folder = null, string loadEncoding = null, string password = null, string filterByType = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;filterByType=[filterByType]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }
            
            // verify the required parameter 'sectionPath' is set
            if (sectionPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionPath' when calling GetHeaderFooters");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionPath == null || string.IsNullOrEmpty(sectionPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionPath" + "}", apiInvoker.ToPathValue(sectionPath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (filterByType == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])filterByType=\[filterByType\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "filterByType" + "]", apiInvoker.ToPathValue(filterByType));
            }
                                    try 
            {                
                if(typeof(HeaderFootersResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as HeaderFootersResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HeaderFootersResponse)ApiInvoker.deserialize(response, typeof(HeaderFootersResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>OfficeMathObjectResponse</returns>            
        public OfficeMathObjectResponse GetOfficeMathObject (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(OfficeMathObjectResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as OfficeMathObjectResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (OfficeMathObjectResponse)ApiInvoker.deserialize(response, typeof(OfficeMathObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>OfficeMathObjectsResponse</returns>            
        public OfficeMathObjectsResponse GetOfficeMathObjects (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/OfficeMathObjects?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjects");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetOfficeMathObjects");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(OfficeMathObjectsResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as OfficeMathObjectsResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (OfficeMathObjectsResponse)ApiInvoker.deserialize(response, typeof(OfficeMathObjectsResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SectionResponse</returns>            
        public SectionResponse GetSection (string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/sections/{sectionIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSection");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSection");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionIndex == null || string.IsNullOrEmpty(sectionIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SectionResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as SectionResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SectionResponse)ApiInvoker.deserialize(response, typeof(SectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionIndex"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SectionPageSetupResponse</returns>            
        public SectionPageSetupResponse GetSectionPageSetup (string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSectionPageSetup");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionIndex == null || string.IsNullOrEmpty(sectionIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SectionPageSetupResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as SectionPageSetupResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SectionPageSetupResponse)ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SectionLinkCollectionResponse</returns>            
        public SectionLinkCollectionResponse GetSections (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/sections?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(SectionLinkCollectionResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as SectionLinkCollectionResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SectionLinkCollectionResponse)ApiInvoker.deserialize(response, typeof(SectionLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableResponse</returns>            
        public TableResponse GetTable (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTable");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetTable");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTable");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableResponse)ApiInvoker.deserialize(response, typeof(TableResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tableRowPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableCellResponse</returns>            
        public TableCellResponse GetTableCell (string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tableRowPath}/cells/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCell");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tableRowPath == null || string.IsNullOrEmpty(tableRowPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tableRowPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tableRowPath" + "}", apiInvoker.ToPathValue(tableRowPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableCellResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableCellResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableCellResponse)ApiInvoker.deserialize(response, typeof(TableCellResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tableRowPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableCellFormatResponse</returns>            
        public TableCellFormatResponse GetTableCellFormat (string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tableRowPath}/cells/{index}/cellformat?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCellFormat");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tableRowPath == null || string.IsNullOrEmpty(tableRowPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tableRowPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tableRowPath" + "}", apiInvoker.ToPathValue(tableRowPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableCellFormatResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableCellFormatResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableCellFormatResponse)ApiInvoker.deserialize(response, typeof(TableCellFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TablePropertiesResponse</returns>            
        public TablePropertiesResponse GetTableProperties (string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables/{index}/properties?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableProperties");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableProperties");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TablePropertiesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TablePropertiesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TablePropertiesResponse)ApiInvoker.deserialize(response, typeof(TablePropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tablePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableRowResponse</returns>            
        public TableRowResponse GetTableRow (string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tablePath}/rows/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRow");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tablePath == null || string.IsNullOrEmpty(tablePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tablePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tablePath" + "}", apiInvoker.ToPathValue(tablePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableRowResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableRowResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableRowResponse)ApiInvoker.deserialize(response, typeof(TableRowResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="tablePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableRowFormatResponse</returns>            
        public TableRowFormatResponse GetTableRowFormat (string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tablePath}/rows/{index}/rowformat?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRowFormat");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tablePath == null || string.IsNullOrEmpty(tablePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tablePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tablePath" + "}", apiInvoker.ToPathValue(tablePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableRowFormatResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableRowFormatResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableRowFormatResponse)ApiInvoker.deserialize(response, typeof(TableRowFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableLinkCollectionResponse</returns>            
        public TableLinkCollectionResponse GetTables (string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTables");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetTables");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(TableLinkCollectionResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as TableLinkCollectionResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableLinkCollectionResponse)ApiInvoker.deserialize(response, typeof(TableLinkCollectionResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="table"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableResponse</returns>            
        public TableResponse InsertTable (string name, TableInsertDto table, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTable");
            }
            
            // verify the required parameter 'table' is set
            if (table == null) 
            {
                throw new ApiException(400, "Missing required parameter 'table' when calling InsertTable");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling InsertTable");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = table; // http body (model) parameter
            try 
            {                
                if(typeof(TableResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as TableResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableResponse)ApiInvoker.deserialize(response, typeof(TableResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="cell"></param> 
        /// <param name="tableRowPath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableCellResponse</returns>            
        public TableCellResponse InsertTableCell (string name, TableCellInsertDto cell, string tableRowPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tableRowPath}/cells?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableCell");
            }
            
            // verify the required parameter 'cell' is set
            if (cell == null) 
            {
                throw new ApiException(400, "Missing required parameter 'cell' when calling InsertTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling InsertTableCell");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tableRowPath == null || string.IsNullOrEmpty(tableRowPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tableRowPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tableRowPath" + "}", apiInvoker.ToPathValue(tableRowPath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = cell; // http body (model) parameter
            try 
            {                
                if(typeof(TableCellResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as TableCellResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableCellResponse)ApiInvoker.deserialize(response, typeof(TableCellResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="row"></param> 
        /// <param name="tablePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableRowResponse</returns>            
        public TableRowResponse InsertTableRow (string name, TableRowInsertDto row, string tablePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tablePath}/rows?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableRow");
            }
            
            // verify the required parameter 'row' is set
            if (row == null) 
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling InsertTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling InsertTableRow");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tablePath == null || string.IsNullOrEmpty(tablePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tablePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tablePath" + "}", apiInvoker.ToPathValue(tablePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = row; // http body (model) parameter
            try 
            {                
                if(typeof(TableRowResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as TableRowResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableRowResponse)ApiInvoker.deserialize(response, typeof(TableRowResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="documentList"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostAppendDocument (string name, DocumentEntryList documentList, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/appendDocument?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAppendDocument");
            }
            
            // verify the required parameter 'documentList' is set
            if (documentList == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentList' when calling PostAppendDocument");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = documentList; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="protectionRequest"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ProtectionDataResponse</returns>            
        public ProtectionDataResponse PostChangeDocumentProtection (string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChangeDocumentProtection");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PostChangeDocumentProtection");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if(typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ProtectionDataResponse)ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="commentIndex"></param> 
        /// <param name="comment"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>CommentResponse</returns>            
        public CommentResponse PostComment (string name, int? commentIndex, CommentDto comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling PostComment");
            }
            
            // verify the required parameter 'comment' is set
            if (comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostComment");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (commentIndex == null || string.IsNullOrEmpty(commentIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "commentIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = comment; // http body (model) parameter
            try 
            {                
                if(typeof(CommentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as CommentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (CommentResponse)ApiInvoker.deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="compareData"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostCompareDocument (string name, CompareData compareData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/compareDocument?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCompareDocument");
            }
            
            // verify the required parameter 'compareData' is set
            if (compareData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling PostCompareDocument");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = compareData; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="withRegions"></param> 
        /// <param name="data">Mail merge data</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="mailMergeDataFile"></param> 
        /// <param name="cleanup"></param> 
        /// <param name="useWholeParagraphAsRegion"></param> 
        /// <param name="destFileName"></param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostDocumentExecuteMailMerge (string name, bool? withRegions, string data = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string mailMergeDataFile = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, string destFileName = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/executeMailMerge/{withRegions}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;mailMergeDataFile=[mailMergeDataFile]&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;destFileName=[destFileName]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentExecuteMailMerge");
            }
            
            // verify the required parameter 'withRegions' is set
            if (withRegions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'withRegions' when calling PostDocumentExecuteMailMerge");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (withRegions == null || string.IsNullOrEmpty(withRegions.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "withRegions" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "withRegions" + "}", apiInvoker.ToPathValue(withRegions));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (mailMergeDataFile == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])mailMergeDataFile=\[mailMergeDataFile\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "mailMergeDataFile" + "]", apiInvoker.ToPathValue(mailMergeDataFile));
            }
            if (cleanup == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=\[cleanup\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "cleanup" + "]", apiInvoker.ToPathValue(cleanup));
            }
            if (useWholeParagraphAsRegion == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=\[useWholeParagraphAsRegion\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useWholeParagraphAsRegion" + "]", apiInvoker.ToPathValue(useWholeParagraphAsRegion));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
                                    if (data != null) 
            {
                formParams.Add("data", data); // form parameter
            }
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="fontDto"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FontResponse</returns>            
        public FontResponse PostDocumentParagraphRunFont (string name, Font fontDto, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs/{index}/font?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'fontDto' is set
            if (fontDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fontDto' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDocumentParagraphRunFont");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = fontDto; // http body (model) parameter
            try 
            {                
                if(typeof(FontResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as FontResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FontResponse)ApiInvoker.deserialize(response, typeof(FontResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="saveOptionsData"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>SaveResponse</returns>            
        public SaveResponse PostDocumentSaveAs (string name, SaveOptionsData saveOptionsData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/saveAs?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentSaveAs");
            }
            
            // verify the required parameter 'saveOptionsData' is set
            if (saveOptionsData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling PostDocumentSaveAs");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                        postBody = saveOptionsData; // http body (model) parameter
            try 
            {                
                if(typeof(SaveResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as SaveResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaveResponse)ApiInvoker.deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="drawingObject">Drawing object parameters</param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DrawingObjectResponse</returns>            
        public DrawingObjectResponse PostDrawingObject (string name, string drawingObject, System.IO.Stream imageFile, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (drawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (imageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDrawingObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    if (drawingObject != null) 
            {
                formParams.Add("drawingObject", drawingObject); // form parameter
            }
            if (imageFile != null) 
            {
                formParams.Add("imageFile", apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if(typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DrawingObjectResponse)ApiInvoker.deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="data">Mail merge data</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="cleanup"></param> 
        /// <param name="useWholeParagraphAsRegion"></param> 
        /// <param name="withRegions"></param> 
        /// <param name="destFileName"></param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostExecuteTemplate (string name, string data, string storage = null, string folder = null, string loadEncoding = null, string password = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null, string destFileName = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/executeTemplate?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;withRegions=[withRegions]&amp;destFileName=[destFileName]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExecuteTemplate");
            }
            
            // verify the required parameter 'data' is set
            if (data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostExecuteTemplate");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (cleanup == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=\[cleanup\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "cleanup" + "]", apiInvoker.ToPathValue(cleanup));
            }
            if (useWholeParagraphAsRegion == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=\[useWholeParagraphAsRegion\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useWholeParagraphAsRegion" + "]", apiInvoker.ToPathValue(useWholeParagraphAsRegion));
            }
            if (withRegions == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=\[withRegions\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "withRegions" + "]", apiInvoker.ToPathValue(withRegions));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
                                    if (data != null) 
            {
                formParams.Add("data", data); // form parameter
            }
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="field"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FieldResponse</returns>            
        public FieldResponse PostField (string name, FieldDto field, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostField");
            }
            
            // verify the required parameter 'field' is set
            if (field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PostField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PostField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = field; // http body (model) parameter
            try 
            {                
                if(typeof(FieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as FieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldResponse)ApiInvoker.deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="footnoteDto"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FootnoteResponse</returns>            
        public FootnoteResponse PostFootnote (string name, FootnoteDto footnoteDto, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (footnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PostFootnote");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PostFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFootnote");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = footnoteDto; // http body (model) parameter
            try 
            {                
                if(typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FootnoteResponse)ApiInvoker.deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="formField"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FormFieldResponse</returns>            
        public FormFieldResponse PostFormField (string name, FormField formField, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (formField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PostFormField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PostFormField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFormField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = formField; // http body (model) parameter
            try 
            {                
                if(typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FormFieldResponse)ApiInvoker.deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="rotationAngle"></param> 
        /// <param name="image"></param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostInsertDocumentWatermarkImage (string name, System.IO.Stream imageFile = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, double? rotationAngle = null, string image = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/watermark/insertImage?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;rotationAngle=[rotationAngle]&amp;image=[image]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkImage");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (rotationAngle == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=\[rotationAngle\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "rotationAngle" + "]", apiInvoker.ToPathValue(rotationAngle));
            }
            if (image == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])image=\[image\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "image" + "]", apiInvoker.ToPathValue(image));
            }
                                    if (imageFile != null) 
            {
                formParams.Add("imageFile", apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="watermarkText"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostInsertDocumentWatermarkText (string name, WatermarkText watermarkText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/watermark/insertText?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkText");
            }
            
            // verify the required parameter 'watermarkText' is set
            if (watermarkText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling PostInsertDocumentWatermarkText");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = watermarkText; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="pageNumber"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostInsertPageNumbers (string name, PageNumber pageNumber, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/insertPageNumbers?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertPageNumbers");
            }
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PostInsertPageNumbers");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = pageNumber; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="data"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <returns>SaveResponse</returns>            
        public SaveResponse PostLoadWebDocument (LoadWebDocumentData data, string storage = null)
        {
            // create path and map variables
            var ResourcePath = "/words/loadWebDocument?appSid={appSid}&amp;storage=[storage]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'data' is set
            if (data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebDocument");
            }
            
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
                        postBody = data; // http body (model) parameter
            try 
            {                
                if(typeof(SaveResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as SaveResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaveResponse)ApiInvoker.deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="replaceText"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ReplaceTextResponse</returns>            
        public ReplaceTextResponse PostReplaceText (string name, ReplaceTextRequest replaceText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/replaceText?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostReplaceText");
            }
            
            // verify the required parameter 'replaceText' is set
            if (replaceText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling PostReplaceText");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = replaceText; // http body (model) parameter
            try 
            {                
                if(typeof(ReplaceTextResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as ReplaceTextResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ReplaceTextResponse)ApiInvoker.deserialize(response, typeof(ReplaceTextResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="run"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>RunResponse</returns>            
        public RunResponse PostRun (string name, Run run, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostRun");
            }
            
            // verify the required parameter 'run' is set
            if (run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PostRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostRun");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostRun");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = run; // http body (model) parameter
            try 
            {                
                if(typeof(RunResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as RunResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RunResponse)ApiInvoker.deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>Object</returns>            
        public Object PostRunTask ()
        {
            // create path and map variables
            var ResourcePath = "/words/tasks?appSid={appSid}";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
                                    try 
            {                
                if(typeof(Object) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as Object;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (Object)ApiInvoker.deserialize(response, typeof(Object));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="format"></param> 
        /// <param name="from"></param> 
        /// <param name="to"></param> 
        /// <param name="zipOutput"></param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>SplitDocumentResponse</returns>            
        public SplitDocumentResponse PostSplitDocument (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string format = null, int? from = null, int? to = null, bool? zipOutput = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/split?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;from=[from]&amp;to=[to]&amp;zipOutput=[zipOutput]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSplitDocument");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (from == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])from=\[from\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "from" + "]", apiInvoker.ToPathValue(from));
            }
            if (to == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])to=\[to\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "to" + "]", apiInvoker.ToPathValue(to));
            }
            if (zipOutput == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])zipOutput=\[zipOutput\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "zipOutput" + "]", apiInvoker.ToPathValue(zipOutput));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(SplitDocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as SplitDocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SplitDocumentResponse)ApiInvoker.deserialize(response, typeof(SplitDocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="bookmarkData"></param> 
        /// <param name="bookmarkName"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BookmarkResponse</returns>            
        public BookmarkResponse PostUpdateDocumentBookmark (string name, BookmarkData bookmarkData, string bookmarkName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/bookmarks/{bookmarkName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkData' is set
            if (bookmarkData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkData' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (bookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling PostUpdateDocumentBookmark");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (bookmarkName == null || string.IsNullOrEmpty(bookmarkName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "bookmarkName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "bookmarkName" + "}", apiInvoker.ToPathValue(bookmarkName));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = bookmarkData; // http body (model) parameter
            try 
            {                
                if(typeof(BookmarkResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as BookmarkResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BookmarkResponse)ApiInvoker.deserialize(response, typeof(BookmarkResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PostUpdateDocumentFields (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/updateFields?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentFields");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="comment"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>CommentResponse</returns>            
        public CommentResponse PutComment (string name, CommentDto comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/comments?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutComment");
            }
            
            // verify the required parameter 'comment' is set
            if (comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PutComment");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = comment; // http body (model) parameter
            try 
            {                
                if(typeof(CommentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as CommentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (CommentResponse)ApiInvoker.deserialize(response, typeof(CommentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="format"></param> 
        /// <param name="document">Converting document</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="outPath"></param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream PutConvertDocument (string format, System.IO.Stream document, string storage = null, string outPath = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/convert?appSid={appSid}&amp;format=[format]&amp;storage=[storage]&amp;outPath=[outPath]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutConvertDocument");
            }
            
            // verify the required parameter 'document' is set
            if (document == null) 
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutConvertDocument");
            }
            
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (outPath == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=\[outPath\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "outPath" + "]", apiInvoker.ToPathValue(outPath));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    if (document != null) 
            {
                formParams.Add("document", apiInvoker.ToFileInfo(document, "document"));
            }
            try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="folder"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <returns>DocumentResponse</returns>            
        public DocumentResponse PutCreateDocument (string folder = null, string storage = null)
        {
            // create path and map variables
            var ResourcePath = "/words/create?appSid={appSid}&amp;folder=[folder]&amp;storage=[storage]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
                                    try 
            {                
                if(typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentResponse)ApiInvoker.deserialize(response, typeof(DocumentResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="useNonMergeFields"></param> 
        /// <returns>FieldNamesResponse</returns>            
        public FieldNamesResponse PutDocumentFieldNames (System.IO.Stream template, bool? useNonMergeFields = null)
        {
            // create path and map variables
            var ResourcePath = "/words/mailMergeFieldNames?appSid={appSid}&amp;useNonMergeFields=[useNonMergeFields]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'template' is set
            if (template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutDocumentFieldNames");
            }
            
            if (useNonMergeFields == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useNonMergeFields=\[useNonMergeFields\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useNonMergeFields" + "]", apiInvoker.ToPathValue(useNonMergeFields));
            }
                                    if (template != null) 
            {
                formParams.Add("Template", apiInvoker.ToFileInfo(template, "Template"));
            }
            try 
            {                
                if(typeof(FieldNamesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as FieldNamesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldNamesResponse)ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="saveOptions"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="resultFile"></param> 
        /// <param name="useAntiAliasing"></param> 
        /// <param name="useHighQualityRendering"></param> 
        /// <param name="imageBrightness"></param> 
        /// <param name="imageColorMode"></param> 
        /// <param name="imageContrast"></param> 
        /// <param name="numeralFormat"></param> 
        /// <param name="pageCount"></param> 
        /// <param name="pageIndex"></param> 
        /// <param name="paperColor"></param> 
        /// <param name="pixelFormat"></param> 
        /// <param name="resolution"></param> 
        /// <param name="scale"></param> 
        /// <param name="tiffCompression"></param> 
        /// <param name="dmlRenderingMode"></param> 
        /// <param name="dmlEffectsRenderingMode"></param> 
        /// <param name="tiffBinarizationMethod"></param> 
        /// <param name="zipOutput"></param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>SaveResponse</returns>            
        public SaveResponse PutDocumentSaveAsTiff (string name, TiffSaveOptionsData saveOptions, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string resultFile = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, float? imageBrightness = null, string imageColorMode = null, float? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, float? resolution = null, float? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/saveAs/tiff?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;resultFile=[resultFile]&amp;useAntiAliasing=[useAntiAliasing]&amp;useHighQualityRendering=[useHighQualityRendering]&amp;imageBrightness=[imageBrightness]&amp;imageColorMode=[imageColorMode]&amp;imageContrast=[imageContrast]&amp;numeralFormat=[numeralFormat]&amp;pageCount=[pageCount]&amp;pageIndex=[pageIndex]&amp;paperColor=[paperColor]&amp;pixelFormat=[pixelFormat]&amp;resolution=[resolution]&amp;scale=[scale]&amp;tiffCompression=[tiffCompression]&amp;dmlRenderingMode=[dmlRenderingMode]&amp;dmlEffectsRenderingMode=[dmlEffectsRenderingMode]&amp;tiffBinarizationMethod=[tiffBinarizationMethod]&amp;zipOutput=[zipOutput]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDocumentSaveAsTiff");
            }
            
            // verify the required parameter 'saveOptions' is set
            if (saveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling PutDocumentSaveAsTiff");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (resultFile == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])resultFile=\[resultFile\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "resultFile" + "]", apiInvoker.ToPathValue(resultFile));
            }
            if (useAntiAliasing == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useAntiAliasing=\[useAntiAliasing\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useAntiAliasing" + "]", apiInvoker.ToPathValue(useAntiAliasing));
            }
            if (useHighQualityRendering == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useHighQualityRendering=\[useHighQualityRendering\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useHighQualityRendering" + "]", apiInvoker.ToPathValue(useHighQualityRendering));
            }
            if (imageBrightness == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageBrightness=\[imageBrightness\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "imageBrightness" + "]", apiInvoker.ToPathValue(imageBrightness));
            }
            if (imageColorMode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageColorMode=\[imageColorMode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "imageColorMode" + "]", apiInvoker.ToPathValue(imageColorMode));
            }
            if (imageContrast == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageContrast=\[imageContrast\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "imageContrast" + "]", apiInvoker.ToPathValue(imageContrast));
            }
            if (numeralFormat == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])numeralFormat=\[numeralFormat\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "numeralFormat" + "]", apiInvoker.ToPathValue(numeralFormat));
            }
            if (pageCount == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageCount=\[pageCount\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "pageCount" + "]", apiInvoker.ToPathValue(pageCount));
            }
            if (pageIndex == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageIndex=\[pageIndex\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "pageIndex" + "]", apiInvoker.ToPathValue(pageIndex));
            }
            if (paperColor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])paperColor=\[paperColor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "paperColor" + "]", apiInvoker.ToPathValue(paperColor));
            }
            if (pixelFormat == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])pixelFormat=\[pixelFormat\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "pixelFormat" + "]", apiInvoker.ToPathValue(pixelFormat));
            }
            if (resolution == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolution=\[resolution\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "resolution" + "]", apiInvoker.ToPathValue(resolution));
            }
            if (scale == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])scale=\[scale\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "scale" + "]", apiInvoker.ToPathValue(scale));
            }
            if (tiffCompression == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])tiffCompression=\[tiffCompression\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "tiffCompression" + "]", apiInvoker.ToPathValue(tiffCompression));
            }
            if (dmlRenderingMode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])dmlRenderingMode=\[dmlRenderingMode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "dmlRenderingMode" + "]", apiInvoker.ToPathValue(dmlRenderingMode));
            }
            if (dmlEffectsRenderingMode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])dmlEffectsRenderingMode=\[dmlEffectsRenderingMode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "dmlEffectsRenderingMode" + "]", apiInvoker.ToPathValue(dmlEffectsRenderingMode));
            }
            if (tiffBinarizationMethod == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])tiffBinarizationMethod=\[tiffBinarizationMethod\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "tiffBinarizationMethod" + "]", apiInvoker.ToPathValue(tiffBinarizationMethod));
            }
            if (zipOutput == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])zipOutput=\[zipOutput\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "zipOutput" + "]", apiInvoker.ToPathValue(zipOutput));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                        postBody = saveOptions; // http body (model) parameter
            try 
            {                
                if(typeof(SaveResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as SaveResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaveResponse)ApiInvoker.deserialize(response, typeof(SaveResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="drawingObject">Drawing object parameters</param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DrawingObjectResponse</returns>            
        public DrawingObjectResponse PutDrawingObject (string name, string drawingObject, System.IO.Stream imageFile, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (drawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (imageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PutDrawingObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    if (drawingObject != null) 
            {
                formParams.Add("drawingObject", drawingObject); // form parameter
            }
            if (imageFile != null) 
            {
                formParams.Add("imageFile", apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if(typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DrawingObjectResponse)ApiInvoker.deserialize(response, typeof(DrawingObjectResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="data">File with mailmerge data</param> 
        /// <param name="withRegions"></param> 
        /// <param name="cleanup"></param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream PutExecuteMailMergeOnline (System.IO.Stream template, System.IO.Stream data, bool? withRegions = null, string cleanup = null)
        {
            // create path and map variables
            var ResourcePath = "/words/executeMailMerge?appSid={appSid}&amp;withRegions=[withRegions]&amp;cleanup=[cleanup]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'template' is set
            if (template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteMailMergeOnline");
            }
            
            // verify the required parameter 'data' is set
            if (data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteMailMergeOnline");
            }
            
            if (withRegions == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=\[withRegions\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "withRegions" + "]", apiInvoker.ToPathValue(withRegions));
            }
            if (cleanup == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=\[cleanup\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "cleanup" + "]", apiInvoker.ToPathValue(cleanup));
            }
                                    if (template != null) 
            {
                formParams.Add("Template", apiInvoker.ToFileInfo(template, "Template"));
            }
            if (data != null) 
            {
                formParams.Add("Data", apiInvoker.ToFileInfo(data, "Data"));
            }
            try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="data">File with mailmerge data</param> 
        /// <param name="cleanup"></param> 
        /// <param name="useWholeParagraphAsRegion"></param> 
        /// <param name="withRegions"></param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream PutExecuteTemplateOnline (System.IO.Stream template, System.IO.Stream data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null)
        {
            // create path and map variables
            var ResourcePath = "/words/executeTemplate?appSid={appSid}&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;withRegions=[withRegions]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'template' is set
            if (template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteTemplateOnline");
            }
            
            // verify the required parameter 'data' is set
            if (data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteTemplateOnline");
            }
            
            if (cleanup == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=\[cleanup\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "cleanup" + "]", apiInvoker.ToPathValue(cleanup));
            }
            if (useWholeParagraphAsRegion == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=\[useWholeParagraphAsRegion\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "useWholeParagraphAsRegion" + "]", apiInvoker.ToPathValue(useWholeParagraphAsRegion));
            }
            if (withRegions == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=\[withRegions\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "withRegions" + "]", apiInvoker.ToPathValue(withRegions));
            }
                                    if (template != null) 
            {
                formParams.Add("Template", apiInvoker.ToFileInfo(template, "Template"));
            }
            if (data != null) 
            {
                formParams.Add("Data", apiInvoker.ToFileInfo(data, "Data"));
            }
            try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="field"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="insertBeforeNode"></param> 
        /// <returns>FieldResponse</returns>            
        public FieldResponse PutField (string name, FieldDto field, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, string insertBeforeNode = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;insertBeforeNode=[insertBeforeNode]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutField");
            }
            
            // verify the required parameter 'field' is set
            if (field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PutField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PutField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (insertBeforeNode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=\[insertBeforeNode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "insertBeforeNode" + "]", apiInvoker.ToPathValue(insertBeforeNode));
            }
                        postBody = field; // http body (model) parameter
            try 
            {                
                if(typeof(FieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as FieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FieldResponse)ApiInvoker.deserialize(response, typeof(FieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="footnoteDto"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>FootnoteResponse</returns>            
        public FootnoteResponse PutFootnote (string name, FootnoteDto footnoteDto, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/footnotes?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (footnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PutFootnote");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PutFootnote");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = footnoteDto; // http body (model) parameter
            try 
            {                
                if(typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FootnoteResponse)ApiInvoker.deserialize(response, typeof(FootnoteResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="formField"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="insertBeforeNode"></param> 
        /// <returns>FormFieldResponse</returns>            
        public FormFieldResponse PutFormField (string name, FormField formField, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, string insertBeforeNode = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/formfields?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;insertBeforeNode=[insertBeforeNode]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (formField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PutFormField");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PutFormField");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (insertBeforeNode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=\[insertBeforeNode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "insertBeforeNode" + "]", apiInvoker.ToPathValue(insertBeforeNode));
            }
                        postBody = formField; // http body (model) parameter
            try 
            {                
                if(typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (FormFieldResponse)ApiInvoker.deserialize(response, typeof(FormFieldResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="headerFooterType"></param> 
        /// <param name="sectionPath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>HeaderFooterResponse</returns>            
        public HeaderFooterResponse PutHeaderFooter (string name, string headerFooterType, string sectionPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterType' is set
            if (headerFooterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling PutHeaderFooter");
            }
            
            // verify the required parameter 'sectionPath' is set
            if (sectionPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionPath' when calling PutHeaderFooter");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionPath == null || string.IsNullOrEmpty(sectionPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionPath" + "}", apiInvoker.ToPathValue(sectionPath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = headerFooterType; // http body (model) parameter
            try 
            {                
                if(typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (HeaderFooterResponse)ApiInvoker.deserialize(response, typeof(HeaderFooterResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraph"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="insertBeforeNode"></param> 
        /// <returns>ParagraphResponse</returns>            
        public ParagraphResponse PutParagraph (string name, ParagraphInsertDto paragraph, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, string insertBeforeNode = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/paragraphs?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;insertBeforeNode=[insertBeforeNode]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutParagraph");
            }
            
            // verify the required parameter 'paragraph' is set
            if (paragraph == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraph' when calling PutParagraph");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling PutParagraph");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (insertBeforeNode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=\[insertBeforeNode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "insertBeforeNode" + "]", apiInvoker.ToPathValue(insertBeforeNode));
            }
                        postBody = paragraph; // http body (model) parameter
            try 
            {                
                if(typeof(ParagraphResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as ParagraphResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ParagraphResponse)ApiInvoker.deserialize(response, typeof(ParagraphResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="protectionRequest"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>ProtectionDataResponse</returns>            
        public ProtectionDataResponse PutProtectDocument (string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutProtectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PutProtectDocument");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if(typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (ProtectionDataResponse)ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="paragraphPath"></param> 
        /// <param name="run"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="insertBeforeNode"></param> 
        /// <returns>RunResponse</returns>            
        public RunResponse PutRun (string name, string paragraphPath, Run run, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null, string insertBeforeNode = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{paragraphPath}/runs?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]&amp;insertBeforeNode=[insertBeforeNode]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PutRun");
            }
            
            // verify the required parameter 'run' is set
            if (run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PutRun");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (paragraphPath == null || string.IsNullOrEmpty(paragraphPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "paragraphPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "paragraphPath" + "}", apiInvoker.ToPathValue(paragraphPath));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (insertBeforeNode == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=\[insertBeforeNode\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "insertBeforeNode" + "]", apiInvoker.ToPathValue(insertBeforeNode));
            }
                        postBody = run; // http body (model) parameter
            try 
            {                
                if(typeof(RunResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as RunResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RunResponse)ApiInvoker.deserialize(response, typeof(RunResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="property"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentPropertyResponse</returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty (string name, string propertyName, DocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutUpdateDocumentProperty");
            }
            
            // verify the required parameter 'property' is set
            if (property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling PutUpdateDocumentProperty");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (propertyName == null || string.IsNullOrEmpty(propertyName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "propertyName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = property; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentPropertyResponse)ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="propertyName"></param> 
        /// <param name="property"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>DocumentPropertyResponse</returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty_2 (string name, string propertyName, DocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateDocumentProperty_2");
            }
            
            // verify the required parameter 'propertyName' is set
            if (propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutUpdateDocumentProperty_2");
            }
            
            // verify the required parameter 'property' is set
            if (property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling PutUpdateDocumentProperty_2");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (propertyName == null || string.IsNullOrEmpty(propertyName.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "propertyName" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = property; // http body (model) parameter
            try 
            {                
                if(typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (DocumentPropertyResponse)ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>RevisionsModificationResponse</returns>            
        public RevisionsModificationResponse RejectAllRevisions (string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/revisions/rejectAll?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RejectAllRevisions");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                                    try 
            {                
                if(typeof(RevisionsModificationResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as RevisionsModificationResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (RevisionsModificationResponse)ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream RenderDrawingObject (string name, string format, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/render?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream RenderMathObject (string name, string format, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}/render?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderMathObject");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderMathObject");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling RenderMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObject");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="pageIndex"></param> 
        /// <param name="format"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream RenderPage (string name, int? pageIndex, string format, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/pages/{pageIndex}/render?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderPage");
            }
            
            // verify the required parameter 'pageIndex' is set
            if (pageIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageIndex' when calling RenderPage");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderPage");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (pageIndex == null || string.IsNullOrEmpty(pageIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "pageIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "pageIndex" + "}", apiInvoker.ToPathValue(pageIndex));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream RenderParagraph (string name, string format, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/paragraphs/{index}/render?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderParagraph");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderParagraph");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling RenderParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraph");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream RenderTable (string name, string format, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables/{index}/render?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;format=[format]&amp;fontsLocation=[fontsLocation]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderTable");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderTable");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling RenderTable");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTable");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (format == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=\[format\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "format" + "]", apiInvoker.ToPathValue(format));
            }
            if (fontsLocation == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])fontsLocation=\[fontsLocation\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "fontsLocation" + "]", apiInvoker.ToPathValue(fontsLocation));
            }
                                    try 
            {                
                if(typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (System.IO.Stream)ApiInvoker.deserialize(response, typeof(System.IO.Stream));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns>SaaSposeResponse</returns>            
        public SaaSposeResponse ResetCache ()
        {
            // create path and map variables
            var ResourcePath = "/words/fonts/cache?appSid={appSid}";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
                                    try 
            {                
                if(typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SaaSposeResponse)ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="pattern"></param> 
        /// <returns>SearchResponse</returns>            
        public SearchResponse Search (string name, string storage = null, string folder = null, string loadEncoding = null, string password = null, string pattern = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/search?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;pattern=[pattern]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling Search");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
            if (pattern == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])pattern=\[pattern\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "pattern" + "]", apiInvoker.ToPathValue(pattern));
            }
                                    try 
            {                
                if(typeof(SearchResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams) as SearchResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SearchResponse)ApiInvoker.deserialize(response, typeof(SearchResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="borderProperties"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>BorderResponse</returns>            
        public BorderResponse UpdateBorder (string name, Border borderProperties, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBorder");
            }
            
            // verify the required parameter 'borderProperties' is set
            if (borderProperties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderProperties' when calling UpdateBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling UpdateBorder");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateBorder");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = borderProperties; // http body (model) parameter
            try 
            {                
                if(typeof(BorderResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as BorderResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (BorderResponse)ApiInvoker.deserialize(response, typeof(BorderResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="sectionIndex"></param> 
        /// <param name="pageSetup"></param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>SectionPageSetupResponse</returns>            
        public SectionPageSetupResponse UpdateSectionPageSetup (string name, int? sectionIndex, PageSetup pageSetup, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'pageSetup' is set
            if (pageSetup == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageSetup' when calling UpdateSectionPageSetup");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (sectionIndex == null || string.IsNullOrEmpty(sectionIndex.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "sectionIndex" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = pageSetup; // http body (model) parameter
            try 
            {                
                if(typeof(SectionPageSetupResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as SectionPageSetupResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (SectionPageSetupResponse)ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="tableRowPath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableCellFormatResponse</returns>            
        public TableCellFormatResponse UpdateTableCellFormat (string name, TableCellFormatDto format, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tableRowPath}/cells/{index}/cellformat?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableCellFormat");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tableRowPath == null || string.IsNullOrEmpty(tableRowPath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tableRowPath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tableRowPath" + "}", apiInvoker.ToPathValue(tableRowPath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = format; // http body (model) parameter
            try 
            {                
                if(typeof(TableCellFormatResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as TableCellFormatResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableCellFormatResponse)ApiInvoker.deserialize(response, typeof(TableCellFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="properties"></param> 
        /// <param name="nodePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TablePropertiesResponse</returns>            
        public TablePropertiesResponse UpdateTableProperties (string name, TablePropertiesDto properties, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{nodePath}/tables/{index}/properties?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'properties' is set
            if (properties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'nodePath' is set
            if (nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableProperties");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (nodePath == null || string.IsNullOrEmpty(nodePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "nodePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "nodePath" + "}", apiInvoker.ToPathValue(nodePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = properties; // http body (model) parameter
            try 
            {                
                if(typeof(TablePropertiesResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as TablePropertiesResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TablePropertiesResponse)ApiInvoker.deserialize(response, typeof(TablePropertiesResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param> 
        /// <param name="format"></param> 
        /// <param name="tablePath"></param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns>TableRowFormatResponse</returns>            
        public TableRowFormatResponse UpdateTableRowFormat (string name, TableRowFormatDto format, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var ResourcePath = "/words/{name}/{tablePath}/rows/{index}/rowformat?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            ResourcePath = Regex
                        .Replace(ResourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            // query params
            var queryParams = new Dictionary<string, string>();
            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;
            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'format' is set
            if (format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableRowFormat");
            }
            
            if (name == null || string.IsNullOrEmpty(name.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "name" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name));
            }
            if (tablePath == null || string.IsNullOrEmpty(tablePath.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "tablePath" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "tablePath" + "}", apiInvoker.ToPathValue(tablePath));
            }
            if (index == null || string.IsNullOrEmpty(index.ToString())) 
            {                
                 ResourcePath = ResourcePath.Replace("/{" + "index" + "}", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index));
            }
            if (destFileName == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=\[destFileName\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "destFileName" + "]", apiInvoker.ToPathValue(destFileName));
            }
            if (storage == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=\[storage\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "storage" + "]", apiInvoker.ToPathValue(storage));
            }
            if (folder == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=\[folder\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "folder" + "]", apiInvoker.ToPathValue(folder));
            }
            if (loadEncoding == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])loadEncoding=\[loadEncoding\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "loadEncoding" + "]", apiInvoker.ToPathValue(loadEncoding));
            }
            if (revisionAuthor == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionAuthor=\[revisionAuthor\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionAuthor" + "]", apiInvoker.ToPathValue(revisionAuthor));
            }
            if (revisionDateTime == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])revisionDateTime=\[revisionDateTime\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "revisionDateTime" + "]", apiInvoker.ToPathValue(revisionDateTime));
            }
            if (password == null) 
            {
                ResourcePath = Regex.Replace(ResourcePath, @"([&?])password=\[password\]", string.Empty);
            } 
            else 
            {
                ResourcePath = ResourcePath.Replace("[" + "password" + "]", apiInvoker.ToPathValue(password));
            }
                        postBody = format; // http body (model) parameter
            try 
            {                
                if(typeof(TableRowFormatResponse) == typeof(Stream)) 
                {
                    return apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams) as TableRowFormatResponse;
                }
               
                var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, postBody, headerParams, formParams);
                if(response != null)
                {
                    return (TableRowFormatResponse)ApiInvoker.deserialize(response, typeof(TableRowFormatResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

    }
}
