using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Watermark
{
    class AddWatermarkImage
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleBlankWordDocument.docx";
            string destFileName = "updated-" + fileName;
            double rotationAngle = 45.0;
            string storage = "dropboxstorage";
            string folder = null;
            string image = "aspose-cloud.png";
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName);


            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to add watermark image to document
                DocumentResponse apiResponse = wordsApi.PostInsertWatermarkImage(fileName, destFileName, rotationAngle, image, storage, folder, file);


                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Watermark image has been added successfully");
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
