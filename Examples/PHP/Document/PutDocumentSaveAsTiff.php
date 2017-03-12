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


	public function putDocumentSaveAsTiff() {
        $body = '{                    
                    "TiffCompression": "Ccitt4",
                    "PageCount": 1,
                    "PixelFormat": "Format16BppRgb555",
                    "PaperColor": "Red",
                    "Resolution": 200,
                    "Scale": 1.5,
                    "ImageBrightness": 0.5,
                    "ImageColorMode": "None",
                    "ImageContrast": 0.9,
                    "UseHighQualityRendering": true,
                    "UseAntiAliasing": true,
                    "PageIndex": 0,                    
                    "NumeralFormat": "EasternArabicIndic",
                    "SaveFormat": "tiff",
                    "FileName": "MyDocument1.tiff"
                  }';

        $result = $this->wordsApi->PutDocumentSaveAsTiff($name="Test.docx", $resultFile = null, $useAntiAliasing = null, $useHighQualityRendering = null, $imageBrightness = null, $imageColorMode = null, $imageContrast = null, $numeralFormat = null, $pageCount = null, $pageIndex = null, $paperColor = null, $pixelFormat = null, $resolution = null, $scale = null, $tiffCompression = null, $dmlRenderingMode = null, $dmlEffectsRenderingMode = null, $tiffBinarizationMethod = null, $storage = null, $folder = null, $zipOutput = null, $body);
        print_r($result);
    }
}

$document = new Document();
$document->putDocumentSaveAsTiff();

?>