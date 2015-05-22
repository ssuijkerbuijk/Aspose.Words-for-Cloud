<?php

namespace Aspose\Words;

use Aspose\Words\ApiException as Exception;
use Aspose\Words\ApiClient;

class WordsApi {

    function __construct() {
        $this->apiClient = new ApiClient();
    }

    /**
     * GetDocumentBookmarkByName
     * Read document bookmark data by its name.
     * name, string: The document name. (required)

     * bookmarkName, string: The bookmark name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return BookmarkResponse
     */
    public function GetDocumentBookmarkByName($name, $bookmarkName, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $bookmarkName == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($bookmarkName != null) {
            $resourcePath = str_replace("{" . "bookmarkName" . "}", $this->apiClient->toQueryValue($bookmarkName), $resourcePath);
        } else {
            $resourcePath = str_replace("&bookmarkName={" . "bookmarkName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BookmarkResponse');
        return $responseObject;
    }

    /**
     * GetDocumentBookmarks
     * Read document bookmarks common info.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return BookmarksResponse
     */
    public function GetDocumentBookmarks($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/bookmarks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BookmarksResponse');
        return $responseObject;
    }

    /**
     * PostUpdateDocumentBookmark
     * Update document bookmark.
     * name, string: The document name. (required)

     * bookmarkName, string: The bookmark name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, BookmarkData: with new bookmark data. (required)

     * @return BookmarkResponse
     */
    public function PostUpdateDocumentBookmark($name, $bookmarkName, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $bookmarkName == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($bookmarkName != null) {
            $resourcePath = str_replace("{" . "bookmarkName" . "}", $this->apiClient->toQueryValue($bookmarkName), $resourcePath);
        } else {
            $resourcePath = str_replace("&bookmarkName={" . "bookmarkName" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'BookmarkResponse');
        return $responseObject;
    }

    /**
     * GetDocument
     * RRead document common info.
     * name, string: The file name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ResponseMessage
     */
    public function GetDocument($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentWithFormat
     * Export the document into the specified format.
     * name, string: The file name. (required)

     * format, string: The destination format. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * outPath, string: Path to save result (optional)

     * @return ResponseMessage
     */
    public function GetDocumentWithFormat($name, $format, $storage = null, $folder = null, $outPath = null) {
        // verify required params are set
        if ($name == '' || $format == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($outPath != null) {
            $resourcePath = str_replace("{" . "outPath" . "}", $this->apiClient->toQueryValue($outPath), $resourcePath);
        } else {
            $resourcePath = str_replace("&outPath={" . "outPath" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PostAppendDocument
     * Append documents to original document.
     * name, string: Original document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: Original document storage. (optional)

     * folder, string: Original document folder. (optional)

     * body, DocumentEntryList: with a list of documents to append. (required)

     * @return DocumentResponse
     */
    public function PostAppendDocument($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/appendDocument/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostExecuteTemplate
     * Populate document template with data.
     * name, string: The template document name. (required)

     * cleanup, string: Clean up options. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * useWholeParagraphAsRegion, bool: Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.              The default value is true. (optional)

     * withRegions, bool: Merge with regions or not. True by default (optional)

     * file, File:  (required)

     * @return DocumentResponse
     */
    public function PostExecuteTemplate($name, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file) {
        // verify required params are set
        if ($name == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($cleanup != null) {
            $resourcePath = str_replace("{" . "cleanup" . "}", $this->apiClient->toQueryValue($cleanup), $resourcePath);
        } else {
            $resourcePath = str_replace("&cleanup={" . "cleanup" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($useWholeParagraphAsRegion != null) {
            $resourcePath = str_replace("{" . "useWholeParagraphAsRegion" . "}", $this->apiClient->toQueryValue($useWholeParagraphAsRegion), $resourcePath);
        } else {
            $resourcePath = str_replace("&useWholeParagraphAsRegion={" . "useWholeParagraphAsRegion" . "}", "", $resourcePath);
        }
        if ($withRegions != null) {
            $resourcePath = str_replace("{" . "withRegions" . "}", $this->apiClient->toQueryValue($withRegions), $resourcePath);
        } else {
            $resourcePath = str_replace("&withRegions={" . "withRegions" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostInsertPageNumbers
     * Insert document page numbers.
     * name, string: A document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, PageNumber: with the page numbers settings. (required)

     * @return DocumentResponse
     */
    public function PostInsertPageNumbers($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/insertPageNumbers/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostLoadWebDocument
     * Load new document from web into the file with any supported format of data.
     * @return SaveResponse
     */
    public function PostLoadWebDocument() {
        //parse inputs
        $resourcePath = "/words/loadWebDocument/?appSid={appSid}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaveResponse');
        return $responseObject;
    }

    /**
     * PostRunTask
     * Run tasks
     * @return ResponseMessage
     */
    public function PostRunTask() {
        //parse inputs
        $resourcePath = "/words/tasks/?appSid={appSid}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PostSplitDocument
     * Split document.
     * name, string: Original document name. (required)

     * format, string: Format to split. (optional)

     * from, int: Start page. (optional)

     * to, int: End page. (optional)

     * zipOutput, bool: ZipOutput or not. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SplitDocumentResponse
     */
    public function PostSplitDocument($name, $format = null, $from = null, $to = null, $zipOutput = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/split/?appSid={appSid}&amp;toFormat={toFormat}&amp;from={from}&amp;to={to}&amp;zipOutput={zipOutput}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($from != null) {
            $resourcePath = str_replace("{" . "from" . "}", $this->apiClient->toQueryValue($from), $resourcePath);
        } else {
            $resourcePath = str_replace("&from={" . "from" . "}", "", $resourcePath);
        }
        if ($to != null) {
            $resourcePath = str_replace("{" . "to" . "}", $this->apiClient->toQueryValue($to), $resourcePath);
        } else {
            $resourcePath = str_replace("&to={" . "to" . "}", "", $resourcePath);
        }
        if ($zipOutput != null) {
            $resourcePath = str_replace("{" . "zipOutput" . "}", $this->apiClient->toQueryValue($zipOutput), $resourcePath);
        } else {
            $resourcePath = str_replace("&zipOutput={" . "zipOutput" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SplitDocumentResponse');
        return $responseObject;
    }

    /**
     * PutConvertDocument
     * Convert document from request content to format specified.
     * format, string: Format to convert. (optional)

     * outPath, string:  (optional)

     * file, File:  (required)

     * @return ResponseMessage
     */
    public function PutConvertDocument($format = null, $outPath = null, $file) {
        // verify required params are set
        if ($file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/convert/?appSid={appSid}&amp;toFormat={toFormat}&amp;outPath={outPath}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($outPath != null) {
            $resourcePath = str_replace("{" . "outPath" . "}", $this->apiClient->toQueryValue($outPath), $resourcePath);
        } else {
            $resourcePath = str_replace("&outPath={" . "outPath" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PutDocumentFieldNames
     * Read document field names.
     * useNonMergeFields, bool:  (optional)

     * @return FieldNamesResponse
     */
    public function PutDocumentFieldNames($useNonMergeFields = null) {
        //parse inputs
        $resourcePath = "/words/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($useNonMergeFields != null) {
            $resourcePath = str_replace("{" . "useNonMergeFields" . "}", $this->apiClient->toQueryValue($useNonMergeFields), $resourcePath);
        } else {
            $resourcePath = str_replace("&useNonMergeFields={" . "useNonMergeFields" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FieldNamesResponse');
        return $responseObject;
    }

    /**
     * PutExecuteMailMergeOnline
     * Execute document mail merge online.
     * withRegions, bool: With regions flag. (required)

     * cleanup, string: Clean up options. (optional)

     * file, File:  (required)

     * @return ResponseMessage
     */
    public function PutExecuteMailMergeOnline($withRegions, $cleanup = null, $file) {
        // verify required params are set
        if ($withRegions == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/executeMailMerge/?withRegions={withRegions}&amp;appSid={appSid}&amp;cleanup={cleanup}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($withRegions != null) {
            $resourcePath = str_replace("{" . "withRegions" . "}", $this->apiClient->toQueryValue($withRegions), $resourcePath);
        } else {
            $resourcePath = str_replace("&withRegions={" . "withRegions" . "}", "", $resourcePath);
        }
        if ($cleanup != null) {
            $resourcePath = str_replace("{" . "cleanup" . "}", $this->apiClient->toQueryValue($cleanup), $resourcePath);
        } else {
            $resourcePath = str_replace("&cleanup={" . "cleanup" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PutExecuteTemplateOnline
     * Populate document template with data online.
     * cleanup, string: Clean up options. (optional)

     * useWholeParagraphAsRegion, bool: Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true. (optional)

     * withRegions, bool: Merge with regions or not. True by default (optional)

     * file, File:  (required)

     * @return ResponseMessage
     */
    public function PutExecuteTemplateOnline($cleanup = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file) {
        // verify required params are set
        if ($file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($cleanup != null) {
            $resourcePath = str_replace("{" . "cleanup" . "}", $this->apiClient->toQueryValue($cleanup), $resourcePath);
        } else {
            $resourcePath = str_replace("&cleanup={" . "cleanup" . "}", "", $resourcePath);
        }
        if ($useWholeParagraphAsRegion != null) {
            $resourcePath = str_replace("{" . "useWholeParagraphAsRegion" . "}", $this->apiClient->toQueryValue($useWholeParagraphAsRegion), $resourcePath);
        } else {
            $resourcePath = str_replace("&useWholeParagraphAsRegion={" . "useWholeParagraphAsRegion" . "}", "", $resourcePath);
        }
        if ($withRegions != null) {
            $resourcePath = str_replace("{" . "withRegions" . "}", $this->apiClient->toQueryValue($withRegions), $resourcePath);
        } else {
            $resourcePath = str_replace("&withRegions={" . "withRegions" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * DeleteDocumentFields
     * Remove fields from document.
     * name, string: The file name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteDocumentFields($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * PostUpdateDocumentFields
     * Update (reevaluate) fields in document.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return DocumentResponse
     */
    public function PostUpdateDocumentFields($name, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/updateFields/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * DeleteDocumentProperty
     * Delete document property.
     * name, string: The document name. (required)

     * propertyName, string: The property name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: Document's storage. (optional)

     * folder, string: Document's folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteDocumentProperty($name, $propertyName, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $propertyName == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($propertyName != null) {
            $resourcePath = str_replace("{" . "propertyName" . "}", $this->apiClient->toQueryValue($propertyName), $resourcePath);
        } else {
            $resourcePath = str_replace("&propertyName={" . "propertyName" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetDocumentProperties
     * Read document properties info.
     * name, string: The document's name. (required)

     * storage, string: The document's storage. (optional)

     * folder, string: The document's folder. (optional)

     * @return DocumentPropertiesResponse
     */
    public function GetDocumentProperties($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/documentProperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentPropertiesResponse');
        return $responseObject;
    }

    /**
     * GetDocumentProperty
     * Read document property info by the property name.
     * name, string: The document name. (required)

     * propertyName, string: The property name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return DocumentPropertyResponse
     */
    public function GetDocumentProperty($name, $propertyName, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $propertyName == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($propertyName != null) {
            $resourcePath = str_replace("{" . "propertyName" . "}", $this->apiClient->toQueryValue($propertyName), $resourcePath);
        } else {
            $resourcePath = str_replace("&propertyName={" . "propertyName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentPropertyResponse');
        return $responseObject;
    }

    /**
     * PutUpdateDocumentProperty
     * Add new or update existing document property.
     * name, string: The document name. (required)

     * propertyName, string: The property name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: Document's storage. (optional)

     * folder, string: Document's folder. (optional)

     * body, DocumentProperty: The property with new value. (required)

     * @return DocumentPropertyResponse
     */
    public function PutUpdateDocumentProperty($name, $propertyName, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $propertyName == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($propertyName != null) {
            $resourcePath = str_replace("{" . "propertyName" . "}", $this->apiClient->toQueryValue($propertyName), $resourcePath);
        } else {
            $resourcePath = str_replace("&propertyName={" . "propertyName" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentPropertyResponse');
        return $responseObject;
    }

    /**
     * DeleteUnprotectDocument
     * Unprotect document.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, ProtectionRequest: with protection settings. (required)

     * @return ProtectionDataResponse
     */
    public function DeleteUnprotectDocument($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ProtectionDataResponse');
        return $responseObject;
    }

    /**
     * GetDocumentProtection
     * Read document protection common info.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ProtectionDataResponse
     */
    public function GetDocumentProtection($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ProtectionDataResponse');
        return $responseObject;
    }

    /**
     * PostChangeDocumentProtection
     * Change document protection.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, ProtectionRequest: with protection settings. (required)

     * @return ProtectionDataResponse
     */
    public function PostChangeDocumentProtection($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ProtectionDataResponse');
        return $responseObject;
    }

    /**
     * PutProtectDocument
     * Protect document.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, ProtectionRequest: with protection settings. (required)

     * @return ProtectionDataResponse
     */
    public function PutProtectDocument($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ProtectionDataResponse');
        return $responseObject;
    }

    /**
     * PostDocumentSaveAs
     * Convert document to tiff with detailed settings and save result to storage.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, SaveOptionsData: Save options. (required)

     * @return SaveResponse
     */
    public function PostDocumentSaveAs($name, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/SaveAs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaveResponse');
        return $responseObject;
    }

    /**
     * PutDocumentSaveAsTiff
     * Convert document to tiff with detailed settings and save result to storage.
     * name, string: The document name. (required)

     * resultFile, string: The resulting file name. (optional)

     * useAntiAliasing, bool: Use antialiasing flag. (optional)

     * useHighQualityRendering, bool: Use high quality flag. (optional)

     * imageBrightness, float: Brightness for the generated images. (optional)

     * imageColorMode, string: Color mode for the generated images. (optional)

     * imageContrast, float: The contrast for the generated images. (optional)

     * numeralFormat, string: The images numeral format. (optional)

     * pageCount, int: Number of pages to render. (optional)

     * pageIndex, int: Page index to start rendering. (optional)

     * paperColor, string: Background image color. (optional)

     * pixelFormat, string: The pixel format of generated images. (optional)

     * resolution, float: The resolution of generated images. (optional)

     * scale, float: Zoom factor for generated images. (optional)

     * tiffCompression, string: The compression tipe. (optional)

     * dmlRenderingMode, string: Optional, default is Fallback. (optional)

     * dmlEffectsRenderingMode, string: Optional, default is Simplified. (optional)

     * tiffBinarizationMethod, string: Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * zipOutput, bool: Optional. A value determining zip output or not. (optional)

     * body, TiffSaveOptionsData: Tiff save options. (required)

     * @return SaveResponse
     */
    public function PutDocumentSaveAsTiff($name, $resultFile = null, $useAntiAliasing = null, $useHighQualityRendering = null, $imageBrightness = null, $imageColorMode = null, $imageContrast = null, $numeralFormat = null, $pageCount = null, $pageIndex = null, $paperColor = null, $pixelFormat = null, $resolution = null, $scale = null, $tiffCompression = null, $dmlRenderingMode = null, $dmlEffectsRenderingMode = null, $tiffBinarizationMethod = null, $storage = null, $folder = null, $zipOutput = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/SaveAs/tiff/?appSid={appSid}&amp;resultFile={resultFile}&amp;useAntiAliasing={useAntiAliasing}&amp;useHighQualityRendering={useHighQualityRendering}&amp;imageBrightness={imageBrightness}&amp;imageColorMode={imageColorMode}&amp;imageContrast={imageContrast}&amp;numeralFormat={numeralFormat}&amp;pageCount={pageCount}&amp;pageIndex={pageIndex}&amp;paperColor={paperColor}&amp;pixelFormat={pixelFormat}&amp;resolution={resolution}&amp;scale={scale}&amp;tiffCompression={tiffCompression}&amp;dmlRenderingMode={dmlRenderingMode}&amp;dmlEffectsRenderingMode={dmlEffectsRenderingMode}&amp;tiffBinarizationMethod={tiffBinarizationMethod}&amp;storage={storage}&amp;folder={folder}&amp;zipOutput={zipOutput}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($resultFile != null) {
            $resourcePath = str_replace("{" . "resultFile" . "}", $this->apiClient->toQueryValue($resultFile), $resourcePath);
        } else {
            $resourcePath = str_replace("&resultFile={" . "resultFile" . "}", "", $resourcePath);
        }
        if ($useAntiAliasing != null) {
            $resourcePath = str_replace("{" . "useAntiAliasing" . "}", $this->apiClient->toQueryValue($useAntiAliasing), $resourcePath);
        } else {
            $resourcePath = str_replace("&useAntiAliasing={" . "useAntiAliasing" . "}", "", $resourcePath);
        }
        if ($useHighQualityRendering != null) {
            $resourcePath = str_replace("{" . "useHighQualityRendering" . "}", $this->apiClient->toQueryValue($useHighQualityRendering), $resourcePath);
        } else {
            $resourcePath = str_replace("&useHighQualityRendering={" . "useHighQualityRendering" . "}", "", $resourcePath);
        }
        if ($imageBrightness != null) {
            $resourcePath = str_replace("{" . "imageBrightness" . "}", $this->apiClient->toQueryValue($imageBrightness), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageBrightness={" . "imageBrightness" . "}", "", $resourcePath);
        }
        if ($imageColorMode != null) {
            $resourcePath = str_replace("{" . "imageColorMode" . "}", $this->apiClient->toQueryValue($imageColorMode), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageColorMode={" . "imageColorMode" . "}", "", $resourcePath);
        }
        if ($imageContrast != null) {
            $resourcePath = str_replace("{" . "imageContrast" . "}", $this->apiClient->toQueryValue($imageContrast), $resourcePath);
        } else {
            $resourcePath = str_replace("&imageContrast={" . "imageContrast" . "}", "", $resourcePath);
        }
        if ($numeralFormat != null) {
            $resourcePath = str_replace("{" . "numeralFormat" . "}", $this->apiClient->toQueryValue($numeralFormat), $resourcePath);
        } else {
            $resourcePath = str_replace("&numeralFormat={" . "numeralFormat" . "}", "", $resourcePath);
        }
        if ($pageCount != null) {
            $resourcePath = str_replace("{" . "pageCount" . "}", $this->apiClient->toQueryValue($pageCount), $resourcePath);
        } else {
            $resourcePath = str_replace("&pageCount={" . "pageCount" . "}", "", $resourcePath);
        }
        if ($pageIndex != null) {
            $resourcePath = str_replace("{" . "pageIndex" . "}", $this->apiClient->toQueryValue($pageIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&pageIndex={" . "pageIndex" . "}", "", $resourcePath);
        }
        if ($paperColor != null) {
            $resourcePath = str_replace("{" . "paperColor" . "}", $this->apiClient->toQueryValue($paperColor), $resourcePath);
        } else {
            $resourcePath = str_replace("&paperColor={" . "paperColor" . "}", "", $resourcePath);
        }
        if ($pixelFormat != null) {
            $resourcePath = str_replace("{" . "pixelFormat" . "}", $this->apiClient->toQueryValue($pixelFormat), $resourcePath);
        } else {
            $resourcePath = str_replace("&pixelFormat={" . "pixelFormat" . "}", "", $resourcePath);
        }
        if ($resolution != null) {
            $resourcePath = str_replace("{" . "resolution" . "}", $this->apiClient->toQueryValue($resolution), $resourcePath);
        } else {
            $resourcePath = str_replace("&resolution={" . "resolution" . "}", "", $resourcePath);
        }
        if ($scale != null) {
            $resourcePath = str_replace("{" . "scale" . "}", $this->apiClient->toQueryValue($scale), $resourcePath);
        } else {
            $resourcePath = str_replace("&scale={" . "scale" . "}", "", $resourcePath);
        }
        if ($tiffCompression != null) {
            $resourcePath = str_replace("{" . "tiffCompression" . "}", $this->apiClient->toQueryValue($tiffCompression), $resourcePath);
        } else {
            $resourcePath = str_replace("&tiffCompression={" . "tiffCompression" . "}", "", $resourcePath);
        }
        if ($dmlRenderingMode != null) {
            $resourcePath = str_replace("{" . "dmlRenderingMode" . "}", $this->apiClient->toQueryValue($dmlRenderingMode), $resourcePath);
        } else {
            $resourcePath = str_replace("&dmlRenderingMode={" . "dmlRenderingMode" . "}", "", $resourcePath);
        }
        if ($dmlEffectsRenderingMode != null) {
            $resourcePath = str_replace("{" . "dmlEffectsRenderingMode" . "}", $this->apiClient->toQueryValue($dmlEffectsRenderingMode), $resourcePath);
        } else {
            $resourcePath = str_replace("&dmlEffectsRenderingMode={" . "dmlEffectsRenderingMode" . "}", "", $resourcePath);
        }
        if ($tiffBinarizationMethod != null) {
            $resourcePath = str_replace("{" . "tiffBinarizationMethod" . "}", $this->apiClient->toQueryValue($tiffBinarizationMethod), $resourcePath);
        } else {
            $resourcePath = str_replace("&tiffBinarizationMethod={" . "tiffBinarizationMethod" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($zipOutput != null) {
            $resourcePath = str_replace("{" . "zipOutput" . "}", $this->apiClient->toQueryValue($zipOutput), $resourcePath);
        } else {
            $resourcePath = str_replace("&zipOutput={" . "zipOutput" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaveResponse');
        return $responseObject;
    }

    /**
     * GetDocumentStatistics
     * Read document statistics.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return StatDataResponse
     */
    public function GetDocumentStatistics($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/statistics/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'StatDataResponse');
        return $responseObject;
    }

    /**
     * DeleteDocumentWatermark
     * Delete watermark (for deleting last watermark from the document).
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return DocumentResponse
     */
    public function DeleteDocumentWatermark($name, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/watermark/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostInsertDocumentWatermarkImage
     * Insert document watermark image.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * rotationAngle, float: The watermark rotation angle. (optional)

     * image, string: The image file server full name. If the name is empty the image is expected in request content. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * file, File:  (required)

     * @return DocumentResponse
     */
    public function PostInsertDocumentWatermarkImage($name, $filename = null, $rotationAngle = null, $image = null, $storage = null, $folder = null, $file) {
        // verify required params are set
        if ($name == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/watermark/insertImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($image != null) {
            $resourcePath = str_replace("{" . "image" . "}", $this->apiClient->toQueryValue($image), $resourcePath);
        } else {
            $resourcePath = str_replace("&image={" . "image" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostInsertDocumentWatermarkText
     * Insert document watermark text.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * text, string: The text to insert. (optional)

     * rotationAngle, float: The text rotation angle. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, WatermarkText: with the watermark data.            If the parameter is provided the query string parameters are ignored. (required)

     * @return DocumentResponse
     */
    public function PostInsertDocumentWatermarkText($name, $filename = null, $text = null, $rotationAngle = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/watermark/insertText/?appSid={appSid}&amp;filename={filename}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($text != null) {
            $resourcePath = str_replace("{" . "text" . "}", $this->apiClient->toQueryValue($text), $resourcePath);
        } else {
            $resourcePath = str_replace("&text={" . "text" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * GetDocumentDrawingObjectByIndex
     * Read document drawing object common info by its index or convert to format specified.
     * name, string: The document name. (required)

     * objectIndex, int: The drawing object index. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder full path. (optional)

     * @return ResponseMessage
     */
    public function GetDocumentDrawingObjectByIndex($name, $objectIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $objectIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($objectIndex != null) {
            $resourcePath = str_replace("{" . "objectIndex" . "}", $this->apiClient->toQueryValue($objectIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&objectIndex={" . "objectIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentDrawingObjectByIndexWithFormat
     * Read document drawing object common info by its index or convert to format specified.
     * name, string: The document name. (required)

     * objectIndex, int: The drawing object index. (required)

     * format, string: The format to convert (if specified). (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder full path. (optional)

     * @return ResponseMessage
     */
    public function GetDocumentDrawingObjectByIndexWithFormat($name, $objectIndex, $format, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $objectIndex == '' || $format == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($objectIndex != null) {
            $resourcePath = str_replace("{" . "objectIndex" . "}", $this->apiClient->toQueryValue($objectIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&objectIndex={" . "objectIndex" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentDrawingObjectImageData
     * Read drawing object image data.
     * name, string: The document name. (required)

     * objectIndex, int: The drawing object index. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ResponseMessage
     */
    public function GetDocumentDrawingObjectImageData($name, $objectIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $objectIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/drawingObjects/{objectIndex}/imageData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($objectIndex != null) {
            $resourcePath = str_replace("{" . "objectIndex" . "}", $this->apiClient->toQueryValue($objectIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&objectIndex={" . "objectIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentDrawingObjectOleData
     * Get drawing object OLE data.
     * name, string: The document name. (required)

     * objectIndex, int: The object index. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ResponseMessage
     */
    public function GetDocumentDrawingObjectOleData($name, $objectIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $objectIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/drawingObjects/{objectIndex}/oleData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($objectIndex != null) {
            $resourcePath = str_replace("{" . "objectIndex" . "}", $this->apiClient->toQueryValue($objectIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&objectIndex={" . "objectIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentDrawingObjects
     * Read document drawing objects common info.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return DrawingObjectsResponse
     */
    public function GetDocumentDrawingObjects($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/drawingObjects/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DrawingObjectsResponse');
        return $responseObject;
    }

    /**
     * DeleteFormField
     * Removes form field from document.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index. (required)

     * paragraphIndex, int: Paragraph index. (required)

     * formfieldIndex, int: Form field index. (required)

     * destFileName, string: Destination file name. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteFormField($name, $sectionIndex, $paragraphIndex, $formfieldIndex, $destFileName = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $paragraphIndex == '' || $formfieldIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($paragraphIndex != null) {
            $resourcePath = str_replace("{" . "paragraphIndex" . "}", $this->apiClient->toQueryValue($paragraphIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&paragraphIndex={" . "paragraphIndex" . "}", "", $resourcePath);
        }
        if ($formfieldIndex != null) {
            $resourcePath = str_replace("{" . "formfieldIndex" . "}", $this->apiClient->toQueryValue($formfieldIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&formfieldIndex={" . "formfieldIndex" . "}", "", $resourcePath);
        }
        if ($destFileName != null) {
            $resourcePath = str_replace("{" . "destFileName" . "}", $this->apiClient->toQueryValue($destFileName), $resourcePath);
        } else {
            $resourcePath = str_replace("&destFileName={" . "destFileName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetFormField
     * Returns representation of an one of the form field.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index. (required)

     * paragraphIndex, int: Paragraph index. (required)

     * formfieldIndex, int: Form field index. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return FormFieldResponse
     */
    public function GetFormField($name, $sectionIndex, $paragraphIndex, $formfieldIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $paragraphIndex == '' || $formfieldIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($paragraphIndex != null) {
            $resourcePath = str_replace("{" . "paragraphIndex" . "}", $this->apiClient->toQueryValue($paragraphIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&paragraphIndex={" . "paragraphIndex" . "}", "", $resourcePath);
        }
        if ($formfieldIndex != null) {
            $resourcePath = str_replace("{" . "formfieldIndex" . "}", $this->apiClient->toQueryValue($formfieldIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&formfieldIndex={" . "formfieldIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FormFieldResponse');
        return $responseObject;
    }

    /**
     * PostFormField
     * Updates form field's properties, returns updated form field's data.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index. (required)

     * paragraphIndex, int: Paragraph index. (required)

     * formfieldIndex, int: Form field index. (required)

     * destFileName, string: Destination file name. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, FormField: From field data. (required)

     * @return FormFieldResponse
     */
    public function PostFormField($name, $sectionIndex, $paragraphIndex, $formfieldIndex, $destFileName = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $paragraphIndex == '' || $formfieldIndex == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($paragraphIndex != null) {
            $resourcePath = str_replace("{" . "paragraphIndex" . "}", $this->apiClient->toQueryValue($paragraphIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&paragraphIndex={" . "paragraphIndex" . "}", "", $resourcePath);
        }
        if ($formfieldIndex != null) {
            $resourcePath = str_replace("{" . "formfieldIndex" . "}", $this->apiClient->toQueryValue($formfieldIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&formfieldIndex={" . "formfieldIndex" . "}", "", $resourcePath);
        }
        if ($destFileName != null) {
            $resourcePath = str_replace("{" . "destFileName" . "}", $this->apiClient->toQueryValue($destFileName), $resourcePath);
        } else {
            $resourcePath = str_replace("&destFileName={" . "destFileName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FormFieldResponse');
        return $responseObject;
    }

    /**
     * PutFormField
     * Adds form field to paragraph, returns added form field's data.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index. (required)

     * paragraphIndex, int: Paragraph index. (required)

     * insertBeforeNode, string: Form field will be inserted before node with index. (optional)

     * destFileName, string: Destination file name. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, FormField: From field data. (required)

     * @return FormFieldResponse
     */
    public function PutFormField($name, $sectionIndex, $paragraphIndex, $insertBeforeNode = null, $destFileName = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $paragraphIndex == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/?appSid={appSid}&amp;insertBeforeNode={insertBeforeNode}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($paragraphIndex != null) {
            $resourcePath = str_replace("{" . "paragraphIndex" . "}", $this->apiClient->toQueryValue($paragraphIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&paragraphIndex={" . "paragraphIndex" . "}", "", $resourcePath);
        }
        if ($insertBeforeNode != null) {
            $resourcePath = str_replace("{" . "insertBeforeNode" . "}", $this->apiClient->toQueryValue($insertBeforeNode), $resourcePath);
        } else {
            $resourcePath = str_replace("&insertBeforeNode={" . "insertBeforeNode" . "}", "", $resourcePath);
        }
        if ($destFileName != null) {
            $resourcePath = str_replace("{" . "destFileName" . "}", $this->apiClient->toQueryValue($destFileName), $resourcePath);
        } else {
            $resourcePath = str_replace("&destFileName={" . "destFileName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FormFieldResponse');
        return $responseObject;
    }

    /**
     * DeleteHeadersFooters
     * Delete document headers and footers.
     * name, string: The document name. (required)

     * headersFootersTypes, string: List of types of headers and footers. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteHeadersFooters($name, $headersFootersTypes = null, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/headersfooters/?appSid={appSid}&amp;headersFootersTypes={headersFootersTypes}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($headersFootersTypes != null) {
            $resourcePath = str_replace("{" . "headersFootersTypes" . "}", $this->apiClient->toQueryValue($headersFootersTypes), $resourcePath);
        } else {
            $resourcePath = str_replace("&headersFootersTypes={" . "headersFootersTypes" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetDocumentHyperlinkByIndex
     * Read document hyperlink by its index.
     * name, string: The document name. (required)

     * hyperlinkIndex, int: The hyperlink index. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return HyperlinkResponse
     */
    public function GetDocumentHyperlinkByIndex($name, $hyperlinkIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $hyperlinkIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/hyperlinks/{hyperlinkIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($hyperlinkIndex != null) {
            $resourcePath = str_replace("{" . "hyperlinkIndex" . "}", $this->apiClient->toQueryValue($hyperlinkIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&hyperlinkIndex={" . "hyperlinkIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'HyperlinkResponse');
        return $responseObject;
    }

    /**
     * GetDocumentHyperlinks
     * Read document hyperlinks common info.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return HyperlinksResponse
     */
    public function GetDocumentHyperlinks($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/hyperlinks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'HyperlinksResponse');
        return $responseObject;
    }

    /**
     * DeleteDocumentMacros
     * Remove macros from document.
     * name, string: The file name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteDocumentMacros($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/macros/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetDocumentFieldNames
     * Read document field names.
     * name, string: The document name. (required)

     * useNonMergeFields, bool:  (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return FieldNamesResponse
     */
    public function GetDocumentFieldNames($name, $useNonMergeFields = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($useNonMergeFields != null) {
            $resourcePath = str_replace("{" . "useNonMergeFields" . "}", $this->apiClient->toQueryValue($useNonMergeFields), $resourcePath);
        } else {
            $resourcePath = str_replace("&useNonMergeFields={" . "useNonMergeFields" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FieldNamesResponse');
        return $responseObject;
    }

    /**
     * PostDocumentExecuteMailMerge
     * Execute document mail merge operation.
     * name, string: The document name. (required)

     * withRegions, bool: With regions flag. (required)

     * mailMergeDataFile, string: Mail merge data. (optional)

     * cleanup, string: Clean up options. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * useWholeParagraphAsRegion, bool: Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true. (optional)

     * file, File:  (required)

     * @return DocumentResponse
     */
    public function PostDocumentExecuteMailMerge($name, $withRegions, $mailMergeDataFile = null, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $file) {
        // verify required params are set
        if ($name == '' || $withRegions == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/executeMailMerge/{withRegions}/?appSid={appSid}&amp;mailMergeDataFile={mailMergeDataFile}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($withRegions != null) {
            $resourcePath = str_replace("{" . "withRegions" . "}", $this->apiClient->toQueryValue($withRegions), $resourcePath);
        } else {
            $resourcePath = str_replace("&withRegions={" . "withRegions" . "}", "", $resourcePath);
        }
        if ($mailMergeDataFile != null) {
            $resourcePath = str_replace("{" . "mailMergeDataFile" . "}", $this->apiClient->toQueryValue($mailMergeDataFile), $resourcePath);
        } else {
            $resourcePath = str_replace("&mailMergeDataFile={" . "mailMergeDataFile" . "}", "", $resourcePath);
        }
        if ($cleanup != null) {
            $resourcePath = str_replace("{" . "cleanup" . "}", $this->apiClient->toQueryValue($cleanup), $resourcePath);
        } else {
            $resourcePath = str_replace("&cleanup={" . "cleanup" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($useWholeParagraphAsRegion != null) {
            $resourcePath = str_replace("{" . "useWholeParagraphAsRegion" . "}", $this->apiClient->toQueryValue($useWholeParagraphAsRegion), $resourcePath);
        } else {
            $resourcePath = str_replace("&useWholeParagraphAsRegion={" . "useWholeParagraphAsRegion" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * DeleteParagraphFields
     * Remove fields from paragraph.
     * name, string: The file name. (required)

     * index, int: Paragraph index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteParagraphFields($name, $index, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $index == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/{index}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($index != null) {
            $resourcePath = str_replace("{" . "index" . "}", $this->apiClient->toQueryValue($index), $resourcePath);
        } else {
            $resourcePath = str_replace("&index={" . "index" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetDocumentParagraph
     * This resource represents one of the paragraphs contained in the document.
     * name, string: The document name. (required)

     * index, int: Paragraph index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ParagraphResponse
     */
    public function GetDocumentParagraph($name, $index, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $index == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/{index}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($index != null) {
            $resourcePath = str_replace("{" . "index" . "}", $this->apiClient->toQueryValue($index), $resourcePath);
        } else {
            $resourcePath = str_replace("&index={" . "index" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ParagraphResponse');
        return $responseObject;
    }

    /**
     * GetDocumentParagraphRun
     * This resource represents one of the paragraphs contained in the document.
     * name, string: The document name. (required)

     * index, int: Paragraph index (required)

     * runIndex, int: Run index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return RunResponse
     */
    public function GetDocumentParagraphRun($name, $index, $runIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $index == '' || $runIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($index != null) {
            $resourcePath = str_replace("{" . "index" . "}", $this->apiClient->toQueryValue($index), $resourcePath);
        } else {
            $resourcePath = str_replace("&index={" . "index" . "}", "", $resourcePath);
        }
        if ($runIndex != null) {
            $resourcePath = str_replace("{" . "runIndex" . "}", $this->apiClient->toQueryValue($runIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&runIndex={" . "runIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'RunResponse');
        return $responseObject;
    }

    /**
     * GetDocumentParagraphRunFont
     * This resource represents one of the paragraphs contained in the document.
     * name, string: The document name. (required)

     * index, int: Paragraph index (required)

     * runIndex, int: Run index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return FontResponse
     */
    public function GetDocumentParagraphRunFont($name, $index, $runIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $index == '' || $runIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($index != null) {
            $resourcePath = str_replace("{" . "index" . "}", $this->apiClient->toQueryValue($index), $resourcePath);
        } else {
            $resourcePath = str_replace("&index={" . "index" . "}", "", $resourcePath);
        }
        if ($runIndex != null) {
            $resourcePath = str_replace("{" . "runIndex" . "}", $this->apiClient->toQueryValue($runIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&runIndex={" . "runIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FontResponse');
        return $responseObject;
    }

    /**
     * GetDocumentParagraphs
     * Return a list of paragraphs that are contained in the document.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return ParagraphLinkCollectionResponse
     */
    public function GetDocumentParagraphs($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ParagraphLinkCollectionResponse');
        return $responseObject;
    }

    /**
     * PostDocumentParagraphRunFont
     * This resource represents one of the paragraphs contained in the document.
     * name, string: The document name. (required)

     * index, int: Paragraph index (required)

     * runIndex, int: Run index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * body, Font: Font dto object (required)

     * @return FontResponse
     */
    public function PostDocumentParagraphRunFont($name, $index, $runIndex, $storage = null, $folder = null, $filename = null, $body) {
        // verify required params are set
        if ($name == '' || $index == '' || $runIndex == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($index != null) {
            $resourcePath = str_replace("{" . "index" . "}", $this->apiClient->toQueryValue($index), $resourcePath);
        } else {
            $resourcePath = str_replace("&index={" . "index" . "}", "", $resourcePath);
        }
        if ($runIndex != null) {
            $resourcePath = str_replace("{" . "runIndex" . "}", $this->apiClient->toQueryValue($runIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&runIndex={" . "runIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'FontResponse');
        return $responseObject;
    }

    /**
     * AcceptAllRevisions
     * Accept all revisions in document
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return RevisionsModificationResponse
     */
    public function AcceptAllRevisions($name, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/revisions/acceptAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'RevisionsModificationResponse');
        return $responseObject;
    }

    /**
     * RejectAllRevisions
     * Reject all revisions in document
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return RevisionsModificationResponse
     */
    public function RejectAllRevisions($name, $filename = null, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/revisions/rejectAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'RevisionsModificationResponse');
        return $responseObject;
    }

    /**
     * DeleteSectionFields
     * Remove fields from section.
     * name, string: The file name. (required)

     * sectionIndex, int: Section index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteSectionFields($name, $sectionIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * DeleteSectionParagraphFields
     * Remove fields from section paragraph.
     * name, string: The file name. (required)

     * sectionIndex, int: Section index (required)

     * paragraphIndex, int: Paragraph index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SaaSposeResponse
     */
    public function DeleteSectionParagraphFields($name, $sectionIndex, $paragraphIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $paragraphIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "DELETE";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($paragraphIndex != null) {
            $resourcePath = str_replace("{" . "paragraphIndex" . "}", $this->apiClient->toQueryValue($paragraphIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&paragraphIndex={" . "paragraphIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SaaSposeResponse');
        return $responseObject;
    }

    /**
     * GetSection
     * Get document section by index.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SectionResponse
     */
    public function GetSection($name, $sectionIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SectionResponse');
        return $responseObject;
    }

    /**
     * GetSectionPageSetup
     * Get page setup of section.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SectionPageSetupResponse
     */
    public function GetSectionPageSetup($name, $sectionIndex, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SectionPageSetupResponse');
        return $responseObject;
    }

    /**
     * GetSections
     * Return a list of sections that are contained in the document.
     * name, string: The document name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * @return SectionLinkCollectionResponse
     */
    public function GetSections($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SectionLinkCollectionResponse');
        return $responseObject;
    }

    /**
     * UpdateSectionPageSetup
     * Update page setup of section.
     * name, string: The document name. (required)

     * sectionIndex, int: Section index (required)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

     * body, PageSetup: Page setup properties dto (required)

     * @return SectionPageSetupResponse
     */
    public function UpdateSectionPageSetup($name, $sectionIndex, $storage = null, $folder = null, $filename = null, $body) {
        // verify required params are set
        if ($name == '' || $sectionIndex == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($sectionIndex != null) {
            $resourcePath = str_replace("{" . "sectionIndex" . "}", $this->apiClient->toQueryValue($sectionIndex), $resourcePath);
        } else {
            $resourcePath = str_replace("&sectionIndex={" . "sectionIndex" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'SectionPageSetupResponse');
        return $responseObject;
    }

    /**
     * GetDocumentTextItems
     * Read document text items.
     * name, string: The document name. (required)

     * storage, string: Document's storage. (optional)

     * folder, string: Document's folder. (optional)

     * @return TextItemsResponse
     */
    public function GetDocumentTextItems($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/textItems/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'TextItemsResponse');
        return $responseObject;
    }

    /**
     * PostReplaceText
     * Replace document text.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, ReplaceTextRequest: with the replace operation settings. (required)

     * @return ReplaceTextResponse
     */
    public function PostReplaceText($name, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/replaceText/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ReplaceTextResponse');
        return $responseObject;
    }

    /**
     * PostInsertWatermarkImage
     * Insert document watermark image.
     * name, string: The document name. (required)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * rotationAngle, float: The watermark rotation angle. (optional)

     * image, string: The image file server full name. If the name is empty the image is expected in request content. (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * file, File:  (required)

     * @return DocumentResponse
     */
    public function PostInsertWatermarkImage($name, $filename = null, $rotationAngle = null, $image = null, $storage = null, $folder = null, $file) {
        // verify required params are set
        if ($name == '' || $file == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/insertWatermarkImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'multipart/form-data';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($image != null) {
            $resourcePath = str_replace("{" . "image" . "}", $this->apiClient->toQueryValue($image), $resourcePath);
        } else {
            $resourcePath = str_replace("&image={" . "image" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

    /**
     * PostInsertWatermarkText
     * Insert document watermark text.
     * name, string: The document name. (required)

     * text, string: The text to insert. (optional)

     * rotationAngle, float: The text rotation angle. (optional)

     * filename, string: Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

     * storage, string: The document storage. (optional)

     * folder, string: The document folder. (optional)

     * body, WatermarkText: with the watermark data.            If the parameter is provided the query string parameters are ignored. (required)

     * @return DocumentResponse
     */
    public function PostInsertWatermarkText($name, $text = null, $rotationAngle = null, $filename = null, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/words/{name}/insertWatermarkText/?appSid={appSid}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($text != null) {
            $resourcePath = str_replace("{" . "text" . "}", $this->apiClient->toQueryValue($text), $resourcePath);
        } else {
            $resourcePath = str_replace("&text={" . "text" . "}", "", $resourcePath);
        }
        if ($rotationAngle != null) {
            $resourcePath = str_replace("{" . "rotationAngle" . "}", $this->apiClient->toQueryValue($rotationAngle), $resourcePath);
        } else {
            $resourcePath = str_replace("&rotationAngle={" . "rotationAngle" . "}", "", $resourcePath);
        }
        if ($filename != null) {
            $resourcePath = str_replace("{" . "filename" . "}", $this->apiClient->toQueryValue($filename), $resourcePath);
        } else {
            $resourcePath = str_replace("&filename={" . "filename" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'DocumentResponse');
        return $responseObject;
    }

}
