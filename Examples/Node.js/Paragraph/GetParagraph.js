const { WordsApi,GetDocumentParagraphRequest} = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "SampleWordDocument.docx";
const request = new GetDocumentParagraphRequest();
request.name = fileName;
request.index = 0;


wordsApi.getDocumentParagraph(request).then((result) => {
        console.log(result);
}).catch(function(err) {
    console.log(err);
});

