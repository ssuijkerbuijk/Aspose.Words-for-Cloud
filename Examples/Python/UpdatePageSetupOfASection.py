import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import PageSetup

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
filename = "SampleBlankWordDocument.docx"
destfilename = "updated-" + filename
sectionIndex = 0

body = PageSetup.PageSetup()
body.RtlGutter = True
body.Orientation = "Portrait"
body.PaperSize = "A5"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
    #invoke Aspose.Words Cloud SDK API to update page setup properties by given section index from a word document
    response = wordsApi.UpdateSectionPageSetup(name=filename, sectionIndex=sectionIndex, body=body, filename=destfilename)

    if response.Status == "OK":
        secPageSetup = response.PageSetup
        if(secPageSetup is not None):
            #display section page setup info
            print "PaperSize :" + response.PageSetup.PaperSize + "  Orientation:  " + response.PageSetup.Orientation

        #download updated document from storage server
        response = storageApi.GetDownload(Path=destfilename)
        outfilename = "c:/temp/" + destfilename
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
