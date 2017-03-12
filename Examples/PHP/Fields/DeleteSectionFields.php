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

	public function deleteSectionFields() {       
		// Upload file to Aspose Cloud Storage
		$fileName = "Test.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->DeleteSectionFields($fileName, $sectionIndex="0", $storage = null, $folder = null);        
        print_r($result);
	}
}

$fields = new Fields();
$fields->deleteSectionFields();

?>