//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class MailMerge {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function postDocumentExecuteMailMerge() {  
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleMailMergeTemplateImage.doc";
		Utils::uploadFile($fileName);    

        $file = realpath(__DIR__ . '/../../..') . '/Data/SampleMailMergeTemplateImageData.txt';
        $result = $this->wordsApi->PostDocumentExecuteMailMerge($fileName, $withRegions=false, $mailMergeDataFile = null, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $file);
        print_r($result);
	}
}

$mailMerge = new MailMerge();
$mailMerge->postDocumentExecuteMailMerge();

?>
//ExEnd:
