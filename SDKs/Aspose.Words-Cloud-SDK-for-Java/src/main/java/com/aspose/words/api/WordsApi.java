package com.aspose.words.api;

import java.io.File;
import java.util.HashMap;
import java.util.Map;

import javax.ws.rs.core.MediaType;

import com.aspose.words.client.ApiException;
import com.aspose.words.client.ApiInvoker;
import com.aspose.words.client.ApiInvokerResponse;
import com.aspose.words.model.BookmarkData;
import com.aspose.words.model.BookmarkResponse;
import com.aspose.words.model.BookmarksResponse;
import com.aspose.words.model.CommentsResponse;
import com.aspose.words.model.CompareData;
import com.aspose.words.model.DocumentEntryList;
import com.aspose.words.model.DocumentPropertiesResponse;
import com.aspose.words.model.DocumentProperty;
import com.aspose.words.model.DocumentPropertyResponse;
import com.aspose.words.model.DocumentResponse;
import com.aspose.words.model.DrawingObjectResponse;
import com.aspose.words.model.DrawingObjectsResponse;
import com.aspose.words.model.FieldNamesResponse;
import com.aspose.words.model.Font;
import com.aspose.words.model.FontResponse;
import com.aspose.words.model.FootnotesDTO;
import com.aspose.words.model.FootnotesResponse;
import com.aspose.words.model.FormField;
import com.aspose.words.model.FormFieldResponse;
import com.aspose.words.model.HyperlinkResponse;
import com.aspose.words.model.HyperlinksResponse;
import com.aspose.words.model.LoadWebDocumentData;
import com.aspose.words.model.OfficeMathObjectsResponse;
import com.aspose.words.model.PageNumber;
import com.aspose.words.model.PageSetup;
import com.aspose.words.model.ParagraphLinkCollectionResponse;
import com.aspose.words.model.ParagraphResponse;
import com.aspose.words.model.ProtectionDataResponse;
import com.aspose.words.model.ProtectionRequest;
import com.aspose.words.model.ReplaceTextRequest;
import com.aspose.words.model.ReplaceTextResponse;
import com.aspose.words.model.ResponseMessage;
import com.aspose.words.model.RevisionsModificationResponse;
import com.aspose.words.model.RunResponse;
import com.aspose.words.model.SaaSposeResponse;
import com.aspose.words.model.SaveOptions;
import com.aspose.words.model.SaveResponse;
import com.aspose.words.model.SearchResult;
import com.aspose.words.model.SectionLinkCollectionResponse;
import com.aspose.words.model.SectionPageSetupResponse;
import com.aspose.words.model.SectionResponse;
import com.aspose.words.model.SplitDocumentResponse;
import com.aspose.words.model.StatDataResponse;
import com.aspose.words.model.TableLinkCollectionResponse;
import com.aspose.words.model.TableObject;
import com.aspose.words.model.TableResponse;
import com.aspose.words.model.TextItemsResponse;
import com.aspose.words.model.TiffSaveOptionsData;
import com.aspose.words.model.WatermarkText;
import com.sun.jersey.multipart.FormDataMultiPart;

public class WordsApi {
	String basePath = "http://api.aspose.cloud/v1.1";
	ApiInvoker apiInvoker = ApiInvoker.getInstance();
	ApiInvokerResponse response = null;

	public WordsApi(String basePath, String apiKey, String appSid) {
		this.basePath = basePath;
		apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
		apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
	}

	public WordsApi(String basePath, String apiKey, String appSid, boolean isDebug) {
		this.basePath = basePath;
		apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
		apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
		if (isDebug)
			apiInvoker.enableDebug();
	}

	public WordsApi(String apiKey, String appSid) {
		apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
		apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
	}

	public WordsApi(String apiKey, String appSid, boolean isDebug) {
		apiInvoker.addDefaultHeader(apiInvoker.API_KEY, apiKey);
		apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);

		if (isDebug)
			apiInvoker.enableDebug();
	}

	public ApiInvoker getInvoker() {
		return apiInvoker;
	}

	public void setBasePath(String basePath) {
		this.basePath = basePath;
	}

	public String getBasePath() {
		return basePath;
	}

	/**
	 * GetDocumentBookmarkByName Read document bookmark data by its name.
	 * 
	 * @param name
	 *            String The document name.
	 * @param bookmarkName
	 *            String The bookmark name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return BookmarkResponse
	 */

	public BookmarkResponse GetDocumentBookmarkByName(String name, String bookmarkName, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || bookmarkName == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (bookmarkName != null)
			resourcePath = resourcePath.replace("{" + "bookmarkName" + "}", apiInvoker.toPathValue(bookmarkName));
		else
			resourcePath = resourcePath.replaceAll("[&?]bookmarkName.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (BookmarkResponse) ApiInvoker.deserialize(response, "", BookmarkResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentBookmarks Read document bookmarks common info.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return BookmarksResponse
	 */

	public BookmarksResponse GetDocumentBookmarks(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/bookmarks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (BookmarksResponse) ApiInvoker.deserialize(response, "", BookmarksResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostUpdateDocumentBookmark Update document bookmark.
	 * 
	 * @param name
	 *            String The document name.
	 * @param bookmarkName
	 *            String The bookmark name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            BookmarkData with new bookmark data.
	 * @return BookmarkResponse
	 */

	public BookmarkResponse PostUpdateDocumentBookmark(String name, String bookmarkName, String filename,
			String storage, String folder, BookmarkData body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || bookmarkName == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (bookmarkName != null)
			resourcePath = resourcePath.replace("{" + "bookmarkName" + "}", apiInvoker.toPathValue(bookmarkName));
		else
			resourcePath = resourcePath.replaceAll("[&?]bookmarkName.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (BookmarkResponse) ApiInvoker.deserialize(response, "", BookmarkResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocument RRead document common info.
	 * 
	 * @param name
	 *            String The file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ResponseMessage
	 */

	public ResponseMessage GetDocument(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentWithFormat Export the document into the specified format.
	 * 
	 * @param name
	 *            String The file name.
	 * @param format
	 *            String The destination format.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param outPath
	 *            String Path to save result
	 * @return ResponseMessage
	 */

	public ResponseMessage GetDocumentWithFormat(String name, String format, String storage, String folder,
			String outPath) {
		Object postBody = null;
		// verify required params are set
		if (name == null || format == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (format != null)
			resourcePath = resourcePath.replace("{" + "format" + "}", apiInvoker.toPathValue(format));
		else
			resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (outPath != null)
			resourcePath = resourcePath.replace("{" + "outPath" + "}", apiInvoker.toPathValue(outPath));
		else
			resourcePath = resourcePath.replaceAll("[&?]outPath.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostAppendDocument Append documents to original document.
	 * 
	 * @param name
	 *            String Original document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String Original document storage.
	 * @param folder
	 *            String Original document folder.
	 * @param body
	 *            DocumentEntryList with a list of documents to append.
	 * @return DocumentResponse
	 */

	public DocumentResponse PostAppendDocument(String name, String filename, String storage, String folder,
			DocumentEntryList body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/appendDocument/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostExecuteTemplate Populate document template with data.
	 * 
	 * @param name
	 *            String The template document name.
	 * @param cleanup
	 *            String Clean up options.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param useWholeParagraphAsRegion
	 *            Boolean Gets or sets a value indicating whether paragraph with
	 *            TableStart or TableEnd field should be fully included into
	 *            mail merge region or particular range between TableStart and
	 *            TableEnd fields. The default value is true.
	 * @param withRegions
	 *            Boolean Merge with regions or not. True by default
	 * @param file
	 *            File
	 * @return DocumentResponse
	 */

	public DocumentResponse PostExecuteTemplate(String name, String cleanup, String filename, String storage,
			String folder, Boolean useWholeParagraphAsRegion, Boolean withRegions, File file) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (cleanup != null)
			resourcePath = resourcePath.replace("{" + "cleanup" + "}", apiInvoker.toPathValue(cleanup));
		else
			resourcePath = resourcePath.replaceAll("[&?]cleanup.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (useWholeParagraphAsRegion != null)
			resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}",
					apiInvoker.toPathValue(useWholeParagraphAsRegion));
		else
			resourcePath = resourcePath.replaceAll("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "");
		if (withRegions != null)
			resourcePath = resourcePath.replace("{" + "withRegions" + "}", apiInvoker.toPathValue(withRegions));
		else
			resourcePath = resourcePath.replaceAll("[&?]withRegions.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (file != null)
			postBody = file;

		/*
		 * if(contentType.startsWith("multipart/form-data")) { FormDataMultiPart
		 * mp = new FormDataMultiPart(); mp.field("file", file,
		 * MediaType.MULTIPART_FORM_DATA_TYPE); postBody = mp; }
		 */
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostInsertPageNumbers Insert document page numbers.
	 * 
	 * @param name
	 *            String A document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            PageNumber with the page numbers settings.
	 * @return DocumentResponse
	 */

	public DocumentResponse PostInsertPageNumbers(String name, String filename, String storage, String folder,
			PageNumber body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/insertPageNumbers/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostLoadWebDocument Load new document from web into the file with any
	 * supported format of data.
	 * 
	 * @return SaveResponse
	 */

	public SaveResponse PostLoadWebDocument(LoadWebDocumentData body) {

		// verify required params are set
		if (body == null) {
			throw new ApiException(400, "missing required params");
		}
		Object postBody = body;
		// create path and map variables
		String resourcePath = "/words/loadWebDocument/?appSid={appSid}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaveResponse) ApiInvoker.deserialize(response, "", SaveResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostRunTask Run tasks
	 * 
	 * @return ResponseMessage
	 */

	public ResponseMessage PostRunTask() {
		Object postBody = null;
		// create path and map variables
		String resourcePath = "/words/tasks/?appSid={appSid}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostSplitDocument Split document.
	 * 
	 * @param name
	 *            String Original document name.
	 * @param format
	 *            String Format to split.
	 * @param from
	 *            Integer Start page.
	 * @param to
	 *            Integer End page.
	 * @param zipOutput
	 *            Boolean ZipOutput or not.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SplitDocumentResponse
	 */

	public SplitDocumentResponse PostSplitDocument(String name, String format, Integer from, Integer to,
			Boolean zipOutput, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/split/?appSid={appSid}&amp;toFormat={toFormat}&amp;from={from}&amp;to={to}&amp;zipOutput={zipOutput}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (format != null)
			resourcePath = resourcePath.replace("{" + "format" + "}", apiInvoker.toPathValue(format));
		else
			resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
		if (from != null)
			resourcePath = resourcePath.replace("{" + "from" + "}", apiInvoker.toPathValue(from));
		else
			resourcePath = resourcePath.replaceAll("[&?]from.*?(?=&|\\?|$)", "");
		if (to != null)
			resourcePath = resourcePath.replace("{" + "to" + "}", apiInvoker.toPathValue(to));
		else
			resourcePath = resourcePath.replaceAll("[&?]to.*?(?=&|\\?|$)", "");
		if (zipOutput != null)
			resourcePath = resourcePath.replace("{" + "zipOutput" + "}", apiInvoker.toPathValue(zipOutput));
		else
			resourcePath = resourcePath.replaceAll("[&?]zipOutput.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SplitDocumentResponse) ApiInvoker.deserialize(response, "", SplitDocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutConvertDocument Convert document from request content to format
	 * specified.
	 * 
	 * @param format
	 *            String Format to convert.
	 * @param outPath
	 *            String
	 * @param file
	 *            File
	 * @return ResponseMessage
	 */

	public ResponseMessage PutConvertDocument(String format, String outPath, File file) {
		Object postBody = null;
		// verify required params are set
		if (file == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/convert/?appSid={appSid}&amp;toFormat={toFormat}&amp;outPath={outPath}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (format != null)
			resourcePath = resourcePath.replace("{" + "format" + "}", apiInvoker.toPathValue(format));
		else
			resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
		if (outPath != null)
			resourcePath = resourcePath.replace("{" + "outPath" + "}", apiInvoker.toPathValue(outPath));
		else
			resourcePath = resourcePath.replaceAll("[&?]outPath.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (contentType.startsWith("multipart/form-data")) {
			FormDataMultiPart mp = new FormDataMultiPart();
			mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
			postBody = mp;
		}
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutDocumentFieldNames Read document field names.
	 * 
	 * @param useNonMergeFields
	 *            Boolean
	 * @return FieldNamesResponse
	 */

	public FieldNamesResponse PutDocumentFieldNames(Boolean useNonMergeFields) {
		Object postBody = null;
		// create path and map variables
		String resourcePath = "/words/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (useNonMergeFields != null)
			resourcePath = resourcePath.replace("{" + "useNonMergeFields" + "}",
					apiInvoker.toPathValue(useNonMergeFields));
		else
			resourcePath = resourcePath.replaceAll("[&?]useNonMergeFields.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FieldNamesResponse) ApiInvoker.deserialize(response, "", FieldNamesResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutExecuteMailMergeOnline Execute document mail merge online.
	 * 
	 * @param withRegions
	 *            Boolean With regions flag.
	 * @param cleanup
	 *            String Clean up options.
	 * @param file
	 *            File
	 * @return ResponseMessage
	 */

	public ResponseMessage PutExecuteMailMergeOnline(Boolean withRegions, String cleanup, File file, File data) {
		Object postBody = null;
		// verify required params are set
		if (withRegions == null || file == null || data == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/executeMailMerge/?withRegions={withRegions}&amp;appSid={appSid}&amp;cleanup={cleanup}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (withRegions != null)
			resourcePath = resourcePath.replace("{" + "withRegions" + "}", apiInvoker.toPathValue(withRegions));
		else
			resourcePath = resourcePath.replaceAll("[&?]withRegions.*?(?=&|\\?|$)", "");
		if (cleanup != null)
			resourcePath = resourcePath.replace("{" + "cleanup" + "}", apiInvoker.toPathValue(cleanup));
		else
			resourcePath = resourcePath.replaceAll("[&?]cleanup.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (contentType.startsWith("multipart/form-data")) {
			FormDataMultiPart mp = new FormDataMultiPart();
			mp.field("file", file, MediaType.APPLICATION_OCTET_STREAM_TYPE);
			mp.field("data", data, MediaType.APPLICATION_XML_TYPE);
			postBody = mp;
		}
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutExecuteTemplateOnline Populate document template with data online.
	 * 
	 * @param cleanup
	 *            String Clean up options.
	 * @param useWholeParagraphAsRegion
	 *            Boolean Gets or sets a value indicating whether paragraph with
	 *            TableStart or TableEnd field should be fully included into
	 *            mail merge region or particular range between TableStart and
	 *            TableEnd fields. The default value is true.
	 * @param withRegions
	 *            Boolean Merge with regions or not. True by default
	 * @param file
	 *            File
	 * @return ResponseMessage
	 */

	public ResponseMessage PutExecuteTemplateOnline(String cleanup, Boolean useWholeParagraphAsRegion,
			Boolean withRegions, File file) {
		Object postBody = null;
		// verify required params are set
		if (file == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (cleanup != null)
			resourcePath = resourcePath.replace("{" + "cleanup" + "}", apiInvoker.toPathValue(cleanup));
		else
			resourcePath = resourcePath.replaceAll("[&?]cleanup.*?(?=&|\\?|$)", "");
		if (useWholeParagraphAsRegion != null)
			resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}",
					apiInvoker.toPathValue(useWholeParagraphAsRegion));
		else
			resourcePath = resourcePath.replaceAll("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "");
		if (withRegions != null)
			resourcePath = resourcePath.replace("{" + "withRegions" + "}", apiInvoker.toPathValue(withRegions));
		else
			resourcePath = resourcePath.replaceAll("[&?]withRegions.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (contentType.startsWith("multipart/form-data")) {
			FormDataMultiPart mp = new FormDataMultiPart();
			mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
			postBody = mp;
		}
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteDocumentFields Remove fields from document.
	 * 
	 * @param name
	 *            String The file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteDocumentFields(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostUpdateDocumentFields Update (reevaluate) fields in document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return DocumentResponse
	 */

	public DocumentResponse PostUpdateDocumentFields(String name, String filename, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/updateFields/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteDocumentProperty Delete document property.
	 * 
	 * @param name
	 *            String The document name.
	 * @param propertyName
	 *            String The property name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String Document's storage.
	 * @param folder
	 *            String Document's folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteDocumentProperty(String name, String propertyName, String filename, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || propertyName == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (propertyName != null)
			resourcePath = resourcePath.replace("{" + "propertyName" + "}", apiInvoker.toPathValue(propertyName));
		else
			resourcePath = resourcePath.replaceAll("[&?]propertyName.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentProperties Read document properties info.
	 * 
	 * @param name
	 *            String The document's name.
	 * @param storage
	 *            String The document's storage.
	 * @param folder
	 *            String The document's folder.
	 * @return DocumentPropertiesResponse
	 */

	public DocumentPropertiesResponse GetDocumentProperties(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/documentProperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentPropertiesResponse) ApiInvoker.deserialize(response, "", DocumentPropertiesResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentProperty Read document property info by the property name.
	 * 
	 * @param name
	 *            String The document name.
	 * @param propertyName
	 *            String The property name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return DocumentPropertyResponse
	 */

	public DocumentPropertyResponse GetDocumentProperty(String name, String propertyName, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || propertyName == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (propertyName != null)
			resourcePath = resourcePath.replace("{" + "propertyName" + "}", apiInvoker.toPathValue(propertyName));
		else
			resourcePath = resourcePath.replaceAll("[&?]propertyName.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentPropertyResponse) ApiInvoker.deserialize(response, "", DocumentPropertyResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutUpdateDocumentProperty Add new or update existing document property.
	 * 
	 * @param name
	 *            String The document name.
	 * @param propertyName
	 *            String The property name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String Document's storage.
	 * @param folder
	 *            String Document's folder.
	 * @param body
	 *            DocumentProperty The property with new value.
	 * @return DocumentPropertyResponse
	 */

	public DocumentPropertyResponse PutUpdateDocumentProperty(String name, String propertyName, String filename,
			String storage, String folder, DocumentProperty body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || propertyName == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (propertyName != null)
			resourcePath = resourcePath.replace("{" + "propertyName" + "}", apiInvoker.toPathValue(propertyName));
		else
			resourcePath = resourcePath.replaceAll("[&?]propertyName.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentPropertyResponse) ApiInvoker.deserialize(response, "", DocumentPropertyResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * Unprotect a Document <br>
	 * This method will only work on JDK8+ because of JDK-7157360 bug -
	 * HttpURLConnection: HTTP method DELETE doesn't support<br>
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            ProtectionRequest with protection settings.
	 * @return ProtectionDataResponse
	 */

	public ProtectionDataResponse DeleteUnprotectDocument(String name, String filename, String storage, String folder,
			ProtectionRequest body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ProtectionDataResponse) ApiInvoker.deserialize(response, "", ProtectionDataResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentProtection Read document protection common info.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ProtectionDataResponse
	 */

	public ProtectionDataResponse GetDocumentProtection(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ProtectionDataResponse) ApiInvoker.deserialize(response, "", ProtectionDataResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostChangeDocumentProtection Change document protection.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            ProtectionRequest with protection settings.
	 * @return ProtectionDataResponse
	 */

	public ProtectionDataResponse PostChangeDocumentProtection(String name, String filename, String storage,
			String folder, ProtectionRequest body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ProtectionDataResponse) ApiInvoker.deserialize(response, "", ProtectionDataResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutProtectDocument Protect document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            ProtectionRequest with protection settings.
	 * @return ProtectionDataResponse
	 */

	public ProtectionDataResponse PutProtectDocument(String name, String filename, String storage, String folder,
			ProtectionRequest body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ProtectionDataResponse) ApiInvoker.deserialize(response, "", ProtectionDataResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostDocumentSaveAs Convert document to tiff with detailed settings and
	 * save result to storage.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            SaveOptionsData Save options.
	 * @return SaveResponse
	 */

	public SaveResponse PostDocumentSaveAs(String name, String storage, String folder, Object body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/SaveAs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaveResponse) ApiInvoker.deserialize(response, "", SaveResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutDocumentSaveAsTiff Convert document to tiff with detailed settings and
	 * save result to storage.
	 * 
	 * @param name
	 *            String The document name.
	 * @param resultFile
	 *            String The resulting file name.
	 * @param useAntiAliasing
	 *            Boolean Use antialiasing flag.
	 * @param useHighQualityRendering
	 *            Boolean Use high quality flag.
	 * @param imageBrightness
	 *            Float Brightness for the generated images.
	 * @param imageColorMode
	 *            String Color mode for the generated images.
	 * @param imageContrast
	 *            Float The contrast for the generated images.
	 * @param numeralFormat
	 *            String The images numeral format.
	 * @param pageCount
	 *            Integer Number of pages to render.
	 * @param pageIndex
	 *            Integer Page index to start rendering.
	 * @param paperColor
	 *            String Background image color.
	 * @param pixelFormat
	 *            String The pixel format of generated images.
	 * @param resolution
	 *            Float The resolution of generated images.
	 * @param scale
	 *            Float Zoom factor for generated images.
	 * @param tiffCompression
	 *            String The compression tipe.
	 * @param dmlRenderingMode
	 *            String Optional, default is Fallback.
	 * @param dmlEffectsRenderingMode
	 *            String Optional, default is Simplified.
	 * @param tiffBinarizationMethod
	 *            String Optional, Tiff binarization method, possible values
	 *            are: FloydSteinbergDithering, Threshold.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param zipOutput
	 *            Boolean Optional. A value determining zip output or not.
	 * @param body
	 *            TiffSaveOptionsData Tiff save options.
	 * @return SaveResponse
	 */

	public SaveResponse PutDocumentSaveAsTiff(String name, String resultFile, Boolean useAntiAliasing,
			Boolean useHighQualityRendering, Float imageBrightness, String imageColorMode, Float imageContrast,
			String numeralFormat, Integer pageCount, Integer pageIndex, String paperColor, String pixelFormat,
			Float resolution, Float scale, String tiffCompression, String dmlRenderingMode,
			String dmlEffectsRenderingMode, String tiffBinarizationMethod, String storage, String folder,
			Boolean zipOutput, TiffSaveOptionsData body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/SaveAs/tiff/?appSid={appSid}&amp;resultFile={resultFile}&amp;useAntiAliasing={useAntiAliasing}&amp;useHighQualityRendering={useHighQualityRendering}&amp;imageBrightness={imageBrightness}&amp;imageColorMode={imageColorMode}&amp;imageContrast={imageContrast}&amp;numeralFormat={numeralFormat}&amp;pageCount={pageCount}&amp;pageIndex={pageIndex}&amp;paperColor={paperColor}&amp;pixelFormat={pixelFormat}&amp;resolution={resolution}&amp;scale={scale}&amp;tiffCompression={tiffCompression}&amp;dmlRenderingMode={dmlRenderingMode}&amp;dmlEffectsRenderingMode={dmlEffectsRenderingMode}&amp;tiffBinarizationMethod={tiffBinarizationMethod}&amp;storage={storage}&amp;folder={folder}&amp;zipOutput={zipOutput}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (resultFile != null)
			resourcePath = resourcePath.replace("{" + "resultFile" + "}", apiInvoker.toPathValue(resultFile));
		else
			resourcePath = resourcePath.replaceAll("[&?]resultFile.*?(?=&|\\?|$)", "");
		if (useAntiAliasing != null)
			resourcePath = resourcePath.replace("{" + "useAntiAliasing" + "}", apiInvoker.toPathValue(useAntiAliasing));
		else
			resourcePath = resourcePath.replaceAll("[&?]useAntiAliasing.*?(?=&|\\?|$)", "");
		if (useHighQualityRendering != null)
			resourcePath = resourcePath.replace("{" + "useHighQualityRendering" + "}",
					apiInvoker.toPathValue(useHighQualityRendering));
		else
			resourcePath = resourcePath.replaceAll("[&?]useHighQualityRendering.*?(?=&|\\?|$)", "");
		if (imageBrightness != null)
			resourcePath = resourcePath.replace("{" + "imageBrightness" + "}", apiInvoker.toPathValue(imageBrightness));
		else
			resourcePath = resourcePath.replaceAll("[&?]imageBrightness.*?(?=&|\\?|$)", "");
		if (imageColorMode != null)
			resourcePath = resourcePath.replace("{" + "imageColorMode" + "}", apiInvoker.toPathValue(imageColorMode));
		else
			resourcePath = resourcePath.replaceAll("[&?]imageColorMode.*?(?=&|\\?|$)", "");
		if (imageContrast != null)
			resourcePath = resourcePath.replace("{" + "imageContrast" + "}", apiInvoker.toPathValue(imageContrast));
		else
			resourcePath = resourcePath.replaceAll("[&?]imageContrast.*?(?=&|\\?|$)", "");
		if (numeralFormat != null)
			resourcePath = resourcePath.replace("{" + "numeralFormat" + "}", apiInvoker.toPathValue(numeralFormat));
		else
			resourcePath = resourcePath.replaceAll("[&?]numeralFormat.*?(?=&|\\?|$)", "");
		if (pageCount != null)
			resourcePath = resourcePath.replace("{" + "pageCount" + "}", apiInvoker.toPathValue(pageCount));
		else
			resourcePath = resourcePath.replaceAll("[&?]pageCount.*?(?=&|\\?|$)", "");
		if (pageIndex != null)
			resourcePath = resourcePath.replace("{" + "pageIndex" + "}", apiInvoker.toPathValue(pageIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]pageIndex.*?(?=&|\\?|$)", "");
		if (paperColor != null)
			resourcePath = resourcePath.replace("{" + "paperColor" + "}", apiInvoker.toPathValue(paperColor));
		else
			resourcePath = resourcePath.replaceAll("[&?]paperColor.*?(?=&|\\?|$)", "");
		if (pixelFormat != null)
			resourcePath = resourcePath.replace("{" + "pixelFormat" + "}", apiInvoker.toPathValue(pixelFormat));
		else
			resourcePath = resourcePath.replaceAll("[&?]pixelFormat.*?(?=&|\\?|$)", "");
		if (resolution != null)
			resourcePath = resourcePath.replace("{" + "resolution" + "}", apiInvoker.toPathValue(resolution));
		else
			resourcePath = resourcePath.replaceAll("[&?]resolution.*?(?=&|\\?|$)", "");
		if (scale != null)
			resourcePath = resourcePath.replace("{" + "scale" + "}", apiInvoker.toPathValue(scale));
		else
			resourcePath = resourcePath.replaceAll("[&?]scale.*?(?=&|\\?|$)", "");
		if (tiffCompression != null)
			resourcePath = resourcePath.replace("{" + "tiffCompression" + "}", apiInvoker.toPathValue(tiffCompression));
		else
			resourcePath = resourcePath.replaceAll("[&?]tiffCompression.*?(?=&|\\?|$)", "");
		if (dmlRenderingMode != null)
			resourcePath = resourcePath.replace("{" + "dmlRenderingMode" + "}",
					apiInvoker.toPathValue(dmlRenderingMode));
		else
			resourcePath = resourcePath.replaceAll("[&?]dmlRenderingMode.*?(?=&|\\?|$)", "");
		if (dmlEffectsRenderingMode != null)
			resourcePath = resourcePath.replace("{" + "dmlEffectsRenderingMode" + "}",
					apiInvoker.toPathValue(dmlEffectsRenderingMode));
		else
			resourcePath = resourcePath.replaceAll("[&?]dmlEffectsRenderingMode.*?(?=&|\\?|$)", "");
		if (tiffBinarizationMethod != null)
			resourcePath = resourcePath.replace("{" + "tiffBinarizationMethod" + "}",
					apiInvoker.toPathValue(tiffBinarizationMethod));
		else
			resourcePath = resourcePath.replaceAll("[&?]tiffBinarizationMethod.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (zipOutput != null)
			resourcePath = resourcePath.replace("{" + "zipOutput" + "}", apiInvoker.toPathValue(zipOutput));
		else
			resourcePath = resourcePath.replaceAll("[&?]zipOutput.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaveResponse) ApiInvoker.deserialize(response, "", SaveResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentStatistics Read document statistics.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return StatDataResponse
	 */

	public StatDataResponse GetDocumentStatistics(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/statistics/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (StatDataResponse) ApiInvoker.deserialize(response, "", StatDataResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteDocumentWatermark Delete watermark (for deleting last watermark
	 * from the document).
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return DocumentResponse
	 */

	public DocumentResponse DeleteDocumentWatermark(String name, String filename, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/watermark/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostInsertDocumentWatermarkImage Insert document watermark image.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param rotationAngle
	 *            Double The watermark rotation angle.
	 * @param image
	 *            String The image file server full name. If the name is empty
	 *            the image is expected in request content.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param file
	 *            File
	 * @return DocumentResponse
	 */

	public DocumentResponse PostInsertDocumentWatermarkImage(String name, String filename, Double rotationAngle,
			String image, String storage, String folder, File file) {
		Object postBody = null;
		// verify required params are set
		if (name == null || file == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/watermark/insertImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (rotationAngle != null)
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}", apiInvoker.toPathValue(rotationAngle));
		else
			resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
		if (image != null)
			resourcePath = resourcePath.replace("{" + "image" + "}", apiInvoker.toPathValue(image));
		else
			resourcePath = resourcePath.replaceAll("[&?]image.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (contentType.startsWith("multipart/form-data")) {
			FormDataMultiPart mp = new FormDataMultiPart();
			mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
			postBody = mp;
		}
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostInsertDocumentWatermarkText Insert document watermark text.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param text
	 *            String The text to insert.
	 * @param rotationAngle
	 *            Double The text rotation angle.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            WatermarkText with the watermark data. If the parameter is
	 *            provided the query string parameters are ignored.
	 * @return DocumentResponse
	 */

	public DocumentResponse PostInsertDocumentWatermarkText(String name, String filename, String text,
			Double rotationAngle, String storage, String folder, WatermarkText body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/watermark/insertText/?appSid={appSid}&amp;filename={filename}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (text != null)
			resourcePath = resourcePath.replace("{" + "text" + "}", apiInvoker.toPathValue(text));
		else
			resourcePath = resourcePath.replaceAll("[&?]text.*?(?=&|\\?|$)", "");
		if (rotationAngle != null)
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}", apiInvoker.toPathValue(rotationAngle));
		else
			resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentDrawingObjectByIndex Read document drawing object common info
	 * by its index or convert to format specified.
	 * 
	 * @param name
	 *            String The document name.
	 * @param objectIndex
	 *            Integer The drawing object index.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder full path.
	 * @return ResponseMessage
	 */

	public DrawingObjectResponse GetDocumentDrawingObjectByIndex(String name, Integer objectIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DrawingObjectResponse) ApiInvoker.deserialize(response, "", DrawingObjectResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentDrawingObjectByIndexWithFormat Read document drawing object
	 * common info by its index or convert to format specified.
	 * 
	 * @param name
	 *            String The document name.
	 * @param objectIndex
	 *            Integer The drawing object index.
	 * @param format
	 *            String The format to convert (if specified).
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder full path.
	 * @return ResponseMessage
	 */

	public ResponseMessage GetDocumentDrawingObjectByIndexWithFormat(String name, Integer objectIndex, String format,
			String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null || format == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (format != null)
			resourcePath = resourcePath.replace("{" + "format" + "}", apiInvoker.toPathValue(format));
		else
			resourcePath = resourcePath.replaceAll("[&?]format.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentDrawingObjectImageData Read drawing object image data.
	 * 
	 * @param name
	 *            String The document name.
	 * @param objectIndex
	 *            Integer The drawing object index.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ResponseMessage
	 */

	public ResponseMessage GetDocumentDrawingObjectImageData(String name, Integer objectIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/drawingObjects/{objectIndex}/imageData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentDrawingObjectOleData Get drawing object OLE data.
	 * 
	 * @param name
	 *            String The document name.
	 * @param objectIndex
	 *            Integer The object index.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ResponseMessage
	 */

	public ResponseMessage GetDocumentDrawingObjectOleData(String name, Integer objectIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/drawingObjects/{objectIndex}/oleData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentDrawingObjects Read document drawing objects common info.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return DrawingObjectsResponse
	 */

	public DrawingObjectsResponse GetDocumentDrawingObjects(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/drawingObjects/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DrawingObjectsResponse) ApiInvoker.deserialize(response, "", DrawingObjectsResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteFormField Removes form field from document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index.
	 * @param paragraphIndex
	 *            Integer Paragraph index.
	 * @param formfieldIndex
	 *            Integer Form field index.
	 * @param destFileName
	 *            String Destination file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteFormField(String name, Integer sectionIndex, Integer paragraphIndex,
			Integer formfieldIndex, String destFileName, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (formfieldIndex != null)
			resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}", apiInvoker.toPathValue(formfieldIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]formfieldIndex.*?(?=&|\\?|$)", "");
		if (destFileName != null)
			resourcePath = resourcePath.replace("{" + "destFileName" + "}", apiInvoker.toPathValue(destFileName));
		else
			resourcePath = resourcePath.replaceAll("[&?]destFileName.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetFormField Returns representation of an one of the form field.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index.
	 * @param paragraphIndex
	 *            Integer Paragraph index.
	 * @param formfieldIndex
	 *            Integer Form field index.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return FormFieldResponse
	 */

	public FormFieldResponse GetFormField(String name, Integer sectionIndex, Integer paragraphIndex,
			Integer formfieldIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (formfieldIndex != null)
			resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}", apiInvoker.toPathValue(formfieldIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]formfieldIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FormFieldResponse) ApiInvoker.deserialize(response, "", FormFieldResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostFormField Updates form field's properties, returns updated form
	 * field's data.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index.
	 * @param paragraphIndex
	 *            Integer Paragraph index.
	 * @param formfieldIndex
	 *            Integer Form field index.
	 * @param destFileName
	 *            String Destination file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            FormField From field data.
	 * @return FormFieldResponse
	 */

	public FormFieldResponse PostFormField(String name, Integer sectionIndex, Integer paragraphIndex,
			Integer formfieldIndex, String destFileName, String storage, String folder, FormField body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || sectionIndex == null || paragraphIndex == null || formfieldIndex == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (formfieldIndex != null)
			resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}", apiInvoker.toPathValue(formfieldIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]formfieldIndex.*?(?=&|\\?|$)", "");
		if (destFileName != null)
			resourcePath = resourcePath.replace("{" + "destFileName" + "}", apiInvoker.toPathValue(destFileName));
		else
			resourcePath = resourcePath.replaceAll("[&?]destFileName.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FormFieldResponse) ApiInvoker.deserialize(response, "", FormFieldResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PutFormField Adds form field to paragraph, returns added form field's
	 * data.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index.
	 * @param paragraphIndex
	 *            Integer Paragraph index.
	 * @param insertBeforeNode
	 *            String Form field will be inserted before node with index.
	 * @param destFileName
	 *            String Destination file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            FormField From field data.
	 * @return FormFieldResponse
	 */

	public FormFieldResponse PutFormField(String name, Integer sectionIndex, Integer paragraphIndex,
			String insertBeforeNode, String destFileName, String storage, String folder, Object body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || sectionIndex == null || paragraphIndex == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/?appSid={appSid}&amp;insertBeforeNode={insertBeforeNode}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (insertBeforeNode != null)
			resourcePath = resourcePath.replace("{" + "insertBeforeNode" + "}",
					apiInvoker.toPathValue(insertBeforeNode));
		else
			resourcePath = resourcePath.replaceAll("[&?]insertBeforeNode.*?(?=&|\\?|$)", "");
		if (destFileName != null)
			resourcePath = resourcePath.replace("{" + "destFileName" + "}", apiInvoker.toPathValue(destFileName));
		else
			resourcePath = resourcePath.replaceAll("[&?]destFileName.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FormFieldResponse) ApiInvoker.deserialize(response, "", FormFieldResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteHeadersFooters Delete document headers and footers.
	 * 
	 * @param name
	 *            String The document name.
	 * @param headersFootersTypes
	 *            String List of types of headers and footers.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteHeadersFooters(String name, String headersFootersTypes, String filename,
			String storage, String folder, String revisionAuthor, String revisionDateTime) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/headersfooters/?appSid={appSid}&amp;headersFootersTypes={headersFootersTypes}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (headersFootersTypes != null)
			resourcePath = resourcePath.replace("{" + "headersFootersTypes" + "}",
					apiInvoker.toPathValue(headersFootersTypes));
		else
			resourcePath = resourcePath.replaceAll("[&?]headersFootersTypes.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentHyperlinkByIndex Read document hyperlink by its index.
	 * 
	 * @param name
	 *            String The document name.
	 * @param hyperlinkIndex
	 *            Integer The hyperlink index.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return HyperlinkResponse
	 */

	public HyperlinkResponse GetDocumentHyperlinkByIndex(String name, Integer hyperlinkIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || hyperlinkIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/hyperlinks/{hyperlinkIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (hyperlinkIndex != null)
			resourcePath = resourcePath.replace("{" + "hyperlinkIndex" + "}", apiInvoker.toPathValue(hyperlinkIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]hyperlinkIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (HyperlinkResponse) ApiInvoker.deserialize(response, "", HyperlinkResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentHyperlinks Read document hyperlinks common info.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return HyperlinksResponse
	 */

	public HyperlinksResponse GetDocumentHyperlinks(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/hyperlinks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (HyperlinksResponse) ApiInvoker.deserialize(response, "", HyperlinksResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteDocumentMacros Remove macros from document.
	 * 
	 * @param name
	 *            String The file name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteDocumentMacros(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/macros/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentFieldNames Read document field names.
	 * 
	 * @param name
	 *            String The document name.
	 * @param useNonMergeFields
	 *            Boolean
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return FieldNamesResponse
	 */

	public FieldNamesResponse GetDocumentFieldNames(String name, Boolean useNonMergeFields, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (useNonMergeFields != null)
			resourcePath = resourcePath.replace("{" + "useNonMergeFields" + "}",
					apiInvoker.toPathValue(useNonMergeFields));
		else
			resourcePath = resourcePath.replaceAll("[&?]useNonMergeFields.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FieldNamesResponse) ApiInvoker.deserialize(response, "", FieldNamesResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostDocumentExecuteMailMerge Execute document mail merge operation.
	 * 
	 * @param name
	 *            String The document name.
	 * @param withRegions
	 *            Boolean With regions flag.
	 * @param mailMergeDataFile
	 *            String Mail merge data.
	 * @param cleanup
	 *            String Clean up options.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param useWholeParagraphAsRegion
	 *            Boolean Gets or sets a value indicating whether paragraph with
	 *            TableStart or TableEnd field should be fully included into
	 *            mail merge region or particular range between TableStart and
	 *            TableEnd fields. The default value is true.
	 * @param file
	 *            File
	 * @return DocumentResponse
	 */

	public DocumentResponse PostDocumentExecuteMailMerge(String name, Boolean withRegions, String mailMergeDataFile,
			String cleanup, String filename, String storage, String folder, Boolean useWholeParagraphAsRegion,
			File file) {
		Object postBody = null;
		// verify required params are set
		if (name == null || withRegions == null || file == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/executeMailMerge/{withRegions}/?appSid={appSid}&amp;mailMergeDataFile={mailMergeDataFile}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (withRegions != null)
			resourcePath = resourcePath.replace("{" + "withRegions" + "}", apiInvoker.toPathValue(withRegions));
		else
			resourcePath = resourcePath.replaceAll("[&?]withRegions.*?(?=&|\\?|$)", "");
		if (mailMergeDataFile != null)
			resourcePath = resourcePath.replace("{" + "mailMergeDataFile" + "}",
					apiInvoker.toPathValue(mailMergeDataFile));
		else
			resourcePath = resourcePath.replaceAll("[&?]mailMergeDataFile.*?(?=&|\\?|$)", "");
		if (cleanup != null)
			resourcePath = resourcePath.replace("{" + "cleanup" + "}", apiInvoker.toPathValue(cleanup));
		else
			resourcePath = resourcePath.replaceAll("[&?]cleanup.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (useWholeParagraphAsRegion != null)
			resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}",
					apiInvoker.toPathValue(useWholeParagraphAsRegion));
		else
			resourcePath = resourcePath.replaceAll("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (file != null)
			postBody = file;
		/*
		 * if(contentType.startsWith("multipart/form-data")) { FormDataMultiPart
		 * mp = new FormDataMultiPart(); mp.field("file", file,
		 * MediaType.MULTIPART_FORM_DATA_TYPE); postBody = mp; }
		 */
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteParagraphFields Remove fields from paragraph.
	 * 
	 * @param name
	 *            String The file name.
	 * @param index
	 *            Integer Paragraph index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteParagraphFields(String name, Integer index, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || index == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/{index}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (index != null)
			resourcePath = resourcePath.replace("{" + "index" + "}", apiInvoker.toPathValue(index));
		else
			resourcePath = resourcePath.replaceAll("[&?]index.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentParagraph This resource represents one of the paragraphs
	 * contained in the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param index
	 *            Integer Paragraph index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ParagraphResponse
	 */

	public ParagraphResponse GetDocumentParagraph(String name, Integer index, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || index == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/{index}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (index != null)
			resourcePath = resourcePath.replace("{" + "index" + "}", apiInvoker.toPathValue(index));
		else
			resourcePath = resourcePath.replaceAll("[&?]index.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ParagraphResponse) ApiInvoker.deserialize(response, "", ParagraphResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentParagraphRun This resource represents one of the paragraphs
	 * contained in the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param index
	 *            Integer Paragraph index
	 * @param runIndex
	 *            Integer Run index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return RunResponse
	 */

	public RunResponse GetDocumentParagraphRun(String name, Integer index, Integer runIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || index == null || runIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (index != null)
			resourcePath = resourcePath.replace("{" + "index" + "}", apiInvoker.toPathValue(index));
		else
			resourcePath = resourcePath.replaceAll("[&?]index.*?(?=&|\\?|$)", "");
		if (runIndex != null)
			resourcePath = resourcePath.replace("{" + "runIndex" + "}", apiInvoker.toPathValue(runIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]runIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (RunResponse) ApiInvoker.deserialize(response, "", RunResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentParagraphRunFont This resource represents one of the
	 * paragraphs contained in the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param index
	 *            Integer Paragraph index
	 * @param runIndex
	 *            Integer Run index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return FontResponse
	 */

	public FontResponse GetDocumentParagraphRunFont(String name, Integer index, Integer runIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || index == null || runIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (index != null)
			resourcePath = resourcePath.replace("{" + "index" + "}", apiInvoker.toPathValue(index));
		else
			resourcePath = resourcePath.replaceAll("[&?]index.*?(?=&|\\?|$)", "");
		if (runIndex != null)
			resourcePath = resourcePath.replace("{" + "runIndex" + "}", apiInvoker.toPathValue(runIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]runIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FontResponse) ApiInvoker.deserialize(response, "", FontResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentParagraphs Return a list of paragraphs that are contained in
	 * the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return ParagraphLinkCollectionResponse
	 */

	public ParagraphLinkCollectionResponse GetDocumentParagraphs(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ParagraphLinkCollectionResponse) ApiInvoker.deserialize(response, "",
					ParagraphLinkCollectionResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostDocumentParagraphRunFont This resource represents one of the
	 * paragraphs contained in the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param index
	 *            Integer Paragraph index
	 * @param runIndex
	 *            Integer Run index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param body
	 *            Font Font dto object
	 * @return FontResponse
	 */

	public FontResponse PostDocumentParagraphRunFont(String name, Integer index, Integer runIndex, String storage,
			String folder, String filename, Font body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || index == null || runIndex == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (index != null)
			resourcePath = resourcePath.replace("{" + "index" + "}", apiInvoker.toPathValue(index));
		else
			resourcePath = resourcePath.replaceAll("[&?]index.*?(?=&|\\?|$)", "");
		if (runIndex != null)
			resourcePath = resourcePath.replace("{" + "runIndex" + "}", apiInvoker.toPathValue(runIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]runIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FontResponse) ApiInvoker.deserialize(response, "", FontResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * AcceptAllRevisions Accept all revisions in document
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return RevisionsModificationResponse
	 */

	public RevisionsModificationResponse AcceptAllRevisions(String name, String filename, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/revisions/acceptAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (RevisionsModificationResponse) ApiInvoker.deserialize(response, "",
					RevisionsModificationResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * RejectAllRevisions Reject all revisions in document
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return RevisionsModificationResponse
	 */

	public RevisionsModificationResponse RejectAllRevisions(String name, String filename, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/revisions/rejectAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (RevisionsModificationResponse) ApiInvoker.deserialize(response, "",
					RevisionsModificationResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteSectionFields Remove fields from section.
	 * 
	 * @param name
	 *            String The file name.
	 * @param sectionIndex
	 *            Integer Section index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteSectionFields(String name, Integer sectionIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * DeleteSectionParagraphFields Remove fields from section paragraph.
	 * 
	 * @param name
	 *            String The file name.
	 * @param sectionIndex
	 *            Integer Section index
	 * @param paragraphIndex
	 *            Integer Paragraph index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SaaSposeResponse
	 */

	public SaaSposeResponse DeleteSectionParagraphFields(String name, Integer sectionIndex, Integer paragraphIndex,
			String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null || paragraphIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetSection Get document section by index.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SectionResponse
	 */

	public SectionResponse GetSection(String name, Integer sectionIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SectionResponse) ApiInvoker.deserialize(response, "", SectionResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetSectionPageSetup Get page setup of section.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SectionPageSetupResponse
	 */

	public SectionPageSetupResponse GetSectionPageSetup(String name, Integer sectionIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || sectionIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SectionPageSetupResponse) ApiInvoker.deserialize(response, "", SectionPageSetupResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetSections Return a list of sections that are contained in the document.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @return SectionLinkCollectionResponse
	 */

	public SectionLinkCollectionResponse GetSections(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SectionLinkCollectionResponse) ApiInvoker.deserialize(response, "",
					SectionLinkCollectionResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * UpdateSectionPageSetup Update page setup of section.
	 * 
	 * @param name
	 *            String The document name.
	 * @param sectionIndex
	 *            Integer Section index
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document.
	 * @param body
	 *            PageSetup Page setup properties dto
	 * @return SectionPageSetupResponse
	 */

	public SectionPageSetupResponse UpdateSectionPageSetup(String name, Integer sectionIndex, String storage,
			String folder, String filename, PageSetup body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || sectionIndex == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SectionPageSetupResponse) ApiInvoker.deserialize(response, "", SectionPageSetupResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * GetDocumentTextItems Read document text items.
	 * 
	 * @param name
	 *            String The document name.
	 * @param storage
	 *            String Document's storage.
	 * @param folder
	 *            String Document's folder.
	 * @return TextItemsResponse
	 */

	public TextItemsResponse GetDocumentTextItems(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/textItems/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (TextItemsResponse) ApiInvoker.deserialize(response, "", TextItemsResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostReplaceText Replace document text.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            ReplaceTextRequest with the replace operation settings.
	 * @return ReplaceTextResponse
	 */

	public ReplaceTextResponse PostReplaceText(String name, String filename, String storage, String folder,
			ReplaceTextRequest body, String revisionAuthor, String revisionDateTime) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/replaceText/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ReplaceTextResponse) ApiInvoker.deserialize(response, "", ReplaceTextResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostInsertWatermarkImage Insert document watermark image.
	 * 
	 * @param name
	 *            String The document name.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param rotationAngle
	 *            Double The watermark rotation angle.
	 * @param image
	 *            String The image file server full name. If the name is empty
	 *            the image is expected in request content.
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param file
	 *            File
	 * @return DocumentResponse
	 */

	public DocumentResponse PostInsertWatermarkImage(String name, String filename, Double rotationAngle, String image,
			String storage, String folder, File file) {
		Object postBody = null;
		// verify required params are set
		if (name == null || file == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/insertWatermarkImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (rotationAngle != null)
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}", apiInvoker.toPathValue(rotationAngle));
		else
			resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
		if (image != null)
			resourcePath = resourcePath.replace("{" + "image" + "}", apiInvoker.toPathValue(image));
		else
			resourcePath = resourcePath.replaceAll("[&?]image.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "multipart/form-data" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		if (contentType.startsWith("multipart/form-data")) {
			FormDataMultiPart mp = new FormDataMultiPart();
			mp.field("file", file, MediaType.MULTIPART_FORM_DATA_TYPE);
			postBody = mp;
		}
		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	/**
	 * PostInsertWatermarkText Insert document watermark text.
	 * 
	 * @param name
	 *            String The document name.
	 * @param text
	 *            String The text to insert.
	 * @param rotationAngle
	 *            Double The text rotation angle.
	 * @param filename
	 *            String Result name of the document after the operation. If
	 *            this parameter is omitted then result of the operation will be
	 *            saved as the source document
	 * @param storage
	 *            String The document storage.
	 * @param folder
	 *            String The document folder.
	 * @param body
	 *            WatermarkText with the watermark data. If the parameter is
	 *            provided the query string parameters are ignored.
	 * @return DocumentResponse
	 */

	public DocumentResponse PostInsertWatermarkText(String name, String text, Double rotationAngle, String filename,
			String storage, String folder, WatermarkText body) {
		Object postBody = body;
		// verify required params are set
		if (name == null || body == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/insertWatermarkText/?appSid={appSid}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (text != null)
			resourcePath = resourcePath.replace("{" + "text" + "}", apiInvoker.toPathValue(text));
		else
			resourcePath = resourcePath.replaceAll("[&?]text.*?(?=&|\\?|$)", "");
		if (rotationAngle != null)
			resourcePath = resourcePath.replace("{" + "rotationAngle" + "}", apiInvoker.toPathValue(rotationAngle));
		else
			resourcePath = resourcePath.replaceAll("[&?]rotationAngle.*?(?=&|\\?|$)", "");
		if (filename != null)
			resourcePath = resourcePath.replace("{" + "filename" + "}", apiInvoker.toPathValue(filename));
		else
			resourcePath = resourcePath.replaceAll("[&?]filename.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");
		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public CommentsResponse GetComment(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/comments?appSid={appSid}&folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (CommentsResponse) ApiInvoker.deserialize(response, "", CommentsResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public CommentsResponse GetComment(String name, Integer commentIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || commentIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/comments/{commentIndex}?appSid={appSid}&folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (commentIndex != null)
			resourcePath = resourcePath.replace("{" + "commentIndex" + "}", apiInvoker.toPathValue(commentIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]commentIndex.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (CommentsResponse) ApiInvoker.deserialize(response, "", CommentsResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public ResponseMessage PutComment(String name, String fileName, String storage, String folder, Object comment) {
		Object postBody = null;
		// verify required params are set
		if (name == null || comment == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/comments/{commentIndex}?folder={folder}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (ResponseMessage) ApiInvoker.deserialize(response, "", ResponseMessage.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public SaaSposeResponse DeleteComment(String name, String fileName, String storage, String folder,
			Integer commentIndex) {
		Object postBody = null;
		// verify required params are set
		if (name == null || commentIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/comments/{commentIndex}?folder={folder}&fileName={fileName}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (fileName != null)
			resourcePath = resourcePath.replace("{" + "fileName" + "}", apiInvoker.toPathValue(fileName));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");
		if (commentIndex != null)
			resourcePath = resourcePath.replace("{" + "commentIndex" + "}", apiInvoker.toPathValue(commentIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]commentIndex.*?(?=&|\\?|$)", "");
		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public SearchResult Search(String name, String pattern, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || pattern == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/search?pattern={pattern}&folder={folder}&appSid={appSid}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		if (pattern != null)
			resourcePath = resourcePath.replace("{" + "pattern" + "}", apiInvoker.toPathValue(pattern));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SearchResult) ApiInvoker.deserialize(response, "", SearchResult.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public DocumentResponse PostCompareDocument(String name, String storage, String folder, CompareData comapreData) {
		Object postBody = comapreData;
		// verify required params are set
		if (name == null || comapreData == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables
		String resourcePath = "/words/{name}/compareDocument?filename={filename}&folder={folder}&appSid={appSid}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");
		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (DocumentResponse) ApiInvoker.deserialize(response, "", DocumentResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	// TODO: This does not work
	public SaaSposeResponse DeleteFootnotes(String name, Integer objectIndex, Integer sectionIndex,
			Integer paragraphIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null || sectionIndex == null || paragraphIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variables

		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/footnotes/{objectIndex}?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		System.out.println("------------------->" + resourcePath);

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				ex.printStackTrace();
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public FootnotesResponse GetFootnotes(String name, Integer objectIndex, Integer sectionIndex,
			Integer paragraphIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null || objectIndex == null || sectionIndex == null || paragraphIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/footnotes?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FootnotesResponse) ApiInvoker.deserialize(response, "", FootnotesResponse.class);
		} catch (ApiException ex) {
			if (ex.getCode() == 404) {
				ex.printStackTrace();
				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	// TODO: Does not work
	public FootnotesResponse PostFootnotes(String name, Integer objectIndex, Integer sectionIndex,
			Integer paragraphIndex, String storage, String folder, FootnotesDTO footnotesDTO) {
		Object postBody = footnotesDTO;
		// verify required params are set
		if (name == null || objectIndex == null || sectionIndex == null || paragraphIndex == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/footnotes/{objectIndex}?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");
		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");
		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "POST", queryParams, postBody, headerParams,
					formParams, contentType);
			return (FootnotesResponse) ApiInvoker.deserialize(response, "", FootnotesResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public OfficeMathObjectsResponse GetOfficeMathObjects(String name, Integer sectionIndex, Integer paragraphIndex,
			String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/OfficeMathObjects?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (OfficeMathObjectsResponse) ApiInvoker.deserialize(response, "", OfficeMathObjectsResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}
	
	
	public SaaSposeResponse DeleteOfficeMathObjects(String name, Integer objectIndex,
            String storage, String folder) {
        Object postBody = null;
        // verify required params are set
        if (name == null) {
            throw new ApiException(400, "missing required params");
        }
        // create path and map variable
        String resourcePath = "/words/{name}/OfficeMathObjects/{objectIndex}?appSid={appSid}&folder={folder}&storage={storage}";
        resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
                .replace("toFormat={toFormat}", "format={format}");
        // query params
        Map<String, String> queryParams = new HashMap<String, String>();
        Map<String, String> headerParams = new HashMap<String, String>();
        Map<String, String> formParams = new HashMap<String, String>();

        if (name != null)
            resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
        else
            resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

        if (objectIndex != null)
            resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
        else
            resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");

        if (storage != null)
            resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
        else
            resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

        if (folder != null)
            resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
        else
            resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

        String[] contentTypes = { "application/json" };

        String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

        try {
            response = apiInvoker.invokeAPI(basePath, resourcePath, "DELETE", queryParams, postBody, headerParams,
                    formParams, contentType);
            return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
        } catch (ApiException ex) {
            ex.printStackTrace();
            ex.getMessage();
            if (ex.getCode() == 404) {

                throw new ApiException(404, "");
            } else {
                throw ex;
            }
        }
    }

	public OfficeMathObjectsResponse GetOfficeMathObjects(String name, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/OfficeMathObjects?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (OfficeMathObjectsResponse) ApiInvoker.deserialize(response, "", OfficeMathObjectsResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	public OfficeMathObjectsResponse GetOfficeMathObjects(String name, Integer sectionIndex, Integer paragraphIndex,
			Integer objectIndex, String storage, String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/OfficeMathObjects/{objectIndex}?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (objectIndex != null)
			resourcePath = resourcePath.replace("{" + "objectIndex" + "}", apiInvoker.toPathValue(objectIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]objectIndex.*?(?=&|\\?|$)", "");

		if (sectionIndex != null)
			resourcePath = resourcePath.replace("{" + "sectionIndex" + "}", apiInvoker.toPathValue(sectionIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]sectionIndex.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (OfficeMathObjectsResponse) ApiInvoker.deserialize(response, "", OfficeMathObjectsResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}

	
	
	
	public OfficeMathObjectsResponse GetOfficeMathObjects(String name, Integer paragraphIndex, String storage,
			String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable
		String resourcePath = "/words/{name}/paragraphs/{paragraphIndex}/OfficeMathObjects?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (paragraphIndex != null)
			resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}", apiInvoker.toPathValue(paragraphIndex));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (OfficeMathObjectsResponse) ApiInvoker.deserialize(response, "", OfficeMathObjectsResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}
	
	
	public TableLinkCollectionResponse GetTables(String name, String nodePath, String storage,String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable

		String resourcePath = "/words/{name}/{nodePath}?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (nodePath != null)
			resourcePath = resourcePath.replace("{" + "nodePath" + "}", apiInvoker.toPathValue(nodePath));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (TableLinkCollectionResponse) ApiInvoker.deserialize(response, "", TableLinkCollectionResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}
	
	
	
	
	
	
	
	public SaaSposeResponse DeleteTable(String name, String nodePath, String storage,String folder) {
		Object postBody = null;
		// verify required params are set
		if (name == null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable

		String resourcePath = "/words/{name}/{nodePath}?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (nodePath != null)
			resourcePath = resourcePath.replace("{" + "nodePath" + "}", apiInvoker.toPathValue(nodePath));
		else
			resourcePath = resourcePath.replaceAll("[&?]paragraphIndex.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "GET", queryParams, postBody, headerParams,
					formParams, contentType);
			return (SaaSposeResponse) ApiInvoker.deserialize(response, "", SaaSposeResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}
	
	
	
	
	
	
	public TableResponse InsertTable(String name, String storage,String folder,TableObject object) {
		Object postBody = object;
		// verify required params are set
		if (name == null || object==null) {
			throw new ApiException(400, "missing required params");
		}
		// create path and map variable

		String resourcePath = "/words/{name}/tables?appSid={appSid}&folder={folder}&storage={storage}";
		resourcePath = resourcePath.replaceAll("\\*", "").replace("&amp;", "&").replace("/?", "?")
				.replace("toFormat={toFormat}", "format={format}");
		// query params
		Map<String, String> queryParams = new HashMap<String, String>();
		Map<String, String> headerParams = new HashMap<String, String>();
		Map<String, String> formParams = new HashMap<String, String>();

		if (name != null)
			resourcePath = resourcePath.replace("{" + "name" + "}", apiInvoker.toPathValue(name));
		else
			resourcePath = resourcePath.replaceAll("[&?]name.*?(?=&|\\?|$)", "");

		if (storage != null)
			resourcePath = resourcePath.replace("{" + "storage" + "}", apiInvoker.toPathValue(storage));
		else
			resourcePath = resourcePath.replaceAll("[&?]storage.*?(?=&|\\?|$)", "");

		if (folder != null)
			resourcePath = resourcePath.replace("{" + "folder" + "}", apiInvoker.toPathValue(folder));
		else
			resourcePath = resourcePath.replaceAll("[&?]folder.*?(?=&|\\?|$)", "");

		String[] contentTypes = { "application/json" };

		String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

		try {
			response = apiInvoker.invokeAPI(basePath, resourcePath, "PUT", queryParams, postBody, headerParams,
					formParams, contentType);
			return (TableResponse) ApiInvoker.deserialize(response, "", TableResponse.class);
		} catch (ApiException ex) {
			ex.printStackTrace();
			ex.getMessage();
			if (ex.getCode() == 404) {

				throw new ApiException(404, "");
			} else {
				throw ex;
			}
		}
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

}
