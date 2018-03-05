const { WordsApi,GetDocumentPropertiesRequest } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "SampleWordDocument.docx";
const request = new GetDocumentPropertiesRequest();
request.name = fileName;


wordsApi.getDocumentProperties(request).then((result) => {
         console.log(result.body);
}).catch(function(err) {
    console.log(err);
});
