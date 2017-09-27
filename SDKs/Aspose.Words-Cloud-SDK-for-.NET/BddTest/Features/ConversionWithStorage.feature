Feature: Conversion with storage
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@ConversionWithStorage
Scenario Outline: Conversion with storage
	Given I have specified document name is '<DocName>'  and format is '<SourceFormat>'	
	And I have specified format '<DestFormat>' document to be converted
	And I have specified output path '<OutPath>'
	When I execute conversion
	Then converted document is saved to storage
	And its filename is '<OutPath>'
	And its format '<DestFormat>'

	Examples: 
		| DocName       | SourceFormat | DestFormat | OutPath                |
		| TableDocument | doc          | pdf        | TableDocumentPdf       |
		| test_doc      | docx         | pdf        | test_docPdf            |
		| test_doc      | docx         | png        | test_docPng            |
		| test_doc      | docx         | html       | test_docHtml           |
		| TableDocument | doc          | html       | TableDocumentHtml      |
		| TableDocument | doc          | txt        | TableDocumentTxt       |
		| TableDocument | doc          | htmlfixed  | TableDocumentHtmlfixed |

