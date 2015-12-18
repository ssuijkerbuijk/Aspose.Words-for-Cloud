'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Document
    Class RejectTrackingChanges
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Reject All Tracking Changes in the Document
            Dim wordRevisionResponse2 As WordRevisionResponse = Common.WordsService.WordsRevisions.RejectAllRevisionsInDocument(inputfile, Common.GetOutputFilePath(inputfile, True), Common.FOLDER)

            Console.WriteLine(Convert.ToString(vbLf & "All tracking changes rejected in ") & inputfile)
        End Sub
    End Class
End Namespace