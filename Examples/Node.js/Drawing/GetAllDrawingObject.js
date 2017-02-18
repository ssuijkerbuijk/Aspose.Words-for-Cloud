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
var name = "SampleWordDocument.docx";
var format = "PNG";

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

		// Invoke Aspose.Words Cloud SDK API to get list of all drawing objects present in a word document
		wordsApi.GetDocumentDrawingObjects(name, null, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			// Export all drawing objects to PNG

			 responseMessage.body.DrawingObjects.List.forEach(function(item) {
				 var objectIndex  = item.link.Href.substring(item.link.Href.lastIndexOf('/')+1);
				 wordsApi.GetDocumentDrawingObjectByIndexWithFormat(name, objectIndex, format, null, null, function(responseMessage) {
						assert.equal(responseMessage.status, 'OK');
						var destfilename = "DrawingObject_out_" + objectIndex + ".png";
						var writeStream = fs.createWriteStream(data_path + destfilename);
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