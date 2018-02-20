<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostFieldRequest;
use Aspose\Words\Model\Field;
use Aspose\Words\Model\DocumentEntry;

class PostFieldExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "GetField.docx";
        $remoteName = "TestPostField.docx";
       
        
        $index = 0;
        $destName = $remoteName;
        $body = new Field(array("result" => 3, "field_code" => "{ NUMPAGES }", "node_id" => "0.0.3"));
        $file = realpath(__DIR__ . '../../') .  '/TestData/Field/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostFieldRequest($remoteName, $body, $index, $folder=null,
            null, null, null, $destName,
            null, null, "sections/0/paragraphs/0");
        $result = $wordsAPI->postField($request);
        echo $result;
    }
}

$bookmarks = new PostFieldExample();
$bookmarks->main();

?>