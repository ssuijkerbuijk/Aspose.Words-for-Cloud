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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.AcceptAllRevisionsRequest" /></param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse AcceptAllRevisions(AcceptAllRevisionsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse DeleteBorder(DeleteBorderRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteBordersRequest" /></param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse DeleteBorders(DeleteBordersRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorders");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteCommentRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteComment(DeleteCommentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling DeleteComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteDocumentMacrosRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDocumentMacros(DeleteDocumentMacrosRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentMacros");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteDocumentPropertyRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteDocumentWatermarkRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse DeleteDocumentWatermark(DeleteDocumentWatermarkRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentWatermark");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteDrawingObjectRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteDrawingObject(DeleteDrawingObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteFieldRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteField(DeleteFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteFieldsRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFields(DeleteFieldsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteFootnoteRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFootnote(DeleteFootnoteRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteFormFieldRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteFormField(DeleteFormFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteHeaderFooterRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteHeaderFooter(DeleteHeaderFooterRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeaderFooter");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteHeadersFootersRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteHeadersFooters(DeleteHeadersFootersRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeadersFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "headersFootersTypes", request.headersFootersTypes);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteOfficeMathObjectRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteOfficeMathObject(DeleteOfficeMathObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteParagraphRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteParagraph(DeleteParagraphRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteRunRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteRun(DeleteRunRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling DeleteRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteTableRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTable(DeleteTableRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteTableCellRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTableCell(DeleteTableCellRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteTableRowRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse DeleteTableRow(DeleteTableRowRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.DeleteUnprotectDocumentRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse DeleteUnprotectDocument(DeleteUnprotectDocumentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnprotectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling DeleteUnprotectDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.protectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse GetBorder(GetBorderRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetBordersRequest" /></param> 
        /// <returns><see cref="BordersResponse"/></returns>            
        public BordersResponse GetBorders(GetBordersRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorders");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse GetComment(GetCommentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling GetComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetCommentsRequest" /></param> 
        /// <returns><see cref="CommentsResponse"/></returns>            
        public CommentsResponse GetComments(GetCommentsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComments");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse GetDocument(GetDocumentRequest request)
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
            if (request.documentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling GetDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "documentName", request.documentName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentBookmarkByNameRequest" /></param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse GetDocumentBookmarkByName(GetDocumentBookmarkByNameRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarkByName");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (request.bookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling GetDocumentBookmarkByName");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", request.bookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentBookmarksRequest" /></param> 
        /// <returns><see cref="BookmarksResponse"/></returns>            
        public BookmarksResponse GetDocumentBookmarks(GetDocumentBookmarksRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentDrawingObjectByIndexRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse GetDocumentDrawingObjectByIndex(GetDocumentDrawingObjectByIndexRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndex");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndex");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentDrawingObjectImageDataRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectImageData(GetDocumentDrawingObjectImageDataRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageData");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentDrawingObjectOleDataRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentDrawingObjectOleData(GetDocumentDrawingObjectOleDataRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleData");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentDrawingObjectsRequest" /></param> 
        /// <returns><see cref="DrawingObjectsResponse"/></returns>            
        public DrawingObjectsResponse GetDocumentDrawingObjects(GetDocumentDrawingObjectsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentFieldNamesRequest" /></param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse GetDocumentFieldNames(GetDocumentFieldNamesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFieldNames");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", request.useNonMergeFields);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentHyperlinkByIndexRequest" /></param> 
        /// <returns><see cref="HyperlinkResponse"/></returns>            
        public HyperlinkResponse GetDocumentHyperlinkByIndex(GetDocumentHyperlinkByIndexRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinkByIndex");
            }
            
            // verify the required parameter 'hyperlinkIndex' is set
            if (request.hyperlinkIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'hyperlinkIndex' when calling GetDocumentHyperlinkByIndex");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "hyperlinkIndex", request.hyperlinkIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentHyperlinksRequest" /></param> 
        /// <returns><see cref="HyperlinksResponse"/></returns>            
        public HyperlinksResponse GetDocumentHyperlinks(GetDocumentHyperlinksRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse GetDocumentParagraph(GetDocumentParagraphRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentParagraphRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse GetDocumentParagraphRun(GetDocumentParagraphRunRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentParagraphRunFontRequest" /></param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse GetDocumentParagraphRunFont(GetDocumentParagraphRunFontRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRunFont");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentParagraphRunsRequest" /></param> 
        /// <returns><see cref="RunsResponse"/></returns>            
        public RunsResponse GetDocumentParagraphRuns(GetDocumentParagraphRunsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRuns");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRuns");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentParagraphsRequest" /></param> 
        /// <returns><see cref="ParagraphLinkCollectionResponse"/></returns>            
        public ParagraphLinkCollectionResponse GetDocumentParagraphs(GetDocumentParagraphsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphs");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentProtectionRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse GetDocumentProtection(GetDocumentProtectionRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProtection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentStatisticsRequest" /></param> 
        /// <returns><see cref="StatDataResponse"/></returns>            
        public StatDataResponse GetDocumentStatistics(GetDocumentStatisticsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentStatistics");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "includeComments", request.includeComments);
            resourcePath = this.AddQueryParameter(resourcePath, "includeFootnotes", request.includeFootnotes);
            resourcePath = this.AddQueryParameter(resourcePath, "includeTextInShapes", request.includeTextInShapes);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentTextItemsRequest" /></param> 
        /// <returns><see cref="TextItemsResponse"/></returns>            
        public TextItemsResponse GetDocumentTextItems(GetDocumentTextItemsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentTextItems");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetDocumentWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDocumentWithFormat(GetDocumentWithFormatRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentWithFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetDocumentWithFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", request.outPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse GetField(GetFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFieldsRequest" /></param> 
        /// <returns><see cref="FieldsResponse"/></returns>            
        public FieldsResponse GetFields(GetFieldsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse GetFootnote(GetFootnoteRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFootnotesRequest" /></param> 
        /// <returns><see cref="FootnotesResponse"/></returns>            
        public FootnotesResponse GetFootnotes(GetFootnotesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotes");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse GetFormField(GetFormFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetFormFieldsRequest" /></param> 
        /// <returns><see cref="FormFieldsResponse"/></returns>            
        public FormFieldsResponse GetFormFields(GetFormFieldsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (request.headerFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", request.headerFooterIndex);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetHeaderFooter_1Request" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter_1(GetHeaderFooter_1Request request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter_1");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (request.headerFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter_1");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", request.headerFooterIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionIndex", request.sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetHeaderFootersRequest" /></param> 
        /// <returns><see cref="HeaderFootersResponse"/></returns>            
        public HeaderFootersResponse GetHeaderFooters(GetHeaderFootersRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.filterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetOfficeMathObjectRequest" /></param> 
        /// <returns><see cref="OfficeMathObjectResponse"/></returns>            
        public OfficeMathObjectResponse GetOfficeMathObject(GetOfficeMathObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetOfficeMathObjectsRequest" /></param> 
        /// <returns><see cref="OfficeMathObjectsResponse"/></returns>            
        public OfficeMathObjectsResponse GetOfficeMathObjects(GetOfficeMathObjectsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetSectionRequest" /></param> 
        /// <returns><see cref="SectionResponse"/></returns>            
        public SectionResponse GetSection(GetSectionRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSection");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetSectionPageSetupRequest" /></param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse GetSectionPageSetup(GetSectionPageSetupRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSectionPageSetup");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetSectionsRequest" /></param> 
        /// <returns><see cref="SectionLinkCollectionResponse"/></returns>            
        public SectionLinkCollectionResponse GetSections(GetSectionsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTableRequest" /></param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse GetTable(GetTableRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTableCellRequest" /></param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse GetTableCell(GetTableCellRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTableCellFormatRequest" /></param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse GetTableCellFormat(GetTableCellFormatRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCellFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTablePropertiesRequest" /></param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse GetTableProperties(GetTablePropertiesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTableRowRequest" /></param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse GetTableRow(GetTableRowRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTableRowFormatRequest" /></param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse GetTableRowFormat(GetTableRowFormatRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRowFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.GetTablesRequest" /></param> 
        /// <returns><see cref="TableLinkCollectionResponse"/></returns>            
        public TableLinkCollectionResponse GetTables(GetTablesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTables");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.InsertTableRequest" /></param> 
        /// <returns><see cref="TableResponse"/></returns>            
        public TableResponse InsertTable(InsertTableRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTable");
            }
            
            // verify the required parameter 'table' is set
            if (request.table == null) 
            {
                throw new ApiException(400, "Missing required parameter 'table' when calling InsertTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.table; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.InsertTableCellRequest" /></param> 
        /// <returns><see cref="TableCellResponse"/></returns>            
        public TableCellResponse InsertTableCell(InsertTableCellRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableCell");
            }
            
            // verify the required parameter 'cell' is set
            if (request.cell == null) 
            {
                throw new ApiException(400, "Missing required parameter 'cell' when calling InsertTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling InsertTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.tableRowPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.cell; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.InsertTableRowRequest" /></param> 
        /// <returns><see cref="TableRowResponse"/></returns>            
        public TableRowResponse InsertTableRow(InsertTableRowRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableRow");
            }
            
            // verify the required parameter 'row' is set
            if (request.row == null) 
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling InsertTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling InsertTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.tablePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.row; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostAppendDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostAppendDocument(PostAppendDocumentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAppendDocument");
            }
            
            // verify the required parameter 'documentList' is set
            if (request.documentList == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentList' when calling PostAppendDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.documentList; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostChangeDocumentProtectionRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PostChangeDocumentProtection(PostChangeDocumentProtectionRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChangeDocumentProtection");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PostChangeDocumentProtection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.protectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PostComment(PostCommentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.commentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling PostComment");
            }
            
            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.commentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.comment; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostCompareDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostCompareDocument(PostCompareDocumentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCompareDocument");
            }
            
            // verify the required parameter 'compareData' is set
            if (request.compareData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling PostCompareDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.compareData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostDocumentExecuteMailMergeRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostDocumentExecuteMailMerge(PostDocumentExecuteMailMergeRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentExecuteMailMerge");
            }
            
            // verify the required parameter 'withRegions' is set
            if (request.withRegions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'withRegions' when calling PostDocumentExecuteMailMerge");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "withRegions", request.withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "mailMergeDataFile", request.mailMergeDataFile);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
            if (request.data != null) 
            {
                formParams.Add("data", request.data); // form parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostDocumentParagraphRunFontRequest" /></param> 
        /// <returns><see cref="FontResponse"/></returns>            
        public FontResponse PostDocumentParagraphRunFont(PostDocumentParagraphRunFontRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'fontDto' is set
            if (request.fontDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fontDto' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDocumentParagraphRunFont");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.fontDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostDocumentSaveAsRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostDocumentSaveAs(PostDocumentSaveAsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentSaveAs");
            }
            
            // verify the required parameter 'saveOptionsData' is set
            if (request.saveOptionsData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling PostDocumentSaveAs");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            postBody = request.saveOptionsData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostDrawingObjectRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PostDrawingObject(PostDrawingObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (request.drawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (request.imageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
            if (request.drawingObject != null) 
            {
                formParams.Add("drawingObject", request.drawingObject); // form parameter
            }
            if (request.imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.imageFile, "imageFile"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostExecuteTemplateRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostExecuteTemplate(PostExecuteTemplateRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExecuteTemplate");
            }
            
            // verify the required parameter 'data' is set
            if (request.data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostExecuteTemplate");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
            if (request.data != null) 
            {
                formParams.Add("data", request.data); // form parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PostField(PostFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostField");
            }
            
            // verify the required parameter 'field' is set
            if (request.field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PostField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.field; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PostFootnote(PostFootnoteRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (request.footnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PostFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.footnoteDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PostFormField(PostFormFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (request.formField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PostFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.formField; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostInsertDocumentWatermarkImageRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkImage(PostInsertDocumentWatermarkImageRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkImage");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "rotationAngle", request.rotationAngle);
            resourcePath = this.AddQueryParameter(resourcePath, "image", request.image);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
            if (request.imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.imageFile, "imageFile"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostInsertDocumentWatermarkTextRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertDocumentWatermarkText(PostInsertDocumentWatermarkTextRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkText");
            }
            
            // verify the required parameter 'watermarkText' is set
            if (request.watermarkText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling PostInsertDocumentWatermarkText");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.watermarkText; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostInsertPageNumbersRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostInsertPageNumbers(PostInsertPageNumbersRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertPageNumbers");
            }
            
            // verify the required parameter 'pageNumber' is set
            if (request.pageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PostInsertPageNumbers");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.pageNumber; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostLoadWebDocumentRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PostLoadWebDocument(PostLoadWebDocumentRequest request)
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
            if (request.data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebDocument");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            postBody = request.data; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostReplaceTextRequest" /></param> 
        /// <returns><see cref="ReplaceTextResponse"/></returns>            
        public ReplaceTextResponse PostReplaceText(PostReplaceTextRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostReplaceText");
            }
            
            // verify the required parameter 'replaceText' is set
            if (request.replaceText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling PostReplaceText");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.replaceText; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PostRun(PostRunRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostRun");
            }
            
            // verify the required parameter 'run' is set
            if (request.run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PostRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.run; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostRunTaskRequest" /></param> 
        /// <returns><see cref="Object"/></returns>            
        public Object PostRunTask(PostRunTaskRequest request)
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostSplitDocumentRequest" /></param> 
        /// <returns><see cref="SplitDocumentResponse"/></returns>            
        public SplitDocumentResponse PostSplitDocument(PostSplitDocumentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSplitDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "from", request.from);
            resourcePath = this.AddQueryParameter(resourcePath, "to", request.to);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", request.zipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostUpdateDocumentBookmarkRequest" /></param> 
        /// <returns><see cref="BookmarkResponse"/></returns>            
        public BookmarkResponse PostUpdateDocumentBookmark(PostUpdateDocumentBookmarkRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkData' is set
            if (request.bookmarkData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkData' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (request.bookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling PostUpdateDocumentBookmark");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", request.bookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.bookmarkData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PostUpdateDocumentFieldsRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PostUpdateDocumentFields(PostUpdateDocumentFieldsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutCommentRequest" /></param> 
        /// <returns><see cref="CommentResponse"/></returns>            
        public CommentResponse PutComment(PutCommentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutComment");
            }
            
            // verify the required parameter 'comment' is set
            if (request.comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PutComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.comment; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutConvertDocumentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutConvertDocument(PutConvertDocumentRequest request)
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
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutConvertDocument");
            }
            
            // verify the required parameter 'document' is set
            if (request.document == null) 
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutConvertDocument");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", request.outPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
            if (request.document != null) 
            {
                formParams.Add("document", this.apiInvoker.ToFileInfo(request.document, "document"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutCreateDocumentRequest" /></param> 
        /// <returns><see cref="DocumentResponse"/></returns>            
        public DocumentResponse PutCreateDocument(PutCreateDocumentRequest request)
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
            
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutDocumentFieldNamesRequest" /></param> 
        /// <returns><see cref="FieldNamesResponse"/></returns>            
        public FieldNamesResponse PutDocumentFieldNames(PutDocumentFieldNamesRequest request)
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
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutDocumentFieldNames");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", request.useNonMergeFields);
            
            if (request.Template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutDocumentSaveAsTiffRequest" /></param> 
        /// <returns><see cref="SaveResponse"/></returns>            
        public SaveResponse PutDocumentSaveAsTiff(PutDocumentSaveAsTiffRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDocumentSaveAsTiff");
            }
            
            // verify the required parameter 'saveOptions' is set
            if (request.saveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling PutDocumentSaveAsTiff");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "resultFile", request.resultFile);
            resourcePath = this.AddQueryParameter(resourcePath, "useAntiAliasing", request.useAntiAliasing);
            resourcePath = this.AddQueryParameter(resourcePath, "useHighQualityRendering", request.useHighQualityRendering);
            resourcePath = this.AddQueryParameter(resourcePath, "imageBrightness", request.imageBrightness);
            resourcePath = this.AddQueryParameter(resourcePath, "imageColorMode", request.imageColorMode);
            resourcePath = this.AddQueryParameter(resourcePath, "imageContrast", request.imageContrast);
            resourcePath = this.AddQueryParameter(resourcePath, "numeralFormat", request.numeralFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "pageCount", request.pageCount);
            resourcePath = this.AddQueryParameter(resourcePath, "pageIndex", request.pageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "paperColor", request.paperColor);
            resourcePath = this.AddQueryParameter(resourcePath, "pixelFormat", request.pixelFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "resolution", request.resolution);
            resourcePath = this.AddQueryParameter(resourcePath, "scale", request.scale);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffCompression", request.tiffCompression);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlRenderingMode", request.dmlRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlEffectsRenderingMode", request.dmlEffectsRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffBinarizationMethod", request.tiffBinarizationMethod);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", request.zipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            postBody = request.saveOptions; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutDrawingObjectRequest" /></param> 
        /// <returns><see cref="DrawingObjectResponse"/></returns>            
        public DrawingObjectResponse PutDrawingObject(PutDrawingObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (request.drawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (request.imageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PutDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
            if (request.drawingObject != null) 
            {
                formParams.Add("drawingObject", request.drawingObject); // form parameter
            }
            if (request.imageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.imageFile, "imageFile"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutExecuteMailMergeOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteMailMergeOnline(PutExecuteMailMergeOnlineRequest request)
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
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteMailMergeOnline");
            }
            
            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteMailMergeOnline");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.withRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.cleanup);
            
            if (request.Template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            if (request.Data != null) 
            {
                formParams.Add("Data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutExecuteTemplateOnlineRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutExecuteTemplateOnline(PutExecuteTemplateOnlineRequest request)
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
            if (request.Template == null) 
            {
                throw new ApiException(400, "Missing required parameter 'template' when calling PutExecuteTemplateOnline");
            }
            
            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PutExecuteTemplateOnline");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.useWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.withRegions);
            
            if (request.Template != null) 
            {
                formParams.Add("Template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            if (request.Data != null) 
            {
                formParams.Add("Data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutFieldRequest" /></param> 
        /// <returns><see cref="FieldResponse"/></returns>            
        public FieldResponse PutField(PutFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutField");
            }
            
            // verify the required parameter 'field' is set
            if (request.field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PutField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.field; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutFootnoteRequest" /></param> 
        /// <returns><see cref="FootnoteResponse"/></returns>            
        public FootnoteResponse PutFootnote(PutFootnoteRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (request.footnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PutFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.footnoteDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutFormFieldRequest" /></param> 
        /// <returns><see cref="FormFieldResponse"/></returns>            
        public FormFieldResponse PutFormField(PutFormFieldRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (request.formField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PutFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.formField; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse PutHeaderFooter(PutHeaderFooterRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterType' is set
            if (request.headerFooterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling PutHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.sectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.headerFooterType; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutParagraphRequest" /></param> 
        /// <returns><see cref="ParagraphResponse"/></returns>            
        public ParagraphResponse PutParagraph(PutParagraphRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutParagraph");
            }
            
            // verify the required parameter 'paragraph' is set
            if (request.paragraph == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraph' when calling PutParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.paragraph; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutProtectDocumentRequest" /></param> 
        /// <returns><see cref="ProtectionDataResponse"/></returns>            
        public ProtectionDataResponse PutProtectDocument(PutProtectDocumentRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutProtectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.protectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PutProtectDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.protectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutRunRequest" /></param> 
        /// <returns><see cref="RunResponse"/></returns>            
        public RunResponse PutRun(PutRunRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.paragraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PutRun");
            }
            
            // verify the required parameter 'run' is set
            if (request.run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PutRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.paragraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.insertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.run; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutUpdateDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty(PutUpdateDocumentPropertyRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutUpdateDocumentProperty");
            }
            
            // verify the required parameter 'property' is set
            if (request.property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling PutUpdateDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.property; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.PutUpdateDocumentProperty_2Request" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutUpdateDocumentProperty_2(PutUpdateDocumentProperty_2Request request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutUpdateDocumentProperty_2");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.propertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PutUpdateDocumentProperty_2");
            }
            
            // verify the required parameter 'property' is set
            if (request.property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling PutUpdateDocumentProperty_2");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.propertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.property; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RejectAllRevisionsRequest" /></param> 
        /// <returns><see cref="RevisionsModificationResponse"/></returns>            
        public RevisionsModificationResponse RejectAllRevisions(RejectAllRevisionsRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RejectAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RenderDrawingObjectRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderDrawingObject(RenderDrawingObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RenderMathObjectRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderMathObject(RenderMathObjectRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderMathObject");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RenderPageRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderPage(RenderPageRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderPage");
            }
            
            // verify the required parameter 'pageIndex' is set
            if (request.pageIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageIndex' when calling RenderPage");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderPage");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "pageIndex", request.pageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RenderParagraphRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderParagraph(RenderParagraphRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderParagraph");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.RenderTableRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream RenderTable(RenderTableRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderTable");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.fontsLocation);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.ResetCacheRequest" /></param> 
        /// <returns><see cref="SaaSposeResponse"/></returns>            
        public SaaSposeResponse ResetCache(ResetCacheRequest request)
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.SearchRequest" /></param> 
        /// <returns><see cref="SearchResponse"/></returns>            
        public SearchResponse Search(SearchRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling Search");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddQueryParameter(resourcePath, "pattern", request.pattern);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.UpdateBorderRequest" /></param> 
        /// <returns><see cref="BorderResponse"/></returns>            
        public BorderResponse UpdateBorder(UpdateBorderRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBorder");
            }
            
            // verify the required parameter 'borderProperties' is set
            if (request.borderProperties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderProperties' when calling UpdateBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.nodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling UpdateBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.borderProperties; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.UpdateSectionPageSetupRequest" /></param> 
        /// <returns><see cref="SectionPageSetupResponse"/></returns>            
        public SectionPageSetupResponse UpdateSectionPageSetup(UpdateSectionPageSetupRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.sectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'pageSetup' is set
            if (request.pageSetup == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageSetup' when calling UpdateSectionPageSetup");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.sectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.pageSetup; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.UpdateTableCellFormatRequest" /></param> 
        /// <returns><see cref="TableCellFormatResponse"/></returns>            
        public TableCellFormatResponse UpdateTableCellFormat(UpdateTableCellFormatRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.tableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableCellFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.tableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.format; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.UpdateTablePropertiesRequest" /></param> 
        /// <returns><see cref="TablePropertiesResponse"/></returns>            
        public TablePropertiesResponse UpdateTableProperties(UpdateTablePropertiesRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'properties' is set
            if (request.properties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.nodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.properties; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="Aspose.Words.Cloud.Sdk.Model.UpdateTableRowFormatRequest" /></param> 
        /// <returns><see cref="TableRowFormatResponse"/></returns>            
        public TableRowFormatResponse UpdateTableRowFormat(UpdateTableRowFormatRequest request)
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
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.tablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableRowFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.tablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.destFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.loadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.revisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.revisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.password);
            postBody = request.format; // http body (model) parameter
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

namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.AcceptAllRevisions" /> operation.
  /// </summary>  
  public class AcceptAllRevisionsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteBorder" /> operation.
  /// </summary>  
  public class DeleteBorderRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteBorders" /> operation.
  /// </summary>  
  public class DeleteBordersRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node with borders(node should be cell or row).
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteComment" /> operation.
  /// </summary>  
  public class DeleteCommentRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? commentIndex { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentMacros" /> operation.
  /// </summary>  
  public class DeleteDocumentMacrosRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentProperty" /> operation.
  /// </summary>  
  public class DeleteDocumentPropertyRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string propertyName { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentWatermark" /> operation.
  /// </summary>  
  public class DeleteDocumentWatermarkRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDrawingObject" /> operation.
  /// </summary>  
  public class DeleteDrawingObjectRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteField" /> operation.
  /// </summary>  
  public class DeleteFieldRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFields" /> operation.
  /// </summary>  
  public class DeleteFieldsRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFootnote" /> operation.
  /// </summary>  
  public class DeleteFootnoteRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFormField" /> operation.
  /// </summary>  
  public class DeleteFormFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteHeaderFooter" /> operation.
  /// </summary>  
  public class DeleteHeaderFooterRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string sectionPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteHeadersFooters" /> operation.
  /// </summary>  
  public class DeleteHeadersFootersRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string sectionPath { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string headersFootersTypes { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteOfficeMathObject" /> operation.
  /// </summary>  
  public class DeleteOfficeMathObjectRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteParagraph" /> operation.
  /// </summary>  
  public class DeleteParagraphRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteRun" /> operation.
  /// </summary>  
  public class DeleteRunRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTable" /> operation.
  /// </summary>  
  public class DeleteTableRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTableCell" /> operation.
  /// </summary>  
  public class DeleteTableCellRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string tableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTableRow" /> operation.
  /// </summary>  
  public class DeleteTableRowRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string tablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteUnprotectDocument" /> operation.
  /// </summary>  
  public class DeleteUnprotectDocumentRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest protectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetBorder" /> operation.
  /// </summary>  
  public class GetBorderRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetBorders" /> operation.
  /// </summary>  
  public class GetBordersRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node with borders(node should be cell or row).
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetComment" /> operation.
  /// </summary>  
  public class GetCommentRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? commentIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetComments" /> operation.
  /// </summary>  
  public class GetCommentsRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocument" /> operation.
  /// </summary>  
  public class GetDocumentRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string documentName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentBookmarkByName" /> operation.
  /// </summary>  
  public class GetDocumentBookmarkByNameRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The bookmark name.
        /// </summary>  
        public string bookmarkName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentBookmarks" /> operation.
  /// </summary>  
  public class GetDocumentBookmarksRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectByIndex" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectByIndexRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectImageData" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectImageDataRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectOleData" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectOleDataRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjects" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentFieldNames" /> operation.
  /// </summary>  
  public class GetDocumentFieldNamesRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// If true, result includes \"mustache\" field names.
        /// </summary>  
        public bool? useNonMergeFields { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentHyperlinkByIndex" /> operation.
  /// </summary>  
  public class GetDocumentHyperlinkByIndexRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The hyperlink index.
        /// </summary>  
        public int? hyperlinkIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentHyperlinks" /> operation.
  /// </summary>  
  public class GetDocumentHyperlinksRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraph" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRun" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRunFont" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunFontRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRuns" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphs" /> operation.
  /// </summary>  
  public class GetDocumentParagraphsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProperties" /> operation.
  /// </summary>  
  public class GetDocumentPropertiesRequest
  {                       
        /// <summary>
        /// The document's name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProperty" /> operation.
  /// </summary>  
  public class GetDocumentPropertyRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string propertyName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProtection" /> operation.
  /// </summary>  
  public class GetDocumentProtectionRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentStatistics" /> operation.
  /// </summary>  
  public class GetDocumentStatisticsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Support including/excluding comments from the WordCount. Default value is \"true\".
        /// </summary>  
        public bool? includeComments { get; set; }

        /// <summary>
        /// Support including/excluding footnotes from the WordCount. Default value is \"false\".
        /// </summary>  
        public bool? includeFootnotes { get; set; }

        /// <summary>
        /// Support including/excluding shape's text from the WordCount. Default value is \"false\"
        /// </summary>  
        public bool? includeTextInShapes { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentTextItems" /> operation.
  /// </summary>  
  public class GetDocumentTextItemsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentWithFormat" /> operation.
  /// </summary>  
  public class GetDocumentWithFormatRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Path to save result
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetField" /> operation.
  /// </summary>  
  public class GetFieldRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFields" /> operation.
  /// </summary>  
  public class GetFieldsRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFootnote" /> operation.
  /// </summary>  
  public class GetFootnoteRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFootnotes" /> operation.
  /// </summary>  
  public class GetFootnotesRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFormField" /> operation.
  /// </summary>  
  public class GetFormFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFormFields" /> operation.
  /// </summary>  
  public class GetFormFieldsRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node containing collection of form fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooter" /> operation.
  /// </summary>  
  public class GetHeaderFooterRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Header/footer index.
        /// </summary>  
        public int? headerFooterIndex { get; set; }

        /// <summary>
        /// Section index.
        /// </summary>  
        public int? sectionIndex { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string filterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooter_1" /> operation.
  /// </summary>  
  public class GetHeaderFooter_1Request
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Header/footer index.
        /// </summary>  
        public int? headerFooterIndex { get; set; }

        /// <summary>
        /// Section index.
        /// </summary>  
        public int? sectionIndex { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string filterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooters" /> operation.
  /// </summary>  
  public class GetHeaderFootersRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string sectionPath { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string filterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetOfficeMathObject" /> operation.
  /// </summary>  
  public class GetOfficeMathObjectRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetOfficeMathObjects" /> operation.
  /// </summary>  
  public class GetOfficeMathObjectsRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSection" /> operation.
  /// </summary>  
  public class GetSectionRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? sectionIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSectionPageSetup" /> operation.
  /// </summary>  
  public class GetSectionPageSetupRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? sectionIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSections" /> operation.
  /// </summary>  
  public class GetSectionsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTable" /> operation.
  /// </summary>  
  public class GetTableRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableCell" /> operation.
  /// </summary>  
  public class GetTableCellRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string tableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableCellFormat" /> operation.
  /// </summary>  
  public class GetTableCellFormatRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string tableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableProperties" /> operation.
  /// </summary>  
  public class GetTablePropertiesRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableRow" /> operation.
  /// </summary>  
  public class GetTableRowRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string tablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableRowFormat" /> operation.
  /// </summary>  
  public class GetTableRowFormatRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string tablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTables" /> operation.
  /// </summary>  
  public class GetTablesRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTable" /> operation.
  /// </summary>  
  public class InsertTableRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Table parameters/
        /// </summary>  
        public TableInsert table { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTableCell" /> operation.
  /// </summary>  
  public class InsertTableCellRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Table cell parameters/
        /// </summary>  
        public TableCellInsert cell { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string tableRowPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTableRow" /> operation.
  /// </summary>  
  public class InsertTableRowRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Table row parameters/
        /// </summary>  
        public TableRowInsert row { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string tablePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostAppendDocument" /> operation.
  /// </summary>  
  public class PostAppendDocumentRequest
  {                       
        /// <summary>
        /// Original document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.DocumentEntryList} with a list of documents to append.
        /// </summary>  
        public DocumentEntryList documentList { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostChangeDocumentProtection" /> operation.
  /// </summary>  
  public class PostChangeDocumentProtectionRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest protectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostComment" /> operation.
  /// </summary>  
  public class PostCommentRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? commentIndex { get; set; }

        /// <summary>
        /// Comment data.
        /// </summary>  
        public Comment comment { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostCompareDocument" /> operation.
  /// </summary>  
  public class PostCompareDocumentRequest
  {                       
        /// <summary>
        /// Original document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare.
        /// </summary>  
        public CompareData compareData { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentExecuteMailMerge" /> operation.
  /// </summary>  
  public class PostDocumentExecuteMailMergeRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// With regions flag.
        /// </summary>  
        public bool? withRegions { get; set; }

        /// <summary>
        /// Mail merge data
        /// </summary>  
        public string data { get; set; }

        /// <summary>
        /// Mail merge data.
        /// </summary>  
        public string mailMergeDataFile { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.
        /// </summary>  
        public bool? useWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentParagraphRunFont" /> operation.
  /// </summary>  
  public class PostDocumentParagraphRunFontRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Font dto object
        /// </summary>  
        public Font fontDto { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentSaveAs" /> operation.
  /// </summary>  
  public class PostDocumentSaveAsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Save options.
        /// </summary>  
        public SaveOptionsData saveOptionsData { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDrawingObject" /> operation.
  /// </summary>  
  public class PostDrawingObjectRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Drawing object parameters
        /// </summary>  
        public string drawingObject { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream imageFile { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostExecuteTemplate" /> operation.
  /// </summary>  
  public class PostExecuteTemplateRequest
  {                       
        /// <summary>
        /// The template document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Mail merge data
        /// </summary>  
        public string data { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or   TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.    The default value is true.
        /// </summary>  
        public bool? useWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Merge with regions or not. True by default
        /// </summary>  
        public bool? withRegions { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostField" /> operation.
  /// </summary>  
  public class PostFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Field data.
        /// </summary>  
        public Field field { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostFootnote" /> operation.
  /// </summary>  
  public class PostFootnoteRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Footnote data.
        /// </summary>  
        public Footnote footnoteDto { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostFormField" /> operation.
  /// </summary>  
  public class PostFormFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// From field data.
        /// </summary>  
        public FormField formField { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertDocumentWatermarkImage" /> operation.
  /// </summary>  
  public class PostInsertDocumentWatermarkImageRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream imageFile { get; set; }

        /// <summary>
        /// The watermark rotation angle.
        /// </summary>  
        public double? rotationAngle { get; set; }

        /// <summary>
        /// The image file server full name. If the name is empty the image is expected in request content.
        /// </summary>  
        public string image { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertDocumentWatermarkText" /> operation.
  /// </summary>  
  public class PostInsertDocumentWatermarkTextRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.WatermarkText} with the watermark data.
        /// </summary>  
        public WatermarkText watermarkText { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertPageNumbers" /> operation.
  /// </summary>  
  public class PostInsertPageNumbersRequest
  {                       
        /// <summary>
        /// A document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.PageNumber} with the page numbers settings.
        /// </summary>  
        public PageNumber pageNumber { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostLoadWebDocument" /> operation.
  /// </summary>  
  public class PostLoadWebDocumentRequest
  {                       
        /// <summary>
        /// Parameters of loading.
        /// </summary>  
        public LoadWebDocumentData data { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostReplaceText" /> operation.
  /// </summary>  
  public class PostReplaceTextRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.Replace.ReplaceTextResponse} with the replace operation settings.
        /// </summary>  
        public ReplaceTextRequest replaceText { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostRun" /> operation.
  /// </summary>  
  public class PostRunRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Run data.
        /// </summary>  
        public Run run { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostRunTask" /> operation.
  /// </summary>  
  public class PostRunTaskRequest
  {                       
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostSplitDocument" /> operation.
  /// </summary>  
  public class PostSplitDocumentRequest
  {                       
        /// <summary>
        /// Original document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Format to split.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Start page.
        /// </summary>  
        public int? from { get; set; }

        /// <summary>
        /// End page.
        /// </summary>  
        public int? to { get; set; }

        /// <summary>
        /// ZipOutput or not.
        /// </summary>  
        public bool? zipOutput { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostUpdateDocumentBookmark" /> operation.
  /// </summary>  
  public class PostUpdateDocumentBookmarkRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.DocumentElements.Bookmarks.BookmarkData} with new bookmark data.
        /// </summary>  
        public BookmarkData bookmarkData { get; set; }

        /// <summary>
        /// The bookmark name.
        /// </summary>  
        public string bookmarkName { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostUpdateDocumentFields" /> operation.
  /// </summary>  
  public class PostUpdateDocumentFieldsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutComment" /> operation.
  /// </summary>  
  public class PutCommentRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Comment data.
        /// </summary>  
        public Comment comment { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutConvertDocument" /> operation.
  /// </summary>  
  public class PutConvertDocumentRequest
  {                       
        /// <summary>
        /// Format to convert.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Converting document
        /// </summary>  
        public System.IO.Stream document { get; set; }

        /// <summary>
        /// Path for saving operation result to the local storage.
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutCreateDocument" /> operation.
  /// </summary>  
  public class PutCreateDocumentRequest
  {                       
        /// <summary>
        /// The document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentFieldNames" /> operation.
  /// </summary>  
  public class PutDocumentFieldNamesRequest
  {                       
        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// Use non merge fields or not.
        /// </summary>  
        public bool? useNonMergeFields { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentSaveAsTiff" /> operation.
  /// </summary>  
  public class PutDocumentSaveAsTiffRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Tiff save options.
        /// </summary>  
        public TiffSaveOptionsData saveOptions { get; set; }

        /// <summary>
        /// The resulting file name.
        /// </summary>  
        public string resultFile { get; set; }

        /// <summary>
        /// Use antialiasing flag.
        /// </summary>  
        public bool? useAntiAliasing { get; set; }

        /// <summary>
        /// Use high quality flag.
        /// </summary>  
        public bool? useHighQualityRendering { get; set; }

        /// <summary>
        /// Brightness for the generated images.
        /// </summary>  
        public float? imageBrightness { get; set; }

        /// <summary>
        /// Color mode for the generated images.
        /// </summary>  
        public string imageColorMode { get; set; }

        /// <summary>
        /// The contrast for the generated images.
        /// </summary>  
        public float? imageContrast { get; set; }

        /// <summary>
        /// The images numeral format.
        /// </summary>  
        public string numeralFormat { get; set; }

        /// <summary>
        /// Number of pages to render.
        /// </summary>  
        public int? pageCount { get; set; }

        /// <summary>
        /// Page index to start rendering.
        /// </summary>  
        public int? pageIndex { get; set; }

        /// <summary>
        /// Background image color.
        /// </summary>  
        public string paperColor { get; set; }

        /// <summary>
        /// The pixel format of generated images.
        /// </summary>  
        public string pixelFormat { get; set; }

        /// <summary>
        /// The resolution of generated images.
        /// </summary>  
        public float? resolution { get; set; }

        /// <summary>
        /// Zoom factor for generated images.
        /// </summary>  
        public float? scale { get; set; }

        /// <summary>
        /// The compression tipe.
        /// </summary>  
        public string tiffCompression { get; set; }

        /// <summary>
        /// Optional, default is Fallback.
        /// </summary>  
        public string dmlRenderingMode { get; set; }

        /// <summary>
        /// Optional, default is Simplified.
        /// </summary>  
        public string dmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
        /// </summary>  
        public string tiffBinarizationMethod { get; set; }

        /// <summary>
        /// Optional. A value determining zip output or not.
        /// </summary>  
        public bool? zipOutput { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDrawingObject" /> operation.
  /// </summary>  
  public class PutDrawingObjectRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Drawing object parameters
        /// </summary>  
        public string drawingObject { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream imageFile { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutExecuteMailMergeOnline" /> operation.
  /// </summary>  
  public class PutExecuteMailMergeOnlineRequest
  {                       
        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// File with mailmerge data
        /// </summary>  
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// With regions flag.
        /// </summary>  
        public bool? withRegions { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string cleanup { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutExecuteTemplateOnline" /> operation.
  /// </summary>  
  public class PutExecuteTemplateOnlineRequest
  {                       
        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// File with mailmerge data
        /// </summary>  
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.
        /// </summary>  
        public bool? useWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Merge with regions or not. True by default
        /// </summary>  
        public bool? withRegions { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutField" /> operation.
  /// </summary>  
  public class PutFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Field data.
        /// </summary>  
        public Field field { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Field will be inserted before node with id=\"nodeId\".
        /// </summary>  
        public string insertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutFootnote" /> operation.
  /// </summary>  
  public class PutFootnoteRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Footnote data.
        /// </summary>  
        public Footnote footnoteDto { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutFormField" /> operation.
  /// </summary>  
  public class PutFormFieldRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// From field data.
        /// </summary>  
        public FormField formField { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Form field will be inserted before node with index.
        /// </summary>  
        public string insertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutHeaderFooter" /> operation.
  /// </summary>  
  public class PutHeaderFooterRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Type of header/footer.
        /// </summary>  
        public string headerFooterType { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string sectionPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutParagraph" /> operation.
  /// </summary>  
  public class PutParagraphRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Paragraph data.
        /// </summary>  
        public ParagraphInsert paragraph { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Paragraph will be inserted before node with index.
        /// </summary>  
        public string insertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutProtectDocument" /> operation.
  /// </summary>  
  public class PutProtectDocumentRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest protectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutRun" /> operation.
  /// </summary>  
  public class PutRunRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string paragraphPath { get; set; }

        /// <summary>
        /// Run data.
        /// </summary>  
        public Run run { get; set; }

        /// <summary>
        /// Paragraph will be inserted before node with index.
        /// </summary>  
        public string insertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutUpdateDocumentProperty" /> operation.
  /// </summary>  
  public class PutUpdateDocumentPropertyRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string propertyName { get; set; }

        /// <summary>
        /// The property with new value.
        /// </summary>  
        public DocumentProperty property { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutUpdateDocumentProperty_2" /> operation.
  /// </summary>  
  public class PutUpdateDocumentProperty_2Request
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string propertyName { get; set; }

        /// <summary>
        /// The property with new value.
        /// </summary>  
        public DocumentProperty property { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RejectAllRevisions" /> operation.
  /// </summary>  
  public class RejectAllRevisionsRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderDrawingObject" /> operation.
  /// </summary>  
  public class RenderDrawingObjectRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains drawing objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderMathObject" /> operation.
  /// </summary>  
  public class RenderMathObjectRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains office math objects.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderPage" /> operation.
  /// </summary>  
  public class RenderPageRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? pageIndex { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderParagraph" /> operation.
  /// </summary>  
  public class RenderParagraphRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains paragraphs.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderTable" /> operation.
  /// </summary>  
  public class RenderTableRequest
  {                       
        /// <summary>
        /// The file name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string fontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ResetCache" /> operation.
  /// </summary>  
  public class ResetCacheRequest
  {                       
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.Search" /> operation.
  /// </summary>  
  public class SearchRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The regular expression used to find matches.
        /// </summary>  
        public string pattern { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateBorder" /> operation.
  /// </summary>  
  public class UpdateBorderRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Border properties
        /// </summary>  
        public Border borderProperties { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateSectionPageSetup" /> operation.
  /// </summary>  
  public class UpdateSectionPageSetupRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? sectionIndex { get; set; }

        /// <summary>
        /// Page setup properties dto
        /// </summary>  
        public PageSetup pageSetup { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableCellFormat" /> operation.
  /// </summary>  
  public class UpdateTableCellFormatRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The properties.
        /// </summary>  
        public TableCellFormat format { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string tableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableProperties" /> operation.
  /// </summary>  
  public class UpdateTablePropertiesRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The properties.
        /// </summary>  
        public TableProperties properties { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string nodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableRowFormat" /> operation.
  /// </summary>  
  public class UpdateTableRowFormatRequest
  {                       
        /// <summary>
        /// The document name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The properties.
        /// </summary>  
        public TableRowFormat format { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string tablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string destFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string loadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string revisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string revisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string password { get; set; }
  }
}
