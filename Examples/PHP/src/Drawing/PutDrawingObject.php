<?php
namespace Drawing;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PutDrawingObjectRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;
class PutDrawingObject
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPutDrawingObject.docx";
       
        $image = realpath(__DIR__ . '../../') .  '/TestData/Common/' . "aspose-cloud.png";
        $file = realpath(__DIR__ . '../../') .  '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PutDrawingObjectRequest($remoteName, "{\"Left\": 0}", $image, $folder=null,
            null, null, null, null,
            null, null, "");
        $result = $wordsAPI->putDrawingObject($request);
        echo $result;
    }
}

$drawing = new PutDrawingObject();
$drawing->main();


?>