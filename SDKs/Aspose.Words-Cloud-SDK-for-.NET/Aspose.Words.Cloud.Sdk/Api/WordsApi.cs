using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Aspose.Words.Cloud.Sdk.Model;

namespace Aspose.Words.Cloud.Sdk.Api
{
    public class WordsApi
    {        
        private readonly string basePath;
        private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();        

        public WordsApi(string apiKey, string appSid, string basePath)
        {
            this.apiInvoker.AddAuthInfo(apiKey, appSid);
            this.basePath = basePath;
        }               

        /// <summary>
        /// Accept all revisions in document 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse AcceptAllRevisions(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/revisions/acceptAll?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(RevisionsModificationResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as RevisionsModificationResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
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
        /// Resets border properties to default values. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node with border(node should be cell or row).</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse DeleteBorder(string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BorderResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as BorderResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
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
        /// Resets borders properties to default values. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node with borders(node should be cell or row).</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse DeleteBorders(string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/borders?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BordersResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as BordersResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BordersResponse)SerializationHelper.Deserialize(response, typeof(BordersResponse));
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
        /// Remove comment from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="commentIndex">Comment index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteComment(string name, int? commentIndex, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Remove macros from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDocumentMacros(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/macros?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentMacros");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete document property. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDocumentProperty(string name, string propertyName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete watermark (for deleting last watermark from the document). 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse DeleteDocumentWatermark(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/watermark?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentWatermark");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Removes drawing object from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDrawingObject(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete field from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteField(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Remove fields from section paragraph. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFields(string name, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Removes footnote from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFootnote(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Removes form field from document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node that contains collection of formfields.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFormField(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete header/footer from document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="sectionPath">Path to parent section.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteHeaderFooter(string name, int? index, string sectionPath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{sectionPath}/headersfooters/{index}?appSid={appSid}&amp;sectionPath=[sectionPath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeaderFooter");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete document headers and footers. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="sectionPath">Path to parent section.</param> 
        /// <param name="headersFootersTypes">List of types of headers and footers.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteHeadersFooters(string name, string sectionPath = null, string headersFootersTypes = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;sectionPath=[sectionPath]&amp;headersFootersTypes=[headersFootersTypes]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeadersFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "headersFootersTypes", headersFootersTypes);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Removes OfficeMath object from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of OfficeMath objects.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteOfficeMathObject(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Remove paragraph from section. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node which contains paragraphs.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteParagraph(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/paragraphs/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Removes run from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteRun(string name, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete a table. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTable(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete a table cell. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tableRowPath">Path to table row.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTableCell(string name, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tableRowPath}/cells/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Delete a table row. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tablePath">Path to table.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTableRow(string name, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tablePath}/rows/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Unprotect document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse DeleteUnprotectDocument(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if (typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
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
        /// Return a border. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node with border(node should be cell or row).</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse GetBorder(string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BorderResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as BorderResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
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
        /// Return a collection of borders. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node with borders(node should be cell or row).</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse GetBorders(string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/borders?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BordersResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as BordersResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BordersResponse)SerializationHelper.Deserialize(response, typeof(BordersResponse));
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
        /// Get comment from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="commentIndex">Comment index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse GetComment(string name, int? commentIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(CommentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as CommentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
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
        /// Get comments from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="CommentsResponse"/></returns>            
        public CommentsResponse GetComments(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/comments?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComments");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(CommentsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as CommentsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (CommentsResponse)SerializationHelper.Deserialize(response, typeof(CommentsResponse));
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
        /// Read document common info. 
        /// </summary>
        /// <param name="documentName">The file name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse GetDocument(string documentName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{documentName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'documentName' is set
            if (documentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling GetDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "documentName", documentName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Read document bookmark data by its name. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="bookmarkName">The bookmark name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse GetDocumentBookmarkByName(string name, string bookmarkName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/bookmarks/{bookmarkName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", bookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BookmarkResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as BookmarkResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BookmarkResponse)SerializationHelper.Deserialize(response, typeof(BookmarkResponse));
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
        /// Read document bookmarks common info. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BookmarksResponse"/></returns>            
        public BookmarksResponse GetDocumentBookmarks(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/bookmarks?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(BookmarksResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as BookmarksResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BookmarksResponse)SerializationHelper.Deserialize(response, typeof(BookmarksResponse));
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
        /// Read document drawing object common info by its index or convert to format specified. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndex");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndex");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
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
        /// Read drawing object image data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectImageData(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/imageData?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageData");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Get drawing object OLE data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectOleData(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/oleData?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleData");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Read document drawing objects common info. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DrawingObjectsResponse"/></returns>            
        public DrawingObjectsResponse GetDocumentDrawingObjects(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DrawingObjectsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as DrawingObjectsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DrawingObjectsResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectsResponse));
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
        /// Read document field names. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="useNonMergeFields">If true, result includes \&quot;mustache\&quot; field names.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse GetDocumentFieldNames(string name, bool? useNonMergeFields = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/mailMergeFieldNames?appSid={appSid}&amp;useNonMergeFields=[useNonMergeFields]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFieldNames");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", useNonMergeFields);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FieldNamesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FieldNamesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldNamesResponse)SerializationHelper.Deserialize(response, typeof(FieldNamesResponse));
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
        /// Read document hyperlink by its index. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="hyperlinkIndex">The hyperlink index.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HyperlinkResponse"/></returns>            
        public HyperlinkResponse GetDocumentHyperlinkByIndex(string name, int? hyperlinkIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/hyperlinks/{hyperlinkIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "hyperlinkIndex", hyperlinkIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(HyperlinkResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as HyperlinkResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HyperlinkResponse)SerializationHelper.Deserialize(response, typeof(HyperlinkResponse));
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
        /// Read document hyperlinks common info. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HyperlinksResponse"/></returns>            
        public HyperlinksResponse GetDocumentHyperlinks(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/hyperlinks?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(HyperlinksResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as HyperlinksResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HyperlinksResponse)SerializationHelper.Deserialize(response, typeof(HyperlinksResponse));
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
        /// This resource represents one of the paragraphs contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node which contains paragraphs.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse GetDocumentParagraph(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/paragraphs/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(ParagraphResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as ParagraphResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ParagraphResponse)SerializationHelper.Deserialize(response, typeof(ParagraphResponse));
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
        /// This resource represents run of text contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse GetDocumentParagraphRun(string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(RunResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as RunResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
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
        /// This resource represents font of run. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse GetDocumentParagraphRunFont(string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs/{index}/font?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FontResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FontResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FontResponse)SerializationHelper.Deserialize(response, typeof(FontResponse));
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
        /// This resource represents collection of runs in the paragraph. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RunsResponse"/></returns>            
        public RunsResponse GetDocumentParagraphRuns(string name, string paragraphPath, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(RunsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as RunsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RunsResponse)SerializationHelper.Deserialize(response, typeof(RunsResponse));
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
        /// Return a list of paragraphs that are contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node which contains paragraphs.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ParagraphLinkCollectionResponse"/></returns>            
        public ParagraphLinkCollectionResponse GetDocumentParagraphs(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/paragraphs?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphs");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(ParagraphLinkCollectionResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as ParagraphLinkCollectionResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ParagraphLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(ParagraphLinkCollectionResponse));
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
        /// Read document properties info. 
        /// </summary>
        /// <param name="name">The document&#39;s name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse GetDocumentProperties(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/documentProperties?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DocumentPropertiesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as DocumentPropertiesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentPropertiesResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertiesResponse));
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
        /// Read document property info by the property name. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse GetDocumentProperty(string name, string propertyName, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
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
        /// Read document protection common info. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse GetDocumentProtection(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/protection?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProtection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
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
        /// Read document statistics. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="includeComments">Support including/excluding comments from the WordCount. Default value is \&quot;true\&quot;.</param> 
        /// <param name="includeFootnotes">Support including/excluding footnotes from the WordCount. Default value is \&quot;false\&quot;.</param> 
        /// <param name="includeTextInShapes">Support including/excluding shape&#39;s text from the WordCount. Default value is \&quot;false\&quot;</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="StatDataResponse"/></returns>            
        public StatDataResponse GetDocumentStatistics(string name, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/statistics?appSid={appSid}&amp;includeComments=[includeComments]&amp;includeFootnotes=[includeFootnotes]&amp;includeTextInShapes=[includeTextInShapes]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentStatistics");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "includeComments", includeComments);
            resourcePath = this.AddQueryParameter(resourcePath, "includeFootnotes", includeFootnotes);
            resourcePath = this.AddQueryParameter(resourcePath, "includeTextInShapes", includeTextInShapes);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(StatDataResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as StatDataResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (StatDataResponse)SerializationHelper.Deserialize(response, typeof(StatDataResponse));
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
        /// Read document text items. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TextItemsResponse"/></returns>            
        public TextItemsResponse GetDocumentTextItems(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/textItems?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentTextItems");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TextItemsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TextItemsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TextItemsResponse)SerializationHelper.Deserialize(response, typeof(TextItemsResponse));
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
        /// Export the document into the specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="outPath">Path to save result</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentWithFormat(string name, string format, string outPath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}?appSid={appSid}&amp;format=[format]&amp;outPath=[outPath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", outPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Get field from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse GetField(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
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
        /// Get fields from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FieldsResponse"/></returns>            
        public FieldsResponse GetFields(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FieldsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FieldsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldsResponse)SerializationHelper.Deserialize(response, typeof(FieldsResponse));
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
        /// Read footnote by index. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse GetFootnote(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
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
        /// Get footnotes from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FootnotesResponse"/></returns>            
        public FootnotesResponse GetFootnotes(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/footnotes?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotes");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FootnotesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FootnotesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FootnotesResponse)SerializationHelper.Deserialize(response, typeof(FootnotesResponse));
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
        /// Returns representation of an one of the form field. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node that contains collection of formfields.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse GetFormField(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormField");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
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
        /// Get form fields from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="nodePath">Path to node containing collection of form fields.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FormFieldsResponse"/></returns>            
        public FormFieldsResponse GetFormFields(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/formfields?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(FormFieldsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as FormFieldsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FormFieldsResponse)SerializationHelper.Deserialize(response, typeof(FormFieldsResponse));
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
        /// Return a header/footer that is contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="headerFooterIndex">Header/footer index.</param> 
        /// <param name="sectionIndex">Section index.</param> 
        /// <param name="filterByType">List of types of headers and footers.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter(string name, int? headerFooterIndex, int? sectionIndex, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/sections/{sectionIndex}/headersfooters/{headerFooterIndex}?appSid={appSid}&amp;filterByType=[filterByType]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", headerFooterIndex);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
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
        /// Return a header/footer that is contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="headerFooterIndex">Header/footer index.</param> 
        /// <param name="sectionIndex">Section index.</param> 
        /// <param name="filterByType">List of types of headers and footers.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter_1(string name, int? headerFooterIndex, int? sectionIndex = null, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/headersfooters/{headerFooterIndex}?appSid={appSid}&amp;sectionIndex=[sectionIndex]&amp;filterByType=[filterByType]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", headerFooterIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
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
        /// Return a list of header/footers that are contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="sectionPath">Path to parent section.</param> 
        /// <param name="filterByType">List of types of headers and footers.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HeaderFootersResponse"/></returns>            
        public HeaderFootersResponse GetHeaderFooters(string name, string sectionPath = null, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;sectionPath=[sectionPath]&amp;filterByType=[filterByType]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(HeaderFootersResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as HeaderFootersResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HeaderFootersResponse)SerializationHelper.Deserialize(response, typeof(HeaderFootersResponse));
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
        /// Read OfficeMath object by index. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of OfficeMath objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="OfficeMathObjectResponse"/></returns>            
        public OfficeMathObjectResponse GetOfficeMathObject(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(OfficeMathObjectResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as OfficeMathObjectResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (OfficeMathObjectResponse)SerializationHelper.Deserialize(response, typeof(OfficeMathObjectResponse));
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
        /// Get OfficeMath objects from document. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="nodePath">Path to node, which contains collection of OfficeMath objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="OfficeMathObjectsResponse"/></returns>            
        public OfficeMathObjectsResponse GetOfficeMathObjects(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/OfficeMathObjects?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(OfficeMathObjectsResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as OfficeMathObjectsResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (OfficeMathObjectsResponse)SerializationHelper.Deserialize(response, typeof(OfficeMathObjectsResponse));
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
        /// Get document section by index. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="sectionIndex">Section index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SectionResponse"/></returns>            
        public SectionResponse GetSection(string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/sections/{sectionIndex}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SectionResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as SectionResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SectionResponse)SerializationHelper.Deserialize(response, typeof(SectionResponse));
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
        /// Get page setup of section. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="sectionIndex">Section index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse GetSectionPageSetup(string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SectionPageSetupResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as SectionPageSetupResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SectionPageSetupResponse)SerializationHelper.Deserialize(response, typeof(SectionPageSetupResponse));
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
        /// Return a list of sections that are contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SectionLinkCollectionResponse"/></returns>            
        public SectionLinkCollectionResponse GetSections(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/sections?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SectionLinkCollectionResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as SectionLinkCollectionResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SectionLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(SectionLinkCollectionResponse));
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
        /// Return a table. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse GetTable(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTable");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
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
        /// Return a table cell. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tableRowPath">Path to table row.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse GetTableCell(string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tableRowPath}/cells/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableCellResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableCellResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableCellResponse)SerializationHelper.Deserialize(response, typeof(TableCellResponse));
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
        /// Return a table cell format. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tableRowPath">Path to table row.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse GetTableCellFormat(string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tableRowPath}/cells/{index}/cellformat?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableCellFormatResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableCellFormatResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableCellFormatResponse)SerializationHelper.Deserialize(response, typeof(TableCellFormatResponse));
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
        /// Return a table properties. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse GetTableProperties(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables/{index}/properties?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TablePropertiesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TablePropertiesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
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
        /// Return a table row. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tablePath">Path to table.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse GetTableRow(string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tablePath}/rows/{index}?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableRowResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableRowResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableRowResponse)SerializationHelper.Deserialize(response, typeof(TableRowResponse));
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
        /// Return a table row format. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="tablePath">Path to table.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse GetTableRowFormat(string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tablePath}/rows/{index}/rowformat?appSid={appSid}&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableRowFormatResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableRowFormatResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableRowFormatResponse)SerializationHelper.Deserialize(response, typeof(TableRowFormatResponse));
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
        /// Return a list of tables that are contained in the document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableLinkCollectionResponse"/></returns>            
        public TableLinkCollectionResponse GetTables(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables?appSid={appSid}&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTables");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(TableLinkCollectionResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as TableLinkCollectionResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableLinkCollectionResponse)SerializationHelper.Deserialize(response, typeof(TableLinkCollectionResponse));
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
        /// Adds table to document, returns added table&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="table">Table parameters/</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse InsertTable(string name, TableInsert table, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = table; // http body (model) parameter
            try 
            {                
                if (typeof(TableResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as TableResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableResponse)SerializationHelper.Deserialize(response, typeof(TableResponse));
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
        /// Adds table cell to table, returns added cell&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="cell">Table cell parameters/</param> 
        /// <param name="tableRowPath">Path to table row.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse InsertTableCell(string name, TableCellInsert cell, string tableRowPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tableRowPath}/cells?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", tableRowPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = cell; // http body (model) parameter
            try 
            {                
                if (typeof(TableCellResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as TableCellResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableCellResponse)SerializationHelper.Deserialize(response, typeof(TableCellResponse));
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
        /// Adds table row to table, returns added row&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="row">Table row parameters/</param> 
        /// <param name="tablePath">Path to table.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse InsertTableRow(string name, TableRowInsert row, string tablePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tablePath}/rows?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", tablePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = row; // http body (model) parameter
            try 
            {                
                if (typeof(TableRowResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as TableRowResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableRowResponse)SerializationHelper.Deserialize(response, typeof(TableRowResponse));
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
        /// Append documents to original document. 
        /// </summary>
        /// <param name="name">Original document name.</param> 
        /// <param name="documentList">{Aspose.Words.Cloud.DTO.DocumentEntryList} with a list of documents to append.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostAppendDocument(string name, DocumentEntryList documentList, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/appendDocument?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = documentList; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Change document protection. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PostChangeDocumentProtection(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if (typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
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
        /// Updates the comment, returns updated comment&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="commentIndex">Comment index</param> 
        /// <param name="comment">Comment data.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PostComment(string name, int? commentIndex, Comment comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = comment; // http body (model) parameter
            try 
            {                
                if (typeof(CommentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as CommentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
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
        /// Compare document with original document. 
        /// </summary>
        /// <param name="name">Original document name.</param> 
        /// <param name="compareData">{Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostCompareDocument(string name, CompareData compareData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/compareDocument?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = compareData; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Execute document mail merge operation. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="withRegions">With regions flag.</param> 
        /// <param name="data">Mail merge data</param> 
        /// <param name="mailMergeDataFile">Mail merge data.</param> 
        /// <param name="cleanup">Clean up options.</param> 
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostDocumentExecuteMailMerge(string name, bool? withRegions, string data = null, string mailMergeDataFile = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/executeMailMerge/{withRegions}?appSid={appSid}&amp;mailMergeDataFile=[mailMergeDataFile]&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "withRegions", withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "mailMergeDataFile", mailMergeDataFile);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            if (data != null) 
            {
                formParams.Add("data", data); // form parameter
            }
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Updates font properties, returns updated font data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="fontDto">Font dto object</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse PostDocumentParagraphRunFont(string name, Font fontDto, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs/{index}/font?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = fontDto; // http body (model) parameter
            try 
            {                
                if (typeof(FontResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as FontResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FontResponse)SerializationHelper.Deserialize(response, typeof(FontResponse));
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
        /// Convert document to destination format with detailed settings and save result to storage. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="saveOptionsData">Save options.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostDocumentSaveAs(string name, SaveOptionsData saveOptionsData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/saveAs?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            postBody = saveOptionsData; // http body (model) parameter
            try 
            {                
                if (typeof(SaveResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as SaveResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
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
        /// Updates drawing object, returns updated  drawing object&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="drawingObject">Drawing object parameters</param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PostDrawingObject(string name, string drawingObject, System.IO.Stream imageFile, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            if (drawingObject != null) 
            {
                formParams.Add("drawingObject", drawingObject); // form parameter
            }
            if (imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if (typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
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
        /// Populate document template with data. 
        /// </summary>
        /// <param name="name">The template document name.</param> 
        /// <param name="data">Mail merge data</param> 
        /// <param name="cleanup">Clean up options.</param> 
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or   TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.    The default value is true.</param> 
        /// <param name="withRegions">Merge with regions or not. True by default</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostExecuteTemplate(string name, string data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/executeTemplate?appSid={appSid}&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;withRegions=[withRegions]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            if (data != null) 
            {
                formParams.Add("data", data); // form parameter
            }
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Updates field&#39;s properties, returns updated field&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="field">Field data.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PostField(string name, Field field, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = field; // http body (model) parameter
            try 
            {                
                if (typeof(FieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as FieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
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
        /// Updates footnote&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="footnoteDto">Footnote data.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PostFootnote(string name, Footnote footnoteDto, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/footnotes/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = footnoteDto; // http body (model) parameter
            try 
            {                
                if (typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
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
        /// Updates properties of form field, returns updated form field. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="formField">From field data.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node that contains collection of formfields.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PostFormField(string name, FormField formField, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/formfields/{index}?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = formField; // http body (model) parameter
            try 
            {                
                if (typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
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
        /// Insert document watermark image. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="rotationAngle">The watermark rotation angle.</param> 
        /// <param name="image">The image file server full name. If the name is empty the image is expected in request content.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkImage(string name, System.IO.Stream imageFile = null, double? rotationAngle = null, string image = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/watermark/insertImage?appSid={appSid}&amp;rotationAngle=[rotationAngle]&amp;image=[image]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkImage");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "rotationAngle", rotationAngle);
            resourcePath = this.AddQueryParameter(resourcePath, "image", image);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            if (imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Insert document watermark text. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="watermarkText">{Aspose.Words.Cloud.DTO.WatermarkText} with the watermark data.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkText(string name, WatermarkText watermarkText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/watermark/insertText?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = watermarkText; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Insert document page numbers. 
        /// </summary>
        /// <param name="name">A document name.</param> 
        /// <param name="pageNumber">{Aspose.Words.Cloud.DTO.PageNumber} with the page numbers settings.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertPageNumbers(string name, PageNumber pageNumber, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/insertPageNumbers?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = pageNumber; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Loads new document from web into the file with any supported format of data. 
        /// </summary>
        /// <param name="data">Parameters of loading.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostLoadWebDocument(LoadWebDocumentData data, string storage = null)
        {
            // create path and map variables
            var resourcePath = "/words/loadWebDocument?appSid={appSid}&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'data' is set
            if (data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebDocument");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            postBody = data; // http body (model) parameter
            try 
            {                
                if (typeof(SaveResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as SaveResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
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
        /// Replace document text. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="replaceText">{Aspose.Words.Cloud.DTO.Replace.ReplaceTextResponse} with the replace operation settings.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ReplaceTextResponse"/></returns>            
        public ReplaceTextResponse PostReplaceText(string name, ReplaceTextRequest replaceText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/replaceText?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = replaceText; // http body (model) parameter
            try 
            {                
                if (typeof(ReplaceTextResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as ReplaceTextResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ReplaceTextResponse)SerializationHelper.Deserialize(response, typeof(ReplaceTextResponse));
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
        /// Updates run&#39;s properties, returns updated run&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="run">Run data.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PostRun(string name, Run run, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = run; // http body (model) parameter
            try 
            {                
                if (typeof(RunResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as RunResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
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
        /// Run tasks 
        /// </summary>
        /// <returns><see cref="Object"/></returns>            
        public Object PostRunTask()
        {
            // create path and map variables
            var resourcePath = "/words/tasks?appSid={appSid}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            
            try 
            {                
                if (typeof(Object) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as Object;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (Object)SerializationHelper.Deserialize(response, typeof(Object));
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
        /// Split document. 
        /// </summary>
        /// <param name="name">Original document name.</param> 
        /// <param name="format">Format to split.</param> 
        /// <param name="from">Start page.</param> 
        /// <param name="to">End page.</param> 
        /// <param name="zipOutput">ZipOutput or not.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="SplitDocumentResponse"/></returns>            
        public SplitDocumentResponse PostSplitDocument(string name, string format = null, int? from = null, int? to = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/split?appSid={appSid}&amp;format=[format]&amp;from=[from]&amp;to=[to]&amp;zipOutput=[zipOutput]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSplitDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "from", from);
            resourcePath = this.AddQueryParameter(resourcePath, "to", to);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", zipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(SplitDocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as SplitDocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SplitDocumentResponse)SerializationHelper.Deserialize(response, typeof(SplitDocumentResponse));
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
        /// Update document bookmark. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="bookmarkData">{Aspose.Words.Cloud.DTO.DocumentElements.Bookmarks.BookmarkData} with new bookmark data.</param> 
        /// <param name="bookmarkName">The bookmark name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse PostUpdateDocumentBookmark(string name, BookmarkData bookmarkData, string bookmarkName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/bookmarks/{bookmarkName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", bookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = bookmarkData; // http body (model) parameter
            try 
            {                
                if (typeof(BookmarkResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as BookmarkResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BookmarkResponse)SerializationHelper.Deserialize(response, typeof(BookmarkResponse));
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
        /// Update (reevaluate) fields in document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostUpdateDocumentFields(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/updateFields?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Adds comment to document, returns inserted comment&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="comment">Comment data.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PutComment(string name, Comment comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/comments?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = comment; // http body (model) parameter
            try 
            {                
                if (typeof(CommentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as CommentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (CommentResponse)SerializationHelper.Deserialize(response, typeof(CommentResponse));
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
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <param name="format">Format to convert.</param> 
        /// <param name="document">Converting document</param> 
        /// <param name="outPath">Path for saving operation result to the local storage.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutConvertDocument(string format, System.IO.Stream document, string outPath = null, string storage = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/convert?appSid={appSid}&amp;format=[format]&amp;outPath=[outPath]&amp;storage=[storage]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", outPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            if (document != null) 
            {
                formParams.Add("document", this.apiInvoker.ToFileInfo(document, "document"));
            }
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Creates new document. 
        /// </summary>
        /// <param name="folder">The document folder.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutCreateDocument(string folder = null, string storage = null)
        {
            // create path and map variables
            var resourcePath = "/words/create?appSid={appSid}&amp;folder=[folder]&amp;storage=[storage]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            
            try 
            {                
                if (typeof(DocumentResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as DocumentResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentResponse)SerializationHelper.Deserialize(response, typeof(DocumentResponse));
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
        /// Read document field names. 
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="useNonMergeFields">Use non merge fields or not.</param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse PutDocumentFieldNames(System.IO.Stream template, bool? useNonMergeFields = null)
        {
            // create path and map variables
            var resourcePath = "/words/mailMergeFieldNames?appSid={appSid}&amp;useNonMergeFields=[useNonMergeFields]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'template' is set
            if (template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutDocumentFieldNames");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", useNonMergeFields);
            
            if (template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(template, "Template"));
            }
            try 
            {                
                if (typeof(FieldNamesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as FieldNamesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldNamesResponse)SerializationHelper.Deserialize(response, typeof(FieldNamesResponse));
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
        /// Convert document to tiff with detailed settings and save result to storage. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="saveOptions">Tiff save options.</param> 
        /// <param name="resultFile">The resulting file name.</param> 
        /// <param name="useAntiAliasing">Use antialiasing flag.</param> 
        /// <param name="useHighQualityRendering">Use high quality flag.</param> 
        /// <param name="imageBrightness">Brightness for the generated images.</param> 
        /// <param name="imageColorMode">Color mode for the generated images.</param> 
        /// <param name="imageContrast">The contrast for the generated images.</param> 
        /// <param name="numeralFormat">The images numeral format.</param> 
        /// <param name="pageCount">Number of pages to render.</param> 
        /// <param name="pageIndex">Page index to start rendering.</param> 
        /// <param name="paperColor">Background image color.</param> 
        /// <param name="pixelFormat">The pixel format of generated images.</param> 
        /// <param name="resolution">The resolution of generated images.</param> 
        /// <param name="scale">Zoom factor for generated images.</param> 
        /// <param name="tiffCompression">The compression tipe.</param> 
        /// <param name="dmlRenderingMode">Optional, default is Fallback.</param> 
        /// <param name="dmlEffectsRenderingMode">Optional, default is Simplified.</param> 
        /// <param name="tiffBinarizationMethod">Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.</param> 
        /// <param name="zipOutput">Optional. A value determining zip output or not.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PutDocumentSaveAsTiff(string name, TiffSaveOptionsData saveOptions, string resultFile = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, float? imageBrightness = null, string imageColorMode = null, float? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, float? resolution = null, float? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/saveAs/tiff?appSid={appSid}&amp;resultFile=[resultFile]&amp;useAntiAliasing=[useAntiAliasing]&amp;useHighQualityRendering=[useHighQualityRendering]&amp;imageBrightness=[imageBrightness]&amp;imageColorMode=[imageColorMode]&amp;imageContrast=[imageContrast]&amp;numeralFormat=[numeralFormat]&amp;pageCount=[pageCount]&amp;pageIndex=[pageIndex]&amp;paperColor=[paperColor]&amp;pixelFormat=[pixelFormat]&amp;resolution=[resolution]&amp;scale=[scale]&amp;tiffCompression=[tiffCompression]&amp;dmlRenderingMode=[dmlRenderingMode]&amp;dmlEffectsRenderingMode=[dmlEffectsRenderingMode]&amp;tiffBinarizationMethod=[tiffBinarizationMethod]&amp;zipOutput=[zipOutput]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "resultFile", resultFile);
            resourcePath = this.AddQueryParameter(resourcePath, "useAntiAliasing", useAntiAliasing);
            resourcePath = this.AddQueryParameter(resourcePath, "useHighQualityRendering", useHighQualityRendering);
            resourcePath = this.AddQueryParameter(resourcePath, "imageBrightness", imageBrightness);
            resourcePath = this.AddQueryParameter(resourcePath, "imageColorMode", imageColorMode);
            resourcePath = this.AddQueryParameter(resourcePath, "imageContrast", imageContrast);
            resourcePath = this.AddQueryParameter(resourcePath, "numeralFormat", numeralFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "pageCount", pageCount);
            resourcePath = this.AddQueryParameter(resourcePath, "pageIndex", pageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "paperColor", paperColor);
            resourcePath = this.AddQueryParameter(resourcePath, "pixelFormat", pixelFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "resolution", resolution);
            resourcePath = this.AddQueryParameter(resourcePath, "scale", scale);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffCompression", tiffCompression);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlRenderingMode", dmlRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlEffectsRenderingMode", dmlEffectsRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffBinarizationMethod", tiffBinarizationMethod);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", zipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            postBody = saveOptions; // http body (model) parameter
            try 
            {                
                if (typeof(SaveResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as SaveResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaveResponse)SerializationHelper.Deserialize(response, typeof(SaveResponse));
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
        /// Adds  drawing object to document, returns added  drawing object&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="drawingObject">Drawing object parameters</param> 
        /// <param name="imageFile">File with image</param> 
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PutDrawingObject(string name, string drawingObject, System.IO.Stream imageFile, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            if (drawingObject != null) 
            {
                formParams.Add("drawingObject", drawingObject); // form parameter
            }
            if (imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(imageFile, "imageFile"));
            }
            try 
            {                
                if (typeof(DrawingObjectResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as DrawingObjectResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DrawingObjectResponse)SerializationHelper.Deserialize(response, typeof(DrawingObjectResponse));
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
        /// Execute document mail merge online. 
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="data">File with mailmerge data</param> 
        /// <param name="withRegions">With regions flag.</param> 
        /// <param name="cleanup">Clean up options.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteMailMergeOnline(System.IO.Stream template, System.IO.Stream data, bool? withRegions = null, string cleanup = null)
        {
            // create path and map variables
            var resourcePath = "/words/executeMailMerge?appSid={appSid}&amp;withRegions=[withRegions]&amp;cleanup=[cleanup]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", cleanup);
            
            if (template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(template, "Template"));
            }
            if (data != null) 
            {
                formParams.Add("Data", this.apiInvoker.ToFileInfo(data, "Data"));
            }
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Populate document template with data online. 
        /// </summary>
        /// <param name="template">File with template</param> 
        /// <param name="data">File with mailmerge data</param> 
        /// <param name="cleanup">Clean up options.</param> 
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.</param> 
        /// <param name="withRegions">Merge with regions or not. True by default</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteTemplateOnline(System.IO.Stream template, System.IO.Stream data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null)
        {
            // create path and map variables
            var resourcePath = "/words/executeTemplate?appSid={appSid}&amp;cleanup=[cleanup]&amp;useWholeParagraphAsRegion=[useWholeParagraphAsRegion]&amp;withRegions=[withRegions]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", withRegions);
            
            if (template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(template, "Template"));
            }
            if (data != null) 
            {
                formParams.Add("Data", this.apiInvoker.ToFileInfo(data, "Data"));
            }
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Adds field to document, returns inserted field&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="field">Field data.</param> 
        /// <param name="nodePath">Path to node, which contains collection of fields.</param> 
        /// <param name="insertBeforeNode">Field will be inserted before node with id&#x3D;\&quot;nodeId\&quot;.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PutField(string name, Field field, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/fields?appSid={appSid}&amp;nodePath=[nodePath]&amp;insertBeforeNode=[insertBeforeNode]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = field; // http body (model) parameter
            try 
            {                
                if (typeof(FieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as FieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FieldResponse)SerializationHelper.Deserialize(response, typeof(FieldResponse));
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
        /// Adds footnote to document, returns added footnote&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="footnoteDto">Footnote data.</param> 
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PutFootnote(string name, Footnote footnoteDto, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/footnotes?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = footnoteDto; // http body (model) parameter
            try 
            {                
                if (typeof(FootnoteResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as FootnoteResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FootnoteResponse)SerializationHelper.Deserialize(response, typeof(FootnoteResponse));
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
        /// Adds form field to paragraph, returns added form field&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="formField">From field data.</param> 
        /// <param name="nodePath">Path to node that contains collection of formfields.</param> 
        /// <param name="insertBeforeNode">Form field will be inserted before node with index.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PutFormField(string name, FormField formField, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/formfields?appSid={appSid}&amp;nodePath=[nodePath]&amp;insertBeforeNode=[insertBeforeNode]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = formField; // http body (model) parameter
            try 
            {                
                if (typeof(FormFieldResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as FormFieldResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (FormFieldResponse)SerializationHelper.Deserialize(response, typeof(FormFieldResponse));
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
        /// Insert to document header or footer. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="headerFooterType">Type of header/footer.</param> 
        /// <param name="sectionPath">Path to parent section.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse PutHeaderFooter(string name, string headerFooterType, string sectionPath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{sectionPath}/headersfooters?appSid={appSid}&amp;sectionPath=[sectionPath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = headerFooterType; // http body (model) parameter
            try 
            {                
                if (typeof(HeaderFooterResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as HeaderFooterResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (HeaderFooterResponse)SerializationHelper.Deserialize(response, typeof(HeaderFooterResponse));
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
        /// Adds paragraph to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="paragraph">Paragraph data.</param> 
        /// <param name="nodePath">Path to node which contains paragraphs.</param> 
        /// <param name="insertBeforeNode">Paragraph will be inserted before node with index.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PutParagraph(string name, ParagraphInsert paragraph, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/paragraphs?appSid={appSid}&amp;nodePath=[nodePath]&amp;insertBeforeNode=[insertBeforeNode]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = paragraph; // http body (model) parameter
            try 
            {                
                if (typeof(ParagraphResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as ParagraphResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ParagraphResponse)SerializationHelper.Deserialize(response, typeof(ParagraphResponse));
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
        /// Protect document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PutProtectDocument(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/protection?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = protectionRequest; // http body (model) parameter
            try 
            {                
                if (typeof(ProtectionDataResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as ProtectionDataResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (ProtectionDataResponse)SerializationHelper.Deserialize(response, typeof(ProtectionDataResponse));
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
        /// Adds run to document, returns added paragraph&#39;s data. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="paragraphPath">Path to parent paragraph.</param> 
        /// <param name="run">Run data.</param> 
        /// <param name="insertBeforeNode">Paragraph will be inserted before node with index.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PutRun(string name, string paragraphPath, Run run, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{paragraphPath}/runs?appSid={appSid}&amp;insertBeforeNode=[insertBeforeNode]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", paragraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = run; // http body (model) parameter
            try 
            {                
                if (typeof(RunResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as RunResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RunResponse)SerializationHelper.Deserialize(response, typeof(RunResponse));
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
        /// Add new or update existing document property. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="property">The property with new value.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty(string name, string propertyName, DocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = property; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "PUT", null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "PUT", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
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
        /// Add new or update existing document property. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="propertyName">The property name.</param> 
        /// <param name="property">The property with new value.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty_2(string name, string propertyName, DocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/documentProperties/{propertyName}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = property; // http body (model) parameter
            try 
            {                
                if (typeof(DocumentPropertyResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as DocumentPropertyResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (DocumentPropertyResponse)SerializationHelper.Deserialize(response, typeof(DocumentPropertyResponse));
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
        /// Reject all revisions in document 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse RejectAllRevisions(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/revisions/rejectAll?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RejectAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(RevisionsModificationResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as RevisionsModificationResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (RevisionsModificationResponse)SerializationHelper.Deserialize(response, typeof(RevisionsModificationResponse));
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
        /// Renders drawing object to specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains drawing objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderDrawingObject(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/drawingObjects/{index}/render?appSid={appSid}&amp;format=[format]&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Renders math object to specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains office math objects.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderMathObject(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/OfficeMathObjects/{index}/render?appSid={appSid}&amp;format=[format]&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Renders page to specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="pageIndex">Comment index</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderPage(string name, int? pageIndex, string format, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/pages/{pageIndex}/render?appSid={appSid}&amp;format=[format]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "pageIndex", pageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Renders paragraph to specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains paragraphs.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderParagraph(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/paragraphs/{index}/render?appSid={appSid}&amp;format=[format]&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Renders table to specified format. 
        /// </summary>
        /// <param name="name">The file name.</param> 
        /// <param name="format">The destination format.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderTable(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables/{index}/render?appSid={appSid}&amp;format=[format]&amp;nodePath=[nodePath]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]&amp;fontsLocation=[fontsLocation]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", fontsLocation);
            
            try 
            {                
                if (typeof(System.IO.Stream) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as System.IO.Stream;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Resets font&#39;s cache. 
        /// </summary>
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse ResetCache()
        {
            // create path and map variables
            var resourcePath = "/words/fonts/cache?appSid={appSid}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            
            try 
            {                
                if (typeof(SaaSposeResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "DELETE", null, headerParams, formParams) as SaaSposeResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "DELETE", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SaaSposeResponse)SerializationHelper.Deserialize(response, typeof(SaaSposeResponse));
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
        /// Search text in document. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="pattern">The regular expression used to find matches.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SearchResponse"/></returns>            
        public SearchResponse Search(string name, string pattern = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/search?appSid={appSid}&amp;pattern=[pattern]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling Search");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddQueryParameter(resourcePath, "pattern", pattern);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            
            try 
            {                
                if (typeof(SearchResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "GET", null, headerParams, formParams) as SearchResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "GET", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SearchResponse)SerializationHelper.Deserialize(response, typeof(SearchResponse));
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
        /// Updates border properties. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="borderProperties">Border properties</param> 
        /// <param name="nodePath">Path to node with border(node should be cell or row).</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse UpdateBorder(string name, Border borderProperties, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/borders/{index}?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = borderProperties; // http body (model) parameter
            try 
            {                
                if (typeof(BorderResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as BorderResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (BorderResponse)SerializationHelper.Deserialize(response, typeof(BorderResponse));
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
        /// Update page setup of section. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="sectionIndex">Section index</param> 
        /// <param name="pageSetup">Page setup properties dto</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse UpdateSectionPageSetup(string name, int? sectionIndex, PageSetup pageSetup, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = pageSetup; // http body (model) parameter
            try 
            {                
                if (typeof(SectionPageSetupResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as SectionPageSetupResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (SectionPageSetupResponse)SerializationHelper.Deserialize(response, typeof(SectionPageSetupResponse));
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
        /// Updates a table cell format. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="format">The properties.</param> 
        /// <param name="tableRowPath">Path to table row.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse UpdateTableCellFormat(string name, TableCellFormat format, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tableRowPath}/cells/{index}/cellformat?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = format; // http body (model) parameter
            try 
            {                
                if (typeof(TableCellFormatResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as TableCellFormatResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableCellFormatResponse)SerializationHelper.Deserialize(response, typeof(TableCellFormatResponse));
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
        /// Updates a table properties. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="properties">The properties.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="nodePath">Path to node, which contains tables.</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse UpdateTableProperties(string name, TableProperties properties, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{nodePath}/tables/{index}/properties?appSid={appSid}&amp;nodePath=[nodePath]&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            // verify the required parameter 'index' is set
            if (index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = properties; // http body (model) parameter
            try 
            {                
                if (typeof(TablePropertiesResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as TablePropertiesResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TablePropertiesResponse)SerializationHelper.Deserialize(response, typeof(TablePropertiesResponse));
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
        /// Updates a table row format. 
        /// </summary>
        /// <param name="name">The document name.</param> 
        /// <param name="format">The properties.</param> 
        /// <param name="tablePath">Path to table.</param> 
        /// <param name="index">Object index</param> 
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param> 
        /// <param name="storage">File storage, which have to be used.</param> 
        /// <param name="folder">Original document folder.</param> 
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param> 
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param> 
        /// <param name="revisionDateTime">The date and time to use for revisions.</param> 
        /// <param name="password">Password for opening an encrypted document.</param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse UpdateTableRowFormat(string name, TableRowFormat format, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/{tablePath}/rows/{index}/rowformat?appSid={appSid}&amp;destFileName=[destFileName]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;revisionAuthor=[revisionAuthor]&amp;revisionDateTime=[revisionDateTime]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

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
            
            resourcePath = this.AddPathParameter(resourcePath, "name", name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", password);
            postBody = format; // http body (model) parameter
            try 
            {                
                if (typeof(TableRowFormatResponse) == typeof(Stream)) 
                {
                    return this.apiInvoker.InvokeBinaryApi(this.basePath, resourcePath, "POST", null, headerParams, formParams) as TableRowFormatResponse;
                }
               
                var response = this.apiInvoker.InvokeApi(this.basePath, resourcePath, "POST", postBody, headerParams, formParams);
                if (response != null)
                {
                    return (TableRowFormatResponse)SerializationHelper.Deserialize(response, typeof(TableRowFormatResponse));
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

        private string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", this.apiInvoker.ToPathValue(parameterValue));
            }

            return url;
        }

        private string AddQueryParameter(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {
                url = Regex.Replace(url, @"([&?])" + parameterName + @"=\[" + parameterName + @"\]", string.Empty);
                url = this.AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (parameterValue == null) 
            {
                url = Regex.Replace(url, @"([&?])" + parameterName + @"=\[" + parameterName + @"\]", string.Empty);
            } 
            else 
            {
                url = url.Replace("[" + parameterName + "]", this.apiInvoker.ToPathValue(parameterValue));
            }
          
            return url;
        }
    }
}
