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


	public function postLoadWebDocument() {
        $xml = <<<XML
          <LoadWebDocumentData>
             <LoadingDocumentUrl>http://google.com</LoadingDocumentUrl>
             <DocSaveOptionsData>
                <SaveFormat>doc</SaveFormat>
                <FileName>google.doc</FileName>
             </DocSaveOptionsData>
          </LoadWebDocumentData>
XML;
        $strXML = simplexml_load_string($xml);
        $result = $this->wordsApi->PostLoadWebDocument($strXML->asXML());
        print_r($result);
    }
}

$document = new Document();
$document->postLoadWebDocument();

?>