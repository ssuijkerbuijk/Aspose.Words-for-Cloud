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
	
	public function deleteFormField() {  
		// Upload file to Aspose Cloud Storage
		$fileName = "FormFilled.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->DeleteFormField($fileName, $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null);        
        print_r($result);
	}
}

$fields = new Fields();
$fields->deleteFormField();

?>
//ExEnd:
