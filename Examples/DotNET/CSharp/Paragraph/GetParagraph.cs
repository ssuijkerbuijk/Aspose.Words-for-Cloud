using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Paragraph
{
    class GetParagraph
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleWordDocument.docx";
            int index = 1;
            string storage = null;
            string folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get paragraph from word document
                ParagraphResponse apiResponse = wordsApi.GetDocumentParagraph(fileName, index, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Com.Aspose.Words.Model.Paragraph docParagraph = apiResponse.Paragraph;
                    Console.WriteLine("NoteId : " + docParagraph.NodeId);
                    Console.WriteLine("Link : " + docParagraph.link.Href);
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
