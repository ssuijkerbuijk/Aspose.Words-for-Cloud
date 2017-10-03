Feature: On fly document conversion
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@PutConvert
Scenario Outline: Conversion on fly
	Given I have specified document <DocName> to send it in request body
	And I have specified format <DestFormat> document to be converted
	When I execute conversion
	Then document is returned as an attachment
	And attachment's format is <DestFormat>

	Examples: 
		| DocName           | DestFormat |
		| TableDocument.doc | pdf        |
		| test_doc.docx     | pdf        |
		| test_doc.docx     | png        |
		| test_doc.docx     | html       |
		| TableDocument.doc | html       |
		| TableDocument.doc | txt        |
		| TableDocument.doc | htmlfixed  |

@PutConvert
Scenario Outline: Conversion with storage
	Given I have specified document <DocName> to send it in request body
	And I have specified format <DestFormat> document to be converted
	And I have specified output path <OutPath>
	And There is no file <OutPath> in storage
	When I execute conversion
	Then document <OutPath> is existed in storage with format <DestFormat>
	
	Examples: 
		| DocName           | DestFormat | OutPath								 |
		| TableDocument.doc | pdf        | out/putconvert/TableDocumentPdf       |
		| test_doc.docx     | pdf        | out/putconvert/test_docPdf            |
		| test_doc.docx     | png        | out/putconvert/test_docPng            |
		| test_doc.docx     | html       | out/putconvert/test_docHtml           |
		| TableDocument.doc | html       | out/putconvert/TableDocumentHtml      |
		| TableDocument.doc | txt        | out/putconvert/TableDocumentTxt       |
		| TableDocument.doc | htmlfixed  | out/putconvert/TableDocumentHtmlfixed |

@PutConvert
Scenario Outline: Convert document using specified encoding
	Given I have specified document <DocName> to send it in request body
	And I have specified format <DestFormat> document to be converted
	And I have specified encoding <LoadEncoding>
	When I execute conversion
	Then document is returned as an attachment
	And attachment's format is <DestFormat>
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