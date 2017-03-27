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

	public function postInsertPageNumbers() {
		// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $alignment = "center";
        $format = "{PAGE} of {NUMPAGES}";
        $isTop = true;
        $setPageNumberOnFirstPage = true;
        $body = array('Format'=>$format, 'Alignment'=>$alignment,
		'IsTop'=>$isTop, 'SetPageNumberOnFirstPage'=>$setPageNumberOnFirstPage);
        
        $result = $this->words->PostInsertPageNumbers($fileName, $filename = null, $storage = null, $folder = null, $body);
        print_r($result);
    }
}

$fields = new Fields();
$fields->postInsertPageNumbers();

?>
//ExEnd:
