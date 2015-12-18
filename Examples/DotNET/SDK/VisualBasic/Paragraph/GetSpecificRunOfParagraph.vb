'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Paragraph
    Class GetSpecificRunOfParagraph
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"
            Dim subdirection As String = "Paragraph"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Get a specific Run of a Paragraph from a Word Document
            Dim wordsRunResponse As WordsRunResponse = Common.WordsService.WordsParagraph.GetParagraphByIndexAndRun(inputfile, 0, 0, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsRunResponse.Run.Text + " run text.")
        End Sub
    End Class
End Namespace
