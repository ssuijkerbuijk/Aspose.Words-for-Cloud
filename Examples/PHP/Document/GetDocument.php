<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Document {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function getDocument() {   
		// Upload file to Aspose Cloud Storage
		$fileName = "Test.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocument($fileName, $storage = null, $folder = null);        
        $this->assertInternalType('string', $result);
	}
}

$document = new Document();
$document->getDocument();

?>