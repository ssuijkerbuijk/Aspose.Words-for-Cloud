'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Bookmark
    Class GetAllBookmarks
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get all Bookmarks from a Word
            Dim wordsBookmarksResponse As WordsBookmarksResponse = Common.WordsService.WordsBookmarks.ReadDocumentBookmarksCommonInfo(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsBookmarksResponse.Bookmarks.BookmarkList.Count + " bookmarks")
        End Sub
    End Class
End Namespace