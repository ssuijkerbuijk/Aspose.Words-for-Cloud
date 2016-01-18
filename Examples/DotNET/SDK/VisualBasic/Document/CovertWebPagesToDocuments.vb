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
