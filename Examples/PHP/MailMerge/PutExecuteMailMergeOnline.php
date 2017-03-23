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

	public function putExecuteMailMergeOnline() {
        $data['file2'] = new CurlFile(realpath(__DIR__ . '/../../..') . '/Data/SampleMailMergeTemplate.docx', 'application/msword');
        $data['file1'] = new CurlFile(realpath(__DIR__ . '/../../..') . '/Data/SampleMailMergeTemplateData.xml', 'text/xml');
        $result = $this->wordsApi->PutExecuteMailMergeOnline($withRegions='false', $cleanup = null, $data);
        print_r($result);
	}
}

$mailMerge = new MailMerge();
$mailMerge->putExecuteMailMergeOnline();

?>
//ExEnd:
