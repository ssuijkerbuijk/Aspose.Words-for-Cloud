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

	public function postDocumentSaveAs() {  
        // Upload file to Aspose Cloud Storage
        $fileName = "SampleWordDocument.docx";
        Utils::uploadFile($fileName);

        $body = '{
                    "SaveFormat": "pdf",
                    "FileName": "SampleWordDocument.pdf"
                 }';

        $response = $this->wordsApi->PostDocumentSaveAs($fileName, $storage = null, $folder = null, $body);
        $result = json_decode($response);
        print_r($result);
    }
}

$document = new Document();
$document->postDocumentSaveAs();

?>