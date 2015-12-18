'//////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Words.Cloud. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'///////////////////////////////////////////////////////////////////////

Imports Aspose.Cloud

Namespace Document
    Class CovertWebPagesToDocuments
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = Common.GetDataDir()

            Dim inputfile As String = "google-sample.xml"

            ' Create XMLDocument object           
            Dim docXML As New System.Xml.XmlDocument()
            ' Load XML from XML file
            docXML.Load(dataDir & inputfile)

            Common.WordsService.LoadNewDocumentFromWebIntoFile(docXML.InnerXml)
        End Sub
    End Class
End Namespace
