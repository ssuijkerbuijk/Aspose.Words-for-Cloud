<?php
namespace Run;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PutRunRequest;
use Aspose\Words\Model\Run;

class PutRunExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "Run.doc";
        $remoteName = "TestPutRun.docx";
     
        $run = new Run(array("text" => "run with text"));
        $file = realpath(__DIR__ . '../../') .  '/TestData/Run/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PutRunRequest($remoteName, "paragraphs/1", $run, $folder=null);
        $result = $wordsAPI->putRun($request);
        echo $result;
    }
}

$object = new PutRunExample();
$object->main();

?>