using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document_Properties
{
    class GetAllDocumentProperties
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
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get all document properties
                DocumentPropertiesResponse apiResponse = wordsApi.GetDocumentProperties(fileName, storage, folder);


                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Doc Properties");
                    foreach (DocumentProperty docProperty in apiResponse.DocumentProperties.List)
                    {
                        Console.WriteLine(docProperty.Name + "  :  " + docProperty.Value);
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
