<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class DrawingObjects {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function getDocumentDrawingObjectOleData() {
		// Upload file to Aspose Cloud Storage
		$fileName = "Sample_EmbeddedOLE.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocumentDrawingObjectOleData($fileName, $objectIndex=0, $storage = null, $folder = null);        
        print_r($result);
	}
}

$drawingObjects = new DrawingObjects();
$drawingObjects->getDocumentDrawingObjectOleData();

?>