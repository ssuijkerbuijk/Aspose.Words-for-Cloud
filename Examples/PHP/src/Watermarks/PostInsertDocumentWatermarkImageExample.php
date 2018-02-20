<?php
namespace Watermarks;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostInsertDocumentWatermarkImageRequest;
class PostInsertDocumentWatermarkImageExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostInsertDocumentWatermarkImage.docx";
        
        $destName =  $remoteName;
        $rotationAngle = 0;
        $image =realpath(__DIR__ . '../../') . '/TestData/Common/' . "aspose-cloud.png";
        $file =realpath(__DIR__ . '../../') . '/TestData/Common/' . $localName;
        $this->storage->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostInsertDocumentWatermarkImageRequest($remoteName, $image, $folder=null,
            null, null, null, $destName,
            null, null, $rotationAngle);
        $result = $wordsAPI->postInsertDocumentWatermarkImage($request);
        echo $result;
    }
}

$object = new PostInsertDocumentWatermarkImageExample();
$object->main();

?>