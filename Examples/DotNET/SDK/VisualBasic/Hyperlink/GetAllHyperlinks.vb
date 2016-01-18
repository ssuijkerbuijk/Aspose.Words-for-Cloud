Imports Aspose.Cloud

Namespace Hyperlink
    Class GetAllHyperlinks
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample-hyperlink.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get all Hyperlinks from a Word
            Dim wordsHyperlinksResponse As WordsHyperlinksResponse = Common.WordsService.WordsHyperlinks.ReadDocumentHyperlinksCommonInfo(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsHyperlinksResponse.Hyperlinks.HyperlinkList.Count + " hyperlinks")
        End Sub
    End Class
End Namespace