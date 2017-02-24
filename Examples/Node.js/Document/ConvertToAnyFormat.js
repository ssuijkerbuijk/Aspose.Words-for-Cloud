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
var filename = "SampleWordDocument";
var name = filename + ".docx";
var format = "html";
var outfilename = "SampleWordDocumentOutput.html";
var body = {'FileName' : outfilename,
        'SaveFormat' : 'html',
        'PrettyFormat' : 'true'
        };
try {
// Upload file to aspose cloud storage
storageApi.PutCreate(name, null, null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to save document to required format
	wordsApi.PostDocumentSaveAs(name, null, null, body, function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');

		// Download document from storage server
		storageApi.GetDownload(outfilename, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
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