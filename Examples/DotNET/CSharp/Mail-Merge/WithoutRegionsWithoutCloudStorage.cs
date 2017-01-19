using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Mail_Merge
{
    class WithoutRegionsWithoutCloudStorage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleMailMergeTemplate.docx";
            String fileDataName = "SampleMailMergeTemplateData.txt";

            String cleanup = null;
            Boolean withRegions = false;

            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName);
            byte[] data = System.IO.File.ReadAllBytes(Common.GetDataDir() + fileDataName);

            try
            {
                // Invoke Aspose.Words Cloud SDK API to execute mail merge without regions and without using the cloud storage
                ResponseMessage apiResponse = wordsApi.PutExecuteMailMergeOnline(withRegions, cleanup, file, data);


                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("mail merge online template has been executed successfully");
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
