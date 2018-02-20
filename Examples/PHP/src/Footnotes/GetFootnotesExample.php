<?php
namespace Footnotes;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\Requests\GetFootnotesRequest;

class GetFootnotesExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "Footnote.doc";
        $remoteName = "TestGetFootnotes.docx";
       
        $file = realpath(__DIR__ . '../../') . '/TestData/Footnote/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new GetFootnotesRequest($remoteName, $folder=null,
            null, null, null, "");
        $result = $wordsAPI->getFootnotes($request);
        echo $result;
    }
}

