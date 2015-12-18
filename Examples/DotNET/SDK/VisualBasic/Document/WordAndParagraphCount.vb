'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Document
    Class WordAndParagraphCount
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Get Word and Paragraph Count from Document
            Dim WordsStatDataResponse As WordsStatDataResponse = Common.WordsService.WordsDocumentStatistics.ReadDocumentStatistics(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have page count " + WordsStatDataResponse.StatData.PageCount + ", paragraph count " + WordsStatDataResponse.StatData.ParagraphCount + " and words count " + WordsStatDataResponse.StatData.WordCount)
        End Sub
    End Class
End Namespace