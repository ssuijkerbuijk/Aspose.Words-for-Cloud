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


	public function deleteDocumentWatermark() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleBlankWatermarkDocument.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->DeleteDocumentWatermark($fileName, $filename = null, $storage = null, $folder = null);        
        print_r($result);
	}
}

$watermark = new Watermark();
$watermark->deleteDocumentWatermark();

?>
//ExEnd:
