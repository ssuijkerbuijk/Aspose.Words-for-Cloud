<?php
namespace MailMerge;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostDocumentExecuteMailMergeRequest;

class PostDocumentExecuteMailMergeExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "SampleMailMergeTemplate.docx";
        $remoteName = "TestPostDocumentExecuteMailMerge.docx";
       
        $destName = $remoteName;
        $data = file_get_contents( realpath(__DIR__ . '../../') . '/TestData/MailMerge/' . "SampleMailMergeTemplateData.txt");
        $file =  realpath(__DIR__ . '../../') . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostDocumentExecuteMailMergeRequest($remoteName, false, $data, $folder=null,
            null, null, null, null,
            null, null, $destName);
        $result = $wordsAPI->postDocumentExecuteMailMerge($request);
        echo $result;
    }
}

$object = new PostDocumentExecuteMailMergeExample();
$object->main();

?>