using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Mail_Merge
{
    class ExecuteTemplate
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "TestExecuteTemplate.doc";
            string cleanup = null;
            string destFileName = "TestExecuteResult.doc";
            string storage = null;
            string folder = null;
            bool useWholeParagraphAsRegion = false;
            bool withRegions = false;
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + "TestExecuteTemplateData.txt");

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                
                // Invoke Aspose.Words Cloud SDK API to execute mail merge temlate
                DocumentResponse apiResponse = wordsApi.PostExecuteTemplate(fileName, cleanup, destFileName, storage, folder, useWholeParagraphAsRegion, withRegions, file);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);
                    System.Diagnostics.Debug.WriteLine("response:" + storageRes.ResponseStream);
                    System.IO.File.WriteAllBytes(Common.GetDataDir() + destFileName, storageRes.ResponseStream);

                    Console.WriteLine("Mail merge template has been executed successfully");
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
