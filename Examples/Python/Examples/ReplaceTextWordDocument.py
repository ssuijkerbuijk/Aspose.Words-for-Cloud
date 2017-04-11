import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import ReplaceTextRequest

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage


apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

#Instantiate Aspose Storage API SDK
storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
storageApi = StorageApi(storage_apiClient)
#Instantiate Aspose Words API SDK
api_client = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, True)
wordsApi = WordsApi(api_client)

#set input file name
filename = "SampleWordDocument.docx"

body = ReplaceTextRequest.ReplaceTextRequest()
body.OldValue = "aspose"
body.NewValue = "aspose.com"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
    #invoke Aspose.Words Cloud SDK API to replace text from a given a Word document
    response = wordsApi.PostReplaceText(name=filename, body=body)

    if response.Status == "OK":
        print "Document has been updated successfully"
        #download updated document from storage server
        response = storageApi.GetDownload(Path=filename)
        outfilename = "c:/temp/" + filename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
