using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Watermark
{
    class AddWatermarkText
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleBlankWordDocument.docx";
            String destFileName = "updated-" + fileName;
            Double rotationAngle = 0.0;
            String storage = "dropboxstorage";
            String folder = null;
            String text = "New";
            WatermarkText body = new WatermarkText();
            body.Text = "aspose.com";

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to add watermark text to document
                DocumentResponse apiResponse = wordsApi.PostInsertWatermarkText(fileName, text, rotationAngle, destFileName, storage, folder, body);


                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Watermark text has been added successfully");
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
