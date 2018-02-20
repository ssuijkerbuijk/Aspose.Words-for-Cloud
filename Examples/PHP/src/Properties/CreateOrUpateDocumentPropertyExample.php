<?php
namespace Properties;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\CreateOrUpdateDocumentPropertyRequest;
use Aspose\Words\Model\DocumentProperty;

class CreateOrUpateDocumentPropertyExample
{
    function main()
    {
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_doc.docx";
        $remoteName = "TestPutUpdateDocumentProperty.docx";
      
        $propertyName = "AsposeAuthor";
        $property = new DocumentProperty(array("name" => "Author", "value" => "Mateen Sajjad"));
        $file =realpath(__DIR__ . '../../') .  '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new CreateOrUpdateDocumentPropertyRequest($remoteName, $propertyName, $property, $foldernull);
        $result = $this->words->createOrUpdateDocumentProperty($request);
        echo $result;
    }
}

$object = new CreateOrUpateDocumentPropertyExample();
$object->main();

?>