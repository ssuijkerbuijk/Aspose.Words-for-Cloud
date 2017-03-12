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

	public function postUpdateDocumentBookmark() {
        $body = array("Name" => "aspose",  "Text" => "Aspose APIs");
        $fileName = "SampleWordDocument.docx";
        Utils::uploadFile($fileName);
        $result = $this->wordsApi->PostUpdateDocumentBookmark($fileName, $bookmarkName="aspose", $filename = null, $storage = null, $folder = null, $body);
        print_r($result);
	}
}

$bookmarks = new Bookmarks();
$bookmarks->postUpdateDocumentBookmark();

?>