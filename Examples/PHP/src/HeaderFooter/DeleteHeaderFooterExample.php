<?php
namespace HeaderFooter;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\DeleteHeadersFootersRequest;
class DeleteHeaderFooterExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "HeadersFooters.doc";
        $remoteName = "TestDeleteHeadersFooters.docx";
        
        $file = realpath(__DIR__ . '../../') . '/TestData/HeaderFooter/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new DeleteHeadersFootersRequest($remoteName, $folder=null,
            null, null, null, null, null,
            null, "");
        $result = $wordsAPI->deleteHeadersFooters($request);
        echo $result;
    }
}

$object = new DeleteHeaderFooterExample();
$object->main();

?>