import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import LoadWebDocumentData
from asposewordscloud.models import SaveOptionsData

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage


apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

try:

    #Instantiate Aspose Storage API SDK
    storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
    storageApi = StorageApi(storage_apiClient)
    #Instantiate Aspose Words API SDK
    api_client = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, True)
    wordsApi = WordsApi(api_client);

    #set output file name
    filename ="WebPageConverterExample.doc"

    loadWebDocumentData = LoadWebDocumentData.LoadWebDocumentData()
    loadWebDocumentData.LoadingDocumentUrl = "http://www.aspose.com/corporate/default.aspx"
    saveOptionsData = SaveOptionsData.SaveOptionsData()
    saveOptionsData.FileName = filename
    saveOptionsData.SaveFormat = "doc"
    loadWebDocumentData.SaveOptions=saveOptionsData

    #invoke Aspose.Words Cloud SDK API to convert live web page into words document
    response = wordsApi.PostLoadWebDocument(body=loadWebDocumentData)

    if(response.Status == 'OK'):
        print "Document has been generated successfully"
        #download output document from storage server
        response = storageApi.GetDownload(Path=filename)
        outfilename = "c:/temp/" + filename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message

