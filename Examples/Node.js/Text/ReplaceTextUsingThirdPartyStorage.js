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
var name = "SampleWordDocument.docx";
var storage = "AsposeDropboxStorage";
var replaceTextRequestBody = {
		'OldValue' : 'aspose',
		'NewValue' : 'aspose.com'
		};

try {
// Upload source file to 3rd party cloud storage
storageApi.PutCreate(name, null, storage, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to replace text from a given word document
	wordsApi.PostReplaceText(name, null, storage, null, replaceTextRequestBody, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			console.log("Document has been updated successfully.");
			
			// Download updated document from storage server
			storageApi.GetDownload(name, null, storage, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var outfilename = name;
				var writeStream = fs.createWriteStream(data_path + outfilename);
				writeStream.write(responseMessage.body);
				});
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1