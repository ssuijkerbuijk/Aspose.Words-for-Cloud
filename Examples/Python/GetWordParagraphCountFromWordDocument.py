import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.models import StatDataResponse

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

#invoke Aspose.Words Cloud SDK API to get document statistics
response = wordsApi.GetDocumentStatistics(filename)

if(response.Status == "OK"):
    print "Total Words: " + str(response.StatData.WordCount);
    print "Total Paragraphs: " + str(response.StatData.ParagraphCount);
    print "Total Page Count: " + str(response.StatData.PageCount);

    for pageStat in response.StatData.PageStatData:
        print "Page# " + str(pageStat.PageNumber)
        print "Page Word Count: " + str(pageStat.WordCount)
        print "Page Paragraph Count: " + str(pageStat.ParagraphCount)

