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

	public function postAppendDocument() {
        // Upload file to Aspose Cloud Storage
        $fileName = "SampleWordDocument.docx";
        Utils::uploadFile($fileName);

        $appendDocs = array("SampleAppendDoc.docx", "SampleAppendDoc2.docx");
        $importFormatsModes = array("KeepSourceFormatting", "UseDestinationStyles");

        $body = '{ "DocumentEntries": [';
        for ($i = 0; $i < count($appendDocs); $i++) {
            $body .= '{ "Href": "' . $appendDocs[$i] .
                    '", "ImportFormatMode": "' . $importFormatsModes[$i] . '" }' .
                    (($i < (count($appendDocs) - 1)) ? ',' : '');
        }
        $body .= '  ] }';
        
        $result = $this->words->PostAppendDocument($fileName, $filename = null, $storage = null, $folder = null, $body);        
        print_r($result);
    }
}

$document = new Document();
$document->postAppendDocument();

?>