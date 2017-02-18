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
var filename ="WebPageConverterExample.doc";

var loadWebDocumentDataBody =  {
		'LoadingDocumentUrl' : 'http://www.aspose.com/corporate/default.aspx',
		'SaveOptions' : {
			'SaveFormat' : 'doc',
			'FileName' : filename
		}
};

try {
	// Invoke Aspose.Words Cloud SDK API to convert live web page into words document
	wordsApi.PostLoadWebDocument(loadWebDocumentDataBody, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			console.log("Document has been generated successfully");

			// Download output document from storage server
			var outfilename = filename;
			storageApi.GetDownload(outfilename, null, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var writeStream = fs.createWriteStream(data_path + outfilename);
				writeStream.write(responseMessage.body);
				});
		});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1