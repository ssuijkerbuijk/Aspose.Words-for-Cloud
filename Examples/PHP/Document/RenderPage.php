//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Document {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

    public function renderPage()
    {
        // Upload file to Aspose Cloud Storage
        $name = "SampleWordDocument.docx";
        Utils::uploadFile($name);

        $page_index = 1;
        $format = "bmp";

        $result = $this->wordsApi->renderPage($name, $page_index, $format, $storage=null, $folder=null);
    }
}

$document = new Document();
$document->renderPage();

?>
//ExEnd: