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

var name =  'test_multi_pages.docx';


try {
	storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

		assert.equal(responseMessage.status, 'OK', '');
		
		wordsApi.GetComments(name, null, null, function(responseMessage) {
				console.log('status:', responseMessage.status);
			});
		});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1