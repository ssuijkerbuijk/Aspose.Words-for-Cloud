var StorageApi = require('asposestoragecloud');
const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData,PostUpdateDocumentBookmarkRequest,BookmarkData } = require("asposewordscloud");


var config = {'appSid':'78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9','apiKey':'b125f13bf6b76ed81ee990142d841195' , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi(config);

// Set input file name
var name = 'SampleWordDocument.docx';
	
const request = new PostUpdateDocumentBookmarkRequest();
request.name = name;
request.folder = null;
request.bookmarkName = "aspose";
request.bookmarkData = new BookmarkData({
         text: "new text"
});

wordsApi.postUpdateDocumentBookmark(request).then((result) => {
		console.log(result);  
       	}).catch(function(err) {
		console.log(err);
});
	


		
