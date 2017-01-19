using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document.SplitResources
{
    class SplitSpecificPagesToNewPDFs
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set input file name
            String fileName = "SampleWordDocument.docx";
            String format = "pdf";
            int? from = 1;
            int? to = 2;
            Boolean zipOutput = true;
            String storage = null;
            String folder = null;

            try
            {
                // Upload file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Words Cloud SDK API to split specific pages to new pdfs
                SplitDocumentResponse apiResponse = wordsApi.PostSplitDocument(fileName, format, from, to, zipOutput, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    foreach (Link pageLink in apiResponse.SplitResult.Pages)
                    {
                        String outputFileName = pageLink.Href;
                        Console.WriteLine("file:" + outputFileName);
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
