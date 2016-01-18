Imports Aspose.Cloud

Namespace Mail_Merge
    Class ExecuteWithoutRegions
        Public Shared Sub Run()
            Dim subdirectory As String = "MailMerge"
            Dim inputfile As String = "WithoutRegions.doc"
            Dim xmlfile As String = "WithoutRegions.xml"
            Dim imagefile As String = "Aspose Logo.png"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            ' Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, subdirectory)

            ' Upload xml file from local directory to Cloud Storage
            Common.UploadFile(xmlfile, subdirectory)

            ' Execute Mail Merge without Regions
            Dim wordsDocumentResponse As WordsDocumentResponse = Common.WordsService.WordsMailMerge.ExecuteDocumentMailMergeOperation(inputfile, False, xmlfile, String.Empty, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            Dim dataDir As String = Common.DownloadFile(inputfile, subdirectory)

            Console.WriteLine(Convert.ToString(vbLf & "Mail merge without regions executed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
