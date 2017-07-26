// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var WordsApi = require('asposewordscloud');
var configProps = require('../Config/config.json');
var data_path = '../../../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi(config);

// Set input file name
var name = "GetField.docx";
var sectionIndex = 0;
var paragraphIndex = 0;

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to get all fields from document
	wordsApi.GetFields(name, sectionIndex, paragraphIndex, null, null,  function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			console.log("Get all fields from document, Done!");
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1