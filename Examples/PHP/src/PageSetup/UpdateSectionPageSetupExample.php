<?php
namespace PageSetup;
require_once('../../vendor/autoload.php');


use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\UpdateSectionPageSetupRequest;
use Aspose\Words\Model\PageSetup;
class UpdateSectionPageSetupExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestUpdateSectionPageSetup.docx";
        $subfolder = "DocumentElements/PageSetup";
        $fullName =  $remoteName;
        $index = 0;
        $body = new PageSetup(array(
            "rtl_gutter" => true,
            "left_margin" => 10,
            "orientation" => PageSetup::ORIENTATION_LANDSCAPE,
            "paper_size" => PageSetup::PAPER_SIZE_A5
        ));
        $file = realpath(__DIR__ . '../../') .  '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new UpdateSectionPageSetupRequest($remoteName, $index, $body, $folder=null);
        $result = $wordsAPI->updateSectionPageSetup($request);
        echo $result;
        
    }
}

$object = new UpdateSectionPageSetupExample();
$object->main();

?>