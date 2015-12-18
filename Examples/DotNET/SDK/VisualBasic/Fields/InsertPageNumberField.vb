'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Fields
    Class InsertPageNumberField
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Insert Page Number Field into the Document
            Dim pageNumberSettings As New PageNumberSettings("{PAGE} of {NUMPAGES}", "right", True, True)
            Common.WordsService.InsertDocumentPageNumbers(inputfile, Common.GetOutputFilePath(inputfile, True), Common.FOLDER, pageNumberSettings)

            Dim dataDir As String = Common.DownloadFile(inputfile, String.Empty)

            Console.WriteLine(Convert.ToString(vbLf & "Page number inserted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace