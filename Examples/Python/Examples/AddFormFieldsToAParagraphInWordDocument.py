import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import FormField
from asposewordscloud.models import FormFieldResponse


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
sectionindex = 0
paragraphindex = 0

body = FormField.FormField()
body.Name = "MyName"
body.Enabled = True
body.OwnStatus = False
body.CalculateOnExit = True
body.TextInputFormat = "UPPERCASE"
body.TextInputType = "Regular"
body.TextInputDefault = "Farooq Sheikh"

#upload file to aspose cloud storage
storageApi.PutCreate(Path=filename, file=data_folder + filename)

try:
    #invoke Aspose.Words Cloud SDK API to add field in the document
    response = wordsApi.PutFormField(name=filename, sectionIndex=sectionindex, paragraphIndex=paragraphindex, body=body, destFileName=destfilename)

    if response.Status == "OK":
        print "Form field has been added successfully"
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
