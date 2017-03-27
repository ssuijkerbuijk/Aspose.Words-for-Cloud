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


	public function putExecuteTemplateOnline() {
        $file = realpath(__DIR__ . '/../..') . '/Data/SampleMailMergeTemplateData.xml';
        $result = $this->wordsApi->PutExecuteTemplateOnline($cleanup = null, $useWholeParagraphAsRegion = null, $withRegions = null, $file);
        print_r($result);
	}
}

$mailMerge = new MailMerge();
$mailMerge->putExecuteTemplateOnline();

?>
//ExEnd:
