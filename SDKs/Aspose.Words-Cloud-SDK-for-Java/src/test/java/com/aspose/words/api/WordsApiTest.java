/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.aspose.words.api;

import static org.junit.Assert.assertNull;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import com.aspose.storage.api.StorageApi;
import com.aspose.words.client.ApiException;
import com.aspose.words.model.BookmarkData;
import com.aspose.words.model.BookmarkResponse;
import com.aspose.words.model.BookmarksResponse;
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
import com.aspose.words.model.FormField;
import com.aspose.words.model.FormFieldResponse;
import com.aspose.words.model.HyperlinkResponse;
import com.aspose.words.model.HyperlinksResponse;
import com.aspose.words.model.LoadWebDocumentData;
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
import com.aspose.words.model.SectionLinkCollectionResponse;
import com.aspose.words.model.SectionPageSetupResponse;
import com.aspose.words.model.SectionResponse;
import com.aspose.words.model.SplitDocumentResponse;
import com.aspose.words.model.StatDataResponse;
import com.aspose.words.model.TextItemsResponse;
import com.aspose.words.model.TiffSaveOptionsData;
import com.aspose.words.model.WatermarkText;

/**
 *
 * @author Imran Anwar
 * @author Farooq Sheikh
 */
public class WordsApiTest {

	static WordsApi wordsApi;
	static StorageApi storageApi;
	// Please get the appSID and apiKey from https://cloud.aspose.com
	static String appSID = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
	static String apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

	public WordsApiTest() {
	}

	@BeforeClass
	public static void setUpClass() {
	        try {
	                   wordsApi = new WordsApi("http://api.aspose.cloud/v1.1",apiKey,appSID);
	                   storageApi = new StorageApi("http://api.aspose.cloud/v1.1",apiKey,appSID);
	                   storageApi.PutCreate("SampleWordDocument.docx", "", "", new File(WordsApiTest.class.getResource("/test_multi_pages.docx").toURI()));
	                   storageApi.PutCreate("test_multi_pages.docx", "", "", new File(WordsApiTest.class.getResource("/test_multi_pages.docx").toURI()));
	                   storageApi.PutCreate("test_convertlocal.docx", "", "", new File(WordsApiTest.class.getResource("/test_convertlocal.docx").toURI()));
	                   storageApi.PutCreate("test_doc.docx", "", "", new File(WordsApiTest.class.getResource("/test_doc.docx").toURI()));
	                   storageApi.PutCreate("test_uploadfile.docx", "", "", new File(WordsApiTest.class.getResource("/test_uploadfile.docx").toURI()));
	                   storageApi.PutCreate("test_multi_pages.docx", "", "", new File(WordsApiTest.class.getResource("/test_multi_pages.docx").toURI()));
	                   storageApi.PutCreate("SampleMailMergeTemplate.docx", "", "", new File(WordsApiTest.class.getResource("/SampleMailMergeTemplate.docx").toURI()));
	                        
	                } catch (Exception e) {
	                        // TODO Auto-generated catch block
	                        e.printStackTrace();
	                }
	}

	@AfterClass
	public static void tearDownClass() {
	}

	@Before
	public void setUp() {
	}

	@After
	public void tearDown() {
	}

	/**
	 * Test of GetDocumentBookmarkByName method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentBookmarkByName() {
		System.out.println("GetDocumentBookmarkByName");
		String name = "test_multi_pages.docx";
		String bookmarkName = "aspose";
		String storage = "";
		String folder = "";
		try {
			
			BookmarkResponse result = wordsApi.GetDocumentBookmarkByName(name, bookmarkName, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentBookmarks method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentBookmarks() {
		System.out.println("GetDocumentBookmarks");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			BookmarksResponse result = wordsApi.GetDocumentBookmarks(name, storage, folder);
		
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostUpdateDocumentBookmark method, of class WordsApi.
	 */
	@Test
	public void testPostUpdateDocumentBookmark() {
		System.out.println("PostUpdateDocumentBookmark");
		String name = "test_multi_pages.docx";
		String bookmarkName = "aspose";
		String filename = "test.docx";
		String storage = "";
		String folder = "";
		BookmarkData body = new BookmarkData();
		body.setName("aspose");
		body.setText("This is updated Bookmark");
		try {
			BookmarkResponse result = wordsApi.PostUpdateDocumentBookmark(name, bookmarkName, filename, storage, folder, body);			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocument method, of class WordsApi.
	 */
	@Test
	public void testGetDocument() {
		System.out.println("GetDocument");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			ResponseMessage result = wordsApi.GetDocument(name, storage, folder);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentWithFormat method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentWithFormat() {
		System.out.println("GetDocumentWithFormat");
		String name = "test_multi_pages.docx";
		String format = "text";
		String storage = "";
		String folder = "";
		String outPath = "";
		try {
			ResponseMessage result = wordsApi.GetDocumentWithFormat(name, format, storage, folder, outPath);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostAppendDocument method, of class WordsApi.
	 */
	@Test
	public void testPostAppendDocument() {
		System.out.println("PostAppendDocument");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		DocumentEntryList body = new DocumentEntryList();
		List<com.aspose.words.model.DocumentEntry> docEntries = new ArrayList();
		
		com.aspose.words.model.DocumentEntry docEntry = new com.aspose.words.model.DocumentEntry();
		docEntry.setHref("test_multi_pages.docx");
		docEntry.setImportFormatMode("KeepSourceFormatting");
		docEntries.add(docEntry);		
		body.setDocumentEntries(docEntries);
		
		try {
			DocumentResponse result = wordsApi.PostAppendDocument(name, filename, storage, folder, body);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostExecuteTemplate method, of class WordsApi.
	 */
	@Test
	public void testPostExecuteTemplate() {
		System.out.println("PostExecuteTemplate");
		String name = "TestExecuteTemplate.doc";
		String cleanup = null;
		String filename = "TestExecuteResult.doc";
		String storage = null;
		String folder = null;
		Boolean useWholeParagraphAsRegion = null;
		Boolean withRegions = null;
		File file;
		try {
			file = new File(getClass().getResource("/TestExecuteTemplateData.txt").toURI());
			storageApi.PutCreate("TestExecuteTemplate.doc", "", "", new File(getClass().getResource("/TestExecuteTemplate.doc").toURI()));
			DocumentResponse result = wordsApi.PostExecuteTemplate(name, cleanup, filename, storage, folder, useWholeParagraphAsRegion, withRegions, file);			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} 

	}

	/**
	 * Test of PostInsertPageNumbers method, of class WordsApi.
	 */
	@Test
	public void testPostInsertPageNumbers() {
		System.out.println("PostInsertPageNumbers");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		PageNumber body = new PageNumber();
		body.setFormat("{PAGE} of {NUMPAGES}");
		body.setAlignment("center");
		try {
			DocumentResponse result = wordsApi.PostInsertPageNumbers(name, filename, storage, folder, body);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostInsertWatermarkImage method, of class WordsApi.
	 */
	@Test
	public void testPostInsertWatermarkImage() {
		System.out.println("PostInsertWatermarkImage");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		Double rotationAngle = null;
		String image = "aspose-cloud.png";
		String storage = "";
		String folder = "";
		File file;
		try {
		        
			file = new File(getClass().getResource("/aspose-cloud.png").toURI());
			storageApi.PutCreate("aspose-cloud.png", "", "", new File(getClass().getResource("/aspose-cloud.png").toURI()));
			DocumentResponse result = wordsApi.PostInsertWatermarkImage(name, filename, rotationAngle, image, storage, folder, file);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} catch(java.net.URISyntaxException uriExp){
			System.out.println("uri exp:" + uriExp.getMessage());
		}

	}

	/**
	 * Test of PostInsertWatermarkText method, of class WordsApi.
	 */
	@Test
	public void testPostInsertWatermarkText() {
		System.out.println("PostInsertWatermarkText");
		String name = "test_multi_pages.docx";
		String text = "New";
		Double rotationAngle = 90.0;
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		WatermarkText body = new WatermarkText();
		body.setText("text");
		try {
			DocumentResponse result = wordsApi.PostInsertWatermarkText(name, text, rotationAngle, filename, storage, folder, body);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostLoadWebDocument method, of class WordsApi.
	 */
	@Test
	public void testPostLoadWebDocument() {
		System.out.println("PostLoadWebDocument");
		LoadWebDocumentData loadWebDocumentData = new LoadWebDocumentData();
		loadWebDocumentData.setLoadingDocumentUrl("http://google.com");
		SaveOptions saveOptions = new SaveOptions();
		saveOptions.setSaveFormat("doc");
		saveOptions.setFileName("google.doc");
		loadWebDocumentData.setSaveOptions(saveOptions);
		try {
			SaveResponse result = wordsApi.PostLoadWebDocument(loadWebDocumentData);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostSplitDocument method, of class WordsApi.
	 */
	@Test
	public void testPostSplitDocument() {
		System.out.println("PostSplitDocument");
		String name = "test_multi_pages.docx";
		String format = "text";
		Integer from = 1;
		Integer to = 2;
		Boolean zipOutput = false;
		String storage = "";
		String folder = "";
		try {
			SplitDocumentResponse result = wordsApi.PostSplitDocument(name, format, from, to, zipOutput, storage, folder);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PutConvertDocument method, of class WordsApi.
	 */
	@Test
	public void testPutConvertDocument() {
		System.out.println("PutConvertDocument");
		String format = "text";
		String outPath = "";
		File file;
		try {
			file = new File(getClass().getResource("/test_uploadfile.docx").toURI());
			ResponseMessage result = wordsApi.PutConvertDocument(format, outPath, file);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} catch(java.net.URISyntaxException uriExp){
			System.out.println("uri exp:" + uriExp.getMessage());
		}

	}

	/**
	 * Test of PutExecuteMailMergeOnline method, of class WordsApi.
	 */
	@Test
	public void testPutExecuteMailMergeOnline() {
		System.out.println("PutExecuteMailMergeOnline");
		Boolean withRegions = false;
		String cleanup = "yes";
		File file;
		File data;
		try {
			file = new File(getClass().getResource("/SampleMailMergeTemplate.docx").toURI());
			data = new File(getClass().getResource("/SampleMailMergeTemplateData.txt").toURI());
			ResponseMessage result = wordsApi.PutExecuteMailMergeOnline(withRegions, cleanup, file,data);
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} 

	}

	/**
	 * Test of PostUpdateDocumentFields method, of class WordsApi.
	 */
	@Test
	public void testPostUpdateDocumentFields() {
		System.out.println("PostUpdateDocumentFields");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			DocumentResponse result = wordsApi.PostUpdateDocumentFields(name, filename, storage, folder);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of DeleteDocumentProperty method, of class WordsApi.
	 */
	@Test
	public void testDeleteDocumentProperty() {
		System.out.println("DeleteDocumentProperty");
		String name = "test_multi_pages.docx";
		String propertyName = "AsposeAuthor";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		DocumentProperty body = new DocumentProperty();
                body.setName("AsposeAuthor");
                body.setValue("Farooq Sheikh");
                body.setBuiltIn(false);
		try {
		        wordsApi.PutUpdateDocumentProperty(name, propertyName, filename, storage, folder, body);
			SaaSposeResponse result = wordsApi.DeleteDocumentProperty(name, propertyName, filename, storage, folder);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentProperties method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentProperties() {
		System.out.println("GetDocumentProperties");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			DocumentPropertiesResponse result = wordsApi.GetDocumentProperties(name, storage, folder);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentProperty method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentProperty() {
		System.out.println("GetDocumentProperty");
		String name = "test_multi_pages.docx";
		String propertyName = "Author";
		String storage = "";
		String folder = "";
		try {
			DocumentPropertyResponse result = wordsApi.GetDocumentProperty(name, propertyName, storage, folder);
		
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PutUpdateDocumentProperty method, of class WordsApi.
	 */
	@Test
	public void testPutUpdateDocumentProperty() {
		System.out.println("PutUpdateDocumentProperty");
		String name = "test_multi_pages.docx";
		String propertyName = "Author";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		DocumentProperty body = new DocumentProperty();
		body.setName("Author");
		body.setValue("Imran Anwar");
		try {
			DocumentPropertyResponse result = wordsApi.PutUpdateDocumentProperty(name, propertyName, filename, storage, folder, body);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of DeleteUnprotectDocument method, of class WordsApi.
	 */
	@Test
	public void testDeleteUnprotectDocument() {
		System.out.println("DeleteUnprotectDocument");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		ProtectionRequest body = new ProtectionRequest();
		body.setPassword("aspose");
		try {
		       // wordsApi.PutProtectDocument(name, filename, storage, folder, body);
			// ProtectionDataResponse result = wordsApi.DeleteUnprotectDocument(name, filename, storage, folder, body);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentProtection method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentProtection() {
		System.out.println("GetDocumentProtection");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			ProtectionDataResponse result = wordsApi.GetDocumentProtection(name, storage, folder);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostChangeDocumentProtection method, of class WordsApi.
	 */
	@Test
	public void testPostChangeDocumentProtection() {
		System.out.println("PostChangeDocumentProtection");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		ProtectionRequest body = new ProtectionRequest();
		body.setNewPassword("");
		try {
			ProtectionDataResponse result = wordsApi.PostChangeDocumentProtection(name, filename, storage, folder, body);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PutProtectDocument method, of class WordsApi.
	 */
	@Test
	public void testPutProtectDocument() {
		System.out.println("PutProtectDocument");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		ProtectionRequest body = new ProtectionRequest();
		try {
			ProtectionDataResponse result = wordsApi.PutProtectDocument(name, filename, storage, folder, body);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostDocumentSaveAs method, of class WordsApi.
	 */
	@Test
	public void testPostDocumentSaveAs() {
		System.out.println("PostDocumentSaveAs");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		
		String xml = "<PdfSaveOptions>" +
		                    "<SaveFormat>pdf</SaveFormat>" +
		                    "<FileName>Output.pdf</FileName>" +
		                    "<ImageCompression>Jpeg</ImageCompression>" +
		                    "<JpegQuality>70</JpegQuality>" +
		                      "<TextCompression>Flate</TextCompression>" +
		                 "</PdfSaveOptions>";
		                    
		try {   
			SaveResponse result = wordsApi.PostDocumentSaveAs(name, storage, folder, xml.getBytes("UTF-8"));
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PutDocumentSaveAsTiff method, of class WordsApi.
	 */
	@Test
	public void testPutDocumentSaveAsTiff() {
		System.out.println("PutDocumentSaveAsTiff");
		String name = "test_multi_pages.docx";
		String resultFile = "test.docx";
		Boolean useAntiAliasing = false;
		Boolean useHighQualityRendering = false;
		Float imageBrightness = null;
		String imageColorMode = null;
		Float imageContrast =null;
		String numeralFormat = null;
		Integer pageCount = null;
		Integer pageIndex = null;
		String paperColor = null;
		String pixelFormat = null;
		Float resolution = null;
		Float scale = null;
		String tiffCompression = null;
		String dmlRenderingMode = null;
		String dmlEffectsRenderingMode = null;
		String tiffBinarizationMethod = null;
		String storage = null;
		String folder = null;
		Boolean zipOutput = false;
		TiffSaveOptionsData body = new TiffSaveOptionsData();
		body.setSaveFormat("tiff");
		body.setFileName("abc.tiff");
		try {
			SaveResponse result = wordsApi.PutDocumentSaveAsTiff(name, resultFile, useAntiAliasing, useHighQualityRendering, imageBrightness, imageColorMode, imageContrast, numeralFormat, pageCount, pageIndex, paperColor, pixelFormat, resolution, scale, tiffCompression, dmlRenderingMode, dmlEffectsRenderingMode, tiffBinarizationMethod, storage, folder, zipOutput, body);
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentStatistics method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentStatistics() {
		System.out.println("GetDocumentStatistics");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			StatDataResponse result = wordsApi.GetDocumentStatistics(name, storage, folder);
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of DeleteDocumentWatermark method, of class WordsApi.
	 */
	@Test
	public void testDeleteDocumentWatermark() {
		System.out.println("DeleteDocumentWatermark");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		String storage = "";
		String folder = "";
		try {
			DocumentResponse result = wordsApi.DeleteDocumentWatermark(name, filename, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostInsertDocumentWatermarkImage method, of class WordsApi.
	 */
	@Test
	public void testPostInsertDocumentWatermarkImage() {
		System.out.println("PostInsertDocumentWatermarkImage");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		Double rotationAngle = null;
		String image = "aspose-cloud.png";
		String storage = null;
		String folder = null;
		File file;		
		
		try {
		        storageApi.PutCreate("aspose-cloud.png", "", "", new File(getClass().getResource("/aspose-cloud.png").toURI()));
			file = new File(getClass().getResource("/aspose-cloud.png").toURI());
			DocumentResponse result = wordsApi.PostInsertDocumentWatermarkImage(name, filename, rotationAngle, image, storage, folder, file);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} catch(java.net.URISyntaxException uriExp){
			System.out.println("uri exp:" + uriExp.getMessage());
		}
		
	}

	/**
	 * Test of PostInsertDocumentWatermarkText method, of class WordsApi.
	 */
	@Test
	public void testPostInsertDocumentWatermarkText() {
		System.out.println("PostInsertDocumentWatermarkText");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		String text = "test";
		Double rotationAngle = 60.0;
		String storage = "";
		String folder = "";
		WatermarkText body = new WatermarkText();
		body.setText("Aspose.com");
		try {
			DocumentResponse result = wordsApi.PostInsertDocumentWatermarkText(name, filename, text, rotationAngle, storage, folder, body);

		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentDrawingObjectByIndex method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentDrawingObjectByIndex() {
		System.out.println("GetDocumentDrawingObjectByIndex");
		String name = "sample_EmbeddedOLE.docx";
		Integer objectIndex = 0;
		String storage = "";
		String folder = "";
		try {
			 DrawingObjectResponse result = wordsApi.GetDocumentDrawingObjectByIndex(name, objectIndex, storage, folder);
			 System.out.println(result.getStatus());
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentDrawingObjectByIndexWithFormat method, of class
	 * WordsApi.
	 */
	@Test
	public void testGetDocumentDrawingObjectByIndexWithFormat() {
		System.out.println("GetDocumentDrawingObjectByIndexWithFormat");
		String name = "test_multi_pages.docx";
		Integer objectIndex = 0;
		String format = "png";
		String storage = "";
		String folder = "";
		try {
			  ResponseMessage result = wordsApi.GetDocumentDrawingObjectByIndexWithFormat(name, objectIndex, format, storage, folder);
			System.out.println(result.getStatus());
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentDrawingObjectImageData method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentDrawingObjectImageData() {
		System.out.println("GetDocumentDrawingObjectImageData");
		String name = "SampleWordDocument.docx";
		Integer objectIndex = 0;
		String storage = "";
		String folder = "";
		try {
			ResponseMessage result = wordsApi.GetDocumentDrawingObjectImageData(name, objectIndex, storage, folder);
			System.out.println(result.getMessage());
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentDrawingObjectOleData method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentDrawingObjectOleData() {
		System.out.println("GetDocumentDrawingObjectOleData");
		String name = "sample_EmbeddedOLE.docx";
		Integer objectIndex = 0;
		String storage = "";
		String folder = "";
		try {
		        storageApi.PutCreate("sample_EmbeddedOLE.docx", "", "", new File(getClass().getResource("/sample_EmbeddedOLE.docx").toURI()));
			ResponseMessage result = wordsApi.GetDocumentDrawingObjectOleData(name, objectIndex, storage, folder);
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentDrawingObjects method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentDrawingObjects() {
		System.out.println("GetDocumentDrawingObjects");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			DrawingObjectsResponse result = wordsApi.GetDocumentDrawingObjects(name, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of DeleteFormField method, of class WordsApi.
	 */
	@Test
	public void testDeleteFormField() {
		System.out.println("DeleteFormField");
		String name = "FormFilled.docx";
		Integer sectionIndex = 0;
		Integer paragraphIndex = 0;
		Integer formfieldIndex = 0;
		String destFileName = "FormFilledTest.docx";
		String storage = "";
		String folder = "";
		try {
		        storageApi.PutCreate("FormFilled.docx", "", "", new File(getClass().getResource("/FormFilled.docx").toURI()));
			SaaSposeResponse result = wordsApi.DeleteFormField(name, sectionIndex, paragraphIndex, formfieldIndex, destFileName, storage, folder);
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetFormField method, of class WordsApi.
	 */
	@Test
	public void testGetFormField() {
		System.out.println("GetFormField");
		String name = "FormFilled.docx";
		Integer sectionIndex = 0;
		Integer paragraphIndex = 0;
		Integer formfieldIndex = 0;
		String storage = "";
		String folder = "";
		try {
		        storageApi.PutCreate("FormFilled.docx", "", "", new File(getClass().getResource("/FormFilled.docx").toURI()));
			FormFieldResponse result = wordsApi.GetFormField(name, sectionIndex, paragraphIndex, formfieldIndex, storage, folder);
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostFormField method, of class WordsApi.
	 */
	@Test
	public void testPostFormField() {
		System.out.println("PostFormField");
		String name = "FormFilled.docx";
		Integer sectionIndex = 0;
		Integer paragraphIndex = 0;
		Integer formfieldIndex = 0;
		String destFileName = "FormFilledTest.docx";
		String storage = "";
		String folder = "";
		FormField body = null;
		try {
		      /*  storageApi.PutCreate("FormFilled.docx", "", "", new File(getClass().getResource("/FormFilled.docx").toURI()));
		        FormFieldResponse result = wordsApi.GetFormField(name, sectionIndex, paragraphIndex, formfieldIndex, storage, folder);
		        if(result!=null && result.getFormField() !=null){
		                body = result.getFormField();
		                body.setHelpText(body.getHelpText() + "updated");
		                FormFieldResponse result2 = wordsApi.PostFormField(name, sectionIndex, paragraphIndex, formfieldIndex, destFileName, storage, folder, body);
		        }
			*/
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PutFormField method, of class WordsApi.
	 */
	@Test
	public void testPutFormField() {
		System.out.println("PutFormField");
		String name = "test_doc.docx";
		Integer sectionIndex = 0;
		Integer paragraphIndex = 0;
		String insertBeforeNode = "";
		String destFileName = "test.docx";
		String storage = "";
		String folder = "";
		
		  String xml = "<FormFieldTextInput>"
                                  + "<Name>MyName</Name>"
                                  + "<Enabled>true</Enabled>"
                                  + "<StatusText />"
                                  + "<OwnStatus>false</OwnStatus>"
                                  + "<HelpText />"
                                  + "<OwnHelp>false</OwnHelp>"
                                  + "<CalculateOnExit>true</CalculateOnExit>"
                                  + "<EntryMacro />"
                                  + "<ExitMacro />"
                                  + "<TextInputFormat>UPPERCASE</TextInputFormat>"
                                  + "<TextInputType>Regular</TextInputType>"
                                  + "<TextInputDefault>Farooq Sheikh</TextInputDefault>"
                                  + "</FormFieldTextInput>";
		  
		try {
			FormFieldResponse result = wordsApi.PutFormField(name, sectionIndex, paragraphIndex, insertBeforeNode, destFileName, storage, folder, xml.getBytes("UTF-8"));
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of DeleteHeadersFooters method, of class WordsApi.
	 */
	@Test
	public void testDeleteHeadersFooters() {
		System.out.println("DeleteHeadersFooters");
		String name = "test_multi_pages.docx";
		String headersFootersTypes = null;
		String filename = "test.docx";
		String storage = "";
		String folder = "";
		try {

			SaaSposeResponse result = wordsApi.DeleteHeadersFooters(name, headersFootersTypes, filename, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentHyperlinkByIndex method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentHyperlinkByIndex() {
		System.out.println("GetDocumentHyperlinkByIndex");
		String name = "test_doc.docx";
		Integer hyperlinkIndex = 0;
		String storage = "";
		String folder = "";
		try {
		        storageApi.PutCreate(name, "", "", new File(getClass().getResource("/test_doc.docx").toURI()));
		        HyperlinkResponse result = wordsApi.GetDocumentHyperlinkByIndex(name, hyperlinkIndex, storage, folder);
			
			
		} catch (Exception apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentHyperlinks method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentHyperlinks() {
		System.out.println("GetDocumentHyperlinks");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {

			HyperlinksResponse result = wordsApi.GetDocumentHyperlinks(name, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentFieldNames method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentFieldNames() {
		System.out.println("GetDocumentFieldNames");
		String name = "test_multi_pages.docx";
		Boolean useNonMergeFields = false;
		String storage = "";
		String folder = "";
		try {

			FieldNamesResponse result = wordsApi.GetDocumentFieldNames(name, useNonMergeFields, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostDocumentExecuteMailMerge method, of class WordsApi.
	 */
	@Test
	public void testPostDocumentExecuteMailMerge() {
		System.out.println("PostDocumentExecuteMailMerge");
		String name = "SampleMailMergeTemplate.docx";
		Boolean withRegions = false;
		String mailMergeDataFile = null;
		String cleanup = null;
		String filename = "SampleMailMergeResult.docx";
		String storage = null;
		String folder = null;
		Boolean useWholeParagraphAsRegion = false;
		File file;
		try {
			file = new File(getClass().getResource("/SampleMailMergeTemplateData.txt").toURI());	          
			DocumentResponse result = wordsApi.PostDocumentExecuteMailMerge(name, withRegions, mailMergeDataFile, cleanup, filename, storage, folder, useWholeParagraphAsRegion, file);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		} catch(java.net.URISyntaxException uriExp){
			System.out.println("uri exp:" + uriExp.getMessage());
		}


	}

	/**
	 * Test of GetDocumentParagraph method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentParagraph() {
		System.out.println("GetDocumentParagraph");
		String name = "test_multi_pages.docx";
		Integer index = 1;
		String storage = "";
		String folder = "";
		try {
			ParagraphResponse result = wordsApi.GetDocumentParagraph(name, index, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentParagraphRun method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentParagraphRun() {
		System.out.println("GetDocumentParagraphRun");
		String name = "test_multi_pages.docx";
		Integer index = 0;
		Integer runIndex = 0;
		String storage = "";
		String folder = "";
		try {

			RunResponse result = wordsApi.GetDocumentParagraphRun(name, index, runIndex, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentParagraphRunFont method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentParagraphRunFont() {
		System.out.println("GetDocumentParagraphRunFont");
		String name = "test_multi_pages.docx";
		Integer index = 0;
		Integer runIndex = 0;
		String storage = "";
		String folder = "";
		try {

			FontResponse result = wordsApi.GetDocumentParagraphRunFont(name, index, runIndex, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentParagraphs method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentParagraphs() {
		System.out.println("GetDocumentParagraphs");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {
			
			ParagraphLinkCollectionResponse result = wordsApi.GetDocumentParagraphs(name, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostDocumentParagraphRunFont method, of class WordsApi.
	 */
	@Test
	public void testPostDocumentParagraphRunFont() {
		System.out.println("PostDocumentParagraphRunFont");
		String name = "test_multi_pages.docx";
		Integer index = 0;
		Integer runIndex = 0;
		String storage = "";
		String folder = "";
		String filename = "test.docx";
		Font body = new Font();
		body.setBold(true);
		try {

			FontResponse result = wordsApi.PostDocumentParagraphRunFont(name, index, runIndex, storage, folder, filename, body);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of AcceptAllRevisions method, of class WordsApi.
	 */
	@Test
	public void testAcceptAllRevisions() {
		System.out.println("AcceptAllRevisions");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		String storage = "";
		String folder = "";
		try {

			RevisionsModificationResponse result = wordsApi.AcceptAllRevisions(name, filename, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of RejectAllRevisions method, of class WordsApi.
	 */
	@Test
	public void testRejectAllRevisions() {
		System.out.println("RejectAllRevisions");
		String name = "test_multi_pages.docx";
		String filename = "test.docx";
		String storage = "";
		String folder = "";
		try {

			RevisionsModificationResponse result = wordsApi.RejectAllRevisions(name, filename, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetSection method, of class WordsApi.
	 */
	@Test
	public void testGetSection() {
		System.out.println("GetSection");
		String name = "test_multi_pages.docx";
		Integer sectionIndex = 0;
		String storage = "";
		String folder = "";
		try {

			SectionResponse result = wordsApi.GetSection(name, sectionIndex, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetSectionPageSetup method, of class WordsApi.
	 */
	@Test
	public void testGetSectionPageSetup() {
		System.out.println("GetSectionPageSetup");
		String name = "test_multi_pages.docx";
		Integer sectionIndex = 0;
		String storage = "";
		String folder = "";
		try {

			SectionPageSetupResponse result = wordsApi.GetSectionPageSetup(name, sectionIndex, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetSections method, of class WordsApi.
	 */
	@Test
	public void testGetSections() {
		System.out.println("GetSections");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {

			SectionLinkCollectionResponse result = wordsApi.GetSections(name, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of UpdateSectionPageSetup method, of class WordsApi.
	 */
	@Test
	public void testUpdateSectionPageSetup() {
		System.out.println("UpdateSectionPageSetup");
		String name = "test_multi_pages.docx";
		Integer sectionIndex = 0;
		String storage = "";
		String folder = "";
		String filename = "";
		PageSetup body = new PageSetup();
		body.setRtlGutter(true);
		body.setLeftMargin(10.0);
		body.setOrientation("Landscape");
		body.setPaperSize("A5");
		
		try {

			SectionPageSetupResponse result = wordsApi.UpdateSectionPageSetup(name, sectionIndex, storage, folder, filename, body);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of GetDocumentTextItems method, of class WordsApi.
	 */
	@Test
	public void testGetDocumentTextItems() {
		System.out.println("GetDocumentTextItems");
		String name = "test_multi_pages.docx";
		String storage = "";
		String folder = "";
		try {

			TextItemsResponse result = wordsApi.GetDocumentTextItems(name, storage, folder);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}

	/**
	 * Test of PostReplaceText method, of class WordsApi.
	 */
	@Test
	public void testPostReplaceText() {
		System.out.println("PostReplaceText");
		String name = "test_multi_pages.docx";
		String filename = "test_multi_pages_result.docx";
		String storage = "";
		String folder = "";
		ReplaceTextRequest body = new ReplaceTextRequest();
		body.setOldValue("aspose");
		body.setNewValue("aspose.com");
		try {
			
			ReplaceTextResponse result = wordsApi.PostReplaceText(name, filename, storage, folder, body);
			
			
		} catch (ApiException apiException) {
			System.out.println("exp:" + apiException.getMessage());
			assertNull(apiException);
		}
	}
}
