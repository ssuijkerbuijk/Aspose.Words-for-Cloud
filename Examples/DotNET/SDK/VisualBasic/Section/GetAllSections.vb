Imports Aspose.Cloud

Namespace Section
    Class GetAllSections
        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"
            Dim subdirection As String = "Section"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection)

            ' Get a List of Sections from a Word Document
            Dim wordsSectionsResponse As WordsSectionsResponse = Common.WordsService.WordsSections.GetSectionsList(inputfile, Common.FOLDER)

            Console.WriteLine((Convert.ToString(vbLf) & inputfile) + " have " + wordsSectionsResponse.Sections.SectionLinkList.Count + " sections.")
        End Sub
    End Class
End Namespace