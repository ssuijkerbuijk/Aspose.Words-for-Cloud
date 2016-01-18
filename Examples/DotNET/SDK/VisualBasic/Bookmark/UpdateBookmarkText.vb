Imports Aspose.Cloud

Namespace Bookmark
    Class UpdateBookmarkText
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            Dim outfile As String = Common.GetOutputFilePath(inputfile, True)

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Update Bookmark Text of a Word
            Dim wordsBookmarkRequest As New WordsBookmarkRequest("AsposePdf", "Aspose.Pdf for .NET")
            Common.WordsService.WordsBookmarks.UpdateDocumentBookmark(inputfile, wordsBookmarkRequest.Name, wordsBookmarkRequest, outfile, Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, String.Empty)

            Console.WriteLine(Convert.ToString(vbLf & "Bookmark text updated successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace