<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PutFormFieldRequest;
use Aspose\Words\Model\FormFieldTextInput;
use Aspose\Words\Model\DocumentEntry;
class PutFormFieldExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "test_multi_pages.docx";
        $remoteName = "TestPutFormField.docx";
      
        $destName = $remoteName;
        $body = new FormFieldTextInput(array(
            "name" => "FullName",
            "enabled" => true,
            "calculate_on_exit" => true,
            "status_text" => "",
            "text_input_type" => FormFieldTextInput::TEXT_INPUT_TYPE_REGULAR,
            "text_input_default" => "123",
            "text_input_format" => "UPPERCASE"
        ));
        $file =realpath(__DIR__ . '../../') . '/TestData/Common/' . $localName;
        $storageAPI->PutCreate($Path=$fullName, $versionId = null, $storage = null, $file);
        $request = new PutFormFieldRequest($remoteName, $body, $folder=null,
            null, null, null, $destName,
            null, null, "sections/0/paragraphs/0");
        $result = $wordsAPI->putFormField($request);
        echo $result;
    }
}

$bookmarks = new PutFormFieldExample();
$bookmarks->main();

?>