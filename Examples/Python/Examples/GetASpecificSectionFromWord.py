import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import SectionResponse

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

sectionIndex = 0

try:
    #invoke Aspose.Words Cloud SDK API to get a specific section present from a word document
    response = wordsApi.GetSection(name=filename, sectionIndex=sectionIndex)

    if response.Status == "OK":
        #get section href
        print "Section Href :: " + response.Section.link.Href

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message

