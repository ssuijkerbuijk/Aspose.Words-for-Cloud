'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Text
    Class ReplaceText
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Replace Text in a Word Document
            Dim replaceText As New WordsReplaceText("Aspose", "Aspose Pty Ltd", True, False)
            Common.WordsService.WordsTextItems.ReplaceDocumentText(inputfile, Common.GetOutputFilePath(inputfile, True), replaceText, Common.FOLDER)

            Console.WriteLine(vbLf & "Text replaced successfully")
        End Sub
    End Class
End Namespace