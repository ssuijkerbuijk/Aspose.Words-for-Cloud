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
var name = "SampleMailMergeTemplateImage.doc";
var filedataname = "SampleMailMergeTemplateImageData.txt";
var destfilename = "updated-" + name;
var logofile = "header-logo.png";

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	storageApi.PutCreate(logofile, null, null, file= data_path + logofile , function(responseMessage) {

		// Invoke Aspose.Words Cloud SDK API to execute mail merge and populate a word document from XML data
		wordsApi.PostDocumentExecuteMailMerge(name, false, null, null, destfilename, null, null, false, data_path + filedataname, function(responseMessage) {

			assert.equal(responseMessage.status, 'OK');
			if(config.debug){console.log('status:', responseMessage.status);}
			if(config.debug){console.log('body:', responseMessage.body);}
			console.log("mail merge template has been executed successfully");
			
			// Download updated document from storage server
			storageApi.GetDownload(destfilename, null, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var outfilename = destfilename;
				var writeStream = fs.createWriteStream(data_path + outfilename);
				writeStream.write(responseMessage.body);
				});
			});
	});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1