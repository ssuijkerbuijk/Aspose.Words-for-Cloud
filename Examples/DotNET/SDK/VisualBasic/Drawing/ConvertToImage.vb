'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Drawing
    Class ConvertToImage
        Public Shared Sub Run()
            Dim subdirectory As String = "Drawing"

            ' The path to the documents directory.
            Dim dataDir As String = (Common.GetDataDir() & subdirectory) + "\"

            Dim inputfile As String = "testfile.doc"
            Dim outputfile As String = "testfile_out_.png"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            dataDir = dataDir & outputfile

            ' Convert Drawing Object to Image
            Common.WordsService.WordsDrawingObjects.ConvertToFormatSpecified(inputfile, 0, WordDrawingObjectsFormat.Png, dataDir, Common.FOLDER)

            Console.WriteLine(Convert.ToString(vbLf & "Drawing object converted successfully to png format." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace