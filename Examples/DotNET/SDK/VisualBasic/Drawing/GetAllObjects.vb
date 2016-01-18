Imports Aspose.Cloud

Namespace Drawing
    Class GetAllObjects
        Public Shared Sub Run()
            Dim subdirectory As String = "Drawing"

            ' The path to the documents directory.
            Dim dataDir As String = (Common.GetDataDir() & subdirectory) + "\"

            Dim inputfile As String = "testfile.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            ' Get All Drawing Objects
            Dim wordsDrawingObjectsResponse As WordsDrawingObjectsResponse = Common.WordsService.WordsDrawingObjects.ReadDocumentDrawingObjectsCommonInfo(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsDrawingObjectsResponse.DrawingObjects.List.Count + " drawing objects.")
        End Sub
    End Class
End Namespace
