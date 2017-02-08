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
var name = "SampleMailMergeTemplate.docx";
var filedataname = "SampleMailMergeTemplateData.txt";
var destfilename = "updated-" + name;
var storage = "AsposeDropboxStorage";

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, null, storage, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');
	// Invoke Aspose.Words Cloud SDK API to execute mail merge and populate a word document from XML data
	wordsApi.PostDocumentExecuteMailMerge(name, false, null, null, destfilename, storage, null, null, data_path + filedataname, function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');
		if(config.debug){console.log('status:', responseMessage.status);}
		if(config.debug){console.log('body:', responseMessage.body);}
		console.log("mail merge template has been executed successfully");
		
		// Download updated document from storage server
		storageApi.GetDownload(destfilename, null, storage, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			var outfilename = destfilename;
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