using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class AcceptAllTrackingChanges
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set input file name
            String docFileName = "SampleWordDocument.docx";
            String fileName = docFileName;
            String storage = null;
            String folder = null;

            try
            {
                // Upload file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Words Cloud SDK API to accept all tracking changes in document
                RevisionsModificationResponse apiResponse = wordsApi.AcceptAllRevisions(docFileName, null, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Document track changes have been accepted successfully ");
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
