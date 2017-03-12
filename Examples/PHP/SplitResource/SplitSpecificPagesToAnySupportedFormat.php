<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class SplitResource {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function postSplitDocument() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->PostSplitDocument($fileName, $format = "text", $from = 1, $to = 2, $zipOutput = false, $storage = null, $folder = null);
        print_r($result);
}
}

$splitResource = new SplitResource();
$splitResource->postSplitDocument();

?>