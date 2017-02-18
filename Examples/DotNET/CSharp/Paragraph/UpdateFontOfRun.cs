using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Paragraph
{
    class UpdateFontOfRun
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleWordDocument.docx";
            string destFileName = "updated-" + fileName;
            int index = 0;
            int runIndex = 0;
            string storage = null;
            string folder = null;

            Font body = new Font();
            body.Bold = true;
            body.Size = 31.0;
            body.Name = "Calibri";

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to update font of run
                FontResponse apiResponse = wordsApi.PostDocumentParagraphRunFont(fileName, index, runIndex, storage, folder, destFileName, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("paragraph run font has been updated successfully");
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
