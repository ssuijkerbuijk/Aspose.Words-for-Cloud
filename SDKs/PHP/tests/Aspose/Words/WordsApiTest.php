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
                         
}    