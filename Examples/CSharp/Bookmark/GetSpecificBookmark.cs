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
