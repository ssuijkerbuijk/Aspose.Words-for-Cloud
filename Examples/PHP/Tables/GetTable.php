//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class Tables {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

	public function getTable()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "TableDocument.doc";
        Utils::uploadFile($name);
        
        $index = 1;
        
        $result = $this->wordsApi->getTable($name, $index, $storage=null, $folder=null);
        print_r($result);
    }
}

$tables = new Tables();
$tables->getTable();

?>
//ExEnd:
