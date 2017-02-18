using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Fields
{
    class InsertPageNumberFieldUsingThirdPartyStorage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleWordDocument.docx";
            String storage = "dropboxstorage";
            String folder = null;

            PageNumber body = new PageNumber();
            body.Format = "{PAGE} of {NUMPAGES}";
            body.Alignment = "center";


            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to insert page number using third party storage
                DocumentResponse apiResponse = wordsApi.PostInsertPageNumbers(fileName, fileName, storage, folder, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Page Number Field has been inserted successfully");
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
