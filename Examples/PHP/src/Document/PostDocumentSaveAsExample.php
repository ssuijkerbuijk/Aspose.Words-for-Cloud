<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\SaveOptionsData;
use Aspose\Words\Model\Requests\PostDocumentSaveAsRequest;

class PostDocumentSaveAsExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostAppendDocument.docx";
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostDocumentSaveAs.docx";
       
        $destName = "TestPostDocumentSaveAs.pdf";
        $saveOptions = new SaveOptionsData(array("save_format" => "pdf", "file_name" => $destName));
        $file =  realpath(__DIR__ . '../../') . '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostDocumentSaveAsRequest($remoteName, $saveOptions, $folder=null);
        $result = $this->words->postDocumentSaveAs($request);
        echo $result;
    }
}

$document = new PostDocumentSaveAsExample();
$document->main();
?>
