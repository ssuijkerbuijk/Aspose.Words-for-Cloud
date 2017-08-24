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

    public function deleteBorders()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "TableDocument.doc";
        Utils::uploadFile($name);
        
        $table_index = 1;
        $row_index = 0;        

        $result = $this->wordsApi->deleteBorders($name, $table_index, $row_index, $storage=null, $folder=null);
        print_r($result);
    }
}

$tables = new Tables();
$tables->deleteBorders();

?>
//ExEnd:
