require 'aspose_words_cloud'

class Fields

  include AsposeWordsCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @words_api = WordsApi.new  
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  # Add form field to paragraph, returns added form field's data.
  def add_form_field_to_paragraph
    file_name = "FormFilled.docx"
    upload_file(file_name)

    form_field = FormField.new
    form_field.name = "FullName"
    form_field.status_text = "Enter your name and surname (trimmed to 30 characters)"
    form_field.enabled = true

    section_index = 0
    paragraph_index = 0
    response = @words_api.put_form_field(file_name, section_index, paragraph_index, form_field)
  end

end

fields = Fields.new()
puts fields.add_form_field_to_paragraph