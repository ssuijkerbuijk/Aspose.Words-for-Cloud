<?php
namespace PageSetup;
require_once('../../vendor/autoload.php');


use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\RenderPageRequest;

class RenderPageExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "SampleWordDocument.docx";
        $remoteName = "TestRenderPage.docx";
        $subfolder = "DocumentElements/PageSetup";
        $fullName =  $remoteName;
        $pageNumber = 1;
        $format = "png";
        $file = realpath(__DIR__ . '../../') .  '/TestData/Text/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new RenderPageRequest($remoteName, $pageNumber, $format, $folder=null);
        $result = $wordsAPI->renderPage($request);
        echo $result;
        
        
    }
}

$object = new RenderPageExample();
$object->main();

?>