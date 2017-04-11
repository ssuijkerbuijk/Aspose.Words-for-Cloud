import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import PageNumber
from asposewordscloud.models import DocumentResponse


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

#configure third party storage name
storage = "AsposeDropboxStorage"

body = PageNumber.PageNumber()
body.Format = "{PAGE} of {NUMPAGES}"
body.Alignment = "center"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename, storage=storage)

try:
    #invoke Aspose.Words Cloud SDK API to insert page number field into a word document
    response = wordsApi.PostInsertPageNumbers(name=filename, body=body, storage=storage)

    if response.Status == "OK":
        print "Page Number Field has been inserted successfully"
        #download updated document from storage server
        response = storageApi.GetDownload(Path=filename, storage=storage)
        outfilename = "c:/temp/" + filename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message


