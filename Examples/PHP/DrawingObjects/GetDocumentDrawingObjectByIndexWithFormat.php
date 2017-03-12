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


	public function getDocumentDrawingObjectByIndexWithFormat() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "OLE.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocumentDrawingObjectByIndexWithFormat($fileName, $objectIndex=0, $format="png", $storage = null, $folder = null);
        $fh = fopen(realpath(__DIR__ . '/../../..') . '/Data/Output/OLE.png', 'w');
        fwrite($fh, $result);
        fclose($fh);
	}
}

$drawingObjects = new DrawingObjects();
$drawingObjects->getDocumentDrawingObjectByIndexWithFormat();

?>