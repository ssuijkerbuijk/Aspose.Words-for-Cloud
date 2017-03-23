//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class HeadersAndFooters {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function deleteHeadersFooters() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->DeleteHeadersFooters($fileName, $headersFootersTypes = null, $filename = null, $storage = null, $folder = null);        
        print_r($result);
	}
}

$headersAndFooters = new HeadersAndFooters();
$headersAndFooters->deleteHeadersFooters();

?>
//ExEnd:
