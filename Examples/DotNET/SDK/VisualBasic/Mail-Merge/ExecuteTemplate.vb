'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Mail_Merge
    Class ExecuteTemplate
        Public Shared Sub Run()
            Dim subdirectory As String = "MailMerge"
            Dim inputfile As String = "Invoice Template.doc"
            Dim xmlfile As String = "Orders.xml"
            Dim imagefile As String = "Aspose Logo.png"

            ' The path to the documents directory.
            Dim dataDir As String = Common.GetDataDir()
            dataDir = (dataDir & subdirectory) + "\"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            ' Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, subdirectory)

            ' Execute Mail Merge Template
            Dim strXML As String = String.Empty
            Using sr As New System.IO.StreamReader(dataDir & xmlfile)
                strXML = sr.ReadToEnd()
            End Using
            Common.WordsService.PopulateDocumentTemplateWithData(inputfile, WordCleanupOptions.ContainingFields, Common.GetOutputFilePath(inputfile, True), Common.FOLDER, strXML)

            ' Download output file from cloud storage and save on local directory
            dataDir = Common.DownloadFile(inputfile, subdirectory)

            Console.WriteLine(Convert.ToString(vbLf & "Mail merge template executed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace