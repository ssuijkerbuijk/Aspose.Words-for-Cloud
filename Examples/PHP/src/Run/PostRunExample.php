<?php
namespace Run;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostRunRequest;
use Aspose\Words\Model\Run;


class PostRunExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "Run.doc";
        $remoteName = "TestPostRun.docx";
       
        $index = 0;
        $run = new Run(array("text" => "Run with text"));
        $file =realpath(__DIR__ . '../../') .  '/TestData/Run/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostRunRequest($remoteName, $run, "paragraphs/1", $index, $folder=null);
        $result = $wordsAPI->postRun($request);
        echo $result;
    }
}

$object = new PostRunExample();
$object->main();

?>