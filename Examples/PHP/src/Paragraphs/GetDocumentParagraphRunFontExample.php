<?php
namespace Paragraphs;
require_once('../../vendor/autoload.php');


use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetDocumentParagraphRunFontRequest;
class GetDocumentParagraphRunFontExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestGetDocumentParagraphRunFont.docx";
        $subfolder = "DocumentElements/Paragraph";
        $fullName = self::$baseTestPath . $subfolder . "/" . $remoteName;
        $index = 0;
        $file =  realpath(__DIR__ . '../../') .'/TestData/Common/' . $localName;
        $this->storage->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new GetDocumentParagraphRunFontRequest($remoteName, "paragraphs/0", $index, $folder=null);
        $result = $wordsAPI->getDocumentParagraphRunFont($request);
        echo $result;
    }
}

$object = new GetDocumentParagraphRunFontExample();
$object->main();

?>