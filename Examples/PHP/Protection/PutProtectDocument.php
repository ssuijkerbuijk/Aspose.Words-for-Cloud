//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Protection {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}


	public function putProtectDocument() {
    	// Upload file to Aspose Cloud Storage
		$fileName = "SampleWordDocument.docx";
		Utils::uploadFile($fileName);

        $password = "123456";
        $protectionType = "AllowOnlyComments";
        $body = array('Password' => $password, 'ProtectionType' => $protectionType);
        
        $result = $this->wordsApi->PutProtectDocument($fileName, $filename = null, $storage = null, $folder = null, $body);
        print_r($result);
}

$protection = new Protection();
$protection->putProtectDocument();

?>
//ExEnd:
