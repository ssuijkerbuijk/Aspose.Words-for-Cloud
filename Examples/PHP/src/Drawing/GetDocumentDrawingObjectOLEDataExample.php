<?php
namespace Drawing;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetDocumentDrawingObjectOleDataRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;
class GetDocumentDrawingObjectOLEDataExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "sample_EmbeddedOLE.docx";
        $remoteName = "TestGetDocumentDrawingObjectOleData.docx";
      
        $index = 0;
        $file = realpath(__DIR__ . '../../') .  '/TestData/Drawing/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new GetDocumentDrawingObjectOleDataRequest($remoteName, $index, $folder=null,
            null, null, null, "sections/0");
        $result = $wordsAPI->getDocumentDrawingObjectOleData($request);
        echo $result;
    }
}

$drawing = new GetDocumentDrawingObjectOLEDataExample();
$drawing->main();


?>