import asposewordscloud
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.WordsApi import ApiException
from asposewordscloud.models import ResponseMessage



apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

try:
    #Instantiate Aspose Words API SDK
    apiClient = asposewordscloud.ApiClient.ApiClient(apiKey, appSid, debug=True)
    wordsApi = WordsApi(apiClient);

    #set input file name
    name = "SampleWordDocument"
    filename = name + ".docx"
    format = "pdf"

    #invoke Aspose.Words Cloud SDK API to convert words document to required format using file
    response = wordsApi.PutConvertDocument(file=data_folder + filename, format="pdf")

    if(response.Status == "OK"):
        outfilename = "c:/temp/" + name + "." + format
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
