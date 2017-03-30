#ExStart:
require 'aspose_words_cloud'

class WorkingWithFields

  include AsposeWordsCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("App Key", "App SID")
    @words_api = WordsApi.new  
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
  end

  # Update (reevaluate) fields in document.
  def get_document_field_names
    file_name = "SampleMailMergeTemplate.docx"
    upload_file(file_name)

    response = @words_api.get_document_field_names(file_name, {useNonMergeFields: false})
  end

end

workingWithFields = WorkingWithFields.new()
puts workingWithFields.get_document_field_names
#ExEnd: