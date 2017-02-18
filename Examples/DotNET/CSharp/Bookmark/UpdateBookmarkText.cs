using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Bookmark
{
    class UpdateBookmarkText
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleWordDocument.docx";

            String storage = null;
            String folder = null;


            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get bookmarks from document by name
                BookmarkResponse apiResponse = wordsApi.PostUpdateDocumentBookmark(fileName, "test", "", storage, folder, null);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {

                    Console.WriteLine("Bookmark updated.");

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
