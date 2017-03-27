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

	public function getDocumentWithFormat() {
		// Upload file to Aspose Cloud Storage
		$fileName = "Test.docx";
		Utils::uploadFile($fileName);

        $result = $this->wordsApi->GetDocumentWithFormat($fileName, $format="pdf", $storage = null, $folder = null, $outPath = null);        
        $fh = fopen(realpath(__DIR__ . '/../../..'). '/Data/Output/Test.pdf', 'w');
        fwrite($fh, $result);
        fclose($fh);
	}
}

$document = new Document();
$document->getDocumentWithFormat();

?>
//ExEnd:
