using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class ConvertToOtherFormatWithOutStorage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string format = "pdf";
            string outPath = null;
            string replaceResourcesHostTo = "new_pdf.pdf";
            byte[] file = System.IO.File.ReadAllBytes( Common.GetDataDir() + "test_uploadfile.docx");

            try
            {
                // Invoke Aspose.Words Cloud SDK API
                ResponseMessage apiResponse = wordsApi.PutConvertDocument(format, outPath, replaceResourcesHostTo, file);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    System.Diagnostics.Debug.WriteLine("response:" + apiResponse.ResponseStream);
                    
                    System.IO.File.WriteAllBytes("\\temp\\" + replaceResourcesHostTo, apiResponse.ResponseStream);
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
