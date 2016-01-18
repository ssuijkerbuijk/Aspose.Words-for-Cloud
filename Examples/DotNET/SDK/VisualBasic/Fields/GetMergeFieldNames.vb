Imports Aspose.Cloud

Namespace Fields
    Class GetMergeFieldNames
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample3.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get All Merge Field Names from a Word Document
            Dim wordsFieldNamesResponse As WordsFieldNamesResponse = Common.WordsService.WordsMailMerge.ReadDocumentFieldNames(inputfile, True, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsFieldNamesResponse.FieldNames.Names.Count + " Merge Field")
        End Sub
    End Class
End Namespace