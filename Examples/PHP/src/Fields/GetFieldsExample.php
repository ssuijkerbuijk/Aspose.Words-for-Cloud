<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetFieldsRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;

class GetFieldsExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "GetField.docx";
        $remoteName = "TestGetFields.docx";
       
        $fullName = self::$baseTestPath . $subfolder . "/" . $remoteName;
        $file = realpath(__DIR__ . '../../') . '/TestData/Field/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new GetFieldsRequest($remoteName, $folder=null,
            null, null, null, "sections/0");
        $result = $wordsAPI->getFields($request);
        echo $result;
    }
}

$fields = new GetFieldsExample();
$fields->main();

?>