//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Watermark {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function postInsertDocumentWatermarkText() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $body = array('Text' => 'Welcome Aspose', 'RotationAngle' => 45.0);
        $result = $this->wordsApi->PostInsertDocumentWatermarkText($fileName, $filename = null, $text = null, $rotationAngle = null, $storage = null, $folder = null, $body);
        print_r($result);
}
}

$watermark = new Watermark();
$watermark->postInsertDocumentWatermarkText();

?>
//ExEnd:
