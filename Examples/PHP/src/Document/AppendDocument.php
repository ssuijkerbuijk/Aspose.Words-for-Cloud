<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostAppendDocumentRequest;
use Aspose\Words\Model\DocumentEntryList;
use Aspose\Words\Model\DocumentEntry;

class AppendDocument
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
                
        $body = new DocumentEntryList();
        $docEntry = new DocumentEntry(array("href" => $remoteName, "import_format_mode" => "KeepSourceFormatting"));
        
        $body->setDocumentEntries(array($docEntry));
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        
        
        $request = new PostAppendDocumentRequest($remoteName, $body, $folder=null,
            null, null, null, $destName,null, null);
        $result =$wordsAPI->postAppendDocument($request);
        echo $result;
    }
}

$document = new AppendDocument();
$document->main();


?>