<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\DeleteFieldRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;

class DeleteFieldExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "GetField.docx";
        $remoteName = "TestDeleteField.docx";
       
        $fieldIndex = 0;
        $file = realpath(__DIR__ . '../../') .  '/TestData/Field/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new DeleteFieldRequest($remoteName,
            $fieldIndex, $folder=null,
            null, null, null, null,
            null, null,"sections/0/paragraphs/0");
        $result = $wordsAPI->deleteField($request);
       echo $result;
    }
}

$fields = new DeleteFieldExample();
$fields->main();

?>