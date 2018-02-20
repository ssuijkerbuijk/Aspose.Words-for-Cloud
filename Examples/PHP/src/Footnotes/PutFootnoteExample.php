<?php
namespace Foornotes;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\Configuration;
use Aspose\Words\WordsApi;
use Aspose\Words\Model\Footnote;
use Aspose\Words\Model\Requests\PutFootnoteRequest;

class PutFootnoteExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "Footnote.doc";
        $remoteName = "TestPutFootnote.docx";
        
        $footnote = new Footnote(array("footnote_type" => Footnote::FOOTNOTE_TYPE_ENDNOTE, "text" => "test endnote"));
        $file = realpath(__DIR__ . '../../') .'/TestData/Footnote/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PutFootnoteRequest($remoteName, $footnote, $folder=null,
            null, null, null, null,
            null, null, "");
        $result = $wordsAPI->putFootnote($request);
        echo $result;
    }
}

