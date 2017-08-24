//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Words\WordsApi;
use Aspose\Words\AsposeApp;

class MathObjects {

	public $wordsApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->wordsApi = new WordsApi();
	}

    public function getOfficeMathObjectsForAParticularSection()
    {       
        // Upload file to Aspose Cloud Storage
        $name = "MathsObject.docx";
        Utils::uploadFile($name);

        $section_index = 0;
        $paragraph_index = 1;
        $result = $this->wordsApi->getOfficeMathObjectsForAParticularSection($name, $section_index, $paragraph_index, $storage=null, $folder=null);
        print_r($result);
    }
}

$mathObjects = new MathObjects();
$mathObjects->getOfficeMathObjectsForAParticularSection();

?>
//ExEnd:
