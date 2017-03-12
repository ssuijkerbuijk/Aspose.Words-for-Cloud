<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Paragraphs {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function deleteParagraphFields() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "Test.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->DeleteParagraphFields($fileName, $index=1, $storage = null, $folder = null);        
        print_r($result);
	}
}

$paragraphs = new Paragraphs();
$paragraphs->deleteParagraphFields();

?>