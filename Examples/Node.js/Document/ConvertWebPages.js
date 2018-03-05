const { WordsApi, GetDocumentWithFormatRequest, SaveOptionsData,LoadWebDocumentData,PostLoadWebDocumentRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var filename ="WebPageConverterExample.doc";

var loadWebDocumentDataBody =  {
		'LoadingDocumentUrl' : 'http://www.aspose.com/corporate/default.aspx',
		'SaveOptions' : {
			'SaveFormat' : 'doc',
			'FileName' : filename
		}
};

const body = new LoadWebDocumentData();
const saveOptions = new SaveOptionsData(
      {
                fileName: "Temp/google.doc",                
                saveFormat: "doc",
                colorMode: "Normal",
                dmlEffectsRenderingMode: "Simplified",
                dmlRenderingMode: "Fallback",
                updateSdtContent: false,
                zipOutput: false,
      });

body.loadingDocumentUrl = "http://google.com";
body.saveOptions = saveOptions;

const request = new PostLoadWebDocumentRequest({data: body});
wordsApi.postLoadWebDocument(request)
            .then((result) => {
               console.log(result);
            });

