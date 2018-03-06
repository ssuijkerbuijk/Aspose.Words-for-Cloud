const { WordsApi, ReplaceTextRequest,PostReplaceTextRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

var fileName = "SampleWordDocument.docx";

const request = new PostReplaceTextRequest();
request.name = fileName;
request.replaceText = new ReplaceTextRequest ({ oldValue: "aspose", newValue: "aspose new" });

wordsApi.postReplaceText(request).then((result) => {
    console.log(result);                       
}).catch(function(err) {
    console.log(err);
});
