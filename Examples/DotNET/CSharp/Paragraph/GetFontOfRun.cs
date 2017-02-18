using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Paragraph
{
    class GetFontOfRun
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleWordDocument.docx";
            int index = 0;
            int runIndex = 0;
            String storage = null;
            String folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get font informations of a run from word document
                FontResponse apiResponse = wordsApi.GetDocumentParagraphRunFont(fileName, index, runIndex, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Font runFont = apiResponse.Font;
                    Console.WriteLine("Font Name : " + runFont.Name);
                    Console.WriteLine("Style : " + runFont.StyleName);
                    Console.WriteLine("Size : " + runFont.Size);
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
