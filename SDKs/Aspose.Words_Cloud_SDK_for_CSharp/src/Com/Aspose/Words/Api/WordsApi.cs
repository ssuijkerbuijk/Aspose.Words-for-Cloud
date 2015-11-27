  using System;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  using Com.Aspose.Words;
  using Com.Aspose.Words.Model;
  namespace Com.Aspose.Words.Api {
    public class WordsApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public WordsApi(String apiKey, String appSid, String basePath = "http://api.aspose.com/v1.1")
      {
	    apiInvoker.addDefaultHeader(apiInvoker.API_KEY,apiKey);
        apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="bookmarkName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public BookmarkResponse GetDocumentBookmarkByName (string name, string bookmarkName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || bookmarkName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (bookmarkName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])bookmarkName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "bookmarkName" + "}", apiInvoker.ToPathValue(bookmarkName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BookmarkResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BookmarkResponse) ApiInvoker.deserialize(response, typeof(BookmarkResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BookmarkResponse) ApiInvoker.deserialize(response, typeof(BookmarkResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public BookmarksResponse GetDocumentBookmarks (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/bookmarks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BookmarksResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BookmarksResponse) ApiInvoker.deserialize(response, typeof(BookmarksResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (BookmarksResponse) ApiInvoker.deserialize(response, typeof(BookmarksResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="bookmarkName"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public BookmarkResponse PostUpdateDocumentBookmark (string name, string bookmarkName, string filename, string storage, string folder, BookmarkData body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || bookmarkName == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (bookmarkName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])bookmarkName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "bookmarkName" + "}", apiInvoker.ToPathValue(bookmarkName)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(BookmarkResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (BookmarkResponse) ApiInvoker.deserialize(response, typeof(BookmarkResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (BookmarkResponse) ApiInvoker.deserialize(response, typeof(BookmarkResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocument (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="outPath"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentWithFormat (string name, string format, string storage, string folder, string outPath) {
        // create path and map variables
        var ResourcePath = "/words/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (outPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "outPath" + "}", apiInvoker.ToPathValue(outPath)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PostAppendDocument (string name, string filename, string storage, string folder, DocumentEntryList body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/appendDocument/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="cleanup"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="useWholeParagraphAsRegion"></param>
      /// <param name="withRegions"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public DocumentResponse PostExecuteTemplate (string name, string cleanup, string filename, string storage, string folder, bool useWholeParagraphAsRegion, bool withRegions, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/{name}/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (cleanup == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "cleanup" + "}", apiInvoker.ToPathValue(cleanup)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (useWholeParagraphAsRegion == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useWholeParagraphAsRegion" + "}", apiInvoker.ToPathValue(useWholeParagraphAsRegion)); 
		}
        if (withRegions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withRegions" + "}", apiInvoker.ToPathValue(withRegions)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PostInsertPageNumbers (string name, string filename, string storage, string folder, PageNumber body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/insertPageNumbers/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <returns></returns>
      public SaveResponse PostLoadWebDocument (Com.Aspose.Words.Model.LoadWebDocumentData body) {
        // create path and map variables
        var ResourcePath = "/words/loadWebDocument/?appSid={appSid}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null)
        {
            throw new ApiException(400, "missing required params");
        }

        try {
          if (typeof(SaveResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <returns></returns>
      public ResponseMessage PostRunTask (byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/tasks/?appSid={appSid}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (file == null)
        {
            throw new ApiException(400, "missing required params");
        }
        if (file != null)
        {
            if (file is byte[])
            {
                formParams.Add("file", file);
            }
            else
            {
                //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
                string paramStr = Convert.ToString(file);
                formParams.Add("file", paramStr);
            }
        }
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="format"></param>
      /// <param name="from"></param>
      /// <param name="to"></param>
      /// <param name="zipOutput"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SplitDocumentResponse PostSplitDocument (string name, string format, int from, int to, bool zipOutput, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/split/?appSid={appSid}&amp;toFormat={toFormat}&amp;from={from}&amp;to={to}&amp;zipOutput={zipOutput}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (from == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])from=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "from" + "}", apiInvoker.ToPathValue(from)); 
		}
        if (to == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])to=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "to" + "}", apiInvoker.ToPathValue(to)); 
		}
        if (zipOutput == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])zipOutput=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "zipOutput" + "}", apiInvoker.ToPathValue(zipOutput)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SplitDocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SplitDocumentResponse) ApiInvoker.deserialize(response, typeof(SplitDocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SplitDocumentResponse) ApiInvoker.deserialize(response, typeof(SplitDocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="format"></param>
      /// <param name="outPath"></param>
      /// <param name="replaceResourcesHostTo"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutConvertDocument (string format, string outPath, string replaceResourcesHostTo, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/convert/?appSid={appSid}&amp;toFormat={toFormat}&amp;outPath={outPath}&amp;replaceResourcesHostTo={replaceResourcesHostTo}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (outPath == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])outPath=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "outPath" + "}", apiInvoker.ToPathValue(outPath)); 
		}
        if (replaceResourcesHostTo == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])replaceResourcesHostTo=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "replaceResourcesHostTo" + "}", apiInvoker.ToPathValue(replaceResourcesHostTo)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="useNonMergeFields"></param>
      /// <returns></returns>
      public FieldNamesResponse PutDocumentFieldNames (bool useNonMergeFields) {
        // create path and map variables
        var ResourcePath = "/words/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (useNonMergeFields == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useNonMergeFields=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useNonMergeFields" + "}", apiInvoker.ToPathValue(useNonMergeFields)); 
		}
        try {
          if (typeof(FieldNamesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldNamesResponse) ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FieldNamesResponse) ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="withRegions"></param>
      /// <param name="cleanup"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutExecuteMailMergeOnline (bool withRegions, string cleanup, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/executeMailMerge/?withRegions={withRegions}&amp;appSid={appSid}&amp;cleanup={cleanup}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (withRegions == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (withRegions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withRegions" + "}", apiInvoker.ToPathValue(withRegions)); 
		}
        if (cleanup == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "cleanup" + "}", apiInvoker.ToPathValue(cleanup)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="cleanup"></param>
      /// <param name="useWholeParagraphAsRegion"></param>
      /// <param name="withRegions"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutExecuteTemplateOnline (string cleanup, bool useWholeParagraphAsRegion, bool withRegions, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (cleanup == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "cleanup" + "}", apiInvoker.ToPathValue(cleanup)); 
		}
        if (useWholeParagraphAsRegion == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useWholeParagraphAsRegion" + "}", apiInvoker.ToPathValue(useWholeParagraphAsRegion)); 
		}
        if (withRegions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withRegions" + "}", apiInvoker.ToPathValue(withRegions)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="commentIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="fileName"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteComment (string name, int commentIndex, string storage, string folder, string fileName) {
        // create path and map variables
        var ResourcePath = "/words/{name}/comments/{commentIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;fileName={fileName}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || commentIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (commentIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])commentIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (fileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fileName" + "}", apiInvoker.ToPathValue(fileName)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="commentIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public CommentResponse GetComment (string name, int commentIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/comments/{commentIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || commentIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (commentIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])commentIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(CommentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public CommentsResponse GetComments (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/comments/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(CommentsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (CommentsResponse) ApiInvoker.deserialize(response, typeof(CommentsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (CommentsResponse) ApiInvoker.deserialize(response, typeof(CommentsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="commentIndex"></param>
      /// <param name="fileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public CommentResponse PostComment (string name, int commentIndex, string fileName, string storage, string folder, CommentDto body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/comments/{commentIndex}/?appSid={appSid}&amp;fileName={fileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || commentIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (commentIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])commentIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "commentIndex" + "}", apiInvoker.ToPathValue(commentIndex)); 
		}
        if (fileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fileName" + "}", apiInvoker.ToPathValue(fileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(CommentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="fileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public CommentResponse PutComment (string name, string fileName, string storage, string folder, CommentDto body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/comments/?appSid={appSid}&amp;fileName={fileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (fileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fileName" + "}", apiInvoker.ToPathValue(fileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(CommentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (CommentResponse) ApiInvoker.deserialize(response, typeof(CommentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteDocumentFields (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="index"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteParagraphFields (string name, int index, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/{index}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || index == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (index == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])index=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteSectionFields (string name, int sectionIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteSectionParagraphFields (string name, int sectionIndex, int paragraphIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="fieldIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FieldResponse GetField (string name, int sectionIndex, int paragraphIndex, int fieldIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || fieldIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (fieldIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fieldIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fieldIndex" + "}", apiInvoker.ToPathValue(fieldIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="fieldIndex"></param>
      /// <param name="destFileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FieldResponse PostField (string name, int sectionIndex, int paragraphIndex, int fieldIndex, string destFileName, string storage, string folder, FieldDto body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || fieldIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (fieldIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])fieldIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "fieldIndex" + "}", apiInvoker.ToPathValue(fieldIndex)); 
		}
        if (destFileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destFileName" + "}", apiInvoker.ToPathValue(destFileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentResponse PostUpdateDocumentFields (string name, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/updateFields/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="insertBeforeNode"></param>
      /// <param name="destFileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FieldResponse PutField (string name, int sectionIndex, int paragraphIndex, string insertBeforeNode, string destFileName, string storage, string folder, FieldDto body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/?appSid={appSid}&amp;insertBeforeNode={insertBeforeNode}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (insertBeforeNode == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "insertBeforeNode" + "}", apiInvoker.ToPathValue(insertBeforeNode)); 
		}
        if (destFileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destFileName" + "}", apiInvoker.ToPathValue(destFileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FieldResponse) ApiInvoker.deserialize(response, typeof(FieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteDocumentProperty (string name, string propertyName, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPropertiesResponse GetDocumentProperties (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/documentProperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertiesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPropertiesResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertiesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPropertiesResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertiesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertyResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="propertyName"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentPropertyResponse PutUpdateDocumentProperty (string name, string propertyName, string filename, string storage, string folder, DocumentProperty body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || propertyName == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (propertyName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])propertyName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "propertyName" + "}", apiInvoker.ToPathValue(propertyName)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentPropertyResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentPropertyResponse) ApiInvoker.deserialize(response, typeof(DocumentPropertyResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public ProtectionDataResponse DeleteUnprotectDocument (string name, string filename, string storage, string folder, ProtectionRequest body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ProtectionDataResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, body, headerParams, formParams);
            if(response != null){
               return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ProtectionDataResponse GetDocumentProtection (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/protection/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ProtectionDataResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public ProtectionDataResponse PostChangeDocumentProtection (string name, string filename, string storage, string folder, ProtectionRequest body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ProtectionDataResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public ProtectionDataResponse PutProtectDocument (string name, string filename, string storage, string folder, ProtectionRequest body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ProtectionDataResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (ProtectionDataResponse) ApiInvoker.deserialize(response, typeof(ProtectionDataResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaveResponse PostDocumentSaveAs (string name, string storage, string folder, SaveOptionsData body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/SaveAs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaveResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
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
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="zipOutput"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SaveResponse PutDocumentSaveAsTiff (string name, string resultFile, bool useAntiAliasing, bool useHighQualityRendering, float? imageBrightness, string imageColorMode, float? imageContrast, string numeralFormat, int? pageCount, int? pageIndex, string paperColor, string pixelFormat, float? resolution, float? scale, string tiffCompression, string dmlRenderingMode, string dmlEffectsRenderingMode, string tiffBinarizationMethod, string storage, string folder, bool zipOutput, TiffSaveOptionsData body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/SaveAs/tiff/?appSid={appSid}&amp;resultFile={resultFile}&amp;useAntiAliasing={useAntiAliasing}&amp;useHighQualityRendering={useHighQualityRendering}&amp;imageBrightness={imageBrightness}&amp;imageColorMode={imageColorMode}&amp;imageContrast={imageContrast}&amp;numeralFormat={numeralFormat}&amp;pageCount={pageCount}&amp;pageIndex={pageIndex}&amp;paperColor={paperColor}&amp;pixelFormat={pixelFormat}&amp;resolution={resolution}&amp;scale={scale}&amp;tiffCompression={tiffCompression}&amp;dmlRenderingMode={dmlRenderingMode}&amp;dmlEffectsRenderingMode={dmlEffectsRenderingMode}&amp;tiffBinarizationMethod={tiffBinarizationMethod}&amp;storage={storage}&amp;folder={folder}&amp;zipOutput={zipOutput}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (resultFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resultFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resultFile" + "}", apiInvoker.ToPathValue(resultFile)); 
		}
        if (useAntiAliasing == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useAntiAliasing=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useAntiAliasing" + "}", apiInvoker.ToPathValue(useAntiAliasing)); 
		}
        if (useHighQualityRendering == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useHighQualityRendering=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useHighQualityRendering" + "}", apiInvoker.ToPathValue(useHighQualityRendering)); 
		}
        if (imageBrightness == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageBrightness=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageBrightness" + "}", apiInvoker.ToPathValue(imageBrightness)); 
		}
        if (imageColorMode == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageColorMode=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageColorMode" + "}", apiInvoker.ToPathValue(imageColorMode)); 
		}
        if (imageContrast == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])imageContrast=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "imageContrast" + "}", apiInvoker.ToPathValue(imageContrast)); 
		}
        if (numeralFormat == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])numeralFormat=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "numeralFormat" + "}", apiInvoker.ToPathValue(numeralFormat)); 
		}
        if (pageCount == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageCount=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageCount" + "}", apiInvoker.ToPathValue(pageCount)); 
		}
        if (pageIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pageIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pageIndex" + "}", apiInvoker.ToPathValue(pageIndex)); 
		}
        if (paperColor == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paperColor=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paperColor" + "}", apiInvoker.ToPathValue(paperColor)); 
		}
        if (pixelFormat == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pixelFormat=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pixelFormat" + "}", apiInvoker.ToPathValue(pixelFormat)); 
		}
        if (resolution == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])resolution=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "resolution" + "}", apiInvoker.ToPathValue(resolution)); 
		}
        if (scale == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])scale=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "scale" + "}", apiInvoker.ToPathValue(scale)); 
		}
        if (tiffCompression == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])tiffCompression=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "tiffCompression" + "}", apiInvoker.ToPathValue(tiffCompression)); 
		}
        if (dmlRenderingMode == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dmlRenderingMode=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dmlRenderingMode" + "}", apiInvoker.ToPathValue(dmlRenderingMode)); 
		}
        if (dmlEffectsRenderingMode == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dmlEffectsRenderingMode=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dmlEffectsRenderingMode" + "}", apiInvoker.ToPathValue(dmlEffectsRenderingMode)); 
		}
        if (tiffBinarizationMethod == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])tiffBinarizationMethod=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "tiffBinarizationMethod" + "}", apiInvoker.ToPathValue(tiffBinarizationMethod)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (zipOutput == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])zipOutput=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "zipOutput" + "}", apiInvoker.ToPathValue(zipOutput)); 
		}
        try {
          if (typeof(SaveResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SaveResponse) ApiInvoker.deserialize(response, typeof(SaveResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="includeComments"></param>
      /// <param name="includeFootnotes"></param>
      /// <param name="includeTextInShapes"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public StatDataResponse GetDocumentStatistics (string name, bool includeComments, bool includeFootnotes, bool includeTextInShapes, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/statistics/?appSid={appSid}&amp;includeComments={includeComments}&amp;includeFootnotes={includeFootnotes}&amp;includeTextInShapes={includeTextInShapes}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (includeComments == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeComments=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "includeComments" + "}", apiInvoker.ToPathValue(includeComments)); 
		}
        if (includeFootnotes == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeFootnotes=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "includeFootnotes" + "}", apiInvoker.ToPathValue(includeFootnotes)); 
		}
        if (includeTextInShapes == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])includeTextInShapes=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "includeTextInShapes" + "}", apiInvoker.ToPathValue(includeTextInShapes)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(StatDataResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (StatDataResponse) ApiInvoker.deserialize(response, typeof(StatDataResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (StatDataResponse) ApiInvoker.deserialize(response, typeof(StatDataResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DocumentResponse DeleteDocumentWatermark (string name, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/watermark/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="image"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public DocumentResponse PostInsertDocumentWatermarkImage (string name, string filename, double rotationAngle, string image, string storage, string folder, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/{name}/watermark/insertImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (image == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])image=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "image" + "}", apiInvoker.ToPathValue(image)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="text"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PostInsertDocumentWatermarkText (string name, string filename, string text, double rotationAngle, string storage, string folder, WatermarkText body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/watermark/insertText/?appSid={appSid}&amp;filename={filename}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (text == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])text=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "text" + "}", apiInvoker.ToPathValue(text)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="objectIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentDrawingObjectByIndex (string name, int objectIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || objectIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (objectIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])objectIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "objectIndex" + "}", apiInvoker.ToPathValue(objectIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="objectIndex"></param>
      /// <param name="format"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentDrawingObjectByIndexWithFormat (string name, int objectIndex, string format, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || objectIndex == null || format == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (objectIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])objectIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "objectIndex" + "}", apiInvoker.ToPathValue(objectIndex)); 
		}
        if (format == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])format=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "format" + "}", apiInvoker.ToPathValue(format)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="objectIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentDrawingObjectImageData (string name, int objectIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/drawingObjects/{objectIndex}/imageData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || objectIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (objectIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])objectIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "objectIndex" + "}", apiInvoker.ToPathValue(objectIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="objectIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ResponseMessage GetDocumentDrawingObjectOleData (string name, int objectIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/drawingObjects/{objectIndex}/oleData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || objectIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (objectIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])objectIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "objectIndex" + "}", apiInvoker.ToPathValue(objectIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public DrawingObjectsResponse GetDocumentDrawingObjects (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/drawingObjects/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DrawingObjectsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DrawingObjectsResponse) ApiInvoker.deserialize(response, typeof(DrawingObjectsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DrawingObjectsResponse) ApiInvoker.deserialize(response, typeof(DrawingObjectsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="formfieldIndex"></param>
      /// <param name="destFileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteFormField (string name, int sectionIndex, int paragraphIndex, int formfieldIndex, string destFileName, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (formfieldIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])formfieldIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "formfieldIndex" + "}", apiInvoker.ToPathValue(formfieldIndex)); 
		}
        if (destFileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destFileName" + "}", apiInvoker.ToPathValue(destFileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="formfieldIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FormFieldResponse GetFormField (string name, int sectionIndex, int paragraphIndex, int formfieldIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (formfieldIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])formfieldIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "formfieldIndex" + "}", apiInvoker.ToPathValue(formfieldIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FormFieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="formfieldIndex"></param>
      /// <param name="destFileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FormFieldResponse PostFormField (string name, int sectionIndex, int paragraphIndex, int formfieldIndex, string destFileName, string storage, string folder, FormField body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (formfieldIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])formfieldIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "formfieldIndex" + "}", apiInvoker.ToPathValue(formfieldIndex)); 
		}
        if (destFileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destFileName" + "}", apiInvoker.ToPathValue(destFileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FormFieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="paragraphIndex"></param>
      /// <param name="insertBeforeNode"></param>
      /// <param name="destFileName"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FormFieldResponse PutFormField (string name, int sectionIndex, int paragraphIndex, string insertBeforeNode, string destFileName, string storage, string folder, FormField body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/?appSid={appSid}&amp;insertBeforeNode={insertBeforeNode}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || paragraphIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (paragraphIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])paragraphIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "paragraphIndex" + "}", apiInvoker.ToPathValue(paragraphIndex)); 
		}
        if (insertBeforeNode == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])insertBeforeNode=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "insertBeforeNode" + "}", apiInvoker.ToPathValue(insertBeforeNode)); 
		}
        if (destFileName == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destFileName=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destFileName" + "}", apiInvoker.ToPathValue(destFileName)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FormFieldResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FormFieldResponse) ApiInvoker.deserialize(response, typeof(FormFieldResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="headersFootersTypes"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteHeadersFooters (string name, string headersFootersTypes, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/headersfooters/?appSid={appSid}&amp;headersFootersTypes={headersFootersTypes}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (headersFootersTypes == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])headersFootersTypes=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "headersFootersTypes" + "}", apiInvoker.ToPathValue(headersFootersTypes)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="hyperlinkIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public HyperlinkResponse GetDocumentHyperlinkByIndex (string name, int hyperlinkIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/hyperlinks/{hyperlinkIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || hyperlinkIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (hyperlinkIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])hyperlinkIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "hyperlinkIndex" + "}", apiInvoker.ToPathValue(hyperlinkIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(HyperlinkResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (HyperlinkResponse) ApiInvoker.deserialize(response, typeof(HyperlinkResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (HyperlinkResponse) ApiInvoker.deserialize(response, typeof(HyperlinkResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public HyperlinksResponse GetDocumentHyperlinks (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/hyperlinks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(HyperlinksResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (HyperlinksResponse) ApiInvoker.deserialize(response, typeof(HyperlinksResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (HyperlinksResponse) ApiInvoker.deserialize(response, typeof(HyperlinksResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SaaSposeResponse DeleteDocumentMacros (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/macros/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SaaSposeResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SaaSposeResponse) ApiInvoker.deserialize(response, typeof(SaaSposeResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="useNonMergeFields"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FieldNamesResponse GetDocumentFieldNames (string name, bool useNonMergeFields, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (useNonMergeFields == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useNonMergeFields=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useNonMergeFields" + "}", apiInvoker.ToPathValue(useNonMergeFields)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FieldNamesResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FieldNamesResponse) ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FieldNamesResponse) ApiInvoker.deserialize(response, typeof(FieldNamesResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="withRegions"></param>
      /// <param name="mailMergeDataFile"></param>
      /// <param name="cleanup"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="useWholeParagraphAsRegion"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public DocumentResponse PostDocumentExecuteMailMerge (string name, bool withRegions, string mailMergeDataFile, string cleanup, string filename, string storage, string folder, bool useWholeParagraphAsRegion, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/{name}/executeMailMerge/{withRegions}/?appSid={appSid}&amp;mailMergeDataFile={mailMergeDataFile}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || withRegions == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (withRegions == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])withRegions=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "withRegions" + "}", apiInvoker.ToPathValue(withRegions)); 
		}
        if (mailMergeDataFile == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])mailMergeDataFile=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "mailMergeDataFile" + "}", apiInvoker.ToPathValue(mailMergeDataFile)); 
		}
        if (cleanup == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])cleanup=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "cleanup" + "}", apiInvoker.ToPathValue(cleanup)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (useWholeParagraphAsRegion == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])useWholeParagraphAsRegion=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "useWholeParagraphAsRegion" + "}", apiInvoker.ToPathValue(useWholeParagraphAsRegion)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="index"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ParagraphResponse GetDocumentParagraph (string name, int index, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/{index}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || index == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (index == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])index=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ParagraphResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ParagraphResponse) ApiInvoker.deserialize(response, typeof(ParagraphResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ParagraphResponse) ApiInvoker.deserialize(response, typeof(ParagraphResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="index"></param>
      /// <param name="runIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public RunResponse GetDocumentParagraphRun (string name, int index, int runIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || index == null || runIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (index == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])index=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index)); 
		}
        if (runIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])runIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "runIndex" + "}", apiInvoker.ToPathValue(runIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(RunResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (RunResponse) ApiInvoker.deserialize(response, typeof(RunResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (RunResponse) ApiInvoker.deserialize(response, typeof(RunResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="index"></param>
      /// <param name="runIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public FontResponse GetDocumentParagraphRunFont (string name, int index, int runIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || index == null || runIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (index == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])index=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index)); 
		}
        if (runIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])runIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "runIndex" + "}", apiInvoker.ToPathValue(runIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(FontResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FontResponse) ApiInvoker.deserialize(response, typeof(FontResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FontResponse) ApiInvoker.deserialize(response, typeof(FontResponse));
            }
            else {
              return null;  
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public ParagraphLinkCollectionResponse GetDocumentParagraphs (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ParagraphLinkCollectionResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ParagraphLinkCollectionResponse) ApiInvoker.deserialize(response, typeof(ParagraphLinkCollectionResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ParagraphLinkCollectionResponse) ApiInvoker.deserialize(response, typeof(ParagraphLinkCollectionResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="index"></param>
      /// <param name="runIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="filename"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public FontResponse PostDocumentParagraphRunFont (string name, int index, int runIndex, string storage, string folder, string filename, Font body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || index == null || runIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (index == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])index=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "index" + "}", apiInvoker.ToPathValue(index)); 
		}
        if (runIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])runIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "runIndex" + "}", apiInvoker.ToPathValue(runIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        try {
          if (typeof(FontResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FontResponse) ApiInvoker.deserialize(response, typeof(FontResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (FontResponse) ApiInvoker.deserialize(response, typeof(FontResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public RevisionsModificationResponse AcceptAllRevisions (string name, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/revisions/acceptAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(RevisionsModificationResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (RevisionsModificationResponse) ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (RevisionsModificationResponse) ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public RevisionsModificationResponse RejectAllRevisions (string name, string filename, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/revisions/rejectAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(RevisionsModificationResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (RevisionsModificationResponse) ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (RevisionsModificationResponse) ApiInvoker.deserialize(response, typeof(RevisionsModificationResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pattern"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SearchResponse Search (string name, string pattern, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/search/?appSid={appSid}&amp;pattern={pattern}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || pattern == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (pattern == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])pattern=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "pattern" + "}", apiInvoker.ToPathValue(pattern)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SearchResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SearchResponse) ApiInvoker.deserialize(response, typeof(SearchResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SearchResponse) ApiInvoker.deserialize(response, typeof(SearchResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SectionResponse GetSection (string name, int sectionIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SectionResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SectionResponse) ApiInvoker.deserialize(response, typeof(SectionResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SectionResponse) ApiInvoker.deserialize(response, typeof(SectionResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SectionPageSetupResponse GetSectionPageSetup (string name, int sectionIndex, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SectionPageSetupResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SectionPageSetupResponse) ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SectionPageSetupResponse) ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public SectionLinkCollectionResponse GetSections (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(SectionLinkCollectionResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SectionLinkCollectionResponse) ApiInvoker.deserialize(response, typeof(SectionLinkCollectionResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (SectionLinkCollectionResponse) ApiInvoker.deserialize(response, typeof(SectionLinkCollectionResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="sectionIndex"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="filename"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public SectionPageSetupResponse UpdateSectionPageSetup (string name, int sectionIndex, string storage, string folder, string filename, PageSetup body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || sectionIndex == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (sectionIndex == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])sectionIndex=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "sectionIndex" + "}", apiInvoker.ToPathValue(sectionIndex)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        try {
          if (typeof(SectionPageSetupResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (SectionPageSetupResponse) ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (SectionPageSetupResponse) ApiInvoker.deserialize(response, typeof(SectionPageSetupResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <returns></returns>
      public TextItemsResponse GetDocumentTextItems (string name, string storage, string folder) {
        // create path and map variables
        var ResourcePath = "/words/{name}/textItems/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(TextItemsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (TextItemsResponse) ApiInvoker.deserialize(response, typeof(TextItemsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public ReplaceTextResponse PostReplaceText (string name, string filename, string storage, string folder, ReplaceTextRequest body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/replaceText/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(ReplaceTextResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ReplaceTextResponse) ApiInvoker.deserialize(response, typeof(ReplaceTextResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (ReplaceTextResponse) ApiInvoker.deserialize(response, typeof(ReplaceTextResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="filename"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="image"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public DocumentResponse PostInsertWatermarkImage (string name, string filename, double rotationAngle, string image, string storage, string folder, byte[] file) {
        // create path and map variables
        var ResourcePath = "/words/{name}/insertWatermarkImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (image == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])image=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "image" + "}", apiInvoker.ToPathValue(image)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      ///  
      /// </summary>
      /// <param name="name"></param>
      /// <param name="text"></param>
      /// <param name="rotationAngle"></param>
      /// <param name="filename"></param>
      /// <param name="storage"></param>
      /// <param name="folder"></param>
      /// <param name="body"></param>
      /// <returns></returns>
      public DocumentResponse PostInsertWatermarkText (string name, string text, double rotationAngle, string filename, string storage, string folder, WatermarkText body) {
        // create path and map variables
        var ResourcePath = "/words/{name}/insertWatermarkText/?appSid={appSid}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null || body == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        if (text == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])text=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "text" + "}", apiInvoker.ToPathValue(text)); 
		}
        if (rotationAngle == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])rotationAngle=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "rotationAngle" + "}", apiInvoker.ToPathValue(rotationAngle)); 
		}
        if (filename == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])filename=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "filename" + "}", apiInvoker.ToPathValue(filename)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (folder == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])folder=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "folder" + "}", apiInvoker.ToPathValue(folder)); 
		}
        try {
          if (typeof(DocumentResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return (DocumentResponse) ApiInvoker.deserialize(response, typeof(DocumentResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
