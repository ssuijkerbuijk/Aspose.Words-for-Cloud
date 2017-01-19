using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Page_Setup
{
    class UpdatePageSetup
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleBlankWordDocument.docx";
            string destFileName = "updated-" + fileName;
            int sectionIndex = 0;
            string storage = null;
            string folder = null;

            PageSetup body = new PageSetup();
            body.RtlGutter = true;
            body.Orientation = "Portrait";
            body.PaperSize = "A5";

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to update page setup
                SectionPageSetupResponse apiResponse = wordsApi.UpdateSectionPageSetup(fileName, sectionIndex, storage, folder, destFileName, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    PageSetup secPageSetup = apiResponse.PageSetup;
                    Console.WriteLine("getPaperSize :" + secPageSetup.PaperSize + "  Orientation:  " + secPageSetup.Orientation);
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
