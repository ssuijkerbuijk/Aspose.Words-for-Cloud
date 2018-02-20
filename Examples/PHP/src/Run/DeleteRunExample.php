<?php
namespace Run;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\DeleteRunRequest;
class DeleteRunExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "Run.doc";
        $remoteName = "TestDeleteRun.docx";
       
        $index = 0;
        $file = realpath(__DIR__ . '../../') .  '/TestData/Run/' . $localName;
        $this->storage->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new DeleteRunRequest($remoteName, "paragraphs/1", $index, $folder=null);
        $result = $this->words->deleteRun($request);
        echo $result;
    }
}

$object = new DeleteRunExample();
$object->main();

?>