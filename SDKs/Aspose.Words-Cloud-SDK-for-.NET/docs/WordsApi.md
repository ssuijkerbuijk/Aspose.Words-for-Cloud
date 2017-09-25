# IO.Swagger.Api.WordsApi

All URIs are relative to *http://localhost/WordsCloud*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptAllRevisions**](WordsApi.md#acceptallrevisions) | **POST** /v{version}/words/{name}/revisions/acceptAll | Accept all revisions in document
[**DeleteBorder**](WordsApi.md#deleteborder) | **DELETE** /v{version}/words/{name}/{nodePath}/borders/{index} | Resets border properties to default values.
[**DeleteBorders**](WordsApi.md#deleteborders) | **DELETE** /v{version}/words/{name}/{nodePath}/borders | Resets borders properties to default values.
[**DeleteComment**](WordsApi.md#deletecomment) | **DELETE** /v{version}/words/{name}/comments/{commentIndex} | Remove comment from document.
[**DeleteDocumentMacros**](WordsApi.md#deletedocumentmacros) | **DELETE** /v{version}/words/{name}/macros | Remove macros from document.
[**DeleteDocumentProperty**](WordsApi.md#deletedocumentproperty) | **DELETE** /v{version}/words/{name}/documentProperties/{propertyName} | Delete document property.
[**DeleteDocumentWatermark**](WordsApi.md#deletedocumentwatermark) | **DELETE** /v{version}/words/{name}/watermark | Delete watermark (for deleting last watermark from the document).
[**DeleteDrawingObject**](WordsApi.md#deletedrawingobject) | **DELETE** /v{version}/words/{name}/{nodePath}/drawingObjects/{index} | Removes drawing object from document.
[**DeleteField**](WordsApi.md#deletefield) | **DELETE** /v{version}/words/{name}/{nodePath}/fields/{index} | Delete field from document.
[**DeleteFields**](WordsApi.md#deletefields) | **DELETE** /v{version}/words/{name}/{nodePath}/fields | Remove fields from section paragraph.
[**DeleteFootnote**](WordsApi.md#deletefootnote) | **DELETE** /v{version}/words/{name}/{nodePath}/footnotes/{index} | Removes footnote from document.
[**DeleteFormField**](WordsApi.md#deleteformfield) | **DELETE** /v{version}/words/{name}/{nodePath}/formfields/{index} | Removes form field from document.
[**DeleteHeaderFooter**](WordsApi.md#deleteheaderfooter) | **DELETE** /v{version}/words/{name}/{sectionPath}/headersfooters/{index} | Delete header/footer from document.
[**DeleteHeadersFooters**](WordsApi.md#deleteheadersfooters) | **DELETE** /v{version}/words/{name}/{sectionPath}/headersfooters | Delete document headers and footers.
[**DeleteOfficeMathObject**](WordsApi.md#deleteofficemathobject) | **DELETE** /v{version}/words/{name}/{nodePath}/OfficeMathObjects/{index} | Removes OfficeMath object from document.
[**DeleteParagraph**](WordsApi.md#deleteparagraph) | **DELETE** /v{version}/words/{name}/{nodePath}/paragraphs/{index} | Remove paragraph from section.
[**DeleteRun**](WordsApi.md#deleterun) | **DELETE** /v{version}/words/{name}/{paragraphPath}/runs/{index} | Removes run from document.
[**DeleteTable**](WordsApi.md#deletetable) | **DELETE** /v{version}/words/{name}/{nodePath}/tables/{index} | Delete a table.
[**DeleteTableCell**](WordsApi.md#deletetablecell) | **DELETE** /v{version}/words/{name}/{tableRowPath}/cells/{index} | Delete a table cell.
[**DeleteTableRow**](WordsApi.md#deletetablerow) | **DELETE** /v{version}/words/{name}/{tablePath}/rows/{index} | Delete a table row.
[**DeleteUnprotectDocument**](WordsApi.md#deleteunprotectdocument) | **DELETE** /v{version}/words/{name}/protection | Unprotect document.
[**GetBorder**](WordsApi.md#getborder) | **GET** /v{version}/words/{name}/{nodePath}/borders/{index} | Return a border.
[**GetBorders**](WordsApi.md#getborders) | **GET** /v{version}/words/{name}/{nodePath}/borders | Return a collection of borders.
[**GetComment**](WordsApi.md#getcomment) | **GET** /v{version}/words/{name}/comments/{commentIndex} | Get comment from document.
[**GetComments**](WordsApi.md#getcomments) | **GET** /v{version}/words/{name}/comments | Get comments from document.
[**GetDocument**](WordsApi.md#getdocument) | **GET** /v{version}/words/{documentName} | Read document common info.
[**GetDocumentBookmarkByName**](WordsApi.md#getdocumentbookmarkbyname) | **GET** /v{version}/words/{name}/bookmarks/{bookmarkName} | Read document bookmark data by its name.
[**GetDocumentBookmarks**](WordsApi.md#getdocumentbookmarks) | **GET** /v{version}/words/{name}/bookmarks | Read document bookmarks common info.
[**GetDocumentDrawingObjectByIndex**](WordsApi.md#getdocumentdrawingobjectbyindex) | **GET** /v{version}/words/{name}/{nodePath}/drawingObjects/{index} | Read document drawing object common info by its index or convert to format specified.
[**GetDocumentDrawingObjectImageData**](WordsApi.md#getdocumentdrawingobjectimagedata) | **GET** /v{version}/words/{name}/{nodePath}/drawingObjects/{index}/imageData | Read drawing object image data.
[**GetDocumentDrawingObjectOleData**](WordsApi.md#getdocumentdrawingobjectoledata) | **GET** /v{version}/words/{name}/{nodePath}/drawingObjects/{index}/oleData | Get drawing object OLE data.
[**GetDocumentDrawingObjects**](WordsApi.md#getdocumentdrawingobjects) | **GET** /v{version}/words/{name}/{nodePath}/drawingObjects | Read document drawing objects common info.
[**GetDocumentFieldNames**](WordsApi.md#getdocumentfieldnames) | **GET** /v{version}/words/{name}/mailMergeFieldNames | Read document field names.
[**GetDocumentHyperlinkByIndex**](WordsApi.md#getdocumenthyperlinkbyindex) | **GET** /v{version}/words/{name}/hyperlinks/{hyperlinkIndex} | Read document hyperlink by its index.
[**GetDocumentHyperlinks**](WordsApi.md#getdocumenthyperlinks) | **GET** /v{version}/words/{name}/hyperlinks | Read document hyperlinks common info.
[**GetDocumentParagraph**](WordsApi.md#getdocumentparagraph) | **GET** /v{version}/words/{name}/{nodePath}/paragraphs/{index} | This resource represents one of the paragraphs contained in the document.
[**GetDocumentParagraphRun**](WordsApi.md#getdocumentparagraphrun) | **GET** /v{version}/words/{name}/{paragraphPath}/runs/{index} | This resource represents run of text contained in the document.
[**GetDocumentParagraphRunFont**](WordsApi.md#getdocumentparagraphrunfont) | **GET** /v{version}/words/{name}/{paragraphPath}/runs/{index}/font | This resource represents font of run.
[**GetDocumentParagraphRuns**](WordsApi.md#getdocumentparagraphruns) | **GET** /v{version}/words/{name}/{paragraphPath}/runs | This resource represents collection of runs in the paragraph.
[**GetDocumentParagraphs**](WordsApi.md#getdocumentparagraphs) | **GET** /v{version}/words/{name}/{nodePath}/paragraphs | Return a list of paragraphs that are contained in the document.
[**GetDocumentProperties**](WordsApi.md#getdocumentproperties) | **GET** /v{version}/words/{name}/documentProperties | Read document properties info.
[**GetDocumentProperty**](WordsApi.md#getdocumentproperty) | **GET** /v{version}/words/{name}/documentProperties/{propertyName} | Read document property info by the property name.
[**GetDocumentProtection**](WordsApi.md#getdocumentprotection) | **GET** /v{version}/words/{name}/protection | Read document protection common info.
[**GetDocumentStatistics**](WordsApi.md#getdocumentstatistics) | **GET** /v{version}/words/{name}/statistics | Read document statistics.
[**GetDocumentTextItems**](WordsApi.md#getdocumenttextitems) | **GET** /v{version}/words/{name}/textItems | Read document text items.
[**GetDocumentWithFormat**](WordsApi.md#getdocumentwithformat) | **GET** /v{version}/words/{name} | Export the document into the specified format.
[**GetField**](WordsApi.md#getfield) | **GET** /v{version}/words/{name}/{nodePath}/fields/{index} | Get field from document.
[**GetFields**](WordsApi.md#getfields) | **GET** /v{version}/words/{name}/{nodePath}/fields | Get fields from document.
[**GetFootnote**](WordsApi.md#getfootnote) | **GET** /v{version}/words/{name}/{nodePath}/footnotes/{index} | Read footnote by index.
[**GetFootnotes**](WordsApi.md#getfootnotes) | **GET** /v{version}/words/{name}/{nodePath}/footnotes | Get footnotes from document.
[**GetFormField**](WordsApi.md#getformfield) | **GET** /v{version}/words/{name}/{nodePath}/formfields/{index} | Returns representation of an one of the form field.
[**GetFormFields**](WordsApi.md#getformfields) | **GET** /v{version}/words/{name}/{nodePath}/formfields | Get form fields from document.
[**GetHeaderFooter**](WordsApi.md#getheaderfooter) | **GET** /v{version}/words/{name}/headersfooters/{headerFooterIndex} | Return a header/footer that is contained in the document.
[**GetHeaderFooter_0**](WordsApi.md#getheaderfooter_0) | **GET** /v{version}/words/{name}/sections/{sectionIndex}/headersfooters/{headerFooterIndex} | Return a header/footer that is contained in the document.
[**GetHeaderFooters**](WordsApi.md#getheaderfooters) | **GET** /v{version}/words/{name}/{sectionPath}/headersfooters | Return a list of header/footers that are contained in the document.
[**GetOfficeMathObject**](WordsApi.md#getofficemathobject) | **GET** /v{version}/words/{name}/{nodePath}/OfficeMathObjects/{index} | Read OfficeMath object by index.
[**GetOfficeMathObjects**](WordsApi.md#getofficemathobjects) | **GET** /v{version}/words/{name}/{nodePath}/OfficeMathObjects | Get OfficeMath objects from document.
[**GetSection**](WordsApi.md#getsection) | **GET** /v{version}/words/{name}/sections/{sectionIndex} | Get document section by index.
[**GetSectionPageSetup**](WordsApi.md#getsectionpagesetup) | **GET** /v{version}/words/{name}/sections/{sectionIndex}/pageSetup | Get page setup of section.
[**GetSections**](WordsApi.md#getsections) | **GET** /v{version}/words/{name}/sections | Return a list of sections that are contained in the document.
[**GetTable**](WordsApi.md#gettable) | **GET** /v{version}/words/{name}/{nodePath}/tables/{index} | Return a table.
[**GetTableCell**](WordsApi.md#gettablecell) | **GET** /v{version}/words/{name}/{tableRowPath}/cells/{index} | Return a table cell.
[**GetTableCellFormat**](WordsApi.md#gettablecellformat) | **GET** /v{version}/words/{name}/{tableRowPath}/cells/{index}/cellformat | Return a table cell format.
[**GetTableProperties**](WordsApi.md#gettableproperties) | **GET** /v{version}/words/{name}/{nodePath}/tables/{index}/properties | Return a table properties.
[**GetTableRow**](WordsApi.md#gettablerow) | **GET** /v{version}/words/{name}/{tablePath}/rows/{index} | Return a table row.
[**GetTableRowFormat**](WordsApi.md#gettablerowformat) | **GET** /v{version}/words/{name}/{tablePath}/rows/{index}/rowformat | Return a table row format.
[**GetTables**](WordsApi.md#gettables) | **GET** /v{version}/words/{name}/{nodePath}/tables | Return a list of tables that are contained in the document.
[**InsertTable**](WordsApi.md#inserttable) | **PUT** /v{version}/words/{name}/{nodePath}/tables | Adds table to document, returns added table&#39;s data.
[**InsertTableCell**](WordsApi.md#inserttablecell) | **PUT** /v{version}/words/{name}/{tableRowPath}/cells | Adds table cell to table, returns added cell&#39;s data.
[**InsertTableRow**](WordsApi.md#inserttablerow) | **PUT** /v{version}/words/{name}/{tablePath}/rows | Adds table row to table, returns added row&#39;s data.
[**PostAppendDocument**](WordsApi.md#postappenddocument) | **POST** /v{version}/words/{name}/appendDocument | Append documents to original document.
[**PostChangeDocumentProtection**](WordsApi.md#postchangedocumentprotection) | **POST** /v{version}/words/{name}/protection | Change document protection.
[**PostComment**](WordsApi.md#postcomment) | **POST** /v{version}/words/{name}/comments/{commentIndex} | Updates the comment, returns updated comment&#39;s data.
[**PostCompareDocument**](WordsApi.md#postcomparedocument) | **POST** /v{version}/words/{name}/compareDocument | Compare document with original document.
[**PostDocumentExecuteMailMerge**](WordsApi.md#postdocumentexecutemailmerge) | **POST** /v{version}/words/{name}/executeMailMerge/{withRegions} | Execute document mail merge operation.
[**PostDocumentParagraphRunFont**](WordsApi.md#postdocumentparagraphrunfont) | **POST** /v{version}/words/{name}/{paragraphPath}/runs/{index}/font | Updates font properties, returns updated font data.
[**PostDocumentSaveAs**](WordsApi.md#postdocumentsaveas) | **POST** /v{version}/words/{name}/saveAs | Convert document to destination format with detailed settings and save result to storage.
[**PostDrawingObject**](WordsApi.md#postdrawingobject) | **POST** /v{version}/words/{name}/{nodePath}/drawingObjects/{index} | Updates drawing object, returns updated  drawing object&#39;s data.
[**PostExecuteTemplate**](WordsApi.md#postexecutetemplate) | **POST** /v{version}/words/{name}/executeTemplate | Populate document template with data.
[**PostField**](WordsApi.md#postfield) | **POST** /v{version}/words/{name}/{nodePath}/fields/{index} | Updates field&#39;s properties, returns updated field&#39;s data.
[**PostFootnote**](WordsApi.md#postfootnote) | **POST** /v{version}/words/{name}/{nodePath}/footnotes/{index} | Updates footnote&#39;s properties, returns updated run&#39;s data.
[**PostFormField**](WordsApi.md#postformfield) | **POST** /v{version}/words/{name}/{nodePath}/formfields/{index} | Updates properties of form field, returns updated form field.
[**PostInsertDocumentWatermarkImage**](WordsApi.md#postinsertdocumentwatermarkimage) | **POST** /v{version}/words/{name}/watermark/insertImage | Insert document watermark image.
[**PostInsertDocumentWatermarkText**](WordsApi.md#postinsertdocumentwatermarktext) | **POST** /v{version}/words/{name}/watermark/insertText | Insert document watermark text.
[**PostInsertPageNumbers**](WordsApi.md#postinsertpagenumbers) | **POST** /v{version}/words/{name}/insertPageNumbers | Insert document page numbers.
[**PostLoadWebDocument**](WordsApi.md#postloadwebdocument) | **POST** /v{version}/words/loadWebDocument | Loads new document from web into the file with any supported format of data.
[**PostReplaceText**](WordsApi.md#postreplacetext) | **POST** /v{version}/words/{name}/replaceText | Replace document text.
[**PostRun**](WordsApi.md#postrun) | **POST** /v{version}/words/{name}/{paragraphPath}/runs/{index} | Updates run&#39;s properties, returns updated run&#39;s data.
[**PostRunTask**](WordsApi.md#postruntask) | **POST** /v{version}/words/tasks | Run tasks
[**PostSplitDocument**](WordsApi.md#postsplitdocument) | **POST** /v{version}/words/{name}/split | Split document.
[**PostUpdateDocumentBookmark**](WordsApi.md#postupdatedocumentbookmark) | **POST** /v{version}/words/{name}/bookmarks/{bookmarkName} | Update document bookmark.
[**PostUpdateDocumentFields**](WordsApi.md#postupdatedocumentfields) | **POST** /v{version}/words/{name}/updateFields | Update (reevaluate) fields in document.
[**PutComment**](WordsApi.md#putcomment) | **PUT** /v{version}/words/{name}/comments | Adds comment to document, returns inserted comment&#39;s data.
[**PutConvertDocument**](WordsApi.md#putconvertdocument) | **PUT** /v{version}/words/convert | Convert document from request content to format specified.
[**PutCreateDocument**](WordsApi.md#putcreatedocument) | **PUT** /v{version}/words/create | Creates new document.  Document is created with format which is recognized from file extensions.   Supported extentions: \&quot;.doc\&quot;, \&quot;.docx\&quot;, \&quot;.docm\&quot;, \&quot;.dot\&quot;, \&quot;.dotm\&quot;, \&quot;.dotx\&quot;, \&quot;.flatopc\&quot;, \&quot;.fopc\&quot;, \&quot;.flatopc_macro\&quot;, \&quot;.fopc_macro\&quot;, \&quot;.flatopc_template\&quot;, \&quot;.fopc_template\&quot;, \&quot;.flatopc_template_macro\&quot;, \&quot;.fopc_template_macro\&quot;, \&quot;.wordml\&quot;, \&quot;.wml\&quot;, \&quot;.rtf\&quot;
[**PutDocumentFieldNames**](WordsApi.md#putdocumentfieldnames) | **PUT** /v{version}/words/mailMergeFieldNames | Read document field names.
[**PutDocumentSaveAsTiff**](WordsApi.md#putdocumentsaveastiff) | **PUT** /v{version}/words/{name}/saveAs/tiff | Convert document to tiff with detailed settings and save result to storage.
[**PutDrawingObject**](WordsApi.md#putdrawingobject) | **PUT** /v{version}/words/{name}/{nodePath}/drawingObjects | Adds  drawing object to document, returns added  drawing object&#39;s data.
[**PutExecuteMailMergeOnline**](WordsApi.md#putexecutemailmergeonline) | **PUT** /v{version}/words/executeMailMerge | Execute document mail merge online.
[**PutExecuteTemplateOnline**](WordsApi.md#putexecutetemplateonline) | **PUT** /v{version}/words/executeTemplate | Populate document template with data online.
[**PutField**](WordsApi.md#putfield) | **PUT** /v{version}/words/{name}/{nodePath}/fields | Adds field to document, returns inserted field&#39;s data.
[**PutFootnote**](WordsApi.md#putfootnote) | **PUT** /v{version}/words/{name}/{nodePath}/footnotes | Adds footnote to document, returns added footnote&#39;s data.
[**PutFormField**](WordsApi.md#putformfield) | **PUT** /v{version}/words/{name}/{nodePath}/formfields | Adds form field to paragraph, returns added form field&#39;s data.
[**PutHeaderFooter**](WordsApi.md#putheaderfooter) | **PUT** /v{version}/words/{name}/{sectionPath}/headersfooters | Insert to document header or footer.
[**PutParagraph**](WordsApi.md#putparagraph) | **PUT** /v{version}/words/{name}/{nodePath}/paragraphs | Adds paragraph to document, returns added paragraph&#39;s data.
[**PutProtectDocument**](WordsApi.md#putprotectdocument) | **PUT** /v{version}/words/{name}/protection | Protect document.
[**PutRun**](WordsApi.md#putrun) | **PUT** /v{version}/words/{name}/{paragraphPath}/runs | Adds run to document, returns added paragraph&#39;s data.
[**PutUpdateDocumentProperty**](WordsApi.md#putupdatedocumentproperty) | **PUT** /v{version}/words/{name}/documentProperties/{propertyName} | Add new or update existing document property.
[**PutUpdateDocumentProperty_0**](WordsApi.md#putupdatedocumentproperty_0) | **POST** /v{version}/words/{name}/documentProperties/{propertyName} | Add new or update existing document property.
[**RejectAllRevisions**](WordsApi.md#rejectallrevisions) | **POST** /v{version}/words/{name}/revisions/rejectAll | Reject all revisions in document
[**RenderDrawingObject**](WordsApi.md#renderdrawingobject) | **GET** /v{version}/words/{name}/{nodePath}/drawingObjects/{index}/render | Renders drawing object to specified format.
[**RenderMathObject**](WordsApi.md#rendermathobject) | **GET** /v{version}/words/{name}/{nodePath}/OfficeMathObjects/{index}/render | Renders math object to specified format.
[**RenderPage**](WordsApi.md#renderpage) | **GET** /v{version}/words/{name}/pages/{pageIndex}/render | Renders page to specified format.
[**RenderParagraph**](WordsApi.md#renderparagraph) | **GET** /v{version}/words/{name}/{nodePath}/paragraphs/{index}/render | Renders paragraph to specified format.
[**RenderTable**](WordsApi.md#rendertable) | **GET** /v{version}/words/{name}/{nodePath}/tables/{index}/render | Renders table to specified format.
[**ResetCache**](WordsApi.md#resetcache) | **DELETE** /v{version}/words/fonts/cache | Resets font&#39;s cache.
[**Search**](WordsApi.md#search) | **GET** /v{version}/words/{name}/search | Search text in document.
[**UpdateBorder**](WordsApi.md#updateborder) | **POST** /v{version}/words/{name}/{nodePath}/borders/{index} | Updates border properties.
[**UpdateSectionPageSetup**](WordsApi.md#updatesectionpagesetup) | **POST** /v{version}/words/{name}/sections/{sectionIndex}/pageSetup | Update page setup of section.
[**UpdateTableCellFormat**](WordsApi.md#updatetablecellformat) | **POST** /v{version}/words/{name}/{tableRowPath}/cells/{index}/cellformat | Updates a table cell format.
[**UpdateTableProperties**](WordsApi.md#updatetableproperties) | **POST** /v{version}/words/{name}/{nodePath}/tables/{index}/properties | Updates a table properties.
[**UpdateTableRowFormat**](WordsApi.md#updatetablerowformat) | **POST** /v{version}/words/{name}/{tablePath}/rows/{index}/rowformat | Updates a table row format.


<a name="acceptallrevisions"></a>
# **AcceptAllRevisions**
> AsposeWordsCloudDTORevisionsModificationResponse AcceptAllRevisions (string version, string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Accept all revisions in document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class AcceptAllRevisionsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Accept all revisions in document
                AsposeWordsCloudDTORevisionsModificationResponse result = apiInstance.AcceptAllRevisions(version, name, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.AcceptAllRevisions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTORevisionsModificationResponse**](AsposeWordsCloudDTORevisionsModificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteborder"></a>
# **DeleteBorder**
> AsposeWordsCloudDTODocumentElementsCommonBorderResponse DeleteBorder (string version, string name, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Resets border properties to default values.

'nodePath' should refer to node with cell or row

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteBorderExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node with border(node should be cell or row).
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Resets border properties to default values.
                AsposeWordsCloudDTODocumentElementsCommonBorderResponse result = apiInstance.DeleteBorder(version, name, nodePath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteBorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node with border(node should be cell or row). | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommonBorderResponse**](AsposeWordsCloudDTODocumentElementsCommonBorderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteborders"></a>
# **DeleteBorders**
> AsposeWordsCloudDTODocumentElementsCommonBordersResponse DeleteBorders (string version, string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Resets borders properties to default values.

'nodePath' should refer to node with cell or row

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteBordersExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node with borders(node should be cell or row).
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Resets borders properties to default values.
                AsposeWordsCloudDTODocumentElementsCommonBordersResponse result = apiInstance.DeleteBorders(version, name, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteBorders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node with borders(node should be cell or row). | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommonBordersResponse**](AsposeWordsCloudDTODocumentElementsCommonBordersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecomment"></a>
# **DeleteComment**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteComment (string version, string name, int? commentIndex, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Remove comment from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteCommentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var commentIndex = 56;  // int? | Comment index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Remove comment from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteComment(version, name, commentIndex, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **commentIndex** | **int?**| Comment index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentmacros"></a>
# **DeleteDocumentMacros**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteDocumentMacros (string version, string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Remove macros from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteDocumentMacrosExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Remove macros from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteDocumentMacros(version, name, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteDocumentMacros: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentproperty"></a>
# **DeleteDocumentProperty**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteDocumentProperty (string version, string name, string propertyName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete document property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete document property.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteDocumentProperty(version, name, propertyName, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentwatermark"></a>
# **DeleteDocumentWatermark**
> AsposeWordsCloudDTODocumentResponse DeleteDocumentWatermark (string version, string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete watermark (for deleting last watermark from the document).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteDocumentWatermarkExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete watermark (for deleting last watermark from the document).
                AsposeWordsCloudDTODocumentResponse result = apiInstance.DeleteDocumentWatermark(version, name, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteDocumentWatermark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedrawingobject"></a>
# **DeleteDrawingObject**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteDrawingObject (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Removes drawing object from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteDrawingObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Removes drawing object from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteDrawingObject(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteDrawingObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefield"></a>
# **DeleteField**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteField (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete field from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete field from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteField(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefields"></a>
# **DeleteFields**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteFields (string version, string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Remove fields from section paragraph.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteFieldsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Remove fields from section paragraph.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteFields(version, name, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefootnote"></a>
# **DeleteFootnote**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteFootnote (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Removes footnote from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteFootnoteExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of footnotes.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Removes footnote from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteFootnote(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteFootnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of footnotes. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteformfield"></a>
# **DeleteFormField**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteFormField (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Removes form field from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteFormFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node that contains collection of formfields.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Removes form field from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteFormField(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteFormField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node that contains collection of formfields. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteheaderfooter"></a>
# **DeleteHeaderFooter**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteHeaderFooter (string version, string name, int? index, string sectionPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete header/footer from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteHeaderFooterExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var sectionPath = sectionPath_example;  // string | Path to parent section.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete header/footer from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteHeaderFooter(version, name, index, sectionPath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteHeaderFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **sectionPath** | **string**| Path to parent section. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteheadersfooters"></a>
# **DeleteHeadersFooters**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteHeadersFooters (string version, string name, string sectionPath, string headersFootersTypes = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete document headers and footers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteHeadersFootersExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var sectionPath = sectionPath_example;  // string | Path to parent section.
            var headersFootersTypes = headersFootersTypes_example;  // string | List of types of headers and footers. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete document headers and footers.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteHeadersFooters(version, name, sectionPath, headersFootersTypes, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteHeadersFooters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **sectionPath** | **string**| Path to parent section. | 
 **headersFootersTypes** | **string**| List of types of headers and footers. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteofficemathobject"></a>
# **DeleteOfficeMathObject**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteOfficeMathObject (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Removes OfficeMath object from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteOfficeMathObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of OfficeMath objects.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Removes OfficeMath object from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteOfficeMathObject(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteOfficeMathObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of OfficeMath objects. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteparagraph"></a>
# **DeleteParagraph**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteParagraph (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Remove paragraph from section.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteParagraphExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node which contains paragraphs.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Remove paragraph from section.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteParagraph(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteParagraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node which contains paragraphs. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterun"></a>
# **DeleteRun**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteRun (string version, string name, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Removes run from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteRunExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Removes run from document.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteRun(version, name, paragraphPath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetable"></a>
# **DeleteTable**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteTable (string version, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete a table.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteTableExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete a table.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteTable(version, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetablecell"></a>
# **DeleteTableCell**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteTableCell (string version, string name, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete a table cell.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteTableCellExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tableRowPath = tableRowPath_example;  // string | Path to table row.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete a table cell.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteTableCell(version, name, tableRowPath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteTableCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tableRowPath** | **string**| Path to table row. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetablerow"></a>
# **DeleteTableRow**
> AsposeWordsCloudDTOCommonSaaSposeResponse DeleteTableRow (string version, string name, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Delete a table row.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteTableRowExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tablePath = tablePath_example;  // string | Path to table.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Delete a table row.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.DeleteTableRow(version, name, tablePath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteTableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tablePath** | **string**| Path to table. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteunprotectdocument"></a>
# **DeleteUnprotectDocument**
> AsposeWordsCloudDTOProtectionDataResponse DeleteUnprotectDocument (string version, string name, AsposeWordsCloudDTOProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Unprotect document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class DeleteUnprotectDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var protectionRequest = new AsposeWordsCloudDTOProtectionRequest(); // AsposeWordsCloudDTOProtectionRequest | {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Unprotect document.
                AsposeWordsCloudDTOProtectionDataResponse result = apiInstance.DeleteUnprotectDocument(version, name, protectionRequest, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.DeleteUnprotectDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **protectionRequest** | [**AsposeWordsCloudDTOProtectionRequest**](AsposeWordsCloudDTOProtectionRequest.md)| {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOProtectionDataResponse**](AsposeWordsCloudDTOProtectionDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getborder"></a>
# **GetBorder**
> AsposeWordsCloudDTODocumentElementsCommonBorderResponse GetBorder (string version, string name, string nodePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a border.

'nodePath' should refer to node with cell or row

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetBorderExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node with border(node should be cell or row).
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a border.
                AsposeWordsCloudDTODocumentElementsCommonBorderResponse result = apiInstance.GetBorder(version, name, nodePath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetBorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node with border(node should be cell or row). | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommonBorderResponse**](AsposeWordsCloudDTODocumentElementsCommonBorderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getborders"></a>
# **GetBorders**
> AsposeWordsCloudDTODocumentElementsCommonBordersResponse GetBorders (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a collection of borders.

'nodePath' should refer to node with cell or row

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetBordersExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node with borders(node should be cell or row).
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a collection of borders.
                AsposeWordsCloudDTODocumentElementsCommonBordersResponse result = apiInstance.GetBorders(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetBorders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node with borders(node should be cell or row). | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommonBordersResponse**](AsposeWordsCloudDTODocumentElementsCommonBordersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomment"></a>
# **GetComment**
> AsposeWordsCloudDTODocumentElementsCommentsCommentResponse GetComment (string version, string name, int? commentIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get comment from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetCommentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var commentIndex = 56;  // int? | Comment index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get comment from document.
                AsposeWordsCloudDTODocumentElementsCommentsCommentResponse result = apiInstance.GetComment(version, name, commentIndex, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **commentIndex** | **int?**| Comment index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommentsCommentResponse**](AsposeWordsCloudDTODocumentElementsCommentsCommentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomments"></a>
# **GetComments**
> AsposeWordsCloudDTODocumentElementsCommentsCommentsResponse GetComments (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get comments from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetCommentsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get comments from document.
                AsposeWordsCloudDTODocumentElementsCommentsCommentsResponse result = apiInstance.GetComments(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommentsCommentsResponse**](AsposeWordsCloudDTODocumentElementsCommentsCommentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> AsposeWordsCloudDTODocumentResponse GetDocument (string version, string documentName, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document common info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var documentName = documentName_example;  // string | The file name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document common info.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.GetDocument(version, documentName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **documentName** | **string**| The file name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentbookmarkbyname"></a>
# **GetDocumentBookmarkByName**
> AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse GetDocumentBookmarkByName (string version, string name, string bookmarkName, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document bookmark data by its name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentBookmarkByNameExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var bookmarkName = bookmarkName_example;  // string | The bookmark name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document bookmark data by its name.
                AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse result = apiInstance.GetDocumentBookmarkByName(version, name, bookmarkName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentBookmarkByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **bookmarkName** | **string**| The bookmark name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse**](AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentbookmarks"></a>
# **GetDocumentBookmarks**
> AsposeWordsCloudDTODocumentElementsBookmarksBookmarksResponse GetDocumentBookmarks (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document bookmarks common info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentBookmarksExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document bookmarks common info.
                AsposeWordsCloudDTODocumentElementsBookmarksBookmarksResponse result = apiInstance.GetDocumentBookmarks(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentBookmarks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsBookmarksBookmarksResponse**](AsposeWordsCloudDTODocumentElementsBookmarksBookmarksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentdrawingobjectbyindex"></a>
# **GetDocumentDrawingObjectByIndex**
> AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse GetDocumentDrawingObjectByIndex (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document drawing object common info by its index or convert to format specified.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentDrawingObjectByIndexExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document drawing object common info by its index or convert to format specified.
                AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse result = apiInstance.GetDocumentDrawingObjectByIndex(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentDrawingObjectByIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse**](AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentdrawingobjectimagedata"></a>
# **GetDocumentDrawingObjectImageData**
> System.IO.Stream GetDocumentDrawingObjectImageData (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read drawing object image data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentDrawingObjectImageDataExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read drawing object image data.
                System.IO.Stream result = apiInstance.GetDocumentDrawingObjectImageData(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentDrawingObjectImageData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentdrawingobjectoledata"></a>
# **GetDocumentDrawingObjectOleData**
> System.IO.Stream GetDocumentDrawingObjectOleData (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get drawing object OLE data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentDrawingObjectOleDataExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get drawing object OLE data.
                System.IO.Stream result = apiInstance.GetDocumentDrawingObjectOleData(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentDrawingObjectOleData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentdrawingobjects"></a>
# **GetDocumentDrawingObjects**
> AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectsResponse GetDocumentDrawingObjects (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document drawing objects common info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentDrawingObjectsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document drawing objects common info.
                AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectsResponse result = apiInstance.GetDocumentDrawingObjects(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentDrawingObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectsResponse**](AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentfieldnames"></a>
# **GetDocumentFieldNames**
> AsposeWordsCloudDTOFieldNamesResponse GetDocumentFieldNames (string version, string name, bool? useNonMergeFields = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document field names.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentFieldNamesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var useNonMergeFields = true;  // bool? | If true, result includes \"mustache\" field names. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document field names.
                AsposeWordsCloudDTOFieldNamesResponse result = apiInstance.GetDocumentFieldNames(version, name, useNonMergeFields, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentFieldNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **useNonMergeFields** | **bool?**| If true, result includes \&quot;mustache\&quot; field names. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOFieldNamesResponse**](AsposeWordsCloudDTOFieldNamesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenthyperlinkbyindex"></a>
# **GetDocumentHyperlinkByIndex**
> AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinkResponse GetDocumentHyperlinkByIndex (string version, string name, int? hyperlinkIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document hyperlink by its index.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentHyperlinkByIndexExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var hyperlinkIndex = 56;  // int? | The hyperlink index.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document hyperlink by its index.
                AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinkResponse result = apiInstance.GetDocumentHyperlinkByIndex(version, name, hyperlinkIndex, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentHyperlinkByIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **hyperlinkIndex** | **int?**| The hyperlink index. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinkResponse**](AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenthyperlinks"></a>
# **GetDocumentHyperlinks**
> AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinksResponse GetDocumentHyperlinks (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document hyperlinks common info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentHyperlinksExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document hyperlinks common info.
                AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinksResponse result = apiInstance.GetDocumentHyperlinks(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentHyperlinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinksResponse**](AsposeWordsCloudDTODocumentElementsHyperlinksHyperlinksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentparagraph"></a>
# **GetDocumentParagraph**
> AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse GetDocumentParagraph (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

This resource represents one of the paragraphs contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentParagraphExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node which contains paragraphs.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // This resource represents one of the paragraphs contained in the document.
                AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse result = apiInstance.GetDocumentParagraph(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentParagraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node which contains paragraphs. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse**](AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentparagraphrun"></a>
# **GetDocumentParagraphRun**
> AsposeWordsCloudDTODocumentElementsRunsRunResponse GetDocumentParagraphRun (string version, string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

This resource represents run of text contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentParagraphRunExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // This resource represents run of text contained in the document.
                AsposeWordsCloudDTODocumentElementsRunsRunResponse result = apiInstance.GetDocumentParagraphRun(version, name, paragraphPath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentParagraphRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsRunsRunResponse**](AsposeWordsCloudDTODocumentElementsRunsRunResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentparagraphrunfont"></a>
# **GetDocumentParagraphRunFont**
> AsposeWordsCloudDTODocumentElementsFontElementFontResponse GetDocumentParagraphRunFont (string version, string name, string paragraphPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

This resource represents font of run.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentParagraphRunFontExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // This resource represents font of run.
                AsposeWordsCloudDTODocumentElementsFontElementFontResponse result = apiInstance.GetDocumentParagraphRunFont(version, name, paragraphPath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentParagraphRunFont: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFontElementFontResponse**](AsposeWordsCloudDTODocumentElementsFontElementFontResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentparagraphruns"></a>
# **GetDocumentParagraphRuns**
> AsposeWordsCloudDTODocumentElementsRunsRunsResponse GetDocumentParagraphRuns (string version, string name, string paragraphPath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

This resource represents collection of runs in the paragraph.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentParagraphRunsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // This resource represents collection of runs in the paragraph.
                AsposeWordsCloudDTODocumentElementsRunsRunsResponse result = apiInstance.GetDocumentParagraphRuns(version, name, paragraphPath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentParagraphRuns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsRunsRunsResponse**](AsposeWordsCloudDTODocumentElementsRunsRunsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentparagraphs"></a>
# **GetDocumentParagraphs**
> AsposeWordsCloudDTODocumentElementsParagraphsParagraphLinkCollectionResponse GetDocumentParagraphs (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a list of paragraphs that are contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentParagraphsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node which contains paragraphs.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a list of paragraphs that are contained in the document.
                AsposeWordsCloudDTODocumentElementsParagraphsParagraphLinkCollectionResponse result = apiInstance.GetDocumentParagraphs(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentParagraphs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node which contains paragraphs. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsParagraphsParagraphLinkCollectionResponse**](AsposeWordsCloudDTODocumentElementsParagraphsParagraphLinkCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperties"></a>
# **GetDocumentProperties**
> AsposeWordsCloudDTODocumentPropertiesResponse GetDocumentProperties (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document properties info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document's name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document properties info.
                AsposeWordsCloudDTODocumentPropertiesResponse result = apiInstance.GetDocumentProperties(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document&#39;s name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentPropertiesResponse**](AsposeWordsCloudDTODocumentPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentproperty"></a>
# **GetDocumentProperty**
> AsposeWordsCloudDTODocumentPropertyResponse GetDocumentProperty (string version, string name, string propertyName, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document property info by the property name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document property info by the property name.
                AsposeWordsCloudDTODocumentPropertyResponse result = apiInstance.GetDocumentProperty(version, name, propertyName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentPropertyResponse**](AsposeWordsCloudDTODocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentprotection"></a>
# **GetDocumentProtection**
> AsposeWordsCloudDTOProtectionDataResponse GetDocumentProtection (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document protection common info.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentProtectionExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document protection common info.
                AsposeWordsCloudDTOProtectionDataResponse result = apiInstance.GetDocumentProtection(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentProtection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOProtectionDataResponse**](AsposeWordsCloudDTOProtectionDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentstatistics"></a>
# **GetDocumentStatistics**
> AsposeWordsCloudDTOStatDataResponse GetDocumentStatistics (string version, string name, bool? includeComments = null, bool? includeFootnotes = null, bool? includeTextInShapes = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document statistics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentStatisticsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var includeComments = true;  // bool? | Support including/excluding comments from the WordCount. Default value is \"true\". (optional) 
            var includeFootnotes = true;  // bool? | Support including/excluding footnotes from the WordCount. Default value is \"false\". (optional) 
            var includeTextInShapes = true;  // bool? | Support including/excluding shape's text from the WordCount. Default value is \"false\" (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document statistics.
                AsposeWordsCloudDTOStatDataResponse result = apiInstance.GetDocumentStatistics(version, name, includeComments, includeFootnotes, includeTextInShapes, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **includeComments** | **bool?**| Support including/excluding comments from the WordCount. Default value is \&quot;true\&quot;. | [optional] 
 **includeFootnotes** | **bool?**| Support including/excluding footnotes from the WordCount. Default value is \&quot;false\&quot;. | [optional] 
 **includeTextInShapes** | **bool?**| Support including/excluding shape&#39;s text from the WordCount. Default value is \&quot;false\&quot; | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOStatDataResponse**](AsposeWordsCloudDTOStatDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenttextitems"></a>
# **GetDocumentTextItems**
> AsposeWordsCloudDTOTextItemsResponse GetDocumentTextItems (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read document text items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentTextItemsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read document text items.
                AsposeWordsCloudDTOTextItemsResponse result = apiInstance.GetDocumentTextItems(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentTextItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOTextItemsResponse**](AsposeWordsCloudDTOTextItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentwithformat"></a>
# **GetDocumentWithFormat**
> System.IO.Stream GetDocumentWithFormat (string version, string name, string format, string outPath = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Export the document into the specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetDocumentWithFormatExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var format = format_example;  // string | The destination format.
            var outPath = outPath_example;  // string | Path to save result (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Export the document into the specified format.
                System.IO.Stream result = apiInstance.GetDocumentWithFormat(version, name, format, outPath, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetDocumentWithFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **format** | **string**| The destination format. | 
 **outPath** | **string**| Path to save result | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfield"></a>
# **GetField**
> AsposeWordsCloudDTODocumentElementsFieldsFieldResponse GetField (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get field from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get field from document.
                AsposeWordsCloudDTODocumentElementsFieldsFieldResponse result = apiInstance.GetField(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFieldsFieldResponse**](AsposeWordsCloudDTODocumentElementsFieldsFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfields"></a>
# **GetFields**
> AsposeWordsCloudDTODocumentElementsFieldsFieldsResponse GetFields (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get fields from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFieldsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get fields from document.
                AsposeWordsCloudDTODocumentElementsFieldsFieldsResponse result = apiInstance.GetFields(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFieldsFieldsResponse**](AsposeWordsCloudDTODocumentElementsFieldsFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfootnote"></a>
# **GetFootnote**
> AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse GetFootnote (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read footnote by index.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFootnoteExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of footnotes.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read footnote by index.
                AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse result = apiInstance.GetFootnote(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetFootnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of footnotes. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse**](AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfootnotes"></a>
# **GetFootnotes**
> AsposeWordsCloudDTODocumentElementsFootnotesFootnotesResponse GetFootnotes (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get footnotes from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFootnotesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of footnotes.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get footnotes from document.
                AsposeWordsCloudDTODocumentElementsFootnotesFootnotesResponse result = apiInstance.GetFootnotes(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetFootnotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **nodePath** | **string**| Path to node, which contains collection of footnotes. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFootnotesFootnotesResponse**](AsposeWordsCloudDTODocumentElementsFootnotesFootnotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformfield"></a>
# **GetFormField**
> AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse GetFormField (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Returns representation of an one of the form field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFormFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node that contains collection of formfields.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Returns representation of an one of the form field.
                AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse result = apiInstance.GetFormField(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetFormField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node that contains collection of formfields. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse**](AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformfields"></a>
# **GetFormFields**
> AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldsResponse GetFormFields (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get form fields from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetFormFieldsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var nodePath = nodePath_example;  // string | Path to node containing collection of form fields.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get form fields from document.
                AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldsResponse result = apiInstance.GetFormFields(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetFormFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **nodePath** | **string**| Path to node containing collection of form fields. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldsResponse**](AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheaderfooter"></a>
# **GetHeaderFooter**
> AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse GetHeaderFooter (string version, string name, int? headerFooterIndex, int? sectionIndex = null, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a header/footer that is contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetHeaderFooterExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var headerFooterIndex = 56;  // int? | Header/footer index.
            var sectionIndex = 56;  // int? | Section index. (optional) 
            var filterByType = filterByType_example;  // string | List of types of headers and footers. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a header/footer that is contained in the document.
                AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse result = apiInstance.GetHeaderFooter(version, name, headerFooterIndex, sectionIndex, filterByType, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetHeaderFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **headerFooterIndex** | **int?**| Header/footer index. | 
 **sectionIndex** | **int?**| Section index. | [optional] 
 **filterByType** | **string**| List of types of headers and footers. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse**](AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheaderfooter_0"></a>
# **GetHeaderFooter_0**
> AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse GetHeaderFooter_0 (string version, string name, int? headerFooterIndex, int? sectionIndex, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a header/footer that is contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetHeaderFooter_0Example
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var headerFooterIndex = 56;  // int? | Header/footer index.
            var sectionIndex = 56;  // int? | Section index.
            var filterByType = filterByType_example;  // string | List of types of headers and footers. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a header/footer that is contained in the document.
                AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse result = apiInstance.GetHeaderFooter_0(version, name, headerFooterIndex, sectionIndex, filterByType, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetHeaderFooter_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **headerFooterIndex** | **int?**| Header/footer index. | 
 **sectionIndex** | **int?**| Section index. | 
 **filterByType** | **string**| List of types of headers and footers. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse**](AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheaderfooters"></a>
# **GetHeaderFooters**
> AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFootersResponse GetHeaderFooters (string version, string name, string sectionPath, string filterByType = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a list of header/footers that are contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetHeaderFootersExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var sectionPath = sectionPath_example;  // string | Path to parent section.
            var filterByType = filterByType_example;  // string | List of types of headers and footers. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a list of header/footers that are contained in the document.
                AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFootersResponse result = apiInstance.GetHeaderFooters(version, name, sectionPath, filterByType, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetHeaderFooters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **sectionPath** | **string**| Path to parent section. | 
 **filterByType** | **string**| List of types of headers and footers. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFootersResponse**](AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFootersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofficemathobject"></a>
# **GetOfficeMathObject**
> AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse GetOfficeMathObject (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Read OfficeMath object by index.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetOfficeMathObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of OfficeMath objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Read OfficeMath object by index.
                AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse result = apiInstance.GetOfficeMathObject(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetOfficeMathObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of OfficeMath objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse**](AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofficemathobjects"></a>
# **GetOfficeMathObjects**
> AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse GetOfficeMathObjects (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get OfficeMath objects from document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetOfficeMathObjectsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of OfficeMath objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get OfficeMath objects from document.
                AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse result = apiInstance.GetOfficeMathObjects(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetOfficeMathObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **nodePath** | **string**| Path to node, which contains collection of OfficeMath objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse**](AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsection"></a>
# **GetSection**
> AsposeWordsCloudDTODocumentElementsSectionsSectionResponse GetSection (string version, string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get document section by index.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetSectionExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var sectionIndex = 56;  // int? | Section index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get document section by index.
                AsposeWordsCloudDTODocumentElementsSectionsSectionResponse result = apiInstance.GetSection(version, name, sectionIndex, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **sectionIndex** | **int?**| Section index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsSectionsSectionResponse**](AsposeWordsCloudDTODocumentElementsSectionsSectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionpagesetup"></a>
# **GetSectionPageSetup**
> AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse GetSectionPageSetup (string version, string name, int? sectionIndex, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Get page setup of section.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetSectionPageSetupExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var sectionIndex = 56;  // int? | Section index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Get page setup of section.
                AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse result = apiInstance.GetSectionPageSetup(version, name, sectionIndex, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetSectionPageSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **sectionIndex** | **int?**| Section index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse**](AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsections"></a>
# **GetSections**
> AsposeWordsCloudDTODocumentElementsSectionsSectionLinkCollectionResponse GetSections (string version, string name, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a list of sections that are contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetSectionsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a list of sections that are contained in the document.
                AsposeWordsCloudDTODocumentElementsSectionsSectionLinkCollectionResponse result = apiInstance.GetSections(version, name, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetSections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsSectionsSectionLinkCollectionResponse**](AsposeWordsCloudDTODocumentElementsSectionsSectionLinkCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettable"></a>
# **GetTable**
> AsposeWordsCloudDTODocumentElementsTablesTableResponse GetTable (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTableExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table.
                AsposeWordsCloudDTODocumentElementsTablesTableResponse result = apiInstance.GetTable(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableResponse**](AsposeWordsCloudDTODocumentElementsTablesTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablecell"></a>
# **GetTableCell**
> AsposeWordsCloudDTODocumentElementsTablesTableCellResponse GetTableCell (string version, string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table cell.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTableCellExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tableRowPath = tableRowPath_example;  // string | Path to table row.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table cell.
                AsposeWordsCloudDTODocumentElementsTablesTableCellResponse result = apiInstance.GetTableCell(version, name, tableRowPath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTableCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tableRowPath** | **string**| Path to table row. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableCellResponse**](AsposeWordsCloudDTODocumentElementsTablesTableCellResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablecellformat"></a>
# **GetTableCellFormat**
> AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse GetTableCellFormat (string version, string name, string tableRowPath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table cell format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTableCellFormatExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tableRowPath = tableRowPath_example;  // string | Path to table row.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table cell format.
                AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse result = apiInstance.GetTableCellFormat(version, name, tableRowPath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTableCellFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tableRowPath** | **string**| Path to table row. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse**](AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettableproperties"></a>
# **GetTableProperties**
> AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse GetTableProperties (string version, string name, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTablePropertiesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table properties.
                AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse result = apiInstance.GetTableProperties(version, name, index, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTableProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse**](AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablerow"></a>
# **GetTableRow**
> AsposeWordsCloudDTODocumentElementsTablesTableRowResponse GetTableRow (string version, string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table row.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTableRowExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tablePath = tablePath_example;  // string | Path to table.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table row.
                AsposeWordsCloudDTODocumentElementsTablesTableRowResponse result = apiInstance.GetTableRow(version, name, tablePath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tablePath** | **string**| Path to table. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableRowResponse**](AsposeWordsCloudDTODocumentElementsTablesTableRowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettablerowformat"></a>
# **GetTableRowFormat**
> AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse GetTableRowFormat (string version, string name, string tablePath, int? index, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a table row format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTableRowFormatExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var tablePath = tablePath_example;  // string | Path to table.
            var index = 56;  // int? | Object index
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a table row format.
                AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse result = apiInstance.GetTableRowFormat(version, name, tablePath, index, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTableRowFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **tablePath** | **string**| Path to table. | 
 **index** | **int?**| Object index | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse**](AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettables"></a>
# **GetTables**
> AsposeWordsCloudDTODocumentElementsTablesTableLinkCollectionResponse GetTables (string version, string name, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Return a list of tables that are contained in the document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class GetTablesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Return a list of tables that are contained in the document.
                AsposeWordsCloudDTODocumentElementsTablesTableLinkCollectionResponse result = apiInstance.GetTables(version, name, nodePath, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.GetTables: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableLinkCollectionResponse**](AsposeWordsCloudDTODocumentElementsTablesTableLinkCollectionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inserttable"></a>
# **InsertTable**
> AsposeWordsCloudDTODocumentElementsTablesTableResponse InsertTable (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTableInsertDto table, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds table to document, returns added table's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class InsertTableExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var table = new AsposeWordsCloudDTODocumentElementsTablesTableInsertDto(); // AsposeWordsCloudDTODocumentElementsTablesTableInsertDto | Table parameters/
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds table to document, returns added table's data.
                AsposeWordsCloudDTODocumentElementsTablesTableResponse result = apiInstance.InsertTable(version, name, table, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.InsertTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **table** | [**AsposeWordsCloudDTODocumentElementsTablesTableInsertDto**](AsposeWordsCloudDTODocumentElementsTablesTableInsertDto.md)| Table parameters/ | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableResponse**](AsposeWordsCloudDTODocumentElementsTablesTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inserttablecell"></a>
# **InsertTableCell**
> AsposeWordsCloudDTODocumentElementsTablesTableCellResponse InsertTableCell (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto cell, string tableRowPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds table cell to table, returns added cell's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class InsertTableCellExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var cell = new AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto(); // AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto | Table cell parameters/
            var tableRowPath = tableRowPath_example;  // string | Path to table row.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds table cell to table, returns added cell's data.
                AsposeWordsCloudDTODocumentElementsTablesTableCellResponse result = apiInstance.InsertTableCell(version, name, cell, tableRowPath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.InsertTableCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **cell** | [**AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto**](AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto.md)| Table cell parameters/ | 
 **tableRowPath** | **string**| Path to table row. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableCellResponse**](AsposeWordsCloudDTODocumentElementsTablesTableCellResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inserttablerow"></a>
# **InsertTableRow**
> AsposeWordsCloudDTODocumentElementsTablesTableRowResponse InsertTableRow (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTableRowInsertDto row, string tablePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds table row to table, returns added row's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class InsertTableRowExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var row = new AsposeWordsCloudDTODocumentElementsTablesTableRowInsertDto(); // AsposeWordsCloudDTODocumentElementsTablesTableRowInsertDto | Table row parameters/
            var tablePath = tablePath_example;  // string | Path to table.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds table row to table, returns added row's data.
                AsposeWordsCloudDTODocumentElementsTablesTableRowResponse result = apiInstance.InsertTableRow(version, name, row, tablePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.InsertTableRow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **row** | [**AsposeWordsCloudDTODocumentElementsTablesTableRowInsertDto**](AsposeWordsCloudDTODocumentElementsTablesTableRowInsertDto.md)| Table row parameters/ | 
 **tablePath** | **string**| Path to table. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableRowResponse**](AsposeWordsCloudDTODocumentElementsTablesTableRowResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postappenddocument"></a>
# **PostAppendDocument**
> AsposeWordsCloudDTODocumentResponse PostAppendDocument (string version, string name, AsposeWordsCloudDTODocumentEntryList documentList, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Append documents to original document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostAppendDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | Original document name.
            var documentList = new AsposeWordsCloudDTODocumentEntryList(); // AsposeWordsCloudDTODocumentEntryList | {Aspose.Words.Cloud.DTO.DocumentEntryList} with a list of documents to append.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Append documents to original document.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostAppendDocument(version, name, documentList, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostAppendDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| Original document name. | 
 **documentList** | [**AsposeWordsCloudDTODocumentEntryList**](AsposeWordsCloudDTODocumentEntryList.md)| {Aspose.Words.Cloud.DTO.DocumentEntryList} with a list of documents to append. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchangedocumentprotection"></a>
# **PostChangeDocumentProtection**
> AsposeWordsCloudDTOProtectionDataResponse PostChangeDocumentProtection (string version, string name, AsposeWordsCloudDTOProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Change document protection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostChangeDocumentProtectionExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var protectionRequest = new AsposeWordsCloudDTOProtectionRequest(); // AsposeWordsCloudDTOProtectionRequest | {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Change document protection.
                AsposeWordsCloudDTOProtectionDataResponse result = apiInstance.PostChangeDocumentProtection(version, name, protectionRequest, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostChangeDocumentProtection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **protectionRequest** | [**AsposeWordsCloudDTOProtectionRequest**](AsposeWordsCloudDTOProtectionRequest.md)| {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOProtectionDataResponse**](AsposeWordsCloudDTOProtectionDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomment"></a>
# **PostComment**
> AsposeWordsCloudDTODocumentElementsCommentsCommentResponse PostComment (string version, string name, int? commentIndex, AsposeWordsCloudDTODocumentElementsCommentsCommentDto comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates the comment, returns updated comment's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostCommentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var commentIndex = 56;  // int? | Comment index
            var comment = new AsposeWordsCloudDTODocumentElementsCommentsCommentDto(); // AsposeWordsCloudDTODocumentElementsCommentsCommentDto | Comment data.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates the comment, returns updated comment's data.
                AsposeWordsCloudDTODocumentElementsCommentsCommentResponse result = apiInstance.PostComment(version, name, commentIndex, comment, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **commentIndex** | **int?**| Comment index | 
 **comment** | [**AsposeWordsCloudDTODocumentElementsCommentsCommentDto**](AsposeWordsCloudDTODocumentElementsCommentsCommentDto.md)| Comment data. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommentsCommentResponse**](AsposeWordsCloudDTODocumentElementsCommentsCommentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomparedocument"></a>
# **PostCompareDocument**
> AsposeWordsCloudDTODocumentResponse PostCompareDocument (string version, string name, AsposeWordsCloudDTOCompareCompareData compareData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Compare document with original document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostCompareDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | Original document name.
            var compareData = new AsposeWordsCloudDTOCompareCompareData(); // AsposeWordsCloudDTOCompareCompareData | {Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Compare document with original document.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostCompareDocument(version, name, compareData, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostCompareDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| Original document name. | 
 **compareData** | [**AsposeWordsCloudDTOCompareCompareData**](AsposeWordsCloudDTOCompareCompareData.md)| {Aspose.Words.Cloud.DTO.Compare.CompareData} with a document to compare. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentexecutemailmerge"></a>
# **PostDocumentExecuteMailMerge**
> AsposeWordsCloudDTODocumentResponse PostDocumentExecuteMailMerge (string version, string name, bool? withRegions, string data = null, string mailMergeDataFile = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Execute document mail merge operation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostDocumentExecuteMailMergeExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var withRegions = true;  // bool? | With regions flag.
            var data = data_example;  // string | Mail merge data (optional) 
            var mailMergeDataFile = mailMergeDataFile_example;  // string | Mail merge data. (optional) 
            var cleanup = cleanup_example;  // string | Clean up options. (optional) 
            var useWholeParagraphAsRegion = true;  // bool? | Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Execute document mail merge operation.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostDocumentExecuteMailMerge(version, name, withRegions, data, mailMergeDataFile, cleanup, useWholeParagraphAsRegion, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostDocumentExecuteMailMerge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **withRegions** | **bool?**| With regions flag. | 
 **data** | **string**| Mail merge data | [optional] 
 **mailMergeDataFile** | **string**| Mail merge data. | [optional] 
 **cleanup** | **string**| Clean up options. | [optional] 
 **useWholeParagraphAsRegion** | **bool?**| Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentparagraphrunfont"></a>
# **PostDocumentParagraphRunFont**
> AsposeWordsCloudDTODocumentElementsFontElementFontResponse PostDocumentParagraphRunFont (string version, string name, AsposeWordsCloudDTODocumentElementsFontElementFont fontDto, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates font properties, returns updated font data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostDocumentParagraphRunFontExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var fontDto = new AsposeWordsCloudDTODocumentElementsFontElementFont(); // AsposeWordsCloudDTODocumentElementsFontElementFont | Font dto object
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates font properties, returns updated font data.
                AsposeWordsCloudDTODocumentElementsFontElementFontResponse result = apiInstance.PostDocumentParagraphRunFont(version, name, fontDto, paragraphPath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostDocumentParagraphRunFont: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **fontDto** | [**AsposeWordsCloudDTODocumentElementsFontElementFont**](AsposeWordsCloudDTODocumentElementsFontElementFont.md)| Font dto object | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFontElementFontResponse**](AsposeWordsCloudDTODocumentElementsFontElementFontResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocumentsaveas"></a>
# **PostDocumentSaveAs**
> AsposeWordsCloudDTOSaveResponse PostDocumentSaveAs (string version, string name, AsposeWordsCloudDTOSavingSaveOptionsData saveOptionsData, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Convert document to destination format with detailed settings and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostDocumentSaveAsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var saveOptionsData = new AsposeWordsCloudDTOSavingSaveOptionsData(); // AsposeWordsCloudDTOSavingSaveOptionsData | Save options.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Convert document to destination format with detailed settings and save result to storage.
                AsposeWordsCloudDTOSaveResponse result = apiInstance.PostDocumentSaveAs(version, name, saveOptionsData, destFileName, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostDocumentSaveAs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **saveOptionsData** | [**AsposeWordsCloudDTOSavingSaveOptionsData**](AsposeWordsCloudDTOSavingSaveOptionsData.md)| Save options. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

[**AsposeWordsCloudDTOSaveResponse**](AsposeWordsCloudDTOSaveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdrawingobject"></a>
# **PostDrawingObject**
> AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse PostDrawingObject (string version, string drawingObject, System.IO.Stream imageFile, string name, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates drawing object, returns updated  drawing object's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostDrawingObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var drawingObject = drawingObject_example;  // string | Drawing object parameters
            var imageFile = new System.IO.Stream(); // System.IO.Stream | File with image
            var name = name_example;  // string | The document name.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates drawing object, returns updated  drawing object's data.
                AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse result = apiInstance.PostDrawingObject(version, drawingObject, imageFile, name, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostDrawingObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **drawingObject** | **string**| Drawing object parameters | 
 **imageFile** | **System.IO.Stream**| File with image | 
 **name** | **string**| The document name. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse**](AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutetemplate"></a>
# **PostExecuteTemplate**
> AsposeWordsCloudDTODocumentResponse PostExecuteTemplate (string version, string data, string name, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Populate document template with data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostExecuteTemplateExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var data = data_example;  // string | Mail merge data
            var name = name_example;  // string | The template document name.
            var cleanup = cleanup_example;  // string | Clean up options. (optional) 
            var useWholeParagraphAsRegion = true;  // bool? | Gets or sets a value indicating whether paragraph with TableStart or   TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.    The default value is true. (optional) 
            var withRegions = true;  // bool? | Merge with regions or not. True by default (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Populate document template with data.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostExecuteTemplate(version, data, name, cleanup, useWholeParagraphAsRegion, withRegions, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostExecuteTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **data** | **string**| Mail merge data | 
 **name** | **string**| The template document name. | 
 **cleanup** | **string**| Clean up options. | [optional] 
 **useWholeParagraphAsRegion** | **bool?**| Gets or sets a value indicating whether paragraph with TableStart or   TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.    The default value is true. | [optional] 
 **withRegions** | **bool?**| Merge with regions or not. True by default | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfield"></a>
# **PostField**
> AsposeWordsCloudDTODocumentElementsFieldsFieldResponse PostField (string version, string name, AsposeWordsCloudDTODocumentElementsFieldsFieldDto field, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates field's properties, returns updated field's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var field = new AsposeWordsCloudDTODocumentElementsFieldsFieldDto(); // AsposeWordsCloudDTODocumentElementsFieldsFieldDto | Field data.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates field's properties, returns updated field's data.
                AsposeWordsCloudDTODocumentElementsFieldsFieldResponse result = apiInstance.PostField(version, name, field, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **field** | [**AsposeWordsCloudDTODocumentElementsFieldsFieldDto**](AsposeWordsCloudDTODocumentElementsFieldsFieldDto.md)| Field data. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFieldsFieldResponse**](AsposeWordsCloudDTODocumentElementsFieldsFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfootnote"></a>
# **PostFootnote**
> AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse PostFootnote (string version, string name, AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto footnoteDto, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates footnote's properties, returns updated run's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostFootnoteExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var footnoteDto = new AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto(); // AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto | Footnote data.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of footnotes.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates footnote's properties, returns updated run's data.
                AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse result = apiInstance.PostFootnote(version, name, footnoteDto, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostFootnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **footnoteDto** | [**AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto**](AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto.md)| Footnote data. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains collection of footnotes. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse**](AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postformfield"></a>
# **PostFormField**
> AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse PostFormField (string version, string name, AsposeWordsCloudDTODocumentElementsFormFieldsFormField formField, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates properties of form field, returns updated form field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostFormFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var formField = new AsposeWordsCloudDTODocumentElementsFormFieldsFormField(); // AsposeWordsCloudDTODocumentElementsFormFieldsFormField | From field data.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node that contains collection of formfields.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates properties of form field, returns updated form field.
                AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse result = apiInstance.PostFormField(version, name, formField, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostFormField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **formField** | [**AsposeWordsCloudDTODocumentElementsFormFieldsFormField**](AsposeWordsCloudDTODocumentElementsFormFieldsFormField.md)| From field data. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node that contains collection of formfields. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse**](AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinsertdocumentwatermarkimage"></a>
# **PostInsertDocumentWatermarkImage**
> AsposeWordsCloudDTODocumentResponse PostInsertDocumentWatermarkImage (string version, string name, System.IO.Stream imageFile = null, double? rotationAngle = null, string image = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Insert document watermark image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostInsertDocumentWatermarkImageExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var imageFile = new System.IO.Stream(); // System.IO.Stream | File with image (optional) 
            var rotationAngle = 1.2;  // double? | The watermark rotation angle. (optional) 
            var image = image_example;  // string | The image file server full name. If the name is empty the image is expected in request content. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Insert document watermark image.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostInsertDocumentWatermarkImage(version, name, imageFile, rotationAngle, image, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostInsertDocumentWatermarkImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **imageFile** | **System.IO.Stream**| File with image | [optional] 
 **rotationAngle** | **double?**| The watermark rotation angle. | [optional] 
 **image** | **string**| The image file server full name. If the name is empty the image is expected in request content. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinsertdocumentwatermarktext"></a>
# **PostInsertDocumentWatermarkText**
> AsposeWordsCloudDTODocumentResponse PostInsertDocumentWatermarkText (string version, string name, AsposeWordsCloudDTOWatermarkText watermarkText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Insert document watermark text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostInsertDocumentWatermarkTextExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var watermarkText = new AsposeWordsCloudDTOWatermarkText(); // AsposeWordsCloudDTOWatermarkText | {Aspose.Words.Cloud.DTO.WatermarkText} with the watermark data.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Insert document watermark text.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostInsertDocumentWatermarkText(version, name, watermarkText, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostInsertDocumentWatermarkText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **watermarkText** | [**AsposeWordsCloudDTOWatermarkText**](AsposeWordsCloudDTOWatermarkText.md)| {Aspose.Words.Cloud.DTO.WatermarkText} with the watermark data. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinsertpagenumbers"></a>
# **PostInsertPageNumbers**
> AsposeWordsCloudDTODocumentResponse PostInsertPageNumbers (string version, string name, AsposeWordsCloudDTOPageNumber pageNumber, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Insert document page numbers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostInsertPageNumbersExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | A document name.
            var pageNumber = new AsposeWordsCloudDTOPageNumber(); // AsposeWordsCloudDTOPageNumber | {Aspose.Words.Cloud.DTO.PageNumber} with the page numbers settings.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Insert document page numbers.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostInsertPageNumbers(version, name, pageNumber, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostInsertPageNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| A document name. | 
 **pageNumber** | [**AsposeWordsCloudDTOPageNumber**](AsposeWordsCloudDTOPageNumber.md)| {Aspose.Words.Cloud.DTO.PageNumber} with the page numbers settings. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postloadwebdocument"></a>
# **PostLoadWebDocument**
> AsposeWordsCloudDTOSaveResponse PostLoadWebDocument (string version, AsposeWordsCloudDTOLoadWebDocumentLoadWebDocumentData data, string storage = null)

Loads new document from web into the file with any supported format of data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostLoadWebDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var data = new AsposeWordsCloudDTOLoadWebDocumentLoadWebDocumentData(); // AsposeWordsCloudDTOLoadWebDocumentLoadWebDocumentData | Parameters of loading.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 

            try
            {
                // Loads new document from web into the file with any supported format of data.
                AsposeWordsCloudDTOSaveResponse result = apiInstance.PostLoadWebDocument(version, data, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostLoadWebDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **data** | [**AsposeWordsCloudDTOLoadWebDocumentLoadWebDocumentData**](AsposeWordsCloudDTOLoadWebDocumentLoadWebDocumentData.md)| Parameters of loading. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 

### Return type

[**AsposeWordsCloudDTOSaveResponse**](AsposeWordsCloudDTOSaveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postreplacetext"></a>
# **PostReplaceText**
> AsposeWordsCloudDTOReplaceReplaceTextResponse PostReplaceText (string version, string name, AsposeWordsCloudDTOReplaceReplaceTextRequest replaceText, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Replace document text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostReplaceTextExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var replaceText = new AsposeWordsCloudDTOReplaceReplaceTextRequest(); // AsposeWordsCloudDTOReplaceReplaceTextRequest | {Aspose.Words.Cloud.DTO.Replace.ReplaceTextResponse} with the replace operation settings.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Replace document text.
                AsposeWordsCloudDTOReplaceReplaceTextResponse result = apiInstance.PostReplaceText(version, name, replaceText, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostReplaceText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **replaceText** | [**AsposeWordsCloudDTOReplaceReplaceTextRequest**](AsposeWordsCloudDTOReplaceReplaceTextRequest.md)| {Aspose.Words.Cloud.DTO.Replace.ReplaceTextResponse} with the replace operation settings. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOReplaceReplaceTextResponse**](AsposeWordsCloudDTOReplaceReplaceTextResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrun"></a>
# **PostRun**
> AsposeWordsCloudDTODocumentElementsRunsRunResponse PostRun (string version, string name, AsposeWordsCloudDTODocumentElementsRunsRun run, string paragraphPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates run's properties, returns updated run's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostRunExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var run = new AsposeWordsCloudDTODocumentElementsRunsRun(); // AsposeWordsCloudDTODocumentElementsRunsRun | Run data.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates run's properties, returns updated run's data.
                AsposeWordsCloudDTODocumentElementsRunsRunResponse result = apiInstance.PostRun(version, name, run, paragraphPath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **run** | [**AsposeWordsCloudDTODocumentElementsRunsRun**](AsposeWordsCloudDTODocumentElementsRunsRun.md)| Run data. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsRunsRunResponse**](AsposeWordsCloudDTODocumentElementsRunsRunResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postruntask"></a>
# **PostRunTask**
> Object PostRunTask (string version)

Run tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostRunTaskExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.

            try
            {
                // Run tasks
                Object result = apiInstance.PostRunTask(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostRunTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsplitdocument"></a>
# **PostSplitDocument**
> AsposeWordsCloudDTOSplitDocumentResponse PostSplitDocument (string version, string name, string format = null, int? from = null, int? to = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Split document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostSplitDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | Original document name.
            var format = format_example;  // string | Format to split. (optional) 
            var from = 56;  // int? | Start page. (optional) 
            var to = 56;  // int? | End page. (optional) 
            var zipOutput = true;  // bool? | ZipOutput or not. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Split document.
                AsposeWordsCloudDTOSplitDocumentResponse result = apiInstance.PostSplitDocument(version, name, format, from, to, zipOutput, destFileName, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostSplitDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| Original document name. | 
 **format** | **string**| Format to split. | [optional] 
 **from** | **int?**| Start page. | [optional] 
 **to** | **int?**| End page. | [optional] 
 **zipOutput** | **bool?**| ZipOutput or not. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

[**AsposeWordsCloudDTOSplitDocumentResponse**](AsposeWordsCloudDTOSplitDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupdatedocumentbookmark"></a>
# **PostUpdateDocumentBookmark**
> AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse PostUpdateDocumentBookmark (string version, string name, AsposeWordsCloudDTODocumentElementsBookmarksBookmarkData bookmarkData, string bookmarkName, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Update document bookmark.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostUpdateDocumentBookmarkExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var bookmarkData = new AsposeWordsCloudDTODocumentElementsBookmarksBookmarkData(); // AsposeWordsCloudDTODocumentElementsBookmarksBookmarkData | {Aspose.Words.Cloud.DTO.DocumentElements.Bookmarks.BookmarkData} with new bookmark data.
            var bookmarkName = bookmarkName_example;  // string | The bookmark name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Update document bookmark.
                AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse result = apiInstance.PostUpdateDocumentBookmark(version, name, bookmarkData, bookmarkName, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostUpdateDocumentBookmark: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **bookmarkData** | [**AsposeWordsCloudDTODocumentElementsBookmarksBookmarkData**](AsposeWordsCloudDTODocumentElementsBookmarksBookmarkData.md)| {Aspose.Words.Cloud.DTO.DocumentElements.Bookmarks.BookmarkData} with new bookmark data. | 
 **bookmarkName** | **string**| The bookmark name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse**](AsposeWordsCloudDTODocumentElementsBookmarksBookmarkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postupdatedocumentfields"></a>
# **PostUpdateDocumentFields**
> AsposeWordsCloudDTODocumentResponse PostUpdateDocumentFields (string version, string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Update (reevaluate) fields in document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PostUpdateDocumentFieldsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Update (reevaluate) fields in document.
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PostUpdateDocumentFields(version, name, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PostUpdateDocumentFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcomment"></a>
# **PutComment**
> AsposeWordsCloudDTODocumentElementsCommentsCommentResponse PutComment (string version, string name, AsposeWordsCloudDTODocumentElementsCommentsCommentDto comment, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds comment to document, returns inserted comment's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutCommentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var comment = new AsposeWordsCloudDTODocumentElementsCommentsCommentDto(); // AsposeWordsCloudDTODocumentElementsCommentsCommentDto | Comment data.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds comment to document, returns inserted comment's data.
                AsposeWordsCloudDTODocumentElementsCommentsCommentResponse result = apiInstance.PutComment(version, name, comment, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **comment** | [**AsposeWordsCloudDTODocumentElementsCommentsCommentDto**](AsposeWordsCloudDTODocumentElementsCommentsCommentDto.md)| Comment data. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommentsCommentResponse**](AsposeWordsCloudDTODocumentElementsCommentsCommentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putconvertdocument"></a>
# **PutConvertDocument**
> System.IO.Stream PutConvertDocument (string version, System.IO.Stream document, string format, string outPath = null, string storage = null, string fontsLocation = null)

Convert document from request content to format specified.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutConvertDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var document = new System.IO.Stream(); // System.IO.Stream | Converting document
            var format = format_example;  // string | Format to convert.
            var outPath = outPath_example;  // string | Path for saving operation result to the local storage. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Convert document from request content to format specified.
                System.IO.Stream result = apiInstance.PutConvertDocument(version, document, format, outPath, storage, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutConvertDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **document** | **System.IO.Stream**| Converting document | 
 **format** | **string**| Format to convert. | 
 **outPath** | **string**| Path for saving operation result to the local storage. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcreatedocument"></a>
# **PutCreateDocument**
> AsposeWordsCloudDTODocumentResponse PutCreateDocument (string version, string fileName = null, string folder = null, string storage = null)

Creates new document.  Document is created with format which is recognized from file extensions.   Supported extentions: \".doc\", \".docx\", \".docm\", \".dot\", \".dotm\", \".dotx\", \".flatopc\", \".fopc\", \".flatopc_macro\", \".fopc_macro\", \".flatopc_template\", \".fopc_template\", \".flatopc_template_macro\", \".fopc_template_macro\", \".wordml\", \".wml\", \".rtf\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutCreateDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var fileName = fileName_example;  // string | The file name. (optional) 
            var folder = folder_example;  // string | The document folder. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 

            try
            {
                // Creates new document.  Document is created with format which is recognized from file extensions.   Supported extentions: \".doc\", \".docx\", \".docm\", \".dot\", \".dotm\", \".dotx\", \".flatopc\", \".fopc\", \".flatopc_macro\", \".fopc_macro\", \".flatopc_template\", \".fopc_template\", \".flatopc_template_macro\", \".fopc_template_macro\", \".wordml\", \".wml\", \".rtf\"
                AsposeWordsCloudDTODocumentResponse result = apiInstance.PutCreateDocument(version, fileName, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutCreateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **fileName** | **string**| The file name. | [optional] 
 **folder** | **string**| The document folder. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentResponse**](AsposeWordsCloudDTODocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdocumentfieldnames"></a>
# **PutDocumentFieldNames**
> AsposeWordsCloudDTOFieldNamesResponse PutDocumentFieldNames (string version, System.IO.Stream template, bool? useNonMergeFields = null)

Read document field names.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutDocumentFieldNamesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var template = new System.IO.Stream(); // System.IO.Stream | File with template
            var useNonMergeFields = true;  // bool? | Use non merge fields or not. (optional) 

            try
            {
                // Read document field names.
                AsposeWordsCloudDTOFieldNamesResponse result = apiInstance.PutDocumentFieldNames(version, template, useNonMergeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutDocumentFieldNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **template** | **System.IO.Stream**| File with template | 
 **useNonMergeFields** | **bool?**| Use non merge fields or not. | [optional] 

### Return type

[**AsposeWordsCloudDTOFieldNamesResponse**](AsposeWordsCloudDTOFieldNamesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdocumentsaveastiff"></a>
# **PutDocumentSaveAsTiff**
> AsposeWordsCloudDTOSaveResponse PutDocumentSaveAsTiff (string version, string name, AsposeWordsCloudDTOSavingImagesTiffSaveOptionsData saveOptions, string resultFile = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, float? imageBrightness = null, string imageColorMode = null, float? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, float? resolution = null, float? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Convert document to tiff with detailed settings and save result to storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutDocumentSaveAsTiffExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var saveOptions = new AsposeWordsCloudDTOSavingImagesTiffSaveOptionsData(); // AsposeWordsCloudDTOSavingImagesTiffSaveOptionsData | Tiff save options.
            var resultFile = resultFile_example;  // string | The resulting file name. (optional) 
            var useAntiAliasing = true;  // bool? | Use antialiasing flag. (optional) 
            var useHighQualityRendering = true;  // bool? | Use high quality flag. (optional) 
            var imageBrightness = 3.4;  // float? | Brightness for the generated images. (optional) 
            var imageColorMode = imageColorMode_example;  // string | Color mode for the generated images. (optional) 
            var imageContrast = 3.4;  // float? | The contrast for the generated images. (optional) 
            var numeralFormat = numeralFormat_example;  // string | The images numeral format. (optional) 
            var pageCount = 56;  // int? | Number of pages to render. (optional) 
            var pageIndex = 56;  // int? | Page index to start rendering. (optional) 
            var paperColor = paperColor_example;  // string | Background image color. (optional) 
            var pixelFormat = pixelFormat_example;  // string | The pixel format of generated images. (optional) 
            var resolution = 3.4;  // float? | The resolution of generated images. (optional) 
            var scale = 3.4;  // float? | Zoom factor for generated images. (optional) 
            var tiffCompression = tiffCompression_example;  // string | The compression tipe. (optional) 
            var dmlRenderingMode = dmlRenderingMode_example;  // string | Optional, default is Fallback. (optional) 
            var dmlEffectsRenderingMode = dmlEffectsRenderingMode_example;  // string | Optional, default is Simplified. (optional) 
            var tiffBinarizationMethod = tiffBinarizationMethod_example;  // string | Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold. (optional) 
            var zipOutput = true;  // bool? | Optional. A value determining zip output or not. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Convert document to tiff with detailed settings and save result to storage.
                AsposeWordsCloudDTOSaveResponse result = apiInstance.PutDocumentSaveAsTiff(version, name, saveOptions, resultFile, useAntiAliasing, useHighQualityRendering, imageBrightness, imageColorMode, imageContrast, numeralFormat, pageCount, pageIndex, paperColor, pixelFormat, resolution, scale, tiffCompression, dmlRenderingMode, dmlEffectsRenderingMode, tiffBinarizationMethod, zipOutput, destFileName, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutDocumentSaveAsTiff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **saveOptions** | [**AsposeWordsCloudDTOSavingImagesTiffSaveOptionsData**](AsposeWordsCloudDTOSavingImagesTiffSaveOptionsData.md)| Tiff save options. | 
 **resultFile** | **string**| The resulting file name. | [optional] 
 **useAntiAliasing** | **bool?**| Use antialiasing flag. | [optional] 
 **useHighQualityRendering** | **bool?**| Use high quality flag. | [optional] 
 **imageBrightness** | **float?**| Brightness for the generated images. | [optional] 
 **imageColorMode** | **string**| Color mode for the generated images. | [optional] 
 **imageContrast** | **float?**| The contrast for the generated images. | [optional] 
 **numeralFormat** | **string**| The images numeral format. | [optional] 
 **pageCount** | **int?**| Number of pages to render. | [optional] 
 **pageIndex** | **int?**| Page index to start rendering. | [optional] 
 **paperColor** | **string**| Background image color. | [optional] 
 **pixelFormat** | **string**| The pixel format of generated images. | [optional] 
 **resolution** | **float?**| The resolution of generated images. | [optional] 
 **scale** | **float?**| Zoom factor for generated images. | [optional] 
 **tiffCompression** | **string**| The compression tipe. | [optional] 
 **dmlRenderingMode** | **string**| Optional, default is Fallback. | [optional] 
 **dmlEffectsRenderingMode** | **string**| Optional, default is Simplified. | [optional] 
 **tiffBinarizationMethod** | **string**| Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold. | [optional] 
 **zipOutput** | **bool?**| Optional. A value determining zip output or not. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

[**AsposeWordsCloudDTOSaveResponse**](AsposeWordsCloudDTOSaveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdrawingobject"></a>
# **PutDrawingObject**
> AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse PutDrawingObject (string version, string drawingObject, System.IO.Stream imageFile, string name, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds  drawing object to document, returns added  drawing object's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutDrawingObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var drawingObject = drawingObject_example;  // string | Drawing object parameters
            var imageFile = new System.IO.Stream(); // System.IO.Stream | File with image
            var name = name_example;  // string | The document name.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of drawing objects.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds  drawing object to document, returns added  drawing object's data.
                AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse result = apiInstance.PutDrawingObject(version, drawingObject, imageFile, name, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutDrawingObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **drawingObject** | **string**| Drawing object parameters | 
 **imageFile** | **System.IO.Stream**| File with image | 
 **name** | **string**| The document name. | 
 **nodePath** | **string**| Path to node, which contains collection of drawing objects. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse**](AsposeWordsCloudDTODocumentElementsDrawingObjectsDrawingObjectResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexecutemailmergeonline"></a>
# **PutExecuteMailMergeOnline**
> System.IO.Stream PutExecuteMailMergeOnline (string version, System.IO.Stream template, System.IO.Stream data, bool? withRegions = null, string cleanup = null)

Execute document mail merge online.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutExecuteMailMergeOnlineExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var template = new System.IO.Stream(); // System.IO.Stream | File with template
            var data = new System.IO.Stream(); // System.IO.Stream | File with mailmerge data
            var withRegions = true;  // bool? | With regions flag. (optional) 
            var cleanup = cleanup_example;  // string | Clean up options. (optional) 

            try
            {
                // Execute document mail merge online.
                System.IO.Stream result = apiInstance.PutExecuteMailMergeOnline(version, template, data, withRegions, cleanup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutExecuteMailMergeOnline: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **template** | **System.IO.Stream**| File with template | 
 **data** | **System.IO.Stream**| File with mailmerge data | 
 **withRegions** | **bool?**| With regions flag. | [optional] 
 **cleanup** | **string**| Clean up options. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexecutetemplateonline"></a>
# **PutExecuteTemplateOnline**
> System.IO.Stream PutExecuteTemplateOnline (string version, System.IO.Stream template, System.IO.Stream data, string cleanup = null, bool? useWholeParagraphAsRegion = null, bool? withRegions = null)

Populate document template with data online.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutExecuteTemplateOnlineExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var template = new System.IO.Stream(); // System.IO.Stream | File with template
            var data = new System.IO.Stream(); // System.IO.Stream | File with mailmerge data
            var cleanup = cleanup_example;  // string | Clean up options. (optional) 
            var useWholeParagraphAsRegion = true;  // bool? | Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true. (optional) 
            var withRegions = true;  // bool? | Merge with regions or not. True by default (optional) 

            try
            {
                // Populate document template with data online.
                System.IO.Stream result = apiInstance.PutExecuteTemplateOnline(version, template, data, cleanup, useWholeParagraphAsRegion, withRegions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutExecuteTemplateOnline: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **template** | **System.IO.Stream**| File with template | 
 **data** | **System.IO.Stream**| File with mailmerge data | 
 **cleanup** | **string**| Clean up options. | [optional] 
 **useWholeParagraphAsRegion** | **bool?**| Gets or sets a value indicating whether paragraph with TableStart or               TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.               The default value is true. | [optional] 
 **withRegions** | **bool?**| Merge with regions or not. True by default | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfield"></a>
# **PutField**
> AsposeWordsCloudDTODocumentElementsFieldsFieldResponse PutField (string version, string name, AsposeWordsCloudDTODocumentElementsFieldsFieldDto field, string nodePath, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds field to document, returns inserted field's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var field = new AsposeWordsCloudDTODocumentElementsFieldsFieldDto(); // AsposeWordsCloudDTODocumentElementsFieldsFieldDto | Field data.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of fields.
            var insertBeforeNode = insertBeforeNode_example;  // string | Field will be inserted before node with id=\"nodeId\". (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds field to document, returns inserted field's data.
                AsposeWordsCloudDTODocumentElementsFieldsFieldResponse result = apiInstance.PutField(version, name, field, nodePath, insertBeforeNode, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **field** | [**AsposeWordsCloudDTODocumentElementsFieldsFieldDto**](AsposeWordsCloudDTODocumentElementsFieldsFieldDto.md)| Field data. | 
 **nodePath** | **string**| Path to node, which contains collection of fields. | 
 **insertBeforeNode** | **string**| Field will be inserted before node with id&#x3D;\&quot;nodeId\&quot;. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFieldsFieldResponse**](AsposeWordsCloudDTODocumentElementsFieldsFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfootnote"></a>
# **PutFootnote**
> AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse PutFootnote (string version, string name, AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto footnoteDto, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds footnote to document, returns added footnote's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutFootnoteExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var footnoteDto = new AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto(); // AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto | Footnote data.
            var nodePath = nodePath_example;  // string | Path to node, which contains collection of footnotes.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds footnote to document, returns added footnote's data.
                AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse result = apiInstance.PutFootnote(version, name, footnoteDto, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutFootnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **footnoteDto** | [**AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto**](AsposeWordsCloudDTODocumentElementsFootnotesFootnoteDto.md)| Footnote data. | 
 **nodePath** | **string**| Path to node, which contains collection of footnotes. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse**](AsposeWordsCloudDTODocumentElementsFootnotesFootnoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putformfield"></a>
# **PutFormField**
> AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse PutFormField (string version, string name, AsposeWordsCloudDTODocumentElementsFormFieldsFormField formField, string nodePath, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds form field to paragraph, returns added form field's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutFormFieldExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var formField = new AsposeWordsCloudDTODocumentElementsFormFieldsFormField(); // AsposeWordsCloudDTODocumentElementsFormFieldsFormField | From field data.
            var nodePath = nodePath_example;  // string | Path to node that contains collection of formfields.
            var insertBeforeNode = insertBeforeNode_example;  // string | Form field will be inserted before node with index. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds form field to paragraph, returns added form field's data.
                AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse result = apiInstance.PutFormField(version, name, formField, nodePath, insertBeforeNode, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutFormField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **formField** | [**AsposeWordsCloudDTODocumentElementsFormFieldsFormField**](AsposeWordsCloudDTODocumentElementsFormFieldsFormField.md)| From field data. | 
 **nodePath** | **string**| Path to node that contains collection of formfields. | 
 **insertBeforeNode** | **string**| Form field will be inserted before node with index. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse**](AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putheaderfooter"></a>
# **PutHeaderFooter**
> AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse PutHeaderFooter (string version, string name, string headerFooterType, string sectionPath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Insert to document header or footer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutHeaderFooterExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var headerFooterType = headerFooterType_example;  // string | Type of header/footer.
            var sectionPath = sectionPath_example;  // string | Path to parent section.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Insert to document header or footer.
                AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse result = apiInstance.PutHeaderFooter(version, name, headerFooterType, sectionPath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutHeaderFooter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **headerFooterType** | **string**| Type of header/footer. | 
 **sectionPath** | **string**| Path to parent section. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse**](AsposeWordsCloudDTODocumentElementsHeaderFootersHeaderFooterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putparagraph"></a>
# **PutParagraph**
> AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse PutParagraph (string version, string name, AsposeWordsCloudDTODocumentElementsParagraphsParagraphInsertDto paragraph, string nodePath, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds paragraph to document, returns added paragraph's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutParagraphExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var paragraph = new AsposeWordsCloudDTODocumentElementsParagraphsParagraphInsertDto(); // AsposeWordsCloudDTODocumentElementsParagraphsParagraphInsertDto | Paragraph data.
            var nodePath = nodePath_example;  // string | Path to node which contains paragraphs.
            var insertBeforeNode = insertBeforeNode_example;  // string | Paragraph will be inserted before node with index. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds paragraph to document, returns added paragraph's data.
                AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse result = apiInstance.PutParagraph(version, name, paragraph, nodePath, insertBeforeNode, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutParagraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **paragraph** | [**AsposeWordsCloudDTODocumentElementsParagraphsParagraphInsertDto**](AsposeWordsCloudDTODocumentElementsParagraphsParagraphInsertDto.md)| Paragraph data. | 
 **nodePath** | **string**| Path to node which contains paragraphs. | 
 **insertBeforeNode** | **string**| Paragraph will be inserted before node with index. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse**](AsposeWordsCloudDTODocumentElementsParagraphsParagraphResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putprotectdocument"></a>
# **PutProtectDocument**
> AsposeWordsCloudDTOProtectionDataResponse PutProtectDocument (string version, string name, AsposeWordsCloudDTOProtectionRequest protectionRequest, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Protect document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutProtectDocumentExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var protectionRequest = new AsposeWordsCloudDTOProtectionRequest(); // AsposeWordsCloudDTOProtectionRequest | {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Protect document.
                AsposeWordsCloudDTOProtectionDataResponse result = apiInstance.PutProtectDocument(version, name, protectionRequest, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutProtectDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **protectionRequest** | [**AsposeWordsCloudDTOProtectionRequest**](AsposeWordsCloudDTOProtectionRequest.md)| {Aspose.Words.Cloud.DTO.ProtectionRequest} with protection settings. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOProtectionDataResponse**](AsposeWordsCloudDTOProtectionDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putrun"></a>
# **PutRun**
> AsposeWordsCloudDTODocumentElementsRunsRunResponse PutRun (string version, string name, string paragraphPath, AsposeWordsCloudDTODocumentElementsRunsRun run, string insertBeforeNode = null, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Adds run to document, returns added paragraph's data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutRunExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var paragraphPath = paragraphPath_example;  // string | Path to parent paragraph.
            var run = new AsposeWordsCloudDTODocumentElementsRunsRun(); // AsposeWordsCloudDTODocumentElementsRunsRun | Run data.
            var insertBeforeNode = insertBeforeNode_example;  // string | Paragraph will be inserted before node with index. (optional) 
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Adds run to document, returns added paragraph's data.
                AsposeWordsCloudDTODocumentElementsRunsRunResponse result = apiInstance.PutRun(version, name, paragraphPath, run, insertBeforeNode, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutRun: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **paragraphPath** | **string**| Path to parent paragraph. | 
 **run** | [**AsposeWordsCloudDTODocumentElementsRunsRun**](AsposeWordsCloudDTODocumentElementsRunsRun.md)| Run data. | 
 **insertBeforeNode** | **string**| Paragraph will be inserted before node with index. | [optional] 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsRunsRunResponse**](AsposeWordsCloudDTODocumentElementsRunsRunResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatedocumentproperty"></a>
# **PutUpdateDocumentProperty**
> AsposeWordsCloudDTODocumentPropertyResponse PutUpdateDocumentProperty (string version, string name, string propertyName, AsposeWordsCloudDTODocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Add new or update existing document property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutUpdateDocumentPropertyExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var property = new AsposeWordsCloudDTODocumentProperty(); // AsposeWordsCloudDTODocumentProperty | The property with new value.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Add new or update existing document property.
                AsposeWordsCloudDTODocumentPropertyResponse result = apiInstance.PutUpdateDocumentProperty(version, name, propertyName, property, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutUpdateDocumentProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **property** | [**AsposeWordsCloudDTODocumentProperty**](AsposeWordsCloudDTODocumentProperty.md)| The property with new value. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentPropertyResponse**](AsposeWordsCloudDTODocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdatedocumentproperty_0"></a>
# **PutUpdateDocumentProperty_0**
> AsposeWordsCloudDTODocumentPropertyResponse PutUpdateDocumentProperty_0 (string version, string name, string propertyName, AsposeWordsCloudDTODocumentProperty property, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Add new or update existing document property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class PutUpdateDocumentProperty_0Example
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var propertyName = propertyName_example;  // string | The property name.
            var property = new AsposeWordsCloudDTODocumentProperty(); // AsposeWordsCloudDTODocumentProperty | The property with new value.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Add new or update existing document property.
                AsposeWordsCloudDTODocumentPropertyResponse result = apiInstance.PutUpdateDocumentProperty_0(version, name, propertyName, property, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.PutUpdateDocumentProperty_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **propertyName** | **string**| The property name. | 
 **property** | [**AsposeWordsCloudDTODocumentProperty**](AsposeWordsCloudDTODocumentProperty.md)| The property with new value. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentPropertyResponse**](AsposeWordsCloudDTODocumentPropertyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rejectallrevisions"></a>
# **RejectAllRevisions**
> AsposeWordsCloudDTORevisionsModificationResponse RejectAllRevisions (string version, string name, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Reject all revisions in document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RejectAllRevisionsExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Reject all revisions in document
                AsposeWordsCloudDTORevisionsModificationResponse result = apiInstance.RejectAllRevisions(version, name, destFileName, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RejectAllRevisions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTORevisionsModificationResponse**](AsposeWordsCloudDTORevisionsModificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renderdrawingobject"></a>
# **RenderDrawingObject**
> System.IO.Stream RenderDrawingObject (string version, string name, string format, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Renders drawing object to specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RenderDrawingObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var format = format_example;  // string | The destination format.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains drawing objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Renders drawing object to specified format.
                System.IO.Stream result = apiInstance.RenderDrawingObject(version, name, format, index, nodePath, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RenderDrawingObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **format** | **string**| The destination format. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains drawing objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rendermathobject"></a>
# **RenderMathObject**
> System.IO.Stream RenderMathObject (string version, string name, string format, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Renders math object to specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RenderMathObjectExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var format = format_example;  // string | The destination format.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains office math objects.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Renders math object to specified format.
                System.IO.Stream result = apiInstance.RenderMathObject(version, name, format, index, nodePath, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RenderMathObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **format** | **string**| The destination format. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains office math objects. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renderpage"></a>
# **RenderPage**
> System.IO.Stream RenderPage (string version, string name, int? pageIndex, string format, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Renders page to specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RenderPageExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var pageIndex = 56;  // int? | Comment index
            var format = format_example;  // string | The destination format.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Renders page to specified format.
                System.IO.Stream result = apiInstance.RenderPage(version, name, pageIndex, format, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RenderPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **pageIndex** | **int?**| Comment index | 
 **format** | **string**| The destination format. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renderparagraph"></a>
# **RenderParagraph**
> System.IO.Stream RenderParagraph (string version, string name, string format, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Renders paragraph to specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RenderParagraphExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var format = format_example;  // string | The destination format.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains paragraphs.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Renders paragraph to specified format.
                System.IO.Stream result = apiInstance.RenderParagraph(version, name, format, index, nodePath, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RenderParagraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **format** | **string**| The destination format. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains paragraphs. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rendertable"></a>
# **RenderTable**
> System.IO.Stream RenderTable (string version, string name, string format, int? index, string nodePath, string storage = null, string folder = null, string loadEncoding = null, string password = null, string fontsLocation = null)

Renders table to specified format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class RenderTableExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The file name.
            var format = format_example;  // string | The destination format.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 
            var fontsLocation = fontsLocation_example;  // string | Folder in filestorage with custom fonts. (optional) 

            try
            {
                // Renders table to specified format.
                System.IO.Stream result = apiInstance.RenderTable(version, name, format, index, nodePath, storage, folder, loadEncoding, password, fontsLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.RenderTable: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The file name. | 
 **format** | **string**| The destination format. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 
 **fontsLocation** | **string**| Folder in filestorage with custom fonts. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetcache"></a>
# **ResetCache**
> AsposeWordsCloudDTOCommonSaaSposeResponse ResetCache (string version)

Resets font's cache.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class ResetCacheExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.

            try
            {
                // Resets font's cache.
                AsposeWordsCloudDTOCommonSaaSposeResponse result = apiInstance.ResetCache(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.ResetCache: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 

### Return type

[**AsposeWordsCloudDTOCommonSaaSposeResponse**](AsposeWordsCloudDTOCommonSaaSposeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> AsposeWordsCloudDTOSearchSearchResponse Search (string version, string name, string pattern = null, string storage = null, string folder = null, string loadEncoding = null, string password = null)

Search text in document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var pattern = pattern_example;  // string | The regular expression used to find matches. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Search text in document.
                AsposeWordsCloudDTOSearchSearchResponse result = apiInstance.Search(version, name, pattern, storage, folder, loadEncoding, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **pattern** | **string**| The regular expression used to find matches. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTOSearchSearchResponse**](AsposeWordsCloudDTOSearchSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateborder"></a>
# **UpdateBorder**
> AsposeWordsCloudDTODocumentElementsCommonBorderResponse UpdateBorder (string version, string name, AsposeWordsCloudDTODocumentElementsCommonBorder borderProperties, string nodePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates border properties.

'nodePath' should refer to node with cell or row

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class UpdateBorderExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var borderProperties = new AsposeWordsCloudDTODocumentElementsCommonBorder(); // AsposeWordsCloudDTODocumentElementsCommonBorder | Border properties
            var nodePath = nodePath_example;  // string | Path to node with border(node should be cell or row).
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates border properties.
                AsposeWordsCloudDTODocumentElementsCommonBorderResponse result = apiInstance.UpdateBorder(version, name, borderProperties, nodePath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.UpdateBorder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **borderProperties** | [**AsposeWordsCloudDTODocumentElementsCommonBorder**](AsposeWordsCloudDTODocumentElementsCommonBorder.md)| Border properties | 
 **nodePath** | **string**| Path to node with border(node should be cell or row). | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsCommonBorderResponse**](AsposeWordsCloudDTODocumentElementsCommonBorderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesectionpagesetup"></a>
# **UpdateSectionPageSetup**
> AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse UpdateSectionPageSetup (string version, string name, int? sectionIndex, AsposeWordsCloudDTODocumentElementsSectionsPageSetup pageSetup, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Update page setup of section.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class UpdateSectionPageSetupExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var sectionIndex = 56;  // int? | Section index
            var pageSetup = new AsposeWordsCloudDTODocumentElementsSectionsPageSetup(); // AsposeWordsCloudDTODocumentElementsSectionsPageSetup | Page setup properties dto
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Update page setup of section.
                AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse result = apiInstance.UpdateSectionPageSetup(version, name, sectionIndex, pageSetup, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.UpdateSectionPageSetup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **sectionIndex** | **int?**| Section index | 
 **pageSetup** | [**AsposeWordsCloudDTODocumentElementsSectionsPageSetup**](AsposeWordsCloudDTODocumentElementsSectionsPageSetup.md)| Page setup properties dto | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse**](AsposeWordsCloudDTODocumentElementsSectionsSectionPageSetupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetablecellformat"></a>
# **UpdateTableCellFormat**
> AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse UpdateTableCellFormat (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTableCellFormatDto format, string tableRowPath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates a table cell format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class UpdateTableCellFormatExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var format = new AsposeWordsCloudDTODocumentElementsTablesTableCellFormatDto(); // AsposeWordsCloudDTODocumentElementsTablesTableCellFormatDto | The properties.
            var tableRowPath = tableRowPath_example;  // string | Path to table row.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates a table cell format.
                AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse result = apiInstance.UpdateTableCellFormat(version, name, format, tableRowPath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.UpdateTableCellFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **format** | [**AsposeWordsCloudDTODocumentElementsTablesTableCellFormatDto**](AsposeWordsCloudDTODocumentElementsTablesTableCellFormatDto.md)| The properties. | 
 **tableRowPath** | **string**| Path to table row. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse**](AsposeWordsCloudDTODocumentElementsTablesTableCellFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetableproperties"></a>
# **UpdateTableProperties**
> AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse UpdateTableProperties (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTablePropertiesDto properties, int? index, string nodePath, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates a table properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class UpdateTablePropertiesExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var properties = new AsposeWordsCloudDTODocumentElementsTablesTablePropertiesDto(); // AsposeWordsCloudDTODocumentElementsTablesTablePropertiesDto | The properties.
            var index = 56;  // int? | Object index
            var nodePath = nodePath_example;  // string | Path to node, which contains tables.
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates a table properties.
                AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse result = apiInstance.UpdateTableProperties(version, name, properties, index, nodePath, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.UpdateTableProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **properties** | [**AsposeWordsCloudDTODocumentElementsTablesTablePropertiesDto**](AsposeWordsCloudDTODocumentElementsTablesTablePropertiesDto.md)| The properties. | 
 **index** | **int?**| Object index | 
 **nodePath** | **string**| Path to node, which contains tables. | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse**](AsposeWordsCloudDTODocumentElementsTablesTablePropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetablerowformat"></a>
# **UpdateTableRowFormat**
> AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse UpdateTableRowFormat (string version, string name, AsposeWordsCloudDTODocumentElementsTablesTableRowFormatDto format, string tablePath, int? index, string destFileName = null, string storage = null, string folder = null, string loadEncoding = null, string revisionAuthor = null, string revisionDateTime = null, string password = null)

Updates a table row format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.com.aspose;

namespace Example
{
    public class UpdateTableRowFormatExample
    {
        public void main()
        {
            var apiInstance = new WordsApi();
            var version = version_example;  // string | Api version.
            var name = name_example;  // string | The document name.
            var format = new AsposeWordsCloudDTODocumentElementsTablesTableRowFormatDto(); // AsposeWordsCloudDTODocumentElementsTablesTableRowFormatDto | Table row format.
            var tablePath = tablePath_example;  // string | Path to table.
            var index = 56;  // int? | Object index
            var destFileName = destFileName_example;  // string | Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional) 
            var storage = storage_example;  // string | File storage, which have to be used. (optional) 
            var folder = folder_example;  // string | Original document folder. (optional) 
            var loadEncoding = loadEncoding_example;  // string | Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. (optional) 
            var revisionAuthor = revisionAuthor_example;  // string | Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. (optional) 
            var revisionDateTime = revisionDateTime_example;  // string | The date and time to use for revisions. (optional) 
            var password = password_example;  // string | Password for opening an encrypted document. (optional) 

            try
            {
                // Updates a table row format.
                AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse result = apiInstance.UpdateTableRowFormat(version, name, format, tablePath, index, destFileName, storage, folder, loadEncoding, revisionAuthor, revisionDateTime, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordsApi.UpdateTableRowFormat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| Api version. | 
 **name** | **string**| The document name. | 
 **format** | [**AsposeWordsCloudDTODocumentElementsTablesTableRowFormatDto**](AsposeWordsCloudDTODocumentElementsTablesTableRowFormatDto.md)| Table row format. | 
 **tablePath** | **string**| Path to table. | 
 **index** | **int?**| Object index | 
 **destFileName** | **string**| Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. | [optional] 
 **storage** | **string**| File storage, which have to be used. | [optional] 
 **folder** | **string**| Original document folder. | [optional] 
 **loadEncoding** | **string**| Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML. | [optional] 
 **revisionAuthor** | **string**| Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions. | [optional] 
 **revisionDateTime** | **string**| The date and time to use for revisions. | [optional] 
 **password** | **string**| Password for opening an encrypted document. | [optional] 

### Return type

[**AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse**](AsposeWordsCloudDTODocumentElementsTablesTableRowFormatResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

