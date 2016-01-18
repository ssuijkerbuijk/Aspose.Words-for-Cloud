Imports Aspose.Cloud

Namespace Document
    Class ConvertToAnotherFormat
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = Common.GetDataDir()

            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            dataDir = (dataDir & Common.GetOutputFilePath(inputfile, False)) + ".pdf"

            ' Convert Word to other File Formats. This can be using the Cloud Storage or without cloud storage
            Common.WordsService.ConvertDocument(inputfile, WordOutputFormat.Pdf, Common.FOLDER, dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "File converted to another format." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace