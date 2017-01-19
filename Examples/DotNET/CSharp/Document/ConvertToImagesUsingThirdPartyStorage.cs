using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class ConvertToImagesUsingThirdPartyStorage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "test_uploadfile.docx";
            String format = "pdf";
            String storage = "dropboxstorage";
            String folder = "";
            String outPath = "";


            try
            {
                // Upload file to aspose cloud storage
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Words Cloud SDK API to convert words document to images using third party storage
                ResponseMessage apiResponse = wordsApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    System.Diagnostics.Debug.WriteLine("response:" + apiResponse.ResponseStream);
                    System.IO.File.WriteAllBytes( Common.GetDataDir() + "WordFormatConverterExampleTest.pdf", apiResponse.ResponseStream);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
