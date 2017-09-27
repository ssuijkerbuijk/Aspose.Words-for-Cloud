Feature: OnFlyConversion
	In order to reuse document content for various purposes (such as read-only PDF distribution)
	A user should be able to convert Word document to different formats

@OnTheFlyConversion
Scenario Outline: Conversion on fly
	Given I have specified document name is <DocName>  and format is <SourceFormat>	
	And I have specified format <DestFormat> document to be converted
	When I execute conversion
	Then document has to be returned as an attachment
	And its format <DestFormat>

Examples: 
		| DocName       | SourceFormat | DestFormat |
		| TableDocument | doc          | pdf        |
		| test_doc      | docx         | pdf        |
		| test_doc      | docx         | png        |
		| test_doc      | docx         | html       |
		| TableDocument | doc          | html       |
		| TableDocument | doc          | txt        |
		| TableDocument | doc          | htmlfixed  |
