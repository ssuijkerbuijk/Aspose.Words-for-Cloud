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

	public function postInsertDocumentWatermarkImage() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $file = realpath(__DIR__ . '/../../..') . '/Data/aspose-cloud.png';
        $result = $this->words->PostInsertDocumentWatermarkImage($fileName, $filename = null, $rotationAngle = null, $image = null, $storage = null, $folder = null, $file);
        $this->assertEquals(200, $result->Code);
    }
}

$watermark = new Watermark();
$watermark->postInsertDocumentWatermarkImage();

?>
//ExEnd:
