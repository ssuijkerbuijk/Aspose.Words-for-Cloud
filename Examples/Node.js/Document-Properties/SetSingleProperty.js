const { WordsApi, CreateOrUpdateDocumentPropertyRequest,DocumentProperty} = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "SampleWordDocument.docx";

request = new CreateOrUpdateDocumentPropertyRequest();
request.name = fileName;
request.propertyName = "Author";
request.property = new DocumentProperty({name: "Author", value: "AuthorValue"});
                   

wordsApi.createOrUpdateDocumentProperty(request).then((result) => {
    console.log(result);
}).catch(function(err) {
    console.log(err);
});
