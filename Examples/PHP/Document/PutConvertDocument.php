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
	
	public function putConvertDocument() {
        $file = realpath(__DIR__ . '/../../..') . '/Data/SampleWordDocument.docx';
        $result = $this->wordsApi->PutConvertDocument($format = "pdf", $outPath = null, $file);
        $fh = fopen(realpath(__DIR__ . '/../../..'). '/Data/Output/FormFilled.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
	}
}

$document = new Document();
$document->putConvertDocument();

?>