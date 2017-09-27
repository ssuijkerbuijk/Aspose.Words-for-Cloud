Feature: ConversionPdfToWord
	In order to make read-only document writeable
	A user should be able to convert PDF document to Word

@ConversionPdfToWord
Scenario Outline: Convert pdf document to word and save to storage
	Given I have uploaded document with name <DocName> to storage
	And I have specified format '<DestFormat>' document to be converted
	And I have specified document name <DocName> in GET URL
	And I have specified output path '<OutPath>'
	When I execute conversion from storage
	Then converted document is saved to storage
	And its filename is '<OutPath>'
	And its format '<DestFormat>'

	Examples: 
	| DocName                  | DestFormat | OutPath                  |
	| awesome_table_in_pdf.pdf | docx       | awesome_table_in_pdfDocx |
	| Delivery.pdf             | docx       | DeliveryDocx             |
	| 45.pdf                   | docx       | 45Docx                   |
	
