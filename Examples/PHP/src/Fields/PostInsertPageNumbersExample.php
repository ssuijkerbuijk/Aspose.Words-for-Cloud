<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostInsertPageNumbersRequest;
use Aspose\Words\Model\PageNumber;
use Aspose\Words\Model\DocumentEntry;

class PostInsertPageNumbersExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostInsertPageNumbers.docx";
       
        $destName =  $remoteName;
        $body = new PageNumber(array("alignment" => "center", "format" => "{PAGE} of {NUMPAGES}"));
        $file = realpath(__DIR__ . '../../') .  '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostInsertPageNumbersRequest($remoteName, $body, $folder=null,
            null, null, null, $destName);
        $result = $wordsAPI->postInsertPageNumbers($request);
        echo $result;
    }
}

$fields = new PostInsertPageNumbersExample();
$fields->main();

?>