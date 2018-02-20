<?php
namespace Math;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\DeleteOfficeMathObjectRequest;
class DeleteOfficeMathObjectExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "MathObjects.docx";
        $remoteName = "TestDeleteOfficeMathObject.docx";
        
        $index = 0;
        $file =  realpath(__DIR__ . '../../') .'/TestData/MathObject/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new DeleteOfficeMathObjectRequest($remoteName, $index, $folder=null,
            null, null, null, null,
            null, null, "");
        $result = $wordsAPI->deleteOfficeMathObject($request);
        echo $result;
    }
}

$object = new DeleteOfficeMathObjectExample();
$object->main();

?>