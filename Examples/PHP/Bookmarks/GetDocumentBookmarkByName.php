<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Bookmarks {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function getDocumentBookmarkByName() {
        // Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocumentBookmarkByName($fileName, $bookmarkName="aspose", $storage = null, $folder = null);        
        print_r($result);
	}
}

$bookmarks = new Bookmarks();
$bookmarks->getDocumentBookmarkByName();

?>