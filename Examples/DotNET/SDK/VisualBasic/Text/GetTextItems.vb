'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Text
    Class GetTextItems
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get Text Items from a Word Document
            Dim wordsTextItemsResponse As WordsTextItemsResponse = Common.WordsService.WordsTextItems.ReadDocumentTextItems(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsTextItemsResponse.TextItems.List.Count.ToString() + " text items")
        End Sub
    End Class
End Namespace