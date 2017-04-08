import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import ProtectionRequest

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage


apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

\#Instantiate Aspose Storage API SDK
storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
storageApi = StorageApi(storage_apiClient)
\#Instantiate Aspose Words API SDK
api_client = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, True)
wordsApi = WordsApi(api_client)

\#set input file name
filename = "SampleWordDocument.docx"
propertyName = "AsposeAuthor"

\#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
\#invoke Aspose.Words Cloud SDK API to get document property by given name from a word document
response = wordsApi.GetDocumentProperty(name=filename, propertyName=propertyName)

if response.Status == "OK":
\#display document property info
print response.DocumentProperty.Name + " : " +   response.DocumentProperty.Value

except ApiException as ex:
print "ApiException:"
print "Code:" + str(ex.code)
print "Message:" + ex.message

