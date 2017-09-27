Feature: StoredDocumentConversionWithStorage
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@StoredDocConversionWithStorage
Scenario Outline: Convert document form storage and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format '<DestFormat>' document to be converted
	And I have specified document name <DocName> in GET URL
	And I have specified output path '<OutPath>'
	When I execute conversion from storage
	Then converted document is saved to storage
	And its filename is '<OutPath>'
	And its format '<DestFormat>'

	Examples: 
	| DocName           | DestFormat | OutPath                |
	| TableDocument.doc | pdf        | TableDocumentPdf       |
	| test_doc.docx     | pdf        | test_docPdf            |
	| test_doc.docx     | png        | test_docPng            |
	| test_doc.docx     | html       | test_docHtml           |
	| TableDocument.doc | html       | TableDocumentHtml      |
	| TableDocument.doc | txt        | TableDocumentTxt       |
	| TableDocument.doc | htmlfixed  | TableDocumentHtmlfixed |