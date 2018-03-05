const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData,GetCommentRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');


var fileName =  'test_multi_pages.docx';

const request = new GetCommentRequest();
request.name = fileName;
request.commentIndex = 0;

wordsApi.getComment(request).then((result) => {
	console.log(result);
}).catch(function(err) {
    	console.log(err);
});
