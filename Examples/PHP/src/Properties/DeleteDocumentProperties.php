<?php
namespace Properties;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\DeleteDocumentPropertyRequest;

class DeleteDocumentProperties
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestDeleteDocumentProperty.docx";
       
        $propertyName = "testProp";
        $destName = self::$baseTestOut . $remoteName;
        $file = rrealpath(__DIR__ . '../../') .'/TestData/Common/' . $localName;
        
        $this->storage->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new DeleteDocumentPropertyRequest($remoteName, $propertyName, $folder=null, null, null, null, $destName);
        $result = $this->words->deleteDocumentProperty($request);
        echo $result;
    }
}


$object = new DeleteDocumentProperties();
$object->main();

?>