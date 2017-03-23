//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Fields {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function deleteDocumentFields() {
		// Upload file to Aspose Cloud Storage
		$fileName = "Test.docx";
		Utils::uploadFile($fileName);     
        
        $result = $this->wordsApi->DeleteDocumentFields($fileName, $storage = null, $folder = null);
        print_r($result);
	}
}

$fields = new Fields();
$fields->deleteDocumentFields();

?>
//ExEnd:
