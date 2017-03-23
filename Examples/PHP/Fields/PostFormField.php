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


	public function postFormField() {
        // Upload file to Aspose Cloud Storage
        $fileName = "FormFilled.docx";
        Utils::uploadFile($fileName);
        
        $body = '{
              "NodeId": "0.0.0",
              "Name": "BirthDate",
              "Enabled": true,
              "StatusText": "Enter your date of birth.",
              "OwnStatus": true,
              "HelpText": "Enter your date of birth.",
              "OwnHelp": true,
              "CalculateOnExit": false,
              "EntryMacro": "",
              "ExitMacro": "",
              "TextInputFormat": "yyyy-MM-dd",
              "TextInputType": "Date",
              "TextInputDefault": "",
              "MaxLength": 0,
              "link": {
                "Href": "FormFilled.docx/sections/0/paragraphs/0/formfields/0",
                "Rel": "self",
                "Type": null,
                "Title": null
              }
            }';
        $result = $this->words->PostFormField($name="FormFilled.docx", $sectionIndex="0", $paragraphIndex="0", $formfieldIndex="0", $destFileName = null, $storage = null, $folder = null, $body);
        $this->assertEquals(200, $result->Code);
    }  
}

$fields = new Fields();
$fields->postFormField();

?>
//ExEnd:
