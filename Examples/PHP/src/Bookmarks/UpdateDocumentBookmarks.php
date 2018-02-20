<?php
namespace Bookmarks;
require_once('../../vendor/autoload.php');
use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostUpdateDocumentBookmarkRequest;
use Aspose\Words\Model\BookmarkData;

class UpdateDocumentBookmarks
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostUpdateDocumentBookmark.docx";
        
        $bookmarkName = "aspose";
        $body = new BookmarkData(array("name" => $bookmarkName, "text" => "This will be the text for Aspose"));
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        
        $storageAPI->PutCreate($remoteName, $versionId = null, $storage = null, $file);
        $request = new PostUpdateDocumentBookmarkRequest($remoteName, $body, $bookmarkName, $folder=null,
            null, null, null, $remoteName);
        $result =$wordsAPI->postUpdateDocumentBookmark($request);
        echo $result;
    }
}


$bookmarks = new UpdateDocumentBookmarks();
$bookmarks->main();


?>