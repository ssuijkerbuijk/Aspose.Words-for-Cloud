import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.models import SaveOptionsData
from asposewordscloud.models import SaveResult

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage

apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

try:

    #Instantiate Aspose Storage API SDK
    storageapiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, debug = True)
    storageApi = StorageApi(storageapiClient)
    #Instantiate Aspose Words API SDK
    apiClient = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, debug = True)
    wordsApi = WordsApi(apiClient);

    #set input file name
    filename = "SampleWordDocument.docx"
    format = "pdf"

    outfilename = "SampleWordDocumentOutput.pdf"

    body = SaveOptionsData.SaveOptionsData()
    body.FileName = outfilename
    body.SaveFormat = "pdf"

    # invoke Aspose.Words Cloud SDK API to save document to required format
    response = wordsApi.PostDocumentSaveAs(filename, body)

    if(response.Status == 'OK'):
        outputfilename = response.SaveResult.DestDocument.Href;
        response = storageApi.GetDownload(Path= outputfilename)
        outfilename = "c:/temp/" + outputfilename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
