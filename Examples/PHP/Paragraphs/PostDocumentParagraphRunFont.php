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


	public function postDocumentParagraphRunFont() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $body = '{
                    "Font:" {
                        "Name": "Arial",
                        "Bold": true
                    }
                }';
        $result = $this->words->PostDocumentParagraphRunFont($fileName, $index=0, $runIndex=0, $storage = null, $folder = null, $filename = null, $body);
        print_r($result);
    }
}

$paragraphs = new Paragraphs();
$paragraphs->postDocumentParagraphRunFont();

?>