const { WordsApi, PostDocumentSaveAsRequest, SaveOptionsData } = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');

var filename = "SampleWordDocument.docx";
var format = "html";
var outfilename = "SampleWordDocumentOutput.html";


const request = new PostDocumentSaveAsRequest({
               	saveOptionsData: new SaveOptionsData({
                        saveFormat: format,
                        fileName: outfilename
                }) 
});
request.name= filename;
wordsApi.postDocumentSaveAs(request).then((result) => {
          console.log(result);
         	}).catch(function(err) {
    			console.log(err);
});

