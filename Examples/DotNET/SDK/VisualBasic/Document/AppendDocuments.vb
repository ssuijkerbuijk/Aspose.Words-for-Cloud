'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Document
    Class AppendDocuments
        Public Shared Sub Run()
            Dim storagefile As String = "doc-sample.doc"
            Dim inputfile1 As String = "doc-sample1.doc"
            Dim inputfile2 As String = "doc-sample2.doc"

            ' Upload input files from local directory to Cloud Storage
            Common.UploadFile(storagefile, String.Empty)
            Common.UploadFile(inputfile1, String.Empty)
            Common.UploadFile(inputfile2, String.Empty)

            ' Append a List of Word Documents
            Dim wordDocumentEntryRequest As New WordDocumentEntryRequest()
            wordDocumentEntryRequest.DocumentEntries.Add(New WordDocumentEntry(inputfile1, WordImportFormatMode.KeepSourceFormatting))
            wordDocumentEntryRequest.DocumentEntries.Add(New WordDocumentEntry(inputfile2, WordImportFormatMode.KeepSourceFormatting))
            Common.WordsService.SplitDocument(storagefile, SplitDocumentFormat.Jpeg, 1, 2, Common.FOLDER)

            '<summary>
            ' Append Documents to Original Document.
            '</summary>
            '<param name="name">file name</param>
            '<param name="wordDocumentEntryRequest">List of Word documents.</param>
            '<param name="filename">Path to save result. Must be a Cloud storage path e.g. MyFolder\out.doc</param>
            '<param name="folder">Folder name on Cloud storage e.g. MyFolder. Empty means files will be uploaded on Default Cloud storage</param>
            Dim wordsDocumentResponse As WordsDocumentResponse = Common.WordsService.AppendDocumentsToOriginalDocument(storagefile, wordDocumentEntryRequest, Common.GetOutputFilePath(storagefile, True), Common.FOLDER)

            ' Download appended document file from cloud storage and save it to local directory
            Dim dataDir As String = Common.DownloadFile(storagefile, String.Empty)

            Console.WriteLine(Convert.ToString(vbLf & "Documents appended successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace