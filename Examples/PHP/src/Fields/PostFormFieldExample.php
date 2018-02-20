<?php
namespace Fields;
require_once('../../vendor/autoload.php');

use Aspose\Storage\StorageApi;
use Aspose\Words\WordsApi;
use Aspose\Words\Configuration;
use Aspose\Words\Model\Requests\PostFormFieldRequest;
use Aspose\Words\Model\FormFieldTextInput;
use Aspose\Words\Model\DocumentEntry;
class PostFormFieldExample
{
    function main(){
        $config = new Configuration();
        $config->setAppKey('b125f13bf6b76ed81ee990142d841195')->setAppSid('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9');
        
        $wordsAPI = new WordsApi(null, $config);
        $storageAPI = new StorageApi();
        $storageAPI->apiClient->apiKey ='b125f13bf6b76ed81ee990142d841195';
        $storageAPI->apiClient->appSid = '78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9';
        $localName = "FormFilled.docx";
        $remoteName = "TestPostFormField.docx";
      
        $index = 0;
        $destName = self::$baseTestOut . $remoteName;
        $body = new FormFieldTextInput(array(
            "name" => "FullName",
            "enabled" => true,
            "calculate_on_exit" => true,
            "status_text" => "",
            "text_input_type" => FormFieldTextInput::TEXT_INPUT_TYPE_REGULAR,
            "text_input_default" => ""
        ));
        $file = realpath(__DIR__ . '../../') .  '/TestData/Field/' . $localName;
        $storageAPI->PutCreate($Path=$remoteName, $versionId = null, $storage = null, $file);
        $request = new PostFormFieldRequest($remoteName, $body, $index, $folder=null,
            null, null, null, $destName,
            null, null, "sections/0");
        $result = $wordsAPI->postFormField($request);
        echo $result;
    }
}
$fields = new PostFormFieldExample();
$fields->main();

?>