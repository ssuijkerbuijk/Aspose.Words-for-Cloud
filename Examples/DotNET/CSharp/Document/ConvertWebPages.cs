using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class ConvertWebPages
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set input file name
            LoadWebDocumentData body = new LoadWebDocumentData();
            var soptions = new SaveOptionsData();
            soptions.FileName = "google.doc";
            soptions.SaveFormat = "doc";
            soptions.ColorMode = "1";
            soptions.DmlEffectsRenderingMode = "1";
            soptions.DmlRenderingMode = "1";
            soptions.UpdateSdtContent = false;
            soptions.ZipOutput = false;

            body.LoadingDocumentUrl = "http://google.com";
            body.SaveOptions = soptions;

            try
            {
                // Invoke Aspose.Words Cloud SDK API to convert web pages to word documents
                SaveResponse apiResponse = wordsApi.PostLoadWebDocument(body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Document " + apiResponse.SaveResult.DestDocument.Href + " has been generated successfully");
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
