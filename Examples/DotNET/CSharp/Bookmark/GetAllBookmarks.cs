using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Bookmark
{
    class GetAllBookmarks
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
                // Invoke Aspose.Words Cloud SDK API to get bookmarks from document
                BookmarksResponse apiResponse = wordsApi.GetDocumentBookmarks(fileName, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    foreach (Com.Aspose.Words.Model.Bookmark bookmark in apiResponse.Bookmarks.BookmarkList)
                    {
                        Console.WriteLine("Name: " + bookmark.Name + " Text: " + bookmark.Text + " link: " + bookmark.link.Href);
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
