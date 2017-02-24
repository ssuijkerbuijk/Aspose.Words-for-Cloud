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
var name = 'SampleWordDocument.docx';
var bookmarkName = 'aspose';

try {	
	storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

		assert.equal(responseMessage.status, 'OK', '');
			
		wordsApi.GetDocumentBookmarkByName(name, bookmarkName, null, null, function(responseMessage) {
				if(config.debug){console.log('status:', responseMessage.status);}
				if(config.debug){console.log('body:', responseMessage.body);}
				assert.equal(responseMessage.status, 'OK', '');
				assert.ok(responseMessage.body !== null && typeof responseMessage.body.Bookmark !== 'undefined', "response body assertion should pass");
				
			});
		});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1