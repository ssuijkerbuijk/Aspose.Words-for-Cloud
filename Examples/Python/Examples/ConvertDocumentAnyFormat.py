import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException

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
    name = "SampleWordDocument"
    filename = name + ".docx"
    format = "pdf"

    #upload file to aspose cloud storage
    storageApi.PutCreate(filename, data_folder + filename)

    #invoke Aspose.Words Cloud SDK API to convert words document to required format
    response = wordsApi.GetDocumentWithFormat(name=filename, format=format)

    if response.Status == 'OK':
        outfilename = "c:/temp/" + name + "." + format
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message

