import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import DrawingObjectsResponse

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

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
    #invoke Aspose.Words Cloud SDK API to get list of all drawing objects present in a word document
    response = wordsApi.GetDocumentDrawingObjects(name=filename)
    if response.Status == "OK":
        #export all drawing objects to PNG
        objectIndex = 0
        for item in response.DrawingObjects.List:
            pngImageDataRes = wordsApi.GetDocumentDrawingObjectByIndexWithFormat(name=filename, objectIndex=objectIndex, format="png");
            destfilename = "DrawingObject_" + str(objectIndex) + ".png";
            outfilename = "c:/temp/" + destfilename
            with open(outfilename, 'wb') as f:
                        for chunk in pngImageDataRes.InputStream:
                            f.write(chunk)
            objectIndex = objectIndex + 1

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message

