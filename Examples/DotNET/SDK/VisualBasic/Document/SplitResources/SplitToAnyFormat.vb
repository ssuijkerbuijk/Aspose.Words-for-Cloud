Imports Aspose.Cloud

Namespace Document.SplitResources
    Class SplitToAnyFormat
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Split specific pages to any Supported Format
            Dim wordsSplitResultResponse As WordsSplitResultResponse = Common.WordsService.SplitDocument(inputfile, SplitDocumentFormat.Png, 1, 2, Common.FOLDER)

            Console.WriteLine(vbLf & "Input file splitted successfully to Png Format.")
        End Sub
    End Class
End Namespace