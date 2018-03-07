const { WordsApi,GetSectionRequest} = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');


var fileName = "MathsObject.docx";

const request = new GetSectionRequest();
request.name = fileName;
request.sectionIndex = 0;

 wordsApi.getSection(request).then((result) => {
    console.log(result);                    
}).catch(function(err) {
    console.log(err);
});