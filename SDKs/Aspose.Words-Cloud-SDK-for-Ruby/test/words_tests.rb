require "minitest/autorun"
require "minitest/unit"

require_relative '../lib/aspose_words_cloud'

class WordsTests < Minitest::Test
	include MiniTest::Assertions
	include AsposeWordsCloud
	include AsposeStorageCloud
	
	def setup
        #Get App key and App SID from https://cloud.aspose.com
        AsposeApp.app_key_and_sid("", "")
		@words_api = WordsApi.new
	end

	def teardown
	end

	def upload_file(file_name)
        	@storage_api = StorageApi.new
		response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
		assert(response, message="Failed to upload {file_name} file.")
	end

	def test_put_convert_document
        	file_name = "SampleWordDocument.docx"
        	convert_to_format = "pdf"
        	response = @words_api.put_convert_document(File.open("../../../data/" << file_name,"r") { |io| io.read }, {format: convert_to_format})
	 	assert(response, message="Failed to convert document from request content to {convert_to_format} format.")
	end

	def test_put_execute_mail_merge_online
        	file_name = "SampleMailMergeTemplate.docx"
        	data_file_name = "SampleMailMergeTemplateData.txt"
        	with_regions = false

        	file = File.open("../../../data/" << file_name,"r") { |io| io.read }
        	data = File.open("../../../data/" << data_file_name,"r") { |io| io.read }
        	response = @words_api.put_execute_mail_merge_online(with_regions, file, data)
	 	assert(response, message="Failed to execute document mail merge online.")
	end	

	def test_put_execute_template_online
		file_name = "SampleExecuteTemplate.doc"
        	data_file_name = "SampleExecuteTemplateData.txt"

		file = File.open("../../../data/" << file_name,"r") { |io| io.read }
        	data = File.open("../../../data/" << data_file_name,"r") { |io| io.read }
        	response = @words_api.put_execute_template_online(file, data)
	 	assert(response, message="Failed to populate document template with data online.")
	end
    
	def test_post_load_web_document	
		load_web_document_data = LoadWebDocumentData.new
		load_web_document_data.loading_document_url = "http://google.com"

		save_options = SaveOptionsData.new
		save_options.save_format = "doc"
		save_options.file_name = "google.doc"

		load_web_document_data.save_options = save_options

        	response = @words_api.post_load_web_document(load_web_document_data)
	 	assert(response, message="Failed to load new document from web into the file with any supported format of data")
	end

	def test_put_document_field_names
		response = @words_api.put_document_field_names({use_non_merge_fields: false})
		assert(response, message="Failed to read document field names")
	end

	def test_post_run_task
        	file_name = "SampleWordDocument.docx"
        	response = @words_api.post_run_task(File.open("../../../data/" << file_name,"r") { |io| io.read })
	 	assert(response, message="Failed to run tasks")
	end

	def test_get_document
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document(file_name)
		assert(response, message="Failed to read document common info")
	end

	def test_get_document_with_format
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		format = "pdf"
		response = @words_api.get_document_with_format(file_name, format)
		assert(response, message="Failed to get document in desired format")
	end

	def test_post_document_save_as
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		save_options = SaveOptionsData.new
		save_options.save_format = "pdf"
		save_options.file_name = "SampleWordDocument.pdf"
		response = @words_api.post_document_save_as(file_name, save_options)
		assert(response, message="Failed to convert document to destination format with detailed settings and save result to storage.")
	end

	def test_put_document_save_as_tiff
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		tiff_save_options = TiffSaveOptionsData.new
		tiff_save_options.file_name = "SampleWordDocument.tiff"
		tiff_save_options.save_format = "tiff"
		response = @words_api.put_document_save_as_tiff(file_name, tiff_save_options)
		assert(response, message="Failed to convert document to tiff with detailed settings and save result to storage")
	end

	def test_post_append_document
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)
		append_doc_1_file_name = "SampleAppendDoc.docx"
		upload_file(append_doc_1_file_name)
		append_doc_2_file_name = "SampleAppendDoc2.docx"
		upload_file(append_doc_2_file_name)

		document_1 = DocumentEntry.new
		document_1.href = append_doc_1_file_name
		document_1.import_format_mode = "KeepSourceFormatting"

		document_2 = DocumentEntry.new
		document_2.href = append_doc_2_file_name
		document_2.import_format_mode = "KeepSourceFormatting"

		document_list = DocumentEntryList.new
		document_list.document_entries = [document_1, document_2]

		response = @words_api.post_append_document(file_name, document_list)
		assert(response, message="Failed to append documents to original document")
	end

	def test_get_document_bookmarks
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_bookmarks(file_name)
		assert(response, message="Failed to read document bookmarks common info")
	end

	def test_get_document_bookmark_by_name
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		bookmark_name = "aspose"
		response = @words_api.get_document_bookmark_by_name(file_name, bookmark_name)
		assert(response, message="Failed to read document bookmark data by its name")
	end

	def test_post_update_document_bookmark
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		bookmark_data = BookmarkData.new
		bookmark_data.name = "aspose"
		bookmark_data.text = "Aspose APIs"

		bookmark_name = "aspose"
		response = @words_api.post_update_document_bookmark(file_name, bookmark_name, bookmark_data)
		assert(response, message="Failed to update document bookmark")
	end

	def test_get_comments
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_comments(file_name)
		assert(response, message="Failed to get comments from document")
	end

	def test_put_comment
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		comment = Comment.new
		comment.author = "Adam"
		comment.text = "Machine Learning"
		comment.initial = "MS"

		comment.content = StoryChildNodes.new
		comment.content.child_nodes = []

		comment.range_start = DocumentPosition.new
		comment.range_start.node = NodeLink.new
		comment.range_start.node.node_id = "0.7.6"
		comment.range_start.offset = 0

		comment.range_end = DocumentPosition.new
		comment.range_end.node = NodeLink.new
		comment.range_end.node.node_id = "0.7.5"
		comment.range_end.offset = 0

		response = @words_api.put_comment(file_name, comment)
		assert(response, message="Failed to add comment to document")
	end

	def test_get_comment
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		comment_index = 0
		response = @words_api.get_comment(file_name, comment_index)
		assert(response, message="Failed to get comment from document")
	end

	def test_post_comment
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		comment = Comment.new
		comment.author = "Adam"
		comment.text = "Machine Learning"

		comment.content = StoryChildNodes.new
		comment.content.child_nodes = []

		comment.range_start = DocumentPosition.new
		comment.range_start.node = NodeLink.new
		comment.range_start.node.node_id = "0.7.6"
		comment.range_start.offset = 0

		comment.range_end = DocumentPosition.new
		comment.range_end.node = NodeLink.new
		comment.range_end.node.node_id = "0.7.5"
		comment.range_end.offset = 0

		comment_index = 0
		response = @words_api.post_comment(file_name, comment_index, comment)
		assert(response, message="Failed to updates the comment")
	end

	def test_delete_comment
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		comment_index = 0
		response = @words_api.delete_comment(file_name, comment_index)
		assert(response, message="Failed to remove comment from document")
	end

	def test_get_document_properties
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_properties(file_name)
		assert(response, message="Failed to read document properties info")
	end

	def test_get_document_property
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		property_name = "Author"
		response = @words_api.get_document_property(file_name, property_name)
		assert(response, message="Failed to read document property info by the property name")
	end

	def test_put_update_document_property
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		property = DocumentProperty.new
		property.name = "Provider"
		property.value = "Jobs"

		property_name = "Provider"
		response = @words_api.put_update_document_property(file_name, property_name, property)
		assert(response, message="Failed to update existing document property")
	end

	def test_delete_document_property
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		property_name = "AsposeAuthor"
		response = @words_api.delete_document_property(file_name, property_name)
		assert(response, message="Failed to delete document property")
	end

	def test_get_document_drawing_objects
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_drawing_objects(file_name)
		assert(response, message="Failed to read document drawing objects common info")
	end

	def test_get_document_drawing_object_by_index
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		object_index = 1
		response = @words_api.get_document_drawing_object_by_index(file_name, object_index)
		assert(response, message="Failed to read document drawing object common info by its index")
	end

	def test_get_document_drawing_object_by_index_with_format
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		object_index = 1 
		format = "png"
		response = @words_api.get_document_drawing_object_by_index_with_format(file_name, object_index, format)
		assert(response, message="Failed to get document drawing object")
	end

	def test_get_document_drawing_object_image_data
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		object_index = 2
		response = @words_api.get_document_drawing_object_image_data(file_name, object_index)
		assert(response, message="Failed to read drawing object image data")
	end

	def test_get_document_drawing_object_ole_data
		file_name = "Sample_EmbeddedOLE.docx"
		upload_file(file_name)

		object_index = 0
		response = @words_api.get_document_drawing_object_ole_data(file_name, object_index)
		assert(response, message="Failed to get drawing object OLE data")
	end

	def test_post_document_execute_mail_merge
		file_name = "SampleMailMergeTemplateImage.doc"
		upload_file(file_name)
		image_name = "header-logo.png"
		upload_file(image_name)

		with_regions = false

		response = @words_api.post_document_execute_mail_merge(file_name, with_regions, File.open("../../../data/SampleMailMergeTemplateImageData.txt","r") { |io| io.read })
		assert(response, message="Failed to execute document mail merge operation")
	end

	def test_post_execute_template
		file_name = "SampleExecuteTemplate.doc"
		upload_file(file_name)

		response = @words_api.post_execute_template(file_name, File.open("../../../data/SampleExecuteTemplateData.txt","r") { |io| io.read })
		assert(response, message="Failed to populate document template with data")
	end

	def test_delete_document_fields
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.delete_document_fields(file_name)
		assert(response, message="Failed to remove fields from document")
	end

	def test_delete_headers_footers
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.delete_headers_footers(file_name)
		assert(response, message="Failed to delete document headers and footers")
	end

	def test_get_document_hyperlinks
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_hyperlinks(file_name)
		assert(response, message="Failed to read document hyperlinks common info")
	end

	def test_get_document_hyperlink_by_index
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		hyperlink_index = 0
		response = @words_api.get_document_hyperlink_by_index(file_name, hyperlink_index)
		assert(response, message="Failed to read document hyperlink by its index")
	end

	def test_post_insert_page_numbers
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		page_number = PageNumber.new
		page_number.format = "{PAGE} of {NUMPAGES}"
		page_number.alignment = "center"

		response = @words_api.post_insert_page_numbers(file_name, page_number)
		assert(response, message="Failed to insert document page numbers")
	end

	def test_post_insert_watermark_image
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.post_insert_watermark_image(file_name, {rotation_angle: 45, image: "aspose-cloud.png"})
		assert(response, message="Failed to insert document watermark image")
	end

	def test_post_insert_watermark_text
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		watermark_text = WatermarkText.new
		watermark_text.text = "Welcome Aspose"
		watermark_text.rotation_angle = 45

		response = @words_api.post_insert_watermark_text(file_name, watermark_text)
		assert(response, message="Failed to insert document watermark text")
	end

	def test_delete_document_macros
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.delete_document_macros(file_name)
		assert(response, message="Failed to remove macros from document")
	end

	def test_get_document_field_names
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_field_names(file_name)
		assert(response, message="Failed to read document field names")
	end

	def test_get_document_paragraphs
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_paragraphs(file_name)
		assert(response, message="Failed to return a list of paragraphs that are contained in the document")
	end

	def test_get_document_paragraph
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		paragraph_index = 1
		response = @words_api.get_document_paragraph(file_name, paragraph_index)
		assert(response, message="Failed to get paragraph contained in the document")
	end

	def test_delete_paragraph_fields
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		paragraph_index = 0
		response = @words_api.delete_paragraph_fields(file_name, paragraph_index)
		assert(response, message="Failed to remove fields from paragraph")
	end

	def test_get_document_paragraph_run
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		paragraph_index = 0
		run_index = 0
		response = @words_api.get_document_paragraph_run(file_name, paragraph_index, run_index)
		assert(response, message="Failed to get a paragraph contained in the document")
	end

	def test_get_document_paragraph_run_font
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)
		
		paragraph_index = 0
		run_index = 0
		response = @words_api.get_document_paragraph_run_font(file_name, paragraph_index, run_index)
		assert(response, message="Failed to get a paragraph contained in the document")
	end

	def test_post_document_paragraph_run_font
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		font = Font.new
		font.name = "Arial"
		font.bold = true

		paragraph_index = 0
		run_index = 0
		response = @words_api.post_document_paragraph_run_font(file_name, paragraph_index, run_index, font)
		assert(response, message="Failed to post document paragraph run font")
	end

	def test_get_document_protection
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_protection(file_name)
		assert(response, message="Failed to read document protection common info")
	end

	def test_put_protect_document
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		protection_data = ProtectionRequest.new
		protection_data.password = "myPassword"

		response = @words_api.put_protect_document(file_name, protection_data)
		assert(response, message="Failed to protect document")
	end

	def test_post_change_document_protection
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		protection_data = ProtectionRequest.new
		protection_data.password = "newPassword"

		response = @words_api.post_change_document_protection(file_name, protection_data)
		assert(response, message="Failed to change document protection")
	end

	def test_delete_unprotect_document
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		protection_data = ProtectionRequest.new
		protection_data.password = "myPassword"

		response = @words_api.delete_unprotect_document(file_name, protection_data)
		assert(response, message="Failed to unprotect document")
	end

	def test_post_replace_text
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		replace_text = ReplaceTextRequest.new
		replace_text.old_value = "Times New Roman"
		replace_text.current_value = "Arial Black"

		response = @words_api.post_replace_text(file_name, replace_text)
		assert(response, message="Failed to replace document text")
	end

	def test_accept_all_revisions
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.accept_all_revisions(file_name)
		assert(response, message="Failed to accept all revisions in document")
	end

	def test_reject_all_revisions
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.reject_all_revisions(file_name)
		assert(response, message="Failed to reject all revisions in document")
	end

	def test_get_words_search
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		pattern = "mat"
		response = @words_api.get_words_search(file_name, pattern)
		assert(response, message="Failed to do words search")
	end

	def test_get_sections
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_sections(file_name)
		assert(response, message="Failed to get a list of sections that are contained in the document")
	end

	def test_get_section
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		section_index = 0
		response = @words_api.get_section(file_name, section_index)
		assert(response, message="Failed to get document section by index")
	end

	def test_delete_section_fields 
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		section_index = 0
		response = @words_api.delete_section_fields(file_name, section_index)
		assert(response, message="Failed to remove fields from section")
	end

	def test_get_section_page_setup
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		section_index = 0
		response = @words_api.get_section_page_setup(file_name, section_index)
		assert(response, message="Failed to get page setup of section")
	end

	def test_update_section_page_setup
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		page_setup = PageSetup.new
		page_setup.rtl_gutter = true
		page_setup.left_margin = 10.0
		page_setup.orientation = "Landscape"
		page_setup.paper_size = "A5"

		section_index = 0
		response = @words_api.update_section_page_setup(file_name, section_index, page_setup)
		assert(response, message="Failed to update page setup of section")
	end

	def test_put_field
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		field = Field.new
		field.result = "John Doe"
		field.field_code = "{ FORMTEXT }"
		field.node_id = "0.1" 

		section_index = 0
		paragraph_index = 0
		response = @words_api.put_field(file_name, section_index, paragraph_index, field)
		assert(response, message="Failed to add field")
	end

	def test_get_field
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		section_index = 0
		paragraph_index = 0
		field_index = 0
		response = @words_api.get_field(file_name, section_index, paragraph_index, field_index)
		assert(response, message="Failed to get field")
	end

	def test_post_field
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		field = Field.new
		field.result = "John Doe"

		section_index = 0
		paragraph_index = 0
		field_index = 0
		response = @words_api.post_field(file_name, section_index, paragraph_index, field_index, field)
		assert(response, message="Failed to update field")
	end

	def test_put_form_field
		file_name = "FormFilled.docx"
		upload_file(file_name)

		form_field = FormField.new
		form_field.name = "FullName"
		form_field.status_text = "Enter your name and surname (trimmed to 30 characters)"
		form_field.enabled = true

		section_index = 0
		paragraph_index = 0
		response = @words_api.put_form_field(file_name, section_index, paragraph_index, form_field)
		assert(response, message="Failed to add form field to paragraph")
	end

	def test_get_form_field
		file_name = "FormFilled.docx"
		upload_file(file_name)

		section_index = 0
		paragraph_index = 0  
		formfield_index = 0
		response = @words_api.get_form_field(file_name, section_index, paragraph_index, formfield_index)
		assert(response, message="Failed to get a form field")
	end

	def test_post_form_field
		file_name = "FormFilled.docx"
		upload_file(file_name)

		form_field = FormField.new
		form_field.name = "CheckBox"
		form_field.status_text = "Helpful?"
		form_field.enabled = true

		section_index = 0
		paragraph_index = 0
		formfield_index = 0
		response = @words_api.post_form_field(file_name, section_index, paragraph_index, formfield_index, form_field)
		assert(response, message="Failed to update form field's properties")
	end

	def test_delete_form_field
		file_name = "FormFilled.docx"
		upload_file(file_name)

		section_index = 0 
		paragraph_index = 0
		formfield_index = 0
		response = @words_api.delete_form_field(file_name, section_index, paragraph_index, formfield_index)
		assert(response, message="Failed to remove form field from document")
	end

	def test_post_split_document
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.post_split_document(file_name, {format: "text", from: 1, to: 2, zip_output: false})
		assert(response, message="Failed to split document")
	end

	def test_get_document_statistics
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_statistics(file_name, {include_comments: true, include_footnotes: true, include_text_in_shapes: true})
		assert(response, message="Failed to read document statistics")
	end

	def test_get_document_text_items
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.get_document_text_items(file_name)
		assert(response, message="Failed to read document text items")
	end

	def test_post_update_document_fields
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.post_update_document_fields(file_name)
		assert(response, message="Failed to update (reevaluate) fields in document")
	end

	def test_delete_document_watermark
		file_name = "SampleBlankWatermarkDocument.docx"
		upload_file(file_name)

		response = @words_api.delete_document_watermark(file_name)
		assert(response, message="Failed to delete watermark")
	end

	def test_post_insert_document_watermark_image
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		response = @words_api.post_insert_document_watermark_image(file_name, {rotation_angle: 45, image: "aspose-cloud.png"})
		assert(response, message="Failed to insert document watermark image")
	end

	def test_post_insert_document_watermark_text
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)

		watermark_text = WatermarkText.new
		watermark_text.text = "Welcome Aspose"
		watermark_text.rotation_angle = 45
		response = @words_api.post_insert_document_watermark_text(file_name, watermark_text)
		assert(response, message="Failed to insert document watermark text")
	end
end
