Feature: MailMerge
	In order to create personalized documents a user
	should be able to perform mail merge

@ExecuteTemplate
Scenario Outline: Execute Template
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	When I execute template
	Then document with merged values should be created
	And document name is Guid value

	Examples: 
	| TemplateName            | Body                        |
	| TestExecuteTemplate.doc | TestExecuteTemplateData.txt |

@ExecuteTemplateWithCustomOut
Scenario Outline: Execute Template With Custom Output
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	And I have specified a destFileName <DestinationFileName>
	When I execute template
	Then document with merged values should be created
	And document name is equal to destFileName

	Examples: 
	| TemplateName            | Body                        | DestinationFileName  |
	| TestExecuteTemplate.doc | TestExecuteTemplateData.txt | ExecutedTemplate.doc |

@ExecuteTemplateWithRegions
Scenario Outline: Execute Template With Regions
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	And I have specified a destFileName <DestinationFileName>
	And I have specified withRegions <UseRegions>
	When I execute template
	Then document with merged values should be created
	And document name is equal to destFileName

	Examples: 
	| TemplateName            | Body                        | DestinationFileName  | UseRegions |
	| TestExecuteTemplate.doc | TestExecuteTemplateData.txt | ExecutedTemplate.doc | true       |

	
@ExecuteTemplateWithRegionsAndNotUseWholeParagraphAsRegion
Scenario Outline: Execute Template With Regions And Not UseWholeParagraphAsRegion
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	And I have specified a destFileName <DestinationFileName>
	And I have specified withRegions <UseRegions>
	And I have specified useWholeParagraphAsRegion <UseWholeParagraphAsRegion>
	When I execute template
	Then document with merged values should be created
	And document name is equal to destFileName

	Examples: 
	| TemplateName            | Body                        | DestinationFileName  | UseRegions | UseWholeParagraphAsRegion |
	| TestExecuteTemplate.doc | TestExecuteTemplateData.txt | ExecutedTemplate.doc | true       | false                     |

@ExecuteTemplateWithImages
Scenario Outline: Execute Template With Images
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	When I execute template
	Then document with merged values should be created
	And document name is Guid value
	And image should be rendered

	Examples: 
	| TemplateName                | Body                               |
	| TestMailMergeWithImages.doc | TestDataWithRemoteScaledImages.xml |

@ExecuteTemplateWithCleanupOptions
Scenario Outline: Execute Template With Cleanup Options
	Given I have specified a template <TemplateName> with mustache syntax
	And I have specified a body <Body>
	And I have specified a cleanup option <Cleanup>
	When I execute template
	Then document with merged values should be created
	And document name is Guid value
	And unused option is cleaned up

	Examples: 
	| TemplateName                        | Body                       | Cleanup         |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | UnusedRegions   |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | UnusedFields    |
	| TestMailMergeWithCleanupOptions.doc | TestCleanupOptionsData.xml | EmptyParagraphs |