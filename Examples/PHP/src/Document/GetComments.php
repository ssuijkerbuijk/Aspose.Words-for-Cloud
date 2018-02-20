<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetCommentsRequest;

class GetComments
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestGetComments.docx";
        
        
        
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        $this->storage->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new GetCommentsRequest($remoteName, $folder=self::$baseTestPath . $subfolder);
        $result = $wordsAPI->getComments($request);
        echo $resultl;
    }
}

$document = new GetComments();
$document->main();