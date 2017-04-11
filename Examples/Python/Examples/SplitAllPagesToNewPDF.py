import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.models import SplitDocumentResponse

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage



apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

#Instantiate Aspose Storage API SDK
storageapiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, debug = True)
storageApi = StorageApi(storageapiClient)
#Instantiate Aspose Words API SDK
apiClient = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, debug = True)
wordsApi = WordsApi(apiClient)

#set input file name
filename = "SampleWordDocument.docx"
format = "pdf"

#upload input file to aspose cloud storage
storageApi.PutCreate(Path = filename, file = data_folder + filename)

#invoke Aspose.Words Cloud SDK API to split word document
response = wordsApi.PostSplitDocument(name=filename, format=format, zipOutput='true')

if response.Status == 'OK':
    print "Document has been splitted to pfds successfully"
    #download splitted pdfs from storage server as zipOutput
    outfilename = response.SplitResult.ZippedPages.Href
    response = storageApi.GetDownload(Path=outfilename)
    with open("c:/temp/" + outfilename, 'wb') as f:
        for chunk in response.InputStream:
            f.write(chunk)
