using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class ConvertToAnyFormat
    {
        public static void Run()
        {
            // ExStart:1
           
                WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
                StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

                // Set input file name
                String fileName = "Rendering.docx";
                String storage = null;
                String folder = null;

                Com.Aspose.Words.Model.SaveOptionsData body = new Com.Aspose.Words.Model.SaveOptionsData();
                body.SaveFormat = "pdf";
                body.FileName = "output.pdf";


                try
                {
                    
                    // Upload file to aspose cloud storage
                    storageApi.PutCreate(fileName, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                    // Invoke Aspose.Words Cloud SDK API to convert words document to required format
                    SaveResponse apiResponse = wordsApi.PostDocumentSaveAs(fileName, storage, folder, body);

                    if (apiResponse != null && apiResponse.Status.Equals("OK"))
                    {
                        Console.WriteLine("doc:" + apiResponse.SaveResult.DestDocument.Href);
                        //Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
        // ExEnd:1    
}

