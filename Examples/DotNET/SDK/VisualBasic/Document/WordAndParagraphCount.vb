Imports Aspose.Cloud

Namespace Document
    Class WordAndParagraphCount
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get Word and Paragraph Count from Document
            Dim WordsStatDataResponse As WordsStatDataResponse = Common.WordsService.WordsDocumentStatistics.ReadDocumentStatistics(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have page count " + WordsStatDataResponse.StatData.PageCount + ", paragraph count " + WordsStatDataResponse.StatData.ParagraphCount + " and words count " + WordsStatDataResponse.StatData.WordCount)
        End Sub
    End Class
End Namespace