<?php
namespace Paragraphs;
require_once('../../vendor/autoload.php');


use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetDocumentParagraphRunsRequest;
class GetDocumentParagraphRunsExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "GetField.docx";
        $remoteName = "TestGetDocumentParagraphRuns.docx";
        $subfolder = "DocumentElements/Paragraph";
        $fullName = self::$baseTestPath . $subfolder . "/" . $remoteName;
        $file =  realpath(__DIR__ . '../../') . '/TestData/Field/' . $localName;
        $this->storage->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new GetDocumentParagraphRunsRequest($remoteName, "sections/0/paragraphs/0", $folder=null);
        $result = $this->words->getDocumentParagraphRuns($request);
        echo $result;
    }
}

$object = new GetDocumentParagraphRunsExample();
$object->main();

?>