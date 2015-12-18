'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

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