import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import ProtectionRequest

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage


apiKey = "b125f13bf6b76ed81ee990142d841195" #sepcify App Key
appSid = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9" #sepcify App SID
apiServer = "http://api.aspose.cloud/v1.1"
data_folder = "../../data/"

#Instantiate Aspose Storage API SDK
storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
storageApi = StorageApi(storage_apiClient)
#Instantiate Aspose Words API SDK
api_client = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, True)
wordsApi = WordsApi(api_client)

#set input file name
filename = "SampleExecuteTemplate.docx"
destfilename = "updated-" + filename
storage = ""

#set input file data name
filedataname = "SampleExecuteTemplateData.txt"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename, storage=storage)

try:
    #invoke Aspose.Words Cloud SDK API to execute mail merge template and populate a word document from XML data
    response = wordsApi.PostExecuteTemplate(name=filename, file=data_folder + filedataname, filename=destfilename, storage=storage)

    if response.Status == "OK":
        print ("mail merge template has been executed successfully")
        #download updated document from storage server
        response = storageApi.GetDownload(Path=destfilename, storage=storage)
        outfilename = "./" + destfilename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print ("ApiException:")
            print ("Code:" + str(ex.code))
            print ("Message:" + ex.message)
