<?php
namespace Hyperlinks;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetDocumentHyperlinkByIndexRequest;
class GetDocumentHyperlinkByIndexExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_doc.docx";
        $remoteName = "TestGetDocumentHyperlinkByIndex.docx";
        
        $index = 0;
        $file = realpath(__DIR__ . '../../') .'/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new GetDocumentHyperlinkByIndexRequest($remoteName, $index, $folder=null);
        $result = $wordsAPI->getDocumentHyperlinkByIndex($request);
        echo $result;
    }
}

$object = new GetDocumentHyperlinkByIndexExample();
$object->main();

?>