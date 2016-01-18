using System;
using Aspose.Cloud;

namespace CSharp.Bookmark
{
    class GetSpecificBookmark
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get a Specific Bookmark from a Word
            WordsBookmarkRequest wordsBookmarkRequest = new WordsBookmarkRequest("AsposePdf", "Aspose.Pdf for .NET");
            WordsBookmarkResponse wordsBookmarkResponse = Common.WordsService.WordsBookmarks.ReadDocumentBookmarkDataByItsName(inputfile, wordsBookmarkRequest.Name, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsBookmarkResponse.Bookmark.Name + " bookmark"); 
        }
    }
}
