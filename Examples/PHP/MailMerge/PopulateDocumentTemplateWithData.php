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

	public function populateDocumentTemplateWithData() {  
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleExecuteTemplate.doc";
		Utils::uploadFile($fileName);    

        $file = realpath(__DIR__ . '/../../..') . '/Data/SampleExecuteTemplateData.txt';
        $result = $this->wordsApi->PostExecuteTemplate($fileName, $cleanup = null, $filename = null, $storage = null, $folder = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file);
        print_r($result);
	}
}

$mailMerge = new MailMerge();
$mailMerge->populateDocumentTemplateWithData();

?>
//ExEnd:
