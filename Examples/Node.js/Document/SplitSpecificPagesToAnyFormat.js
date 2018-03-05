const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData,PostSplitDocumentRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "SampleWordDocument.docx";
var format = "png";

const request = new PostSplitDocumentRequest();                
request.name = fileName;
request.format = format;
request.from = 1;
request.to = 2;
request.destFileName = "NewImage.png";
	
wordsApi.postSplitDocument(request).then((result) => {
              console.log(result);
}).catch(function(err) {
    		console.log(err);
});
               
