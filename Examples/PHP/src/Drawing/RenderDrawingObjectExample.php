<?php
namespace Drawing;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\RenderDrawingObjectRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;
class RenderDrawingObjectExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestRenderDrawingObject.docx";
      
        $index = 0;
        $format = "png";
        $file =realpath(__DIR__ . '../../') .  '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new RenderDrawingObjectRequest($remoteName, $format, $index, $folder=null,
            null, null, null, "sections/0");
        $result = $wordsAPI->renderDrawingObject($request);
        echo $result;
    }
}

$drawing = new RenderDrawingObjectExample();
$drawing->main();


?>