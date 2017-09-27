Feature: ConversionWithEncoding
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@ConversionWithEncoding
Scenario Outline: Convert document using specified encoding
	Given I have specified document name is <DocName>  and format is <SourceFormat>
	And I have specified format <DestFormat> document to be converted
	And I have specified encoding <LoadEncoding>
	When I execute conversion with encoding
	Then document has to be returned as an attachment
	And its format <DestFormat>
	And symbols are encoded properly

	Examples: 
		| DocName       | SourceFormat | DestFormat | LoadEncoding |
		| TableDocument | doc          | pdf        | UTF-8        |
		| test_doc      | docx         | pdf        | UTF-8        |
		| test_doc      | docx         | png        | UTF-8        |
		| test_doc      | docx         | html       | UTF-8        |
		| TableDocument | doc          | html       | UTF-8        |
		| TableDocument | doc          | txt        | UTF-8        |
		| TableDocument | doc          | htmlfixed  | UTF-8        |
