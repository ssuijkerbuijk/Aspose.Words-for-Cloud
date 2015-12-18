'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Drawing
    Class GetImageObject
        Public Shared Sub Run()
            Dim subdirectory As String = "Drawing"

            ' The path to the documents directory.
            Dim dataDir As String = (Common.GetDataDir() & subdirectory) + "\"

            Dim inputfile As String = "imagefile.doc"
            Dim outputfile As String = "imagefile_out_.png"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            dataDir = dataDir & outputfile

            ' Get the Image Drawing Object from Document
            Common.WordsService.WordsDrawingObjects.ReadDrawingObjectImageData(inputfile, 1, String.Empty, dataDir)

            Console.WriteLine(Convert.ToString(vbLf & "Image object fetched successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace