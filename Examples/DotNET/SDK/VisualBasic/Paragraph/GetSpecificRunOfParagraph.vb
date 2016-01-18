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
