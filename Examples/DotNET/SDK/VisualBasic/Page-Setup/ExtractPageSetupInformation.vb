'///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Page_Setup
    Class ExtractPageSetupInformation
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"
            Dim subdirection As String = "PageSetup"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Extract Page Setup Information from a Word Document
            Dim pageSetupResponse As PageSetupResponse = Common.WordsService.WordsSections.GetPageSetupOfSection(inputfile, 0, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf & "Page setup informations from ") & inputfile) + " file extracted successfully.")
        End Sub
    End Class
End Namespace