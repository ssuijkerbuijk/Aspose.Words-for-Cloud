//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

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
