
Imports Aspose.Cloud

Namespace Section.Header_and_Footer
    Class RemoveHeaderAndFooter
        Public Shared Sub Run()
            Dim inputfile As String = "header-footer.doc"
            Dim subdirection As String = "Section"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Remove all Headers and Footers
            Common.WordsService.WordsHeadersFooters.DeleteDocumentHeadersAndFooters(inputfile, String.Empty, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, subdirection)

            Console.WriteLine(Convert.ToString(vbLf & "All headers and footers removed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
