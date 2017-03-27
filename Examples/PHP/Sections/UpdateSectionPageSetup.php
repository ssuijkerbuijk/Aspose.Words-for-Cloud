//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Sections {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function updateSectionPageSetup() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $body = '{
                    "PageSetup": {
                        "LeftMargin":10.0,
                        "Orientation": "Landscape",
                        "PaperSize": "A5"
                    }
                 }';
        $result = $this->words->UpdateSectionPageSetup($fileName, $sectionIndex=0, $storage = null, $folder = null, $filename = null, $body);
        print_r($result);
    }
}

$sections = new Sections();
$sections->updateSectionPageSetup();

?>
//ExEnd:
