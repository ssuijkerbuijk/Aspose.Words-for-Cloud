const { WordsApi, WatermarkText,PostInsertDocumentWatermarkTextRequest} = require("asposewordscloud");
wordsApi = new WordsApi('78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9', 'b125f13bf6b76ed81ee990142d841195');


var fileName = "MathsObject.docx";
const request = new PostInsertDocumentWatermarkTextRequest();
request.name = fileName;
request.watermarkText = new WatermarkText ({ text: "This is the text", rotationAngle: 90.0 });

wordsApi.postInsertDocumentWatermarkText(request).then((result) => {
     console.log(result);        
}).catch(function(err) {
    console.log(err);
});