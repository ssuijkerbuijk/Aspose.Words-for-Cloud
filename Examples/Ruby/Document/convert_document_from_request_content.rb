#ExStart:
require 'aspose_words_cloud'

class WorkingWithDocument

  include AsposeWordsCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @words_api = WordsApi.new  
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
  end

  # Convert document from request content to format specified.
  def convert_document_from_request_content
    file_name = "SampleWordDocument.docx"
    convert_to_format = "pdf"
    response = @words_api.put_convert_document(File.open("../../../data/" << file_name,"r") { |io| io.read }, {format: convert_to_format})
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.convert_document_from_request_content
#ExEnd: