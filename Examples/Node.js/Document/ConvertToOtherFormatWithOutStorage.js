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
var format = "pdf";

try {

	// Invoke Aspose.Words Cloud SDK API to convert words document to required format using file
	wordsApi.PutConvertDocument(format, null, data_path + name, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			
			// Download output document from response
			var outfilename = filename + '.' + format;
			var writeStream = fs.createWriteStream(data_path + outfilename);
			writeStream.write(responseMessage.body);
			});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1