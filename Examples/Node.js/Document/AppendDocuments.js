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
var name =  'SampleWordDocument.docx';
var document1 =  'FormFilled.docx';

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Upload appended file to aspose cloud storage
	storageApi.PutCreate(document1, null, null, file= data_path + document1 , function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');

		var documentEntryList =  {'DocumentEntries' : [
			                          {
			                        	'Href' : document1,
			          					'ImportFormatMode' : 'KeepSourceFormatting'

			                          }
			                       ]};

		// Invoke Aspose.Words Cloud SDK API to append word document
		wordsApi.PostAppendDocument(name, null, null, null, documentEntryList, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			console.log("Documents have been appended successfully");

			// Download appended document from storage server
			storageApi.GetDownload(name, null, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var outfilename = 'appended-' + name;
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