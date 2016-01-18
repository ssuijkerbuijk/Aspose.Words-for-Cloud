Imports Aspose.Cloud

Namespace Protection
    Class ProtectDocument
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample-protect.doc"
            Dim subdirection As String = "Protection"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Protect a Word Document
            Dim wordsProtectionRequest As New WordsProtectionRequest("aspose", "aspose", ProtectionType.[ReadOnly])
            Common.WordsService.WordsDocumentProtection.ProtectDocument(inputfile, Common.GetOutputFilePath(inputfile, True), wordsProtectionRequest, Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, subdirection)

            Console.WriteLine(Convert.ToString(vbLf & "Read only protection added." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace