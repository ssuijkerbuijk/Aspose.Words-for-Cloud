'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Bookmark
    Class GetSpecificBookmark
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get a Specific Bookmark from a Word
            Dim wordsBookmarkRequest As New WordsBookmarkRequest("AsposePdf", "Aspose.Pdf for .NET")
            Dim wordsBookmarkResponse As WordsBookmarkResponse = Common.WordsService.WordsBookmarks.ReadDocumentBookmarkDataByItsName(inputfile, wordsBookmarkRequest.Name, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsBookmarkResponse.Bookmark.Name + " bookmark")
        End Sub
    End Class
End Namespace