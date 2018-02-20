<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\TiffSaveOptionsData;
use Aspose\Words\Model\Requests\PutDocumentSaveAsTiffRequest;

class PutDocumentSaveAsTiffExample
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
        $destName ="TestPutDocumentSaveAsTiff.tiff";
        
        
        $body = new TiffSaveOptionsData(array("file_name" => "abc.tiff", "save_format" => "tiff"));
        $file =realpath(__DIR__ . '../../') . '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PutDocumentSaveAsTiffRequest($remoteName, $body, $folder=null,
            null, null, null, $destName);
        $result =$wordsAPI->putDocumentSaveAsTiff($request);
        echo $result;
    }
}

$document = new PutDocumentSaveAsTiffExample();
$document->main();

?>