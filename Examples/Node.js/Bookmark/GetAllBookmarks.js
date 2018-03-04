// ExStart:1
var StorageApi = require('asposestoragecloud');
const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData,GetDocumentBookmarksRequest } = require("asposewordscloud");
var data_path = '../../../Data/';
var assert = require('assert');

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':'78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9','apiKey':'b125f13bf6b76ed81ee990142d841195' , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var name = "MathsObject.docx";

try {
	const request = new GetDocumentBookmarksRequest();
        request.name = name;
	wordsApi.getDocumentBookmarks(request)
                        .then((result) => {
		              console.log(result);
                        }).catch(function(err) {
    				console.log(err);
			});



}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1
