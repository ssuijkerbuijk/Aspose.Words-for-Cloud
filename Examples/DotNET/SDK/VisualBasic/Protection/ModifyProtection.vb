Imports Aspose.Cloud

Namespace Protection
    Class ModifyProtection
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample-unprotect.doc"
            Dim subdirection As String = "Protection"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Modify Protection of the Word Document
            Dim wordsProtectionRequest2 As New WordsProtectionRequest("aspose", "aspose2", ProtectionType.[ReadOnly])
            Common.WordsService.WordsDocumentProtection.ChangeDocumentProtection(inputfile, Common.GetOutputFilePath(inputfile, True), wordsProtectionRequest2, Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, subdirection)

            Console.WriteLine(Convert.ToString(vbLf & "Document protection updated successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace