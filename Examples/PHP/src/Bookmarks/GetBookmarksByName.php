<?php
namespace Bookmarks;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\GetDocumentBookmarkByNameRequest;
class GetBookmarksByName
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestGetDocumentBookmarkByName.docx";
        
        $bookmarkName = "aspose";
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        echo $file;
        
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        
        
        $request = new GetDocumentBookmarkByNameRequest($remoteName, $bookmarkName, $folder=null);
        $result = $wordsAPI->getDocumentBookmarkByName($request);
        
        echo $result;
    }
   
    
}

$bookmarks = new GetBookmarksByName();
$bookmarks->main();

?>