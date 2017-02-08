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

try {
	// Invoke Aspose.Words Cloud SDK API to execute mail merge online and populate a word document from XML data
	wordsApi.PutExecuteMailMergeOnline(false, null, data_path + name, data_path + filedataname, function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');
		console.log("mail merge online template has been executed successfully");
		
		// Download updated document from response
		var outfilename = destfilename;
		var writeStream = fs.createWriteStream(data_path + outfilename);
		writeStream.write(responseMessage.body);

	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1