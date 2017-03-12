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

	public function putUpdateDocumentProperty() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $body = array('Name' => 'Provider', 'Value' => 'Jobs');   
        $result = $this->wordsApi->PutUpdateDocumentProperty($fileName, $propertyName="Provider", $filename = null, $storage = null, $folder = null, $body);
        print_r($result);
	}
}

$documentProperties = new DocumentProperties();
$documentProperties->putUpdateDocumentProperty();

?>