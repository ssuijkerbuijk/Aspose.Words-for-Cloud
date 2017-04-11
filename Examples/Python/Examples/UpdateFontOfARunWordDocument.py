import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import Font

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
destfilename = "updated-" + filename
index = 1
runIndex = 0

body = Font.Font()
body.Bold = True
body.Size = 31.0
body.Name = "Calibri"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
    #invoke Aspose.Words Cloud SDK API to update font of a specific run of a paragraph present in a word document
    response = wordsApi.PostDocumentParagraphRunFont(name=filename, index=index, runIndex=runIndex, body=body, filename=destfilename)

    if response.Status == "OK":
        print "paragraph run font has been updated successfully"
        #download updated file from cloud storage
        response = storageApi.GetDownload(Path=destfilename)
        outfilename = "c:/temp/" + destfilename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
