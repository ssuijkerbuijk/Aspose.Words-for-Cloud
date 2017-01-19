using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Fields
{
    class GetMergeFieldNames
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleMailMergeTemplate.docx";
            String storage = null;
            String folder = null;
            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get merge field names from document
                FieldNamesResponse apiResponse = wordsApi.GetDocumentFieldNames(fileName, false, storage, folder);
                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    foreach (String fieldName in apiResponse.FieldNames.Names)
                    {
                        Console.WriteLine(fieldName);
                    }
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
