require 'aspose_words_cloud'

class WorkingWithDocumentProperties

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

  def add_new_or_update_existing_document_property
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    property = DocumentProperty.new
    property.name = "Provider"
    property.value = "Jobs"

    property_name = "Provider"
    response = @words_api.put_update_document_property(file_name, property_name, property)
  end

end

workingWithDocumentProperties = WorkingWithDocumentProperties.new()
puts workingWithDocumentProperties.add_new_or_update_existing_document_property