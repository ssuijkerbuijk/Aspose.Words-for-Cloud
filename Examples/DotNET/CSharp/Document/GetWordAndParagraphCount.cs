using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class GetWordAndParagraphCount
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            // Set input file name
            String fileName = "SampleWordDocument.docx";          
            String storage = null;
            String folder = null;

            try
            {
                // Upload file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Words Cloud SDK API to get word and paragraph count from word document
                StatDataResponse apiResponse = wordsApi.GetDocumentStatistics(fileName, false, false, false, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Total Words: " + apiResponse.StatData.WordCount);
                    Console.WriteLine("Total Paragraphs: " + apiResponse.StatData.ParagraphCount);
                    Console.WriteLine("Total Page Count: " + apiResponse.StatData.PageCount);

                    foreach (PageStatData pageStat in apiResponse.StatData.PageStatData)
                    {
                        Console.WriteLine("Page# " + pageStat.PageNumber);
                        Console.WriteLine("Page Word Count: " + pageStat.WordCount);
                        Console.WriteLine("Page Paragraph Count: " + pageStat.ParagraphCount);
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
