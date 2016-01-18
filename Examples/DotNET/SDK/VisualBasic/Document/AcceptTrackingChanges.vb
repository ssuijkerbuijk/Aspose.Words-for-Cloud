Imports Aspose.Cloud

Namespace Document
    Class AcceptTrackingChanges
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Accept All Tracking Changes in the Document
            Dim wordRevisionResponse As WordRevisionResponse = Common.WordsService.WordsRevisions.AcceptAllRevisionsInDocument(inputfile, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            Console.WriteLine(Convert.ToString(vbLf & "All tracking changes accepted in ") & inputfile)
        End Sub
    End Class
End Namespace