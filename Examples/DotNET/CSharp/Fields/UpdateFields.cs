using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Fields
{
    class UpdateFields
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleWordDocument.docx";
            String storage = null;
            String folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                
                // Invoke Aspose.Words Cloud SDK API to update all fields in document
                DocumentResponse apiResponse = wordsApi.PostUpdateDocumentFields(fileName, fileName, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Document fields have been updated successfully");
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
