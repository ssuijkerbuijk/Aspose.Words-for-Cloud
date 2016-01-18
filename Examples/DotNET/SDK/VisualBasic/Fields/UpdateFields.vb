Imports Aspose.Cloud

Namespace Fields
    Class UpdateFields
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Update All Fields in the Word Document
            Dim wordsDocumentResponse As WordsDocumentResponse = Common.WordsService.WordsDocumentFields.UpdateFieldsInDocument(inputfile, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            Console.WriteLine(vbLf & "All fields updated successfully.")
        End Sub
    End Class
End Namespace