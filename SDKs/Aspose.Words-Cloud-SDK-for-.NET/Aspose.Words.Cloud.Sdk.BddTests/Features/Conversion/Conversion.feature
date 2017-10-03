Feature: Document conversion
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@OnTheFlyConversion
Scenario Outline: Conversion on fly
	Given I have specified document name is <DocName>	
	And I have specified format <DestFormat> document to be converted
	When I execute conversion
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
	
@ConversionWithStorage
Scenario Outline: Conversion with storage
	Given I have specified document name is <DocName>
	And I have specified format <DestFormat> document to be converted
	And I have specified output path <OutPath>
	When I execute conversion
	Then converted document is saved to storage
	And its filename is <OutPath>
	And its format <DestFormat>

	Examples: 
		| DocName           | DestFormat | OutPath                |
		| TableDocument.doc | pdf        | TableDocumentPdf       |
		| test_doc.docx     | pdf        | test_docPdf            |
		| test_doc.docx     | png        | test_docPng            |
		| test_doc.docx     | html       | test_docHtml           |
		| TableDocument.doc | html       | TableDocumentHtml      |
		| TableDocument.doc | txt        | TableDocumentTxt       |
		| TableDocument.doc | htmlfixed  | TableDocumentHtmlfixed |
	
@StoredDocConversionWithStorage
Scenario Outline: Convert document form storage and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in GET URL
	And I have specified output path <OutPath>
	When I execute conversion from storage
	Then converted document is saved to storage
	And its filename is <OutPath>
	And its format <DestFormat>

	Examples: 
	| DocName           | DestFormat | OutPath                |
	| TableDocument.doc | pdf        | TableDocumentPdf       |
	| test_doc.docx     | pdf        | test_docPdf            |
	| test_doc.docx     | png        | test_docPng            |
	| test_doc.docx     | html       | test_docHtml           |
	| TableDocument.doc | html       | TableDocumentHtml      |
	| TableDocument.doc | txt        | TableDocumentTxt       |
	| TableDocument.doc | htmlfixed  | TableDocumentHtmlfixed | 


@ConversionWithEncoding
Scenario Outline: Convert document using specified encoding
	Given I have specified document name is <DocName>
	And I have specified format <DestFormat> document to be converted
	And I have specified encoding <LoadEncoding>
	When I execute conversion with encoding
	Then document has to be returned as an attachment
	And its format <DestFormat>
	And symbols are encoded properly

	Examples: 
		| DocName           | DestFormat | LoadEncoding |
		| TableDocument.doc | pdf        | UTF-8        |
		| test_doc.docx     | pdf        | UTF-8        |
		| test_doc.docx     | png        | UTF-8        |
		| test_doc.docx     | html       | UTF-8        |
		| TableDocument.doc | html       | UTF-8        |
		| TableDocument.doc | txt        | UTF-8        |
		| TableDocument.doc | htmlfixed  | UTF-8        |

@ConversionPdfToWord
Scenario Outline: Convert pdf document to word and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in GET URL
	And I have specified output path <OutPath>
	When I execute conversion from storage
	Then converted document is saved to storage
	And its filename is <OutPath>
	And its format <DestFormat>

	Examples: 
	| DocName                  | DestFormat | OutPath                  |
	| awesome_table_in_pdf.pdf | docx       | awesome_table_in_pdfDocx |
	| Delivery.pdf             | docx       | DeliveryDocx             |
	| 45.pdf                   | docx       | 45Docx                   |