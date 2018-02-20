<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\SaveOptionsData;
use Aspose\Words\Model\LoadWebDocumentData;
use Aspose\Words\Model\Requests\PostLoadWebDocumentRequest;
class LoadWebDocumentExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $saveOptions = new SaveOptionsData(array(
            "file_name" => "google.doc",
            "save_format" => "doc",
            "color_mode" => "1",
            "dml_effects_rendering_mode" => "1",
            "dml_rendering_mode" => "1",
            "update_sdt_content" => false,
            "zip_output" => false
        ));
        $body = new LoadWebDocumentData(array("loading_document_url" => "http://google.com", "save_options" => $saveOptions));
        $request = new PostLoadWebDocumentRequest($body);
        $result = $wordsAPI->postLoadWebDocument($request);
        echo $result;
    }
}

$document = new LoadWebDocumentExample();
$document->main();