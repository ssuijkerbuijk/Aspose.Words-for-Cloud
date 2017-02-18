// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var WordsApi = require('asposewordscloud');
var configProps = require('../Data/config.json');
var data_path = '../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi(config);

// Set input file name
var name = "SampleWordDocument.docx";
var index = 1;

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to get a specific paragraph from a word document
	wordsApi.GetDocumentParagraph(name, index, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			var docParagraph = responseMessage.body.Paragraph;
			
			// Display document paragraph info
			console.log("NoteId : " + docParagraph.NodeId);
			console.log("Link : " + docParagraph.link.Href);
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1