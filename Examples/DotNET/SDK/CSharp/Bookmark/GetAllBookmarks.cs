using System;
using Aspose.Cloud;

namespace CSharp.Bookmark
{
    class GetAllBookmarks
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
     
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get all Bookmarks from a Word
            WordsBookmarksResponse wordsBookmarksResponse = Common.WordsService.WordsBookmarks.ReadDocumentBookmarksCommonInfo(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsBookmarksResponse.Bookmarks.BookmarkList.Count + " bookmarks"); 
        }
    }
}
