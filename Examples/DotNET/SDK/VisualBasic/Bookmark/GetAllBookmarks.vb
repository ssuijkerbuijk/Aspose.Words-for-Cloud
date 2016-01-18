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