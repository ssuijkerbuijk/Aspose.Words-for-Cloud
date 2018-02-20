<?php
namespace Document;
require_once('../../vendor/autoload.php');


use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostCommentRequest;
use Aspose\Words\Model\DocumentPosition;
use Aspose\Words\Model\Comment;
use Aspose\Words\Model\NodeLink;


class PostComment
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPostComment.docx";
        
        $index = 0;
        $nodeLink = new NodeLink(array("node_id" => "0.0.3"));
        $documentPosition = new DocumentPosition(array("node" => $nodeLink, "offset" => 0));
        $body = new Comment(array("range_start" => $documentPosition,
            "range_end" => $documentPosition,"initial" => "IA",
            "author" => "Imran Anwar", "text" => "A new Comment"));
        $file = realpath(__DIR__ . '../../') . '\\TestData\\Common\\' . $localName;
        
        $this->storage->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostCommentRequest($remoteName, $index, $body, $folder=null);
        $result = $wordsAPI->postComment($request);
        echo $result;
    }
}
$document = new PostComment();
$document->main();
