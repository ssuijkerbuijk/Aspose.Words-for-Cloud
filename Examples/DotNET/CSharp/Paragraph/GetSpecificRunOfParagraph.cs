using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Paragraph
{
    class GetSpecificRunOfParagraph
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleWordDocument.docx";
            int index = 1;
            int runIndex = 0;
            string storage = null;
            string folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get specific run of paragraph
                RunResponse apiResponse = wordsApi.GetDocumentParagraphRun(fileName, index, runIndex, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Run docParagraphRun = apiResponse.Run;
                    Console.WriteLine("NoteId : " + docParagraphRun.NodeId);
                    Console.WriteLine("Link : " + docParagraphRun.link.Href);
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
