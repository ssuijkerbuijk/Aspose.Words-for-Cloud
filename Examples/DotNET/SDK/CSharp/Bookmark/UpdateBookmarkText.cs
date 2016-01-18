using System;
using Aspose.Cloud;

namespace CSharp.Bookmark
{
    class UpdateBookmarkText
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
           
            string outfile = Common.GetOutputFilePath(inputfile, true);

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Update Bookmark Text of a Word
            WordsBookmarkRequest wordsBookmarkRequest = new WordsBookmarkRequest("AsposePdf", "Aspose.Pdf for .NET");
            Common.WordsService.WordsBookmarks.UpdateDocumentBookmark(inputfile, wordsBookmarkRequest.Name, wordsBookmarkRequest, outfile, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nBookmark text updated successfully.\nFile saved at " + dataDir);
        }
    }
}
