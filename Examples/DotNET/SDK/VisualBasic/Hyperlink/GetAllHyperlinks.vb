'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Hyperlink
    Class GetAllHyperlinks
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample-hyperlink.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get all Hyperlinks from a Word
            Dim wordsHyperlinksResponse As WordsHyperlinksResponse = Common.WordsService.WordsHyperlinks.ReadDocumentHyperlinksCommonInfo(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsHyperlinksResponse.Hyperlinks.HyperlinkList.Count + " hyperlinks")
        End Sub
    End Class
End Namespace