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

  def get_document_property
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    property_name = "Author"
    response = @words_api.get_document_property(file_name, property_name)
  end

end

workingWithDocumentProperties = WorkingWithDocumentProperties.new()
puts workingWithDocumentProperties.get_document_property