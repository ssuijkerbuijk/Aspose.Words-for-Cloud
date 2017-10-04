namespace Aspose.Words.Cloud.Sdk.Api
{
    using System;    
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Requests;

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
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// Add new or update existing document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateOrUpdateDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse CreateOrUpdateDocumentProperty(CreateOrUpdateDocumentPropertyRequest request)
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling CreateOrUpdateDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling CreateOrUpdateDocumentProperty");
            }
            
            // verify the required parameter 'property' is set
            if (request.Property == null) 
            {
                throw new ApiException(400, "Missing required parameter 'property' when calling CreateOrUpdateDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Property; // http body (model) parameter
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
        /// Resets border properties to default values. &#39;nodePath&#39; should refer to node with cell or row
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteBorderRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteBordersRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling DeleteBorders");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteCommentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling DeleteComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteDocumentMacrosRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentMacros");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling DeleteDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteDocumentWatermarkRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDocumentWatermark");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteDrawingObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteFieldsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteFootnoteRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteFormFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeaderFooter");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteHeadersFootersRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteHeadersFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "headersFootersTypes", request.HeadersFootersTypes);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteOfficeMathObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteParagraphRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteRunRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling DeleteRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteTableRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteTableCellRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling DeleteTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteTableRowRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling DeleteTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling DeleteTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="DeleteUnprotectDocumentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeleteUnprotectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling DeleteUnprotectDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.ProtectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="GetBorderRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetBordersRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBorders");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling GetBorders");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetCommentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling GetComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetCommentsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetComments");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentRequest" /></param> 
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
            if (request.DocumentName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentName' when calling GetDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "documentName", request.DocumentName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentBookmarkByNameRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarkByName");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling GetDocumentBookmarkByName");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", request.BookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentBookmarksRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentBookmarks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectByIndexRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectByIndex");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectByIndex");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectImageDataRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectImageData");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectImageData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectOleDataRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjectOleData");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentDrawingObjectOleData");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentDrawingObjectsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentDrawingObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentFieldNamesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentFieldNames");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", request.UseNonMergeFields);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentHyperlinkByIndexRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinkByIndex");
            }
            
            // verify the required parameter 'hyperlinkIndex' is set
            if (request.HyperlinkIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'hyperlinkIndex' when calling GetDocumentHyperlinkByIndex");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "hyperlinkIndex", request.HyperlinkIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentHyperlinksRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentHyperlinks");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentParagraphRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunFontRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetDocumentParagraphRunFont");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentParagraphRunsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphRuns");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling GetDocumentParagraphRuns");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentParagraphsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentParagraphs");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProperty");
            }
            
            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling GetDocumentProperty");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentProtectionRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentProtection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentStatisticsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentStatistics");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "includeComments", request.IncludeComments);
            resourcePath = this.AddQueryParameter(resourcePath, "includeFootnotes", request.IncludeFootnotes);
            resourcePath = this.AddQueryParameter(resourcePath, "includeTextInShapes", request.IncludeTextInShapes);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentTextItemsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentTextItems");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetDocumentWithFormatRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDocumentWithFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetDocumentWithFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", request.OutPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="GetFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetFieldsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetFootnoteRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetFootnotesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFootnotes");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetFormFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetFormFieldsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetFormFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetHeaderFooterRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooter(GetHeaderFooterRequest request)
        {
            // create path and map variables
            var resourcePath = "/words/{name}/headersfooters/{headerFooterIndex}?appSid={appSid}&amp;filterByType=[filterByType]&amp;storage=[storage]&amp;folder=[folder]&amp;loadEncoding=[loadEncoding]&amp;password=[password]";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            var headerParams = new Dictionary<string, string>();
            var formParams = new Dictionary<string, object>();
            object postBody = null;            
            
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (request.HeaderFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", request.HeaderFooterIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.FilterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetHeaderFooterOfSectionRequest" /></param> 
        /// <returns><see cref="HeaderFooterResponse"/></returns>            
        public HeaderFooterResponse GetHeaderFooterOfSection(GetHeaderFooterOfSectionRequest request)
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooterOfSection");
            }
            
            // verify the required parameter 'headerFooterIndex' is set
            if (request.HeaderFooterIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterIndex' when calling GetHeaderFooterOfSection");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetHeaderFooterOfSection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "headerFooterIndex", request.HeaderFooterIndex);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.FilterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetHeaderFootersRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetHeaderFooters");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "filterByType", request.FilterByType);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetOfficeMathObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetOfficeMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetOfficeMathObjectsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetOfficeMathObjects");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetSectionRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSection");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetSectionPageSetupRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling GetSectionPageSetup");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetSectionsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetSections");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTableRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTableCellRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCell");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTableCellFormatRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling GetTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableCellFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTablePropertiesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTableRowRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRow");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTableRowFormatRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling GetTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling GetTableRowFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="GetTablesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetTables");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="InsertTableRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTable");
            }
            
            // verify the required parameter 'table' is set
            if (request.Table == null) 
            {
                throw new ApiException(400, "Missing required parameter 'table' when calling InsertTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Table; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="InsertTableCellRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableCell");
            }
            
            // verify the required parameter 'cell' is set
            if (request.Cell == null) 
            {
                throw new ApiException(400, "Missing required parameter 'cell' when calling InsertTableCell");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling InsertTableCell");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Cell; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="InsertTableRowRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertTableRow");
            }
            
            // verify the required parameter 'row' is set
            if (request.Row == null) 
            {
                throw new ApiException(400, "Missing required parameter 'row' when calling InsertTableRow");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling InsertTableRow");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Row; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostAppendDocumentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAppendDocument");
            }
            
            // verify the required parameter 'documentList' is set
            if (request.DocumentList == null) 
            {
                throw new ApiException(400, "Missing required parameter 'documentList' when calling PostAppendDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.DocumentList; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostChangeDocumentProtectionRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostChangeDocumentProtection");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PostChangeDocumentProtection");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.ProtectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostCommentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostComment");
            }
            
            // verify the required parameter 'commentIndex' is set
            if (request.CommentIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'commentIndex' when calling PostComment");
            }
            
            // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PostComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "commentIndex", request.CommentIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Comment; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostCompareDocumentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostCompareDocument");
            }
            
            // verify the required parameter 'compareData' is set
            if (request.CompareData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'compareData' when calling PostCompareDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.CompareData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostDocumentExecuteMailMergeRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentExecuteMailMerge");
            }
            
            // verify the required parameter 'withRegions' is set
            if (request.WithRegions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'withRegions' when calling PostDocumentExecuteMailMerge");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "withRegions", request.WithRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "mailMergeDataFile", request.MailMergeDataFile);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.Cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
            if (request.Data != null) 
            {
                formParams.Add("Data", request.Data); // form parameter
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
        /// <param name="request">Request. <see cref="PostDocumentParagraphRunFontRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'fontDto' is set
            if (request.FontDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fontDto' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostDocumentParagraphRunFont");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDocumentParagraphRunFont");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.FontDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostDocumentSaveAsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDocumentSaveAs");
            }
            
            // verify the required parameter 'saveOptionsData' is set
            if (request.SaveOptionsData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptionsData' when calling PostDocumentSaveAs");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            postBody = request.SaveOptionsData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostDrawingObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PostDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
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
        /// <param name="request">Request. <see cref="PostExecuteTemplateRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostExecuteTemplate");
            }
            
            // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostExecuteTemplate");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.Cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.WithRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
            if (request.Data != null) 
            {
                formParams.Add("Data", request.Data); // form parameter
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
        /// <param name="request">Request. <see cref="PostFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostField");
            }
            
            // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PostField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Field; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostFootnoteRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PostFootnote");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.FootnoteDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostFormFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PostFormField");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.FormField; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostInsertDocumentWatermarkImageRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkImage");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "rotationAngle", request.RotationAngle);
            resourcePath = this.AddQueryParameter(resourcePath, "image", request.Image);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
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
        /// <param name="request">Request. <see cref="PostInsertDocumentWatermarkTextRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertDocumentWatermarkText");
            }
            
            // verify the required parameter 'watermarkText' is set
            if (request.WatermarkText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'watermarkText' when calling PostInsertDocumentWatermarkText");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.WatermarkText; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostInsertPageNumbersRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostInsertPageNumbers");
            }
            
            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PostInsertPageNumbers");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.PageNumber; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostLoadWebDocumentRequest" /></param> 
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
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostLoadWebDocument");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            postBody = request.Data; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostReplaceTextRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostReplaceText");
            }
            
            // verify the required parameter 'replaceText' is set
            if (request.ReplaceText == null) 
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling PostReplaceText");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.ReplaceText; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostRunRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostRun");
            }
            
            // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PostRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PostRun");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling PostRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Run; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostRunTaskRequest" /></param> 
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
        /// <param name="request">Request. <see cref="PostSplitDocumentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostSplitDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "from", request.From);
            resourcePath = this.AddQueryParameter(resourcePath, "to", request.To);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", request.ZipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="PostUpdateDocumentBookmarkRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkData' is set
            if (request.BookmarkData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkData' when calling PostUpdateDocumentBookmark");
            }
            
            // verify the required parameter 'bookmarkName' is set
            if (request.BookmarkName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'bookmarkName' when calling PostUpdateDocumentBookmark");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "bookmarkName", request.BookmarkName);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.BookmarkData; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PostUpdateDocumentFieldsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostUpdateDocumentFields");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="PutCommentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutComment");
            }
            
            // verify the required parameter 'comment' is set
            if (request.Comment == null) 
            {
                throw new ApiException(400, "Missing required parameter 'comment' when calling PutComment");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Comment; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutConvertDocumentRequest" /></param> 
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
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PutConvertDocument");
            }
            
            // verify the required parameter 'document' is set
            if (request.Document == null) 
            {
                throw new ApiException(400, "Missing required parameter 'document' when calling PutConvertDocument");
            }
            
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "outPath", request.OutPath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
            if (request.Document != null) 
            {
                formParams.Add("document", this.apiInvoker.ToFileInfo(request.Document, "Document"));
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
        /// Creates new document.  Document is created with format which is recognized from file extensions.   Supported extentions: \&quot;.doc\&quot;, \&quot;.docx\&quot;, \&quot;.docm\&quot;, \&quot;.dot\&quot;, \&quot;.dotm\&quot;, \&quot;.dotx\&quot;, \&quot;.flatopc\&quot;, \&quot;.fopc\&quot;, \&quot;.flatopc_macro\&quot;, \&quot;.fopc_macro\&quot;, \&quot;.flatopc_template\&quot;, \&quot;.fopc_template\&quot;, \&quot;.flatopc_template_macro\&quot;, \&quot;.fopc_template_macro\&quot;, \&quot;.wordml\&quot;, \&quot;.wml\&quot;, \&quot;.rtf\&quot; 
        /// </summary>
        /// <param name="request">Request. <see cref="PutCreateDocumentRequest" /></param> 
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
            
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            
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
        /// <param name="request">Request. <see cref="PutDocumentFieldNamesRequest" /></param> 
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
            
            resourcePath = this.AddQueryParameter(resourcePath, "useNonMergeFields", request.UseNonMergeFields);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
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
        /// <param name="request">Request. <see cref="PutDocumentSaveAsTiffRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDocumentSaveAsTiff");
            }
            
            // verify the required parameter 'saveOptions' is set
            if (request.SaveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling PutDocumentSaveAsTiff");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "resultFile", request.ResultFile);
            resourcePath = this.AddQueryParameter(resourcePath, "useAntiAliasing", request.UseAntiAliasing);
            resourcePath = this.AddQueryParameter(resourcePath, "useHighQualityRendering", request.UseHighQualityRendering);
            resourcePath = this.AddQueryParameter(resourcePath, "imageBrightness", request.ImageBrightness);
            resourcePath = this.AddQueryParameter(resourcePath, "imageColorMode", request.ImageColorMode);
            resourcePath = this.AddQueryParameter(resourcePath, "imageContrast", request.ImageContrast);
            resourcePath = this.AddQueryParameter(resourcePath, "numeralFormat", request.NumeralFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "pageCount", request.PageCount);
            resourcePath = this.AddQueryParameter(resourcePath, "pageIndex", request.PageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "paperColor", request.PaperColor);
            resourcePath = this.AddQueryParameter(resourcePath, "pixelFormat", request.PixelFormat);
            resourcePath = this.AddQueryParameter(resourcePath, "resolution", request.Resolution);
            resourcePath = this.AddQueryParameter(resourcePath, "scale", request.Scale);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffCompression", request.TiffCompression);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlRenderingMode", request.DmlRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "dmlEffectsRenderingMode", request.DmlEffectsRenderingMode);
            resourcePath = this.AddQueryParameter(resourcePath, "tiffBinarizationMethod", request.TiffBinarizationMethod);
            resourcePath = this.AddQueryParameter(resourcePath, "zipOutput", request.ZipOutput);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            postBody = request.SaveOptions; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutDrawingObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'drawingObject' is set
            if (request.DrawingObject == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingObject' when calling PutDrawingObject");
            }
            
            // verify the required parameter 'imageFile' is set
            if (request.ImageFile == null) 
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling PutDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
            if (request.DrawingObject != null) 
            {
                formParams.Add("DrawingObject", request.DrawingObject); // form parameter
            }
            if (request.ImageFile != null) 
            {
                formParams.Add("imageFile", this.apiInvoker.ToFileInfo(request.ImageFile, "ImageFile"));
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
        /// <param name="request">Request. <see cref="PutExecuteMailMergeOnlineRequest" /></param> 
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
            
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.WithRegions);
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.Cleanup);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
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
        /// <param name="request">Request. <see cref="PutExecuteTemplateOnlineRequest" /></param> 
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
            
            resourcePath = this.AddQueryParameter(resourcePath, "cleanup", request.Cleanup);
            resourcePath = this.AddQueryParameter(resourcePath, "useWholeParagraphAsRegion", request.UseWholeParagraphAsRegion);
            resourcePath = this.AddQueryParameter(resourcePath, "withRegions", request.WithRegions);
            
            if (request.Template != null) 
            {
                formParams.Add("template", this.apiInvoker.ToFileInfo(request.Template, "Template"));
            }
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
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
        /// <param name="request">Request. <see cref="PutFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutField");
            }
            
            // verify the required parameter 'field' is set
            if (request.Field == null) 
            {
                throw new ApiException(400, "Missing required parameter 'field' when calling PutField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Field; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutFootnoteRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFootnote");
            }
            
            // verify the required parameter 'footnoteDto' is set
            if (request.FootnoteDto == null) 
            {
                throw new ApiException(400, "Missing required parameter 'footnoteDto' when calling PutFootnote");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.FootnoteDto; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutFormFieldRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutFormField");
            }
            
            // verify the required parameter 'formField' is set
            if (request.FormField == null) 
            {
                throw new ApiException(400, "Missing required parameter 'formField' when calling PutFormField");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.FormField; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutHeaderFooterRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutHeaderFooter");
            }
            
            // verify the required parameter 'headerFooterType' is set
            if (request.HeaderFooterType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'headerFooterType' when calling PutHeaderFooter");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "sectionPath", request.SectionPath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.HeaderFooterType; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutParagraphRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutParagraph");
            }
            
            // verify the required parameter 'paragraph' is set
            if (request.Paragraph == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraph' when calling PutParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Paragraph; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutProtectDocumentRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutProtectDocument");
            }
            
            // verify the required parameter 'protectionRequest' is set
            if (request.ProtectionRequest == null) 
            {
                throw new ApiException(400, "Missing required parameter 'protectionRequest' when calling PutProtectDocument");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.ProtectionRequest; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="PutRunRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutRun");
            }
            
            // verify the required parameter 'paragraphPath' is set
            if (request.ParagraphPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'paragraphPath' when calling PutRun");
            }
            
            // verify the required parameter 'run' is set
            if (request.Run == null) 
            {
                throw new ApiException(400, "Missing required parameter 'run' when calling PutRun");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "paragraphPath", request.ParagraphPath);
            resourcePath = this.AddQueryParameter(resourcePath, "insertBeforeNode", request.InsertBeforeNode);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Run; // http body (model) parameter
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
        /// Reject all revisions in document 
        /// </summary>
        /// <param name="request">Request. <see cref="RejectAllRevisionsRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RejectAllRevisions");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="RenderDrawingObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderDrawingObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderDrawingObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="RenderMathObjectRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderMathObject");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderMathObject");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderMathObject");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="RenderPageRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderPage");
            }
            
            // verify the required parameter 'pageIndex' is set
            if (request.PageIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageIndex' when calling RenderPage");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderPage");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "pageIndex", request.PageIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="RenderParagraphRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderParagraph");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderParagraph");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderParagraph");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="RenderTableRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling RenderTable");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling RenderTable");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling RenderTable");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "format", request.Format);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            resourcePath = this.AddQueryParameter(resourcePath, "fontsLocation", request.FontsLocation);
            
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
        /// <param name="request">Request. <see cref="ResetCacheRequest" /></param> 
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
        /// <param name="request">Request. <see cref="SearchRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling Search");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddQueryParameter(resourcePath, "pattern", request.Pattern);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            
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
        /// <param name="request">Request. <see cref="UpdateBorderRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateBorder");
            }
            
            // verify the required parameter 'borderProperties' is set
            if (request.BorderProperties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'borderProperties' when calling UpdateBorder");
            }
            
            // verify the required parameter 'nodePath' is set
            if (request.NodePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'nodePath' when calling UpdateBorder");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateBorder");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.BorderProperties; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="UpdateSectionPageSetupRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'sectionIndex' is set
            if (request.SectionIndex == null) 
            {
                throw new ApiException(400, "Missing required parameter 'sectionIndex' when calling UpdateSectionPageSetup");
            }
            
            // verify the required parameter 'pageSetup' is set
            if (request.PageSetup == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageSetup' when calling UpdateSectionPageSetup");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "sectionIndex", request.SectionIndex);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.PageSetup; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="UpdateTableCellFormatRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'tableRowPath' is set
            if (request.TableRowPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tableRowPath' when calling UpdateTableCellFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableCellFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tableRowPath", request.TableRowPath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Format; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="UpdateTablePropertiesRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'properties' is set
            if (request.Properties == null) 
            {
                throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateTableProperties");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableProperties");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "nodePath", request.NodePath);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Properties; // http body (model) parameter
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
        /// <param name="request">Request. <see cref="UpdateTableRowFormatRequest" /></param> 
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
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'format' is set
            if (request.Format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'tablePath' is set
            if (request.TablePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'tablePath' when calling UpdateTableRowFormat");
            }
            
            // verify the required parameter 'index' is set
            if (request.Index == null) 
            {
                throw new ApiException(400, "Missing required parameter 'index' when calling UpdateTableRowFormat");
            }
            
            resourcePath = this.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = this.AddPathParameter(resourcePath, "tablePath", request.TablePath);
            resourcePath = this.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = this.AddQueryParameter(resourcePath, "destFileName", request.DestFileName);
            resourcePath = this.AddQueryParameter(resourcePath, "storage", request.Storage);
            resourcePath = this.AddQueryParameter(resourcePath, "folder", request.Folder);
            resourcePath = this.AddQueryParameter(resourcePath, "loadEncoding", request.LoadEncoding);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionAuthor", request.RevisionAuthor);
            resourcePath = this.AddQueryParameter(resourcePath, "revisionDateTime", request.RevisionDateTime);
            resourcePath = this.AddQueryParameter(resourcePath, "password", request.Password);
            postBody = request.Format; // http body (model) parameter
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

namespace Aspose.Words.Cloud.Sdk.Requests 
{
  using Aspose.Words.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.AcceptAllRevisions" /> operation.
  /// </summary>  
  public class AcceptAllRevisionsRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptAllRevisionsRequest"/> class.
        /// </summary>        
        public AcceptAllRevisionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptAllRevisionsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public AcceptAllRevisionsRequest(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CreateOrUpdateDocumentProperty" /> operation.
  /// </summary>  
  public class CreateOrUpdateDocumentPropertyRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocumentPropertyRequest"/> class.
        /// </summary>        
        public CreateOrUpdateDocumentPropertyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateDocumentPropertyRequest"/> class.
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
        public CreateOrUpdateDocumentPropertyRequest(string name, string propertyName, DocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.PropertyName = propertyName;
            this.Property = property;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string PropertyName { get; set; }

        /// <summary>
        /// The property with new value.
        /// </summary>  
        public DocumentProperty Property { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteBorder" /> operation.
  /// </summary>  
  public class DeleteBorderRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBorderRequest"/> class.
        /// </summary>        
        public DeleteBorderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBorderRequest"/> class.
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
        public DeleteBorderRequest(string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteBorders" /> operation.
  /// </summary>  
  public class DeleteBordersRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBordersRequest"/> class.
        /// </summary>        
        public DeleteBordersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBordersRequest"/> class.
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
        public DeleteBordersRequest(string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node with borders(node should be cell or row).
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteComment" /> operation.
  /// </summary>  
  public class DeleteCommentRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommentRequest"/> class.
        /// </summary>        
        public DeleteCommentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCommentRequest"/> class.
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
        public DeleteCommentRequest(string name, int? commentIndex, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.CommentIndex = commentIndex;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? CommentIndex { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentMacros" /> operation.
  /// </summary>  
  public class DeleteDocumentMacrosRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentMacrosRequest"/> class.
        /// </summary>        
        public DeleteDocumentMacrosRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentMacrosRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public DeleteDocumentMacrosRequest(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentProperty" /> operation.
  /// </summary>  
  public class DeleteDocumentPropertyRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentPropertyRequest"/> class.
        /// </summary>        
        public DeleteDocumentPropertyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentPropertyRequest"/> class.
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
        public DeleteDocumentPropertyRequest(string name, string propertyName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.PropertyName = propertyName;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string PropertyName { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDocumentWatermark" /> operation.
  /// </summary>  
  public class DeleteDocumentWatermarkRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentWatermarkRequest"/> class.
        /// </summary>        
        public DeleteDocumentWatermarkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentWatermarkRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public DeleteDocumentWatermarkRequest(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteDrawingObject" /> operation.
  /// </summary>  
  public class DeleteDrawingObjectRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDrawingObjectRequest"/> class.
        /// </summary>        
        public DeleteDrawingObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDrawingObjectRequest"/> class.
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
        public DeleteDrawingObjectRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteField" /> operation.
  /// </summary>  
  public class DeleteFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFieldRequest"/> class.
        /// </summary>        
        public DeleteFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFieldRequest"/> class.
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
        public DeleteFieldRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFields" /> operation.
  /// </summary>  
  public class DeleteFieldsRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFieldsRequest"/> class.
        /// </summary>        
        public DeleteFieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFieldsRequest"/> class.
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
        public DeleteFieldsRequest(string name, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFootnote" /> operation.
  /// </summary>  
  public class DeleteFootnoteRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFootnoteRequest"/> class.
        /// </summary>        
        public DeleteFootnoteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFootnoteRequest"/> class.
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
        public DeleteFootnoteRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteFormField" /> operation.
  /// </summary>  
  public class DeleteFormFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFormFieldRequest"/> class.
        /// </summary>        
        public DeleteFormFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFormFieldRequest"/> class.
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
        public DeleteFormFieldRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteHeaderFooter" /> operation.
  /// </summary>  
  public class DeleteHeaderFooterRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHeaderFooterRequest"/> class.
        /// </summary>        
        public DeleteHeaderFooterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHeaderFooterRequest"/> class.
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
        public DeleteHeaderFooterRequest(string name, int? index, string sectionPath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.SectionPath = sectionPath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string SectionPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteHeadersFooters" /> operation.
  /// </summary>  
  public class DeleteHeadersFootersRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHeadersFootersRequest"/> class.
        /// </summary>        
        public DeleteHeadersFootersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHeadersFootersRequest"/> class.
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
        public DeleteHeadersFootersRequest(string name, string sectionPath = null, string headersFootersTypes = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.SectionPath = sectionPath;
            this.HeadersFootersTypes = headersFootersTypes;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string SectionPath { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string HeadersFootersTypes { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteOfficeMathObject" /> operation.
  /// </summary>  
  public class DeleteOfficeMathObjectRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOfficeMathObjectRequest"/> class.
        /// </summary>        
        public DeleteOfficeMathObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOfficeMathObjectRequest"/> class.
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
        public DeleteOfficeMathObjectRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteParagraph" /> operation.
  /// </summary>  
  public class DeleteParagraphRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteParagraphRequest"/> class.
        /// </summary>        
        public DeleteParagraphRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteParagraphRequest"/> class.
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
        public DeleteParagraphRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteRun" /> operation.
  /// </summary>  
  public class DeleteRunRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRunRequest"/> class.
        /// </summary>        
        public DeleteRunRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRunRequest"/> class.
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
        public DeleteRunRequest(string name, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.ParagraphPath = paragraphPath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTable" /> operation.
  /// </summary>  
  public class DeleteTableRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRequest"/> class.
        /// </summary>        
        public DeleteTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRequest"/> class.
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
        public DeleteTableRequest(string name, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTableCell" /> operation.
  /// </summary>  
  public class DeleteTableCellRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableCellRequest"/> class.
        /// </summary>        
        public DeleteTableCellRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableCellRequest"/> class.
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
        public DeleteTableCellRequest(string name, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.TableRowPath = tableRowPath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string TableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteTableRow" /> operation.
  /// </summary>  
  public class DeleteTableRowRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRowRequest"/> class.
        /// </summary>        
        public DeleteTableRowRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTableRowRequest"/> class.
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
        public DeleteTableRowRequest(string name, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.TablePath = tablePath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string TablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.DeleteUnprotectDocument" /> operation.
  /// </summary>  
  public class DeleteUnprotectDocumentRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUnprotectDocumentRequest"/> class.
        /// </summary>        
        public DeleteUnprotectDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUnprotectDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public DeleteUnprotectDocumentRequest(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ProtectionRequest = protectionRequest;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest ProtectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetBorder" /> operation.
  /// </summary>  
  public class GetBorderRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBorderRequest"/> class.
        /// </summary>        
        public GetBorderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBorderRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="nodePath">Path to node with border(node should be cell or row).</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetBorderRequest(string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetBorders" /> operation.
  /// </summary>  
  public class GetBordersRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBordersRequest"/> class.
        /// </summary>        
        public GetBordersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBordersRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="nodePath">Path to node with borders(node should be cell or row).</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetBordersRequest(string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node with borders(node should be cell or row).
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetComment" /> operation.
  /// </summary>  
  public class GetCommentRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentRequest"/> class.
        /// </summary>        
        public GetCommentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="commentIndex">Comment index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetCommentRequest(string name, int? commentIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.CommentIndex = commentIndex;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? CommentIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetComments" /> operation.
  /// </summary>  
  public class GetCommentsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentsRequest"/> class.
        /// </summary>        
        public GetCommentsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentsRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetCommentsRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocument" /> operation.
  /// </summary>  
  public class GetDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentRequest"/> class.
        /// </summary>        
        public GetDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentRequest"/> class.
        /// </summary>
        /// <param name="documentName">The file name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentRequest(string documentName, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.DocumentName = documentName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string DocumentName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentBookmarkByName" /> operation.
  /// </summary>  
  public class GetDocumentBookmarkByNameRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentBookmarkByNameRequest"/> class.
        /// </summary>        
        public GetDocumentBookmarkByNameRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentBookmarkByNameRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="bookmarkName">The bookmark name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentBookmarkByNameRequest(string name, string bookmarkName, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.BookmarkName = bookmarkName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The bookmark name.
        /// </summary>  
        public string BookmarkName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentBookmarks" /> operation.
  /// </summary>  
  public class GetDocumentBookmarksRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentBookmarksRequest"/> class.
        /// </summary>        
        public GetDocumentBookmarksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentBookmarksRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentBookmarksRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectByIndex" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectByIndexRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectByIndexRequest"/> class.
        /// </summary>        
        public GetDocumentDrawingObjectByIndexRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectByIndexRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentDrawingObjectByIndexRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectImageData" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectImageDataRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectImageDataRequest"/> class.
        /// </summary>        
        public GetDocumentDrawingObjectImageDataRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectImageDataRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentDrawingObjectImageDataRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectOleData" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectOleDataRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectOleDataRequest"/> class.
        /// </summary>        
        public GetDocumentDrawingObjectOleDataRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectOleDataRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentDrawingObjectOleDataRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjects" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectsRequest"/> class.
        /// </summary>        
        public GetDocumentDrawingObjectsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="nodePath">Path to node, which contains collection of drawing objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentDrawingObjectsRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentFieldNames" /> operation.
  /// </summary>  
  public class GetDocumentFieldNamesRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesRequest"/> class.
        /// </summary>        
        public GetDocumentFieldNamesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentFieldNamesRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="useNonMergeFields">If true, result includes \&quot;mustache\&quot; field names.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentFieldNamesRequest(string name, bool? useNonMergeFields = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.UseNonMergeFields = useNonMergeFields;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// If true, result includes \"mustache\" field names.
        /// </summary>  
        public bool? UseNonMergeFields { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentHyperlinkByIndex" /> operation.
  /// </summary>  
  public class GetDocumentHyperlinkByIndexRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentHyperlinkByIndexRequest"/> class.
        /// </summary>        
        public GetDocumentHyperlinkByIndexRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentHyperlinkByIndexRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="hyperlinkIndex">The hyperlink index.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentHyperlinkByIndexRequest(string name, int? hyperlinkIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.HyperlinkIndex = hyperlinkIndex;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The hyperlink index.
        /// </summary>  
        public int? HyperlinkIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentHyperlinks" /> operation.
  /// </summary>  
  public class GetDocumentHyperlinksRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentHyperlinksRequest"/> class.
        /// </summary>        
        public GetDocumentHyperlinksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentHyperlinksRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentHyperlinksRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraph" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRequest"/> class.
        /// </summary>        
        public GetDocumentParagraphRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node which contains paragraphs.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentParagraphRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRun" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunRequest"/> class.
        /// </summary>        
        public GetDocumentParagraphRunRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="paragraphPath">Path to parent paragraph.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentParagraphRunRequest(string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ParagraphPath = paragraphPath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRunFont" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunFontRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunFontRequest"/> class.
        /// </summary>        
        public GetDocumentParagraphRunFontRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunFontRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="paragraphPath">Path to parent paragraph.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentParagraphRunFontRequest(string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ParagraphPath = paragraphPath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphRuns" /> operation.
  /// </summary>  
  public class GetDocumentParagraphRunsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunsRequest"/> class.
        /// </summary>        
        public GetDocumentParagraphRunsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphRunsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="paragraphPath">Path to parent paragraph.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentParagraphRunsRequest(string name, string paragraphPath, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ParagraphPath = paragraphPath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentParagraphs" /> operation.
  /// </summary>  
  public class GetDocumentParagraphsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphsRequest"/> class.
        /// </summary>        
        public GetDocumentParagraphsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentParagraphsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="nodePath">Path to node which contains paragraphs.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentParagraphsRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProperties" /> operation.
  /// </summary>  
  public class GetDocumentPropertiesRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPropertiesRequest"/> class.
        /// </summary>        
        public GetDocumentPropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">The document&#39;s name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentPropertiesRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document's name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProperty" /> operation.
  /// </summary>  
  public class GetDocumentPropertyRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPropertyRequest"/> class.
        /// </summary>        
        public GetDocumentPropertyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentPropertyRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="propertyName">The property name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentPropertyRequest(string name, string propertyName, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.PropertyName = propertyName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The property name.
        /// </summary>  
        public string PropertyName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentProtection" /> operation.
  /// </summary>  
  public class GetDocumentProtectionRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProtectionRequest"/> class.
        /// </summary>        
        public GetDocumentProtectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProtectionRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentProtectionRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentStatistics" /> operation.
  /// </summary>  
  public class GetDocumentStatisticsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsRequest"/> class.
        /// </summary>        
        public GetDocumentStatisticsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatisticsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="includeComments">Support including/excluding comments from the WordCount. Default value is \&quot;true\&quot;.</param>
        /// <param name="includeFootnotes">Support including/excluding footnotes from the WordCount. Default value is \&quot;false\&quot;.</param>
        /// <param name="includeTextInShapes">Support including/excluding shape&#39;s text from the WordCount. Default value is \&quot;false\&quot;</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentStatisticsRequest(string name, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.IncludeComments = includeComments;
            this.IncludeFootnotes = includeFootnotes;
            this.IncludeTextInShapes = includeTextInShapes;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Support including/excluding comments from the WordCount. Default value is \"true\".
        /// </summary>  
        public bool? IncludeComments { get; set; }

        /// <summary>
        /// Support including/excluding footnotes from the WordCount. Default value is \"false\".
        /// </summary>  
        public bool? IncludeFootnotes { get; set; }

        /// <summary>
        /// Support including/excluding shape's text from the WordCount. Default value is \"false\"
        /// </summary>  
        public bool? IncludeTextInShapes { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentTextItems" /> operation.
  /// </summary>  
  public class GetDocumentTextItemsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextItemsRequest"/> class.
        /// </summary>        
        public GetDocumentTextItemsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextItemsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentTextItemsRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentWithFormat" /> operation.
  /// </summary>  
  public class GetDocumentWithFormatRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentWithFormatRequest"/> class.
        /// </summary>        
        public GetDocumentWithFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentWithFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="format">The destination format.</param>
        /// <param name="outPath">Path to save result</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public GetDocumentWithFormatRequest(string name, string format, string outPath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.OutPath = outPath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Path to save result
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetField" /> operation.
  /// </summary>  
  public class GetFieldRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldRequest"/> class.
        /// </summary>        
        public GetFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of fields.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFieldRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFields" /> operation.
  /// </summary>  
  public class GetFieldsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldsRequest"/> class.
        /// </summary>        
        public GetFieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldsRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="nodePath">Path to node, which contains collection of fields.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFieldsRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFootnote" /> operation.
  /// </summary>  
  public class GetFootnoteRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFootnoteRequest"/> class.
        /// </summary>        
        public GetFootnoteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFootnoteRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFootnoteRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFootnotes" /> operation.
  /// </summary>  
  public class GetFootnotesRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFootnotesRequest"/> class.
        /// </summary>        
        public GetFootnotesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFootnotesRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="nodePath">Path to node, which contains collection of footnotes.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFootnotesRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFormField" /> operation.
  /// </summary>  
  public class GetFormFieldRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFormFieldRequest"/> class.
        /// </summary>        
        public GetFormFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFormFieldRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node that contains collection of formfields.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFormFieldRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetFormFields" /> operation.
  /// </summary>  
  public class GetFormFieldsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFormFieldsRequest"/> class.
        /// </summary>        
        public GetFormFieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFormFieldsRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="nodePath">Path to node containing collection of form fields.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetFormFieldsRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node containing collection of form fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooter" /> operation.
  /// </summary>  
  public class GetHeaderFooterRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterRequest"/> class.
        /// </summary>        
        public GetHeaderFooterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="headerFooterIndex">Header/footer index.</param>
        /// <param name="filterByType">List of types of headers and footers.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetHeaderFooterRequest(string name, int? headerFooterIndex, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.HeaderFooterIndex = headerFooterIndex;
            this.FilterByType = filterByType;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Header/footer index.
        /// </summary>  
        public int? HeaderFooterIndex { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string FilterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooterOfSection" /> operation.
  /// </summary>  
  public class GetHeaderFooterOfSectionRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterOfSectionRequest"/> class.
        /// </summary>        
        public GetHeaderFooterOfSectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFooterOfSectionRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="headerFooterIndex">Header/footer index.</param>
        /// <param name="sectionIndex">Section index.</param>
        /// <param name="filterByType">List of types of headers and footers.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetHeaderFooterOfSectionRequest(string name, int? headerFooterIndex, int? sectionIndex, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.HeaderFooterIndex = headerFooterIndex;
            this.SectionIndex = sectionIndex;
            this.FilterByType = filterByType;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Header/footer index.
        /// </summary>  
        public int? HeaderFooterIndex { get; set; }

        /// <summary>
        /// Section index.
        /// </summary>  
        public int? SectionIndex { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string FilterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetHeaderFooters" /> operation.
  /// </summary>  
  public class GetHeaderFootersRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFootersRequest"/> class.
        /// </summary>        
        public GetHeaderFootersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetHeaderFootersRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="sectionPath">Path to parent section.</param>
        /// <param name="filterByType">List of types of headers and footers.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetHeaderFootersRequest(string name, string sectionPath = null, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.SectionPath = sectionPath;
            this.FilterByType = filterByType;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string SectionPath { get; set; }

        /// <summary>
        /// List of types of headers and footers.
        /// </summary>  
        public string FilterByType { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetOfficeMathObject" /> operation.
  /// </summary>  
  public class GetOfficeMathObjectRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOfficeMathObjectRequest"/> class.
        /// </summary>        
        public GetOfficeMathObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOfficeMathObjectRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains collection of OfficeMath objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetOfficeMathObjectRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetOfficeMathObjects" /> operation.
  /// </summary>  
  public class GetOfficeMathObjectsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOfficeMathObjectsRequest"/> class.
        /// </summary>        
        public GetOfficeMathObjectsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOfficeMathObjectsRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="nodePath">Path to node, which contains collection of OfficeMath objects.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetOfficeMathObjectsRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains collection of OfficeMath objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSection" /> operation.
  /// </summary>  
  public class GetSectionRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionRequest"/> class.
        /// </summary>        
        public GetSectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="sectionIndex">Section index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetSectionRequest(string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.SectionIndex = sectionIndex;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? SectionIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSectionPageSetup" /> operation.
  /// </summary>  
  public class GetSectionPageSetupRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionPageSetupRequest"/> class.
        /// </summary>        
        public GetSectionPageSetupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionPageSetupRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="sectionIndex">Section index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetSectionPageSetupRequest(string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.SectionIndex = sectionIndex;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? SectionIndex { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetSections" /> operation.
  /// </summary>  
  public class GetSectionsRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionsRequest"/> class.
        /// </summary>        
        public GetSectionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSectionsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetSectionsRequest(string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTable" /> operation.
  /// </summary>  
  public class GetTableRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRequest"/> class.
        /// </summary>        
        public GetTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains tables.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTableRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableCell" /> operation.
  /// </summary>  
  public class GetTableCellRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableCellRequest"/> class.
        /// </summary>        
        public GetTableCellRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableCellRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="tableRowPath">Path to table row.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTableCellRequest(string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.TableRowPath = tableRowPath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string TableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableCellFormat" /> operation.
  /// </summary>  
  public class GetTableCellFormatRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableCellFormatRequest"/> class.
        /// </summary>        
        public GetTableCellFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableCellFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="tableRowPath">Path to table row.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTableCellFormatRequest(string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.TableRowPath = tableRowPath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string TableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableProperties" /> operation.
  /// </summary>  
  public class GetTablePropertiesRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTablePropertiesRequest"/> class.
        /// </summary>        
        public GetTablePropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTablePropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index</param>
        /// <param name="nodePath">Path to node, which contains tables.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTablePropertiesRequest(string name, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableRow" /> operation.
  /// </summary>  
  public class GetTableRowRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRowRequest"/> class.
        /// </summary>        
        public GetTableRowRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRowRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="tablePath">Path to table.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTableRowRequest(string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.TablePath = tablePath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string TablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTableRowFormat" /> operation.
  /// </summary>  
  public class GetTableRowFormatRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRowFormatRequest"/> class.
        /// </summary>        
        public GetTableRowFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableRowFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="tablePath">Path to table.</param>
        /// <param name="index">Object index</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTableRowFormatRequest(string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.TablePath = tablePath;
            this.Index = index;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string TablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetTables" /> operation.
  /// </summary>  
  public class GetTablesRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTablesRequest"/> class.
        /// </summary>        
        public GetTablesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTablesRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="nodePath">Path to node, which contains tables.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetTablesRequest(string name, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTable" /> operation.
  /// </summary>  
  public class InsertTableRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableRequest"/> class.
        /// </summary>        
        public InsertTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableRequest"/> class.
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
        public InsertTableRequest(string name, TableInsert table, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Table = table;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Table parameters/
        /// </summary>  
        public TableInsert Table { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTableCell" /> operation.
  /// </summary>  
  public class InsertTableCellRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableCellRequest"/> class.
        /// </summary>        
        public InsertTableCellRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableCellRequest"/> class.
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
        public InsertTableCellRequest(string name, TableCellInsert cell, string tableRowPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Cell = cell;
            this.TableRowPath = tableRowPath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Table cell parameters/
        /// </summary>  
        public TableCellInsert Cell { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string TableRowPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertTableRow" /> operation.
  /// </summary>  
  public class InsertTableRowRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableRowRequest"/> class.
        /// </summary>        
        public InsertTableRowRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertTableRowRequest"/> class.
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
        public InsertTableRowRequest(string name, TableRowInsert row, string tablePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Row = row;
            this.TablePath = tablePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Table row parameters/
        /// </summary>  
        public TableRowInsert Row { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string TablePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostAppendDocument" /> operation.
  /// </summary>  
  public class PostAppendDocumentRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAppendDocumentRequest"/> class.
        /// </summary>        
        public PostAppendDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAppendDocumentRequest"/> class.
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
        public PostAppendDocumentRequest(string name, DocumentEntryList documentList, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.DocumentList = documentList;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// Original document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.DocumentEntryList} with a list of documents to append.
        /// </summary>  
        public DocumentEntryList DocumentList { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostChangeDocumentProtection" /> operation.
  /// </summary>  
  public class PostChangeDocumentProtectionRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostChangeDocumentProtectionRequest"/> class.
        /// </summary>        
        public PostChangeDocumentProtectionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChangeDocumentProtectionRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public PostChangeDocumentProtectionRequest(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ProtectionRequest = protectionRequest;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest ProtectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostComment" /> operation.
  /// </summary>  
  public class PostCommentRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCommentRequest"/> class.
        /// </summary>        
        public PostCommentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCommentRequest"/> class.
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
        public PostCommentRequest(string name, int? commentIndex, Comment comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.CommentIndex = commentIndex;
            this.Comment = comment;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? CommentIndex { get; set; }

        /// <summary>
        /// Comment data.
        /// </summary>  
        public Comment Comment { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostCompareDocument" /> operation.
  /// </summary>  
  public class PostCompareDocumentRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCompareDocumentRequest"/> class.
        /// </summary>        
        public PostCompareDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCompareDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">Original document name.</param>
        /// <param name="compareData">{Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public PostCompareDocumentRequest(string name, CompareData compareData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.CompareData = compareData;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// Original document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare.
        /// </summary>  
        public CompareData CompareData { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentExecuteMailMerge" /> operation.
  /// </summary>  
  public class PostDocumentExecuteMailMergeRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentExecuteMailMergeRequest"/> class.
        /// </summary>        
        public PostDocumentExecuteMailMergeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentExecuteMailMergeRequest"/> class.
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
        public PostDocumentExecuteMailMergeRequest(string name, bool? withRegions, string data = null, string mailMergeDataFile = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.WithRegions = withRegions;
            this.Data = data;
            this.MailMergeDataFile = mailMergeDataFile;
            this.Cleanup = cleanup;
            this.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// With regions flag.
        /// </summary>  
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Mail merge data
        /// </summary>  
        public string Data { get; set; }

        /// <summary>
        /// Mail merge data.
        /// </summary>  
        public string MailMergeDataFile { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.
        /// </summary>  
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentParagraphRunFont" /> operation.
  /// </summary>  
  public class PostDocumentParagraphRunFontRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentParagraphRunFontRequest"/> class.
        /// </summary>        
        public PostDocumentParagraphRunFontRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentParagraphRunFontRequest"/> class.
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
        public PostDocumentParagraphRunFontRequest(string name, Font fontDto, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.FontDto = fontDto;
            this.ParagraphPath = paragraphPath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Font dto object
        /// </summary>  
        public Font FontDto { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDocumentSaveAs" /> operation.
  /// </summary>  
  public class PostDocumentSaveAsRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentSaveAsRequest"/> class.
        /// </summary>        
        public PostDocumentSaveAsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDocumentSaveAsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="saveOptionsData">Save options.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public PostDocumentSaveAsRequest(string name, SaveOptionsData saveOptionsData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.SaveOptionsData = saveOptionsData;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Save options.
        /// </summary>  
        public SaveOptionsData SaveOptionsData { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostDrawingObject" /> operation.
  /// </summary>  
  public class PostDrawingObjectRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingObjectRequest"/> class.
        /// </summary>        
        public PostDrawingObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingObjectRequest"/> class.
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
        public PostDrawingObjectRequest(string name, string drawingObject, System.IO.Stream imageFile, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.DrawingObject = drawingObject;
            this.ImageFile = imageFile;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Drawing object parameters
        /// </summary>  
        public string DrawingObject { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostExecuteTemplate" /> operation.
  /// </summary>  
  public class PostExecuteTemplateRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostExecuteTemplateRequest"/> class.
        /// </summary>        
        public PostExecuteTemplateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostExecuteTemplateRequest"/> class.
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
        public PostExecuteTemplateRequest(string name, string data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Data = data;
            this.Cleanup = cleanup;
            this.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
            this.WithRegions = withRegions;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The template document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Mail merge data
        /// </summary>  
        public string Data { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or   TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.    The default value is true.
        /// </summary>  
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Merge with regions or not. True by default
        /// </summary>  
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostField" /> operation.
  /// </summary>  
  public class PostFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFieldRequest"/> class.
        /// </summary>        
        public PostFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFieldRequest"/> class.
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
        public PostFieldRequest(string name, Field field, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Field = field;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Field data.
        /// </summary>  
        public Field Field { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostFootnote" /> operation.
  /// </summary>  
  public class PostFootnoteRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFootnoteRequest"/> class.
        /// </summary>        
        public PostFootnoteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFootnoteRequest"/> class.
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
        public PostFootnoteRequest(string name, Footnote footnoteDto, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.FootnoteDto = footnoteDto;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Footnote data.
        /// </summary>  
        public Footnote FootnoteDto { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostFormField" /> operation.
  /// </summary>  
  public class PostFormFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFormFieldRequest"/> class.
        /// </summary>        
        public PostFormFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFormFieldRequest"/> class.
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
        public PostFormFieldRequest(string name, FormField formField, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.FormField = formField;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// From field data.
        /// </summary>  
        public FormField FormField { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertDocumentWatermarkImage" /> operation.
  /// </summary>  
  public class PostInsertDocumentWatermarkImageRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertDocumentWatermarkImageRequest"/> class.
        /// </summary>        
        public PostInsertDocumentWatermarkImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertDocumentWatermarkImageRequest"/> class.
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
        public PostInsertDocumentWatermarkImageRequest(string name, System.IO.Stream imageFile = null, double? rotationAngle = null, string image = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.ImageFile = imageFile;
            this.RotationAngle = rotationAngle;
            this.Image = image;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// The watermark rotation angle.
        /// </summary>  
        public double? RotationAngle { get; set; }

        /// <summary>
        /// The image file server full name. If the name is empty the image is expected in request content.
        /// </summary>  
        public string Image { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertDocumentWatermarkText" /> operation.
  /// </summary>  
  public class PostInsertDocumentWatermarkTextRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertDocumentWatermarkTextRequest"/> class.
        /// </summary>        
        public PostInsertDocumentWatermarkTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertDocumentWatermarkTextRequest"/> class.
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
        public PostInsertDocumentWatermarkTextRequest(string name, WatermarkText watermarkText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.WatermarkText = watermarkText;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.WatermarkText} with the watermark data.
        /// </summary>  
        public WatermarkText WatermarkText { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostInsertPageNumbers" /> operation.
  /// </summary>  
  public class PostInsertPageNumbersRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertPageNumbersRequest"/> class.
        /// </summary>        
        public PostInsertPageNumbersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInsertPageNumbersRequest"/> class.
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
        public PostInsertPageNumbersRequest(string name, PageNumber pageNumber, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.PageNumber = pageNumber;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// A document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.PageNumber} with the page numbers settings.
        /// </summary>  
        public PageNumber PageNumber { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostLoadWebDocument" /> operation.
  /// </summary>  
  public class PostLoadWebDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostLoadWebDocumentRequest"/> class.
        /// </summary>        
        public PostLoadWebDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLoadWebDocumentRequest"/> class.
        /// </summary>
        /// <param name="data">Parameters of loading.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        public PostLoadWebDocumentRequest(LoadWebDocumentData data, string storage = null)             
        {
            this.Data = data;
            this.Storage = storage;
        }

        /// <summary>
        /// Parameters of loading.
        /// </summary>  
        public LoadWebDocumentData Data { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostReplaceText" /> operation.
  /// </summary>  
  public class PostReplaceTextRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostReplaceTextRequest"/> class.
        /// </summary>        
        public PostReplaceTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostReplaceTextRequest"/> class.
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
        public PostReplaceTextRequest(string name, ReplaceTextRequest replaceText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.ReplaceText = replaceText;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.Replace.ReplaceTextResponse} with the replace operation settings.
        /// </summary>  
        public ReplaceTextRequest ReplaceText { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostRun" /> operation.
  /// </summary>  
  public class PostRunRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostRunRequest"/> class.
        /// </summary>        
        public PostRunRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostRunRequest"/> class.
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
        public PostRunRequest(string name, Run run, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Run = run;
            this.ParagraphPath = paragraphPath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Run data.
        /// </summary>  
        public Run Run { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
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
  public class PostSplitDocumentRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSplitDocumentRequest"/> class.
        /// </summary>        
        public PostSplitDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSplitDocumentRequest"/> class.
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
        public PostSplitDocumentRequest(string name, string format = null, int? from = null, int? to = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.From = from;
            this.To = to;
            this.ZipOutput = zipOutput;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Original document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Format to split.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Start page.
        /// </summary>  
        public int? From { get; set; }

        /// <summary>
        /// End page.
        /// </summary>  
        public int? To { get; set; }

        /// <summary>
        /// ZipOutput or not.
        /// </summary>  
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostUpdateDocumentBookmark" /> operation.
  /// </summary>  
  public class PostUpdateDocumentBookmarkRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpdateDocumentBookmarkRequest"/> class.
        /// </summary>        
        public PostUpdateDocumentBookmarkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpdateDocumentBookmarkRequest"/> class.
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
        public PostUpdateDocumentBookmarkRequest(string name, BookmarkData bookmarkData, string bookmarkName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.BookmarkData = bookmarkData;
            this.BookmarkName = bookmarkName;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.DocumentElements.Bookmarks.BookmarkData} with new bookmark data.
        /// </summary>  
        public BookmarkData BookmarkData { get; set; }

        /// <summary>
        /// The bookmark name.
        /// </summary>  
        public string BookmarkName { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostUpdateDocumentFields" /> operation.
  /// </summary>  
  public class PostUpdateDocumentFieldsRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpdateDocumentFieldsRequest"/> class.
        /// </summary>        
        public PostUpdateDocumentFieldsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostUpdateDocumentFieldsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public PostUpdateDocumentFieldsRequest(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutComment" /> operation.
  /// </summary>  
  public class PutCommentRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutCommentRequest"/> class.
        /// </summary>        
        public PutCommentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutCommentRequest"/> class.
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
        public PutCommentRequest(string name, Comment comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Comment = comment;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Comment data.
        /// </summary>  
        public Comment Comment { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutConvertDocument" /> operation.
  /// </summary>  
  public class PutConvertDocumentRequest : ICanUseCustomFontsRequest   
  {
      public PutConvertDocumentRequest()
      {
          
      }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertDocumentRequest"/> class.
        /// </summary>        
        public PutConvertDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutConvertDocumentRequest"/> class.
        /// </summary>
        /// <param name="format">Format to convert.</param>
        /// <param name="document">Converting document</param>
        /// <param name="outPath">Path for saving operation result to the local storage.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public PutConvertDocumentRequest(string format, System.IO.Stream document, string outPath = null, string storage = null, string fontsLocation = null)             
        {
            this.Format = format;
            this.Document = document;
            this.OutPath = outPath;
            this.Storage = storage;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// Format to convert.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Converting document
        /// </summary>  
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// Path for saving operation result to the local storage.
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutCreateDocument" /> operation.
  /// </summary>  
  public class PutCreateDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutCreateDocumentRequest"/> class.
        /// </summary>        
        public PutCreateDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutCreateDocumentRequest"/> class.
        /// </summary>
        /// <param name="folder">The document folder.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        public PutCreateDocumentRequest(string folder = null, string storage = null)             
        {
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentFieldNames" /> operation.
  /// </summary>  
  public class PutDocumentFieldNamesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentFieldNamesRequest"/> class.
        /// </summary>        
        public PutDocumentFieldNamesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentFieldNamesRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="useNonMergeFields">Use non merge fields or not.</param>
        public PutDocumentFieldNamesRequest(System.IO.Stream template, bool? useNonMergeFields = null)             
        {
            this.Template = template;
            this.UseNonMergeFields = useNonMergeFields;
        }

        /// <summary>
        /// File with template
        /// </summary>  
        public System.IO.Stream Template { get; set; }

        /// <summary>
        /// Use non merge fields or not.
        /// </summary>  
        public bool? UseNonMergeFields { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDocumentSaveAsTiff" /> operation.
  /// </summary>  
  public class PutDocumentSaveAsTiffRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentSaveAsTiffRequest"/> class.
        /// </summary>        
        public PutDocumentSaveAsTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDocumentSaveAsTiffRequest"/> class.
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
        public PutDocumentSaveAsTiffRequest(string name, TiffSaveOptionsData saveOptions, string resultFile = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, float? imageBrightness = null, string imageColorMode = null, float? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, float? resolution = null, float? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.SaveOptions = saveOptions;
            this.ResultFile = resultFile;
            this.UseAntiAliasing = useAntiAliasing;
            this.UseHighQualityRendering = useHighQualityRendering;
            this.ImageBrightness = imageBrightness;
            this.ImageColorMode = imageColorMode;
            this.ImageContrast = imageContrast;
            this.NumeralFormat = numeralFormat;
            this.PageCount = pageCount;
            this.PageIndex = pageIndex;
            this.PaperColor = paperColor;
            this.PixelFormat = pixelFormat;
            this.Resolution = resolution;
            this.Scale = scale;
            this.TiffCompression = tiffCompression;
            this.DmlRenderingMode = dmlRenderingMode;
            this.DmlEffectsRenderingMode = dmlEffectsRenderingMode;
            this.TiffBinarizationMethod = tiffBinarizationMethod;
            this.ZipOutput = zipOutput;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Tiff save options.
        /// </summary>  
        public TiffSaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// The resulting file name.
        /// </summary>  
        public string ResultFile { get; set; }

        /// <summary>
        /// Use antialiasing flag.
        /// </summary>  
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Use high quality flag.
        /// </summary>  
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Brightness for the generated images.
        /// </summary>  
        public float? ImageBrightness { get; set; }

        /// <summary>
        /// Color mode for the generated images.
        /// </summary>  
        public string ImageColorMode { get; set; }

        /// <summary>
        /// The contrast for the generated images.
        /// </summary>  
        public float? ImageContrast { get; set; }

        /// <summary>
        /// The images numeral format.
        /// </summary>  
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Number of pages to render.
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Page index to start rendering.
        /// </summary>  
        public int? PageIndex { get; set; }

        /// <summary>
        /// Background image color.
        /// </summary>  
        public string PaperColor { get; set; }

        /// <summary>
        /// The pixel format of generated images.
        /// </summary>  
        public string PixelFormat { get; set; }

        /// <summary>
        /// The resolution of generated images.
        /// </summary>  
        public float? Resolution { get; set; }

        /// <summary>
        /// Zoom factor for generated images.
        /// </summary>  
        public float? Scale { get; set; }

        /// <summary>
        /// The compression tipe.
        /// </summary>  
        public string TiffCompression { get; set; }

        /// <summary>
        /// Optional, default is Fallback.
        /// </summary>  
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Optional, default is Simplified.
        /// </summary>  
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
        /// </summary>  
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Optional. A value determining zip output or not.
        /// </summary>  
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutDrawingObject" /> operation.
  /// </summary>  
  public class PutDrawingObjectRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDrawingObjectRequest"/> class.
        /// </summary>        
        public PutDrawingObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDrawingObjectRequest"/> class.
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
        public PutDrawingObjectRequest(string name, string drawingObject, System.IO.Stream imageFile, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.DrawingObject = drawingObject;
            this.ImageFile = imageFile;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Drawing object parameters
        /// </summary>  
        public string DrawingObject { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// Path to node, which contains collection of drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutExecuteMailMergeOnline" /> operation.
  /// </summary>  
  public class PutExecuteMailMergeOnlineRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteMailMergeOnlineRequest"/> class.
        /// </summary>        
        public PutExecuteMailMergeOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteMailMergeOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="data">File with mailmerge data</param>
        /// <param name="withRegions">With regions flag.</param>
        /// <param name="cleanup">Clean up options.</param>
        public PutExecuteMailMergeOnlineRequest(System.IO.Stream template, System.IO.Stream data, bool? withRegions = null, string cleanup = null)             
        {
            this.Template = template;
            this.Data = data;
            this.WithRegions = withRegions;
            this.Cleanup = cleanup;
        }

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
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutExecuteTemplateOnline" /> operation.
  /// </summary>  
  public class PutExecuteTemplateOnlineRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateOnlineRequest"/> class.
        /// </summary>        
        public PutExecuteTemplateOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutExecuteTemplateOnlineRequest"/> class.
        /// </summary>
        /// <param name="template">File with template</param>
        /// <param name="data">File with mailmerge data</param>
        /// <param name="cleanup">Clean up options.</param>
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.</param>
        /// <param name="withRegions">Merge with regions or not. True by default</param>
        public PutExecuteTemplateOnlineRequest(System.IO.Stream template, System.IO.Stream data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null)             
        {
            this.Template = template;
            this.Data = data;
            this.Cleanup = cleanup;
            this.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
            this.WithRegions = withRegions;
        }

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
        public string Cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true.
        /// </summary>  
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Merge with regions or not. True by default
        /// </summary>  
        public bool? WithRegions { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutField" /> operation.
  /// </summary>  
  public class PutFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFieldRequest"/> class.
        /// </summary>        
        public PutFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFieldRequest"/> class.
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
        public PutFieldRequest(string name, Field field, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Field = field;
            this.NodePath = nodePath;
            this.InsertBeforeNode = insertBeforeNode;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Field data.
        /// </summary>  
        public Field Field { get; set; }

        /// <summary>
        /// Path to node, which contains collection of fields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Field will be inserted before node with id=\"nodeId\".
        /// </summary>  
        public string InsertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutFootnote" /> operation.
  /// </summary>  
  public class PutFootnoteRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFootnoteRequest"/> class.
        /// </summary>        
        public PutFootnoteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFootnoteRequest"/> class.
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
        public PutFootnoteRequest(string name, Footnote footnoteDto, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.FootnoteDto = footnoteDto;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Footnote data.
        /// </summary>  
        public Footnote FootnoteDto { get; set; }

        /// <summary>
        /// Path to node, which contains collection of footnotes.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutFormField" /> operation.
  /// </summary>  
  public class PutFormFieldRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutFormFieldRequest"/> class.
        /// </summary>        
        public PutFormFieldRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFormFieldRequest"/> class.
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
        public PutFormFieldRequest(string name, FormField formField, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.FormField = formField;
            this.NodePath = nodePath;
            this.InsertBeforeNode = insertBeforeNode;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// From field data.
        /// </summary>  
        public FormField FormField { get; set; }

        /// <summary>
        /// Path to node that contains collection of formfields.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Form field will be inserted before node with index.
        /// </summary>  
        public string InsertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutHeaderFooter" /> operation.
  /// </summary>  
  public class PutHeaderFooterRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutHeaderFooterRequest"/> class.
        /// </summary>        
        public PutHeaderFooterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutHeaderFooterRequest"/> class.
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
        public PutHeaderFooterRequest(string name, string headerFooterType, string sectionPath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.HeaderFooterType = headerFooterType;
            this.SectionPath = sectionPath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Type of header/footer.
        /// </summary>  
        public string HeaderFooterType { get; set; }

        /// <summary>
        /// Path to parent section.
        /// </summary>  
        public string SectionPath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutParagraph" /> operation.
  /// </summary>  
  public class PutParagraphRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutParagraphRequest"/> class.
        /// </summary>        
        public PutParagraphRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutParagraphRequest"/> class.
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
        public PutParagraphRequest(string name, ParagraphInsert paragraph, string nodePath = null, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Paragraph = paragraph;
            this.NodePath = nodePath;
            this.InsertBeforeNode = insertBeforeNode;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Paragraph data.
        /// </summary>  
        public ParagraphInsert Paragraph { get; set; }

        /// <summary>
        /// Path to node which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Paragraph will be inserted before node with index.
        /// </summary>  
        public string InsertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutProtectDocument" /> operation.
  /// </summary>  
  public class PutProtectDocumentRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutProtectDocumentRequest"/> class.
        /// </summary>        
        public PutProtectDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutProtectDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="protectionRequest">{Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public PutProtectDocumentRequest(string name, ProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.ProtectionRequest = protectionRequest;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
        /// </summary>  
        public ProtectionRequest ProtectionRequest { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PutRun" /> operation.
  /// </summary>  
  public class PutRunRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutRunRequest"/> class.
        /// </summary>        
        public PutRunRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutRunRequest"/> class.
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
        public PutRunRequest(string name, string paragraphPath, Run run, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.ParagraphPath = paragraphPath;
            this.Run = run;
            this.InsertBeforeNode = insertBeforeNode;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Path to parent paragraph.
        /// </summary>  
        public string ParagraphPath { get; set; }

        /// <summary>
        /// Run data.
        /// </summary>  
        public Run Run { get; set; }

        /// <summary>
        /// Paragraph will be inserted before node with index.
        /// </summary>  
        public string InsertBeforeNode { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RejectAllRevisions" /> operation.
  /// </summary>  
  public class RejectAllRevisionsRequest : ICanModifyDocumentRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectAllRevisionsRequest"/> class.
        /// </summary>        
        public RejectAllRevisionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectAllRevisionsRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public RejectAllRevisionsRequest(string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderDrawingObject" /> operation.
  /// </summary>  
  public class RenderDrawingObjectRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderDrawingObjectRequest"/> class.
        /// </summary>        
        public RenderDrawingObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderDrawingObjectRequest"/> class.
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
        public RenderDrawingObjectRequest(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains drawing objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderMathObject" /> operation.
  /// </summary>  
  public class RenderMathObjectRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderMathObjectRequest"/> class.
        /// </summary>        
        public RenderMathObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderMathObjectRequest"/> class.
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
        public RenderMathObjectRequest(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains office math objects.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderPage" /> operation.
  /// </summary>  
  public class RenderPageRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderPageRequest"/> class.
        /// </summary>        
        public RenderPageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderPageRequest"/> class.
        /// </summary>
        /// <param name="name">The file name.</param>
        /// <param name="pageIndex">Comment index</param>
        /// <param name="format">The destination format.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public RenderPageRequest(string name, int? pageIndex, string format, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.PageIndex = pageIndex;
            this.Format = format;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Comment index
        /// </summary>  
        public int? PageIndex { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderParagraph" /> operation.
  /// </summary>  
  public class RenderParagraphRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderParagraphRequest"/> class.
        /// </summary>        
        public RenderParagraphRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderParagraphRequest"/> class.
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
        public RenderParagraphRequest(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains paragraphs.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.RenderTable" /> operation.
  /// </summary>  
  public class RenderTableRequest : IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTableRequest"/> class.
        /// </summary>        
        public RenderTableRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderTableRequest"/> class.
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
        public RenderTableRequest(string name, string format, int? index, string nodePath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)             
        {
            this.Name = name;
            this.Format = format;
            this.Index = index;
            this.NodePath = nodePath;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The destination format.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }
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
  public class SearchRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest"/> class.
        /// </summary>        
        public SearchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="pattern">The regular expression used to find matches.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public SearchRequest(string name, string pattern = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Pattern = pattern;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The regular expression used to find matches.
        /// </summary>  
        public string Pattern { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateBorder" /> operation.
  /// </summary>  
  public class UpdateBorderRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBorderRequest"/> class.
        /// </summary>        
        public UpdateBorderRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBorderRequest"/> class.
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
        public UpdateBorderRequest(string name, Border borderProperties, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.BorderProperties = borderProperties;
            this.NodePath = nodePath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Border properties
        /// </summary>  
        public Border BorderProperties { get; set; }

        /// <summary>
        /// Path to node with border(node should be cell or row).
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateSectionPageSetup" /> operation.
  /// </summary>  
  public class UpdateSectionPageSetupRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSectionPageSetupRequest"/> class.
        /// </summary>        
        public UpdateSectionPageSetupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSectionPageSetupRequest"/> class.
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
        public UpdateSectionPageSetupRequest(string name, int? sectionIndex, PageSetup pageSetup, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.SectionIndex = sectionIndex;
            this.PageSetup = pageSetup;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Section index
        /// </summary>  
        public int? SectionIndex { get; set; }

        /// <summary>
        /// Page setup properties dto
        /// </summary>  
        public PageSetup PageSetup { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableCellFormat" /> operation.
  /// </summary>  
  public class UpdateTableCellFormatRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableCellFormatRequest"/> class.
        /// </summary>        
        public UpdateTableCellFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableCellFormatRequest"/> class.
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
        public UpdateTableCellFormatRequest(string name, TableCellFormat format, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Format = format;
            this.TableRowPath = tableRowPath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The properties.
        /// </summary>  
        public TableCellFormat Format { get; set; }

        /// <summary>
        /// Path to table row.
        /// </summary>  
        public string TableRowPath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableProperties" /> operation.
  /// </summary>  
  public class UpdateTablePropertiesRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTablePropertiesRequest"/> class.
        /// </summary>        
        public UpdateTablePropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTablePropertiesRequest"/> class.
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
        public UpdateTablePropertiesRequest(string name, TableProperties properties, int? index, string nodePath = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Properties = properties;
            this.Index = index;
            this.NodePath = nodePath;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The properties.
        /// </summary>  
        public TableProperties Properties { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to node, which contains tables.
        /// </summary>  
        public string NodePath { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateTableRowFormat" /> operation.
  /// </summary>  
  public class UpdateTableRowFormatRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableRowFormatRequest"/> class.
        /// </summary>        
        public UpdateTableRowFormatRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableRowFormatRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="format">Table row format.</param>
        /// <param name="tablePath">Path to table.</param>
        /// <param name="index">Object index</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public UpdateTableRowFormatRequest(string name, TableRowFormat format, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)             
        {
            this.Name = name;
            this.Format = format;
            this.TablePath = tablePath;
            this.Index = index;
            this.DestFileName = destFileName;
            this.Storage = storage;
            this.Folder = folder;
            this.LoadEncoding = loadEncoding;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Table row format.
        /// </summary>  
        public TableRowFormat Format { get; set; }

        /// <summary>
        /// Path to table.
        /// </summary>  
        public string TablePath { get; set; }

        /// <summary>
        /// Object index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }
  }
}
