require 'aspose_words_cloud'

class WorkingWithText

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

  # Read document text items.
  def read_document_text_items
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)
    response = @words_api.get_document_text_items(file_name)
  end

end

workingWithText = WorkingWithText.new()
puts workingWithText.read_document_text_items