const { WordsApi, GetDocumentParagraphRunFontRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "SampleWordDocument.docx";
var index = 1;
var runIndex = 0;


const request = new GetDocumentParagraphRunFontRequest();
request.name = fileName;
request.paragraphPath = "sections/0/paragraphs/0";
request.index = 0;


return wordsApi.getDocumentParagraphRunFont(request).then((result) => {
     console.log(result);
}).catch(function(err) {
    console.log(err);
});

