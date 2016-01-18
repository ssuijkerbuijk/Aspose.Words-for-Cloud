Imports Aspose.Cloud

Namespace Fields.ParagraphLevel
    Class AddFormFields

        Public Shared Sub Run()
            Dim inputfile As String = "doc-sample.doc"

            ' Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, String.Empty)

            ' Convert Word Documents to any Format with Additional Settings
            Dim saveOptionsXML As String = "<PdfSaveOptions>" & vbCr & vbLf & "               <SaveFormat>pdf</SaveFormat>" & vbCr & vbLf & "               <FileName>Output.pdf</FileName>" & vbCr & vbLf & "               <ImageCompression>Jpeg</ImageCompression>" & vbCr & vbLf & "               <JpegQuality>70</JpegQuality>" & vbCr & vbLf & "               <TextCompression>Flate</TextCompression>" & vbCr & vbLf & "            </PdfSaveOptions>"

            Common.WordsService.WordsDocumentSaveAs.ConvertDocument(inputfile, saveOptionsXML, Common.FOLDER)
        End Sub
    End Class
End Namespace