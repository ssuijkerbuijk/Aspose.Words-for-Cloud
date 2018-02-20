<?php
namespace Text;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\SearchRequest;
class SearchTextExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "SampleWordDocument.docx";
        $remoteName = "TestSearch.docx";
      
        $pattern = "aspose";
        $file =realpath(__DIR__ . '../../') . '/TestData/Text/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new SearchRequest($remoteName, $pattern, $folder=null);
        $result = $wordsAPI->search($request);
        echo $result;
    }
}

$object = new SearchTextExample();
$object->main();

?>