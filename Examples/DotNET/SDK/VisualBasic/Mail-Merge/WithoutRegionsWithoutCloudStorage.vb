'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Mail_Merge
    Class WithoutRegionsWithoutCloudStorage
        Public Shared Sub Run()
            Dim subdirectory As String = "MailMerge"
            Dim inputfile As String = "WithoutRegionsWithoutStorage.doc"
            Dim xmlfile As String = "WithoutRegionsWithoutStorage.xml"

            ' The path to the documents directory.
            Dim dataDir As String = (Common.GetDataDir() & subdirectory) + "\"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory)

            Dim strXML As String = String.Empty
            Using sr As New System.IO.StreamReader(dataDir & xmlfile)
                strXML = sr.ReadToEnd()
            End Using

            Common.WordsService.ExecuteDocumentMailMergeOnline(strXML, False, String.Empty, inputfile, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            ' Download output file from cloud storage and save on local directory
            dataDir = Common.DownloadFile(inputfile, subdirectory)

            Console.WriteLine(Convert.ToString(vbLf & "Mail merge without regions and without cloud storage executed successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace