<?php

require_once realpath(__DIR__) . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class WordsApiTest extends PHPUnit_Framework_TestCase {
    
    protected $words;

    protected function setUp()
    {        
        AsposeApp::$appSID = Utils::appSID;
        AsposeApp::$apiKey = Utils::apiKey;
        $this->words = new WordsApi();
    }
    
    public function testAcceptAllRevisions()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->AcceptAllRevisions($name, $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentFields()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteDocumentFields($name, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentMacros()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteDocumentMacros($name, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentProperty()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteDocumentProperty($name, $propertyName="Test", $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentWatermark()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteDocumentWatermark($name, $filename = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteFormField()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "FormFilled.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteFormField($name, $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteHeadersFooters()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteHeadersFooters($name, $headersFootersTypes = null, $filename = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteParagraphFields()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteParagraphFields($name, $index=1, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteSectionFields()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);    

        $result = $this->words->DeleteSectionFields($name, $sectionIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteSectionParagraphFields()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->DeleteSectionParagraphFields($name, $sectionIndex="0", $paragraphIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteUnprotectDocument()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = array("Password"=>"123456");
        $result = $this->words->DeleteUnprotectDocument($name, $filename = null, $storage = null, $folder = null, $body);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocument()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocument($name, $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentBookmarkByName()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentBookmarkByName($name, $bookmarkName="_GoBack", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentBookmarks()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentBookmarks($name, $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentDrawingObjectByIndex()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "OLE.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentDrawingObjectByIndex($name, $objectIndex="0", $storage = null, $folder = null);                
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjectByIndexWithFormat()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "OLE.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentDrawingObjectByIndexWithFormat($name, $objectIndex="0", $format="png", $storage = null, $folder = null);
        $fh = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/Output/OLE.png', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/../../../../../Data/Output/OLE.png');
    }
    
    public function testGetDocumentDrawingObjectImageData()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "OLE.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentDrawingObjectImageData($name, $objectIndex="0", $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjectOleData()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "OLE.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentDrawingObjectOleData($name, $objectIndex="0", $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjects()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "OLE.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentDrawingObjects($name, $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentHyperlinkByIndex()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentHyperlinkByIndex($name, $hyperlinkIndex=1, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentHyperlinks()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentHyperlinks($name, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraph()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "test_multi_pages.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentParagraph($name, $index=1, $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphRun()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "test_multi_pages.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentParagraphRun($name, $index="0", $runIndex="0", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphRunFont()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentParagraphRunFont($name, $index="0", $runIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphs()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentParagraphs($name, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProperties()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentProperties($name, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProperty()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentProperty($name, $propertyName="Author", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProtection()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentProtection($name, $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentStatistics()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentStatistics($name, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentTextItems()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentTextItems($name, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentWithFormat()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetDocumentWithFormat($name, $format="pdf", $storage = null, $folder = null, $outPath = null);  
        $fh = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/Output/Test.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/../../../../../Data/Output/Test.pdf');
    }
    
    public function testGetFormField()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "FormFilled.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetFormField($name, $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSection()
    {   
        // Upload file to Aspose Cloud Storage    
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetSection($name, $sectionIndex='0', $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSectionPageSetup()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetSectionPageSetup($name, $sectionIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSections()
    {   
        // Upload file to Aspose Cloud Storage    
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->GetSections($name, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostAppendDocument()
    {   
        // Upload file to Aspose Cloud Storage    
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);
        Utils::uploadFile("test_multi_pages.docx");

        $appendDocs = array("test_multi_pages.docx");
        $importFormatsModes = array("KeepSourceFormatting", "UseDestinationStyles");

        $body = '{ "DocumentEntries": [';
        for ($i = 0; $i < count($appendDocs); $i++) {
            $body .= '{ "Href": "' . $appendDocs[$i] .
                    '", "ImportFormatMode": "' . $importFormatsModes[$i] . '" }' .
                    (($i < (count($appendDocs) - 1)) ? ',' : '');
        }
        $body .= '  ] }';
        
        $result = $this->words->PostAppendDocument($name, $filename = null, $storage = null, $folder = null, $body);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostChangeDocumentProtection()
    {   
        // Upload file to Aspose Cloud Storage    
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = array("Password" => "123456", "NewPassword" => "123456789");
        $result = $this->words->PostChangeDocumentProtection($name, $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentExecuteMailMerge()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleMailMergeTemplate.docx";
        Utils::uploadFile($name);

        $file = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/SampleMailMergeTemplateData.xml', 'w');
        $result = $this->words->PostDocumentExecuteMailMerge($name, $withRegions='false', $mailMergeDataFile = null, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentParagraphRunFont()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = '{
                    "Font:" {
                        "Name": "Calibri"
                    }
                  }';
        $result = $this->words->PostDocumentParagraphRunFont($name, $index="0", $runIndex="0", $storage = null, $folder = null, $filename = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentSaveAs()
    {   
        // Upload file to Aspose Cloud Storage 
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = '{
                    "SaveFormat": "pdf",
                    "FileName": "Test.pdf",
                    "ImageCompression": "Jpeg",
                    "JpegQuality": 70,
                    "TextCompression": "Flate"
                 }';

        $response = $this->words->PostDocumentSaveAs($name, $storage = null, $folder = null, $body);
        $result = json_decode($response);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostFormField()
    {
        // Upload file to Aspose Cloud Storage
        $name = "FormFilled.docx";
        Utils::uploadFile($name);

        $body = '{
              "NodeId": "0.0.0",
              "Name": "BirthDate",
              "Enabled": true,
              "StatusText": "Enter your date of birth.",
              "OwnStatus": true,
              "HelpText": "Enter your date of birth.",
              "OwnHelp": true,
              "CalculateOnExit": false,
              "EntryMacro": "",
              "ExitMacro": "",
              "TextInputFormat": "yyyy-MM-dd",
              "TextInputType": "Date",
              "TextInputDefault": "",
              "MaxLength": 0,
              "link": {
                "Href": "FormFilled.docx/sections/0/paragraphs/0/formfields/0",
                "Rel": "self",
                "Type": null,
                "Title": null
              }
            }';
        $result = $this->words->PostFormField($name, $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertDocumentWatermarkImage()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $file = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/watermark.png', 'w');
        $result = $this->words->PostInsertDocumentWatermarkImage($name, $filename = null, $rotationAngle = null, $image = null, $storage = null, $folder = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertDocumentWatermarkText()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = array('Text' => 'Watermark text here', 'RotationAngle' => '45.0');
        $result = $this->words->PostInsertDocumentWatermarkText($name, $filename = null, $text = null, $rotationAngle = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertPageNumbers()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $alignment = "right";
        $format = "{PAGE} of {NUMPAGES}";
        $isTop = True;
        $setPageNumberOnFirstPage = True;
        $body = array('Format'=>$format, 'Alignment'=>$alignment,
		'IsTop'=>$isTop, 'SetPageNumberOnFirstPage'=>$setPageNumberOnFirstPage);
        
        $result = $this->words->PostInsertPageNumbers($name, $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostLoadWebDocument()
    {
        $xml = <<<XML
          <LoadWebDocumentData>
             <LoadingDocumentUrl>http://google.com</LoadingDocumentUrl>
             <DocSaveOptionsData>
             <SaveFormat>doc</SaveFormat>
             <FileName>google1.doc</FileName>
             </DocSaveOptionsData>
          </LoadWebDocumentData>
XML;
        $strXML = simplexml_load_string($xml);
        $result = $this->words->PostLoadWebDocument($strXML->asXML());
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostReplaceText()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $oldValue = "sample";
        $newValue = "demo";
        $isMatchCase = False;
        $isMatchWholeWord = True;
        $body = array('OldValue'=>$oldValue, 'NewValue'=>$newValue, 
		'IsMatchCase'=>$isMatchCase, 'IsMatchWholeWord'=>$isMatchWholeWord);
        
        $result = $this->words->PostReplaceText($name, $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostRunTask()
    {   
        $result = $this->words->PostRunTask();
        print_r($result);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostSplitDocument()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->PostSplitDocument($name, $format = "pdf", $from = null, $to = null, $zipOutput = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostUpdateDocumentBookmark()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = array("Text" => "Update bookmark text");
        $result = $this->words->PostUpdateDocumentBookmark($name, $bookmarkName="_GoBack", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostUpdateDocumentFields()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->PostUpdateDocumentFields($name, $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutConvertDocument()
    {   
        $file = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/FormFilled.docx', 'w');
        $result = $this->words->PutConvertDocument($format = "pdf", $outPath = null, $file);
        $fh = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/Output/FormFilled.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(realpath(__DIR__ . '/../../../../..'). '/Data/Output/FormFilled.pdf');
    }
    
    public function testPutDocumentFieldNames()
    {
        $result = $this->words->PutDocumentFieldNames($useNonMergeFields = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutDocumentSaveAsTiff()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = '{                    
                    "TiffCompression": "Ccitt4",
                    "PageCount": 1,
                    "PixelFormat": "Format16BppRgb555",
                    "PaperColor": "Red",
                    "Resolution": 200,
                    "Scale": 1.5,
                    "ImageBrightness": 0.5,
                    "ImageColorMode": "None",
                    "ImageContrast": 0.9,
                    "UseHighQualityRendering": true,
                    "UseAntiAliasing": true,
                    "PageIndex": 0,                    
                    "NumeralFormat": "EasternArabicIndic",
                    "SaveFormat": "tiff",
                    "FileName": "MyDocument1.tiff"
                  }';
        $result = $this->words->PutDocumentSaveAsTiff($name, $resultFile = null, $useAntiAliasing = null, $useHighQualityRendering = null, $imageBrightness = null, $imageColorMode = null, $imageContrast = null, $numeralFormat = null, $pageCount = null, $pageIndex = null, $paperColor = null, $pixelFormat = null, $resolution = null, $scale = null, $tiffCompression = null, $dmlRenderingMode = null, $dmlEffectsRenderingMode = null, $tiffBinarizationMethod = null, $storage = null, $folder = null, $zipOutput = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutExecuteMailMergeOnline()
    {
        $data['file2'] = new CurlFile(realpath(__DIR__). '/../../../../../Data/SampleMailMergeTemplate.docx', 'application/msword');
        $data['file1'] = new CurlFile(realpath(__DIR__). '/../../../../../Data/SampleMailMergeTemplateData.xml', 'text/xml');
        $result = $this->words->PutExecuteMailMergeOnline($withRegions='false', $cleanup = null, $data);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutExecuteTemplateOnline()
    {
        $file = fopen(realpath(__DIR__ . '/../../../../..'). '/Data/SampleMailMergeTemplateData.xml', 'w');
        $result = $this->words->PutExecuteTemplateOnline($cleanup = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutFormField()
    {
        // Upload file to Aspose Cloud Storage
        $name = "FormFilled.docx";
        Utils::uploadFile($name);

        $body = '{
              "NodeId": "0.0.0",
              "Name": "StartDate",
              "Enabled": true,
              "StatusText": "Enter your date of start.",
              "OwnStatus": true,
              "HelpText": "Enter your date of start.",
              "OwnHelp": true,
              "CalculateOnExit": false,
              "EntryMacro": "",
              "ExitMacro": "",
              "TextInputFormat": "yyyy-MM-dd",
              "TextInputType": "Date",
              "TextInputDefault": "",
              "MaxLength": 0,
              "link": {
                "Href": "FormFilled.docx/sections/0/paragraphs/0/formfields/0",
                "Rel": "self",
                "Type": null,
                "Title": null
              }
            }';
        $result = $this->words->PutFormField($name, $sectionIndex="0", $paragraphIndex="0", $insertBeforeNode = null, $destFileName = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutProtectDocument()
    {   
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $password = "123456";
        $protectionType = "AllowOnlyComments";
        $body = array('Password' => $password, 'ProtectionType' => $protectionType);
        
        $result = $this->words->PutProtectDocument($name, $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutUpdateDocumentProperty()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = array('Value' => 'John');   
        $result = $this->words->PutUpdateDocumentProperty($name, $propertyName="Author", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testRejectAllRevisions()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $result = $this->words->RejectAllRevisions($name, $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testUpdateSectionPageSetup()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $body = '{
                    "PageSetup": {
                        "LeftMargin":99,
                        "Orientation": "Landscape",
                        "PaperSize": "A5"
                    }
                 }';
        $result = $this->words->UpdateSectionPageSetup($name, $sectionIndex="0", $storage = null, $folder = null, $filename = null, $body);
        $this->assertEquals(200, $result->Code);
    }
                         
}    