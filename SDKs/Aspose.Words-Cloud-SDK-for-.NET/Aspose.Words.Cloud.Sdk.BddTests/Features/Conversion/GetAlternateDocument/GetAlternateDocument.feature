Feature: Stored document conversion with return result in response
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@ConversionOfStoredDoc
Scenario Outline: Conversion of stored document
	Given I have uploaded document with name <DocName> to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in GET URL
	When I execute conversion from storage
	Then document has to be returned as an attachment
	And its format <DestFormat>

	Examples: 
	| DocName           | DestFormat |
	| TableDocument.doc | pdf        |
	| test_doc.docx     | pdf        |
	| test_doc.docx     | png        | 
	| test_doc.docx     | html       | 
	| TableDocument.doc | html       | 
	| TableDocument.doc | txt        | 
	| TableDocument.doc | htmlfixed  |