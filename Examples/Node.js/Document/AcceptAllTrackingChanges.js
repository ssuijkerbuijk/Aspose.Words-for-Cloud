
const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData,AcceptAllRevisionsRequest } = require("asposewordscloud");
var config = {'appSid':'78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9','apiKey':'b125f13bf6b76ed81ee990142d841195' , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
var wordsApi = new WordsApi(config);


// Set input file name
var name = "SampleWordDocument.docx";

const request = new AcceptAllRevisionsRequest();
request.name = name;
request.folder = null;

return wordsApi.acceptAllRevisions(request).then((result) => {
       console.log(result);
}).catch(function(err) {
    	console.log(err);
});

