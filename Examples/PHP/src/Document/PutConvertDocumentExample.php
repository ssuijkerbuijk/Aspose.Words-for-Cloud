<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\Requests\PutConvertDocumentRequest;
class PutConvertDocumentExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $format = "pdf";
        $file = realpath(__DIR__ . '../../') . '/TestData/ConvertDocument/' . "test_uploadfile.docx";
        $request = new PutConvertDocumentRequest($file, $format);
        $result = $wordsAPI->putConvertDocument($request);
        echo $result;
    }
}

$document = new PutConvertDocumentExample();
$document->main();

?>