<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PutCommentRequest;
use Aspose\Words\Model\DocumentPosition;
use Aspose\Words\Model\Comment;
use Aspose\Words\Model\NodeLink;


class PutComment
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPutComment.docx";
        
        $subfolder = "DocumentElements/Comments";
        $fullName = self::$baseTestPath . $subfolder . "/" . $remoteName;
        
        
        $nodeLink = new NodeLink(array("node_id" => "0.0.3"));
        $documentPosition = new DocumentPosition(array("node" => $nodeLink, "offset" => 0));
        $body = new Comment(array(
            "range_start" => $documentPosition,
            "range_end" => $documentPosition,
            "initial" => "MS",
            "author" => "M. Sajjad",
            "text" => "A new comment"
        ));
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        
        $storageAPI->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new PutCommentRequest($remoteName, $body, $folder=self::$baseTestPath . $subfolder);
        $result = $wordsAPI->putComment($request);
        echo $resultl;
    }
}

$document = new PutComment();
$document->main();