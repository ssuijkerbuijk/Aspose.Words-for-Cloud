const { WordsApi, PostChangeDocumentProtectionRequest, ProtectionRequest} = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

// Set input file name
var fileName = "MathsObject.docx";

request = new PostChangeDocumentProtectionRequest();
request.name = fileName;
request.protectionRequest = new ProtectionRequest({ newPassword: "" });

wordsApi.postChangeDocumentProtection(request).then((result) => {
    console.log(result);     
  }).catch(function(err) {
    // Deal with an error
    console.log(err);
});