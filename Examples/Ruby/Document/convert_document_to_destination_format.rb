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

  # Convert document to destination format with detailed settings and save result to storage.
  def convert_document_to_destination_format
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    save_options = SaveOptionsData.new
    save_options.save_format = "pdf"
    save_options.file_name = "SampleWordDocument.pdf"
    response = @words_api.post_document_save_as(file_name, save_options)
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.convert_document_to_destination_format
#ExEnd: