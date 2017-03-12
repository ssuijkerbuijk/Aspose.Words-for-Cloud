<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class DocumentProperties {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function getDocumentProperties() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocumentProperties($fileName, $storage = null, $folder = null);        
        print_r($result);
	}
}

$documentProperties = new DocumentProperties();
$documentProperties->getDocumentProperties();

?>