'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Paragraph
    Class GetFontOfRun
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"
            Dim subdirection As String = "Paragraph"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Get Font Information of a Run from a Word Document
            Dim WordsFontResponse As WordsFontResponse = Common.WordsService.WordsParagraph.GetDocumentFontByParagraphAndRun(inputfile, 0, 0, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + WordsFontResponse.Font.Name + " font.")
        End Sub
    End Class
End Namespace