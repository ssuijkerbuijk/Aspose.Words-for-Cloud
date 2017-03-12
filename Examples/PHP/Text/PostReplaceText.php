<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Text {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function postReplaceText() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $oldValue = "Times New Roman";
        $newValue = "Arial Black";
        $isMatchCase = false;
        $isMatchWholeWord = true;
        $body = array('OldValue'=>$oldValue, 'NewValue'=>$newValue, 
					'IsMatchCase'=>$isMatchCase, 'IsMatchWholeWord'=>$isMatchWholeWord);
        
        $result = $this->wordsApi->PostReplaceText($fileName, $filename = null, $storage = null, $folder = null, $body);
        print_r($result);
	}
}

$text = new Text();
$text->postReplaceText();

?>