'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Paragraph
    Class GetParagraphs
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"
            Dim subdirection As String = "Paragraph"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Get a List of Paragraphs from a Word Document
            Dim wordsParagraphsResponse As WordsParagraphsResponse = Common.WordsService.WordsParagraph.GetParagraphs(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsParagraphsResponse.Paragraphs.ParagraphLinkList.Count + " paragraphs.")
        End Sub
    End Class
End Namespace