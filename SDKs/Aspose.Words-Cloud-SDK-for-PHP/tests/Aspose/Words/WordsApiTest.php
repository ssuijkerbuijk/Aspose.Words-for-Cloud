<?php

use Aspose\Words\WordsApi;

class WordsApiTest extends PHPUnit_Framework_TestCase {
    
    protected $words;

    protected function setUp()
    {        
        $this->words = new WordsApi();
    }
    
    public function testAcceptAllRevisions()
    {       
        $result = $this->words->AcceptAllRevisions($name="Test.docx", $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentFields()
    {       
        $result = $this->words->DeleteDocumentFields($name="Test.docx", $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentMacros()
    {       
        $result = $this->words->DeleteDocumentMacros($name="Test.docx", $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentProperty()
    {       
        $result = $this->words->DeleteDocumentProperty($name="Test.docx", $propertyName="Test", $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteDocumentWatermark()
    {       
        $result = $this->words->DeleteDocumentWatermark($name="Test.docx", $filename = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteFormField()
    {       
        $result = $this->words->DeleteFormField($name="FormFilled.docx", $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteHeadersFooters()
    {       
        $result = $this->words->DeleteHeadersFooters($name="Test.docx", $headersFootersTypes = null, $filename = null, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteParagraphFields()
    {       
        $result = $this->words->DeleteParagraphFields($name="Test.docx", $index=1, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteSectionFields()
    {       
        $result = $this->words->DeleteSectionFields($name="Test.docx", $sectionIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteSectionParagraphFields()
    {       
        $result = $this->words->DeleteSectionParagraphFields($name="Test.docx", $sectionIndex="0", $paragraphIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testDeleteUnprotectDocument()
    {       
        $body = array("Password"=>"123456");
        $result = $this->words->DeleteUnprotectDocument($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocument()
    {       
        $result = $this->words->GetDocument($name="Test.docx", $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentBookmarkByName()
    {       
        $result = $this->words->GetDocumentBookmarkByName($name="Test.docx", $bookmarkName="_GoBack", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentBookmarks()
    {       
        $result = $this->words->GetDocumentBookmarks($name="Test.docx", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentDrawingObjectByIndex()
    {       
        $result = $this->words->GetDocumentDrawingObjectByIndex($name="OLE.docx", $objectIndex="0", $storage = null, $folder = null);                
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjectByIndexWithFormat()
    {       
        $result = $this->words->GetDocumentDrawingObjectByIndexWithFormat($name="OLE.docx", $objectIndex="0", $format="png", $storage = null, $folder = null);
        $fh = fopen(getcwd(). '/Data/Output/OLE.png', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/Data/Output/OLE.png');
    }
    
    public function testGetDocumentDrawingObjectImageData()
    {       
        $result = $this->words->GetDocumentDrawingObjectImageData($name="OLE.docx", $objectIndex="0", $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjectOleData()
    {       
        $result = $this->words->GetDocumentDrawingObjectOleData($name="OLE.docx", $objectIndex="0", $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
    }
    
    public function testGetDocumentDrawingObjects()
    {       
        $result = $this->words->GetDocumentDrawingObjects($name="OLE.docx", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentHyperlinkByIndex()
    {       
        $result = $this->words->GetDocumentHyperlinkByIndex($name="Test.docx", $hyperlinkIndex=1, $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentHyperlinks()
    {       
        $result = $this->words->GetDocumentHyperlinks($name="Test.docx", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraph()
    {       
        $result = $this->words->GetDocumentParagraph($name="test_multi_pages.docx", $index=1, $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphRun()
    {       
        $result = $this->words->GetDocumentParagraphRun($name="test_multi_pages.docx", $index="0", $runIndex="0", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphRunFont()
    {       
        $result = $this->words->GetDocumentParagraphRunFont($name="Test.docx", $index="0", $runIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentParagraphs()
    {       
        $result = $this->words->GetDocumentParagraphs($name="Test.docx", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProperties()
    {       
        $result = $this->words->GetDocumentProperties($name="Test.docx", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProperty()
    {       
        $result = $this->words->GetDocumentProperty($name="Test.docx", $propertyName="Author", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentProtection()
    {       
        $result = $this->words->GetDocumentProtection($name="Test.docx", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentStatistics()
    {       
        $result = $this->words->GetDocumentStatistics($name="Test.docx", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentTextItems()
    {       
        $result = $this->words->GetDocumentTextItems($name="Test.docx", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetDocumentWithFormat()
    {       
        $result = $this->words->GetDocumentWithFormat($name="Test.docx", $format="pdf", $storage = null, $folder = null, $outPath = null);        
        $fh = fopen(getcwd(). '/Data/Output/Test.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/Data/Output/Test.pdf');
    }
    
    public function testGetFormField()
    {       
        $result = $this->words->GetFormField($name="FormFilled.docx", $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSection()
    {       
        $result = $this->words->GetSection($name="Test.docx", $sectionIndex='0', $storage = null, $folder = null);                
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSectionPageSetup()
    {       
        $result = $this->words->GetSectionPageSetup($name="Test.docx", $sectionIndex="0", $storage = null, $folder = null);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testGetSections()
    {       
        $result = $this->words->GetSections($name="Test.docx", $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostAppendDocument()
    {       
        $appendDocs = array("test_multi_pages.docx");
        $importFormatsModes = array("KeepSourceFormatting", "UseDestinationStyles");

        $body = '{ "DocumentEntries": [';
        for ($i = 0; $i < count($appendDocs); $i++) {
            $body .= '{ "Href": "' . $appendDocs[$i] .
                    '", "ImportFormatMode": "' . $importFormatsModes[$i] . '" }' .
                    (($i < (count($appendDocs) - 1)) ? ',' : '');
        }
        $body .= '  ] }';
        
        $result = $this->words->PostAppendDocument($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);        
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostChangeDocumentProtection()
    {       
        $body = array("Password" => "123456", "NewPassword" => "123456789");
        $result = $this->words->PostChangeDocumentProtection($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentExecuteMailMerge()
    {       
        $file = getcwd() . '/Data/Input/SampleMailMergeTemplateData.xml';
        $result = $this->words->PostDocumentExecuteMailMerge($name="SampleMailMergeTemplate.docx", $withRegions='false', $mailMergeDataFile = null, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentParagraphRunFont()
    {       
        $body = '{
                    "Font:" {
                        "Name": "Calibri"
                    }
                  }';
        $result = $this->words->PostDocumentParagraphRunFont($name="Test.docx", $index="0", $runIndex="0", $storage = null, $folder = null, $filename = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostDocumentSaveAs()
    {       
        $body = '{
                    "SaveFormat": "pdf",
                    "FileName": "Test.pdf",
                    "ImageCompression": "Jpeg",
                    "JpegQuality": 70,
                    "TextCompression": "Flate"
                 }';

        $response = $this->words->PostDocumentSaveAs($name="Test.docx", $storage = null, $folder = null, $body);
        $result = json_decode($response);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostFormField()
    {
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
        $result = $this->words->PostFormField($name="FormFilled.docx", $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertDocumentWatermarkImage()
    {
        $file = getcwd() . '/Data/Input/watermark.png';
        $result = $this->words->PostInsertDocumentWatermarkImage($name="Test.docx", $filename = null, $rotationAngle = null, $image = null, $storage = null, $folder = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertDocumentWatermarkText()
    {
        $body = array('Text' => 'Watermark text here', 'RotationAngle' => '45.0');
        $result = $this->words->PostInsertDocumentWatermarkText($name="Test.docx", $filename = null, $text = null, $rotationAngle = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostInsertPageNumbers()
    {
        $alignment = "right";
        $format = "{PAGE} of {NUMPAGES}";
        $isTop = True;
        $setPageNumberOnFirstPage = True;
        $body = array('Format'=>$format, 'Alignment'=>$alignment,
		'IsTop'=>$isTop, 'SetPageNumberOnFirstPage'=>$setPageNumberOnFirstPage);
        
        $result = $this->words->PostInsertPageNumbers($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);
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
        $oldValue = "sample";
        $newValue = "demo";
        $isMatchCase = False;
        $isMatchWholeWord = True;
        $body = array('OldValue'=>$oldValue, 'NewValue'=>$newValue, 
		'IsMatchCase'=>$isMatchCase, 'IsMatchWholeWord'=>$isMatchWholeWord);
        
        $result = $this->words->PostReplaceText($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);
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
        $result = $this->words->PostSplitDocument($name="Test.docx", $format = "pdf", $from = null, $to = null, $zipOutput = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostUpdateDocumentBookmark()
    {
        $body = array("Text" => "Update bookmark text");
        $result = $this->words->PostUpdateDocumentBookmark($name="Test.docx", $bookmarkName="_GoBack", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPostUpdateDocumentFields()
    {
        $result = $this->words->PostUpdateDocumentFields($name="Test.docx", $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutConvertDocument()
    {
        $file = getcwd() . '/Data/Input/FormFilled.docx';
        $result = $this->words->PutConvertDocument($format = "pdf", $outPath = null, $file);
        $fh = fopen(getcwd(). '/Data/Output/FormFilled.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
        $this->assertFileExists(getcwd(). '/Data/Output/FormFilled.pdf');
    }
    
    public function testPutDocumentFieldNames()
    {
        $result = $this->words->PutDocumentFieldNames($useNonMergeFields = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutDocumentSaveAsTiff()
    {
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
        $result = $this->words->PutDocumentSaveAsTiff($name="Test.docx", $resultFile = null, $useAntiAliasing = null, $useHighQualityRendering = null, $imageBrightness = null, $imageColorMode = null, $imageContrast = null, $numeralFormat = null, $pageCount = null, $pageIndex = null, $paperColor = null, $pixelFormat = null, $resolution = null, $scale = null, $tiffCompression = null, $dmlRenderingMode = null, $dmlEffectsRenderingMode = null, $tiffBinarizationMethod = null, $storage = null, $folder = null, $zipOutput = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutExecuteMailMergeOnline()
    {
        $data['file2'] = new CurlFile(getcwd() . '/Data/Input/SampleMailMergeTemplate.docx', 'application/msword');
        $data['file1'] = new CurlFile(getcwd() . '/Data/Input/SampleMailMergeTemplateData.xml', 'text/xml');
        $result = $this->words->PutExecuteMailMergeOnline($withRegions='false', $cleanup = null, $data);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutExecuteTemplateOnline()
    {
        $file = getcwd() . '/Data/Input/SampleMailMergeTemplateData.xml';
        $result = $this->words->PutExecuteTemplateOnline($cleanup = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutFormField()
    {
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
        $result = $this->words->PutFormField($name="FormFilled.docx", $sectionIndex="0", $paragraphIndex="0", $insertBeforeNode = null, $destFileName = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutProtectDocument()
    {
        $password = "123456";
        $protectionType = "AllowOnlyComments";
        $body = array('Password' => $password, 'ProtectionType' => $protectionType);
        
        $result = $this->words->PutProtectDocument($name="Test.docx", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testPutUpdateDocumentProperty()
    {
        $body = array('Value' => 'John');   
        $result = $this->words->PutUpdateDocumentProperty($name="Test.docx", $propertyName="Author", $filename = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testRejectAllRevisions()
    {
        $result = $this->words->RejectAllRevisions($name="Test.docx", $filename = null, $storage = null, $folder = null);
        $this->assertEquals(200, $result->Code);
    }
    
    public function testUpdateSectionPageSetup()
    {
        $body = '{
                    "PageSetup": {
                        "LeftMargin":99,
                        "Orientation": "Landscape",
                        "PaperSize": "A5"
                    }
                 }';
        $result = $this->words->UpdateSectionPageSetup($name="Test.docx", $sectionIndex="0", $storage = null, $folder = null, $filename = null, $body);
        $this->assertEquals(200, $result->Code);
    }
                         
}    