Feature: Stored document conversion with save result to storage
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@StoredDocConversionWithStorage
Scenario Outline: Convert document form storage and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	And I have specified output path <OutPath>
	And I have specified encoding <LoadEncoding>
	When I execute conversion from storage
	Then document <OutPath> is existed on storage
	And document from storage is downloadble
	And symbols are encoded properly
	
	Examples: 
	| DocName           | DestFormat | OutPath                                     | LoadEncoding |
	| TableDocument.doc | pdf        | out/saveus/TableDocumentPdf.pdf             | utf-8        |
	| test_doc.docx     | pdf        | out/saveus/test_docPdf.pdf                  | utf-8        |
	| test_doc.docx     | png        | out/saveus/test_docPng.pdf                  | utf-8        |
	| test_doc.docx     | html       | out/saveus/test_docHtml.html                | utf-8        |
	| TableDocument.doc | html       | out/saveus/TableDocumentHtml.html           | utf-8        |
	| TableDocument.doc | txt        | out/saveus/TableDocumentTxt.txt             | utf-8        |
	| TableDocument.doc | htmlfixed  | out/saveus/TableDocumentHtmlfixed.htmlfixed | utf-8        |


@ConversionPdfToWord
Scenario Outline: Convert pdf document to word and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format <DestFormat> document to be converted
	And I have specified document name <DocName> in URL
	And I have specified output path <OutPath>
	When I execute conversion from storage
	Then document <OutPath> is existed on storage

	Examples: 
	| DocName                  | DestFormat | OutPath                                  |
	| awesome_table_in_pdf.pdf | docx       | out/saveus/awesome_table_in_pdfDocx.docx |
	| Delivery.pdf             | docx       | out/saveus/DeliveryDocx.docx             |
	| 45.pdf                   | docx       | out/saveus/45Docx.docx                   |