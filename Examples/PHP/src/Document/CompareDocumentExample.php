<?php
namespace Document;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\CompareData;
use Aspose\Words\Model\Requests\PostCompareDocumentRequest;
class CompareDocumentExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        
        $localName1 = "compareTestDoc1.doc";
        $localName2 = "compareTestDoc2.doc";
        $remoteName1 = "TestPostCompareDocument1.doc";
        $remoteName2 = "TestPostCompareDocument2.doc";
        

        $destName =   "TestCompareDocumentOut.doc";
        $compareData = new CompareData(array("author" => "author", "comparing_with_document" => $fullName2, "date_time" => new \DateTime("now")));
        
        $file1 =  realpath(__DIR__ . '../../')  . '//TestData//CompareDocument//' . $localName1;
        $storageAPI->PutCreate($remoteName1, $versionId = null, $storage = null, $file1);
        $file2 =  realpath(__DIR__ . '../../'). '//TestData//CompareDocument//' . $localName2;
        $storageAPI->PutCreate($remoteName2, $versionId = null, $storage = null, $file2);
        $request = new PostCompareDocumentRequest($remoteName1, $compareData, $folder=null,
            null, null, null, $destName);
        $result = $this->words->postCompareDocument($request);
       echo $result;
    }
}
$document = new PostComment();
$document->main();

?>
