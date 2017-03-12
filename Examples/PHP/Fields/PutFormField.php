<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Fields {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function putFormField() {
      // Upload file to Aspose Cloud Storage
      $fileName = "FormFilled.docx";
      Utils::uploadFile($fileName);
      
      $body = '{
                "Name": "FullName",
                "Enabled": true,
                "StatusText": "Enter your name and surname (trimmed to 30 characters)"  
              }';
      $result = $this->words->PutFormField($fileName, $sectionIndex=0, $paragraphIndex=0, $insertBeforeNode = null, $destFileName = null, $storage = null, $folder = null, $body);
      print_r($result);
  }  
}

$fields = new Fields();
$fields->putFormField();

?>