import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.models import DocumentEntry
from asposewordscloud.models import DocumentEntryList
from asposewordscloud.models import DocumentResponse

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

    #set destination file name
    source_file_name = "AppendWordDocumentsExample-TestFile-Source.doc"
    #set source file name
    dest_file_name = "AppendWordDocumentsExample-TestFile-Destination.doc"

    #upload source file to aspose cloud storage
    storageApi.PutCreate(source_file_name, data_folder + source_file_name)
    #upload destination file to aspose cloud storage
    storageApi.PutCreate(dest_file_name, data_folder + dest_file_name)

    document_entry_1 = DocumentEntry.DocumentEntry()
    document_entry_1.Href = source_file_name
    document_entry_1.ImportFormatMode = "KeepSourceFormatting"

    body = DocumentEntryList.DocumentEntryList()
    body.DocumentEntries = [document_entry_1]

    #invoke Aspose.Words Cloud SDK API to append word document
    response = wordsApi.PostAppendDocument(dest_file_name, body)

    if(response.Status == 'OK'):
        print "Documents have been appended successfully"
        #download appended document from storage server
        response = storageApi.GetDownload(Path=dest_file_name)
        outfilename = "c:/temp/" + dest_file_name
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
