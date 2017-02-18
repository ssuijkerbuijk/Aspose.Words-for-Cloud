using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class AppendDocuments
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set destination file name
            String destFileName = "test_doc.docx";

            // Set source file name
            String sourceFileName = "test_uploadfile.docx";

            Com.Aspose.Words.Model.DocumentEntryList body = new Com.Aspose.Words.Model.DocumentEntryList();
            List<Com.Aspose.Words.Model.DocumentEntry> docEntries = new List<Com.Aspose.Words.Model.DocumentEntry>();

            Com.Aspose.Words.Model.DocumentEntry docEntry = new Com.Aspose.Words.Model.DocumentEntry();
            docEntry.Href = sourceFileName;
            docEntry.ImportFormatMode = "KeepSourceFormatting";

            docEntries.Add(docEntry);
            body.DocumentEntries = docEntries;
            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(sourceFileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + destFileName));

                // Upload destination file to aspose cloud storage
                storageApi.PutCreate(destFileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + sourceFileName));

                // Invoke Aspose.Words Cloud SDK API to append word document
                Com.Aspose.Words.Model.DocumentResponse apiResponse = wordsApi.PostAppendDocument(destFileName, null, null, null, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Documents have been appended successfully");
                    
                    Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(destFileName, null, null);
                    System.Diagnostics.Debug.WriteLine("response:" + storageRes.ResponseStream);
                    System.IO.File.WriteAllBytes(Common.GetDataDir() + sourceFileName, storageRes.ResponseStream);
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
