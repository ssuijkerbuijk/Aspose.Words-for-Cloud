using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Watermark
{
    class RemoveWatermark
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleBlankWatermarkDocument.docx";
            String destFileName = "updated-" + fileName;
            String storage = null;
            String folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to remove watermark from document
                DocumentResponse apiResponse = wordsApi.DeleteDocumentWatermark(fileName, destFileName, storage, folder);


                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Watermark is removed successfully");
                    Console.ReadKey();
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
