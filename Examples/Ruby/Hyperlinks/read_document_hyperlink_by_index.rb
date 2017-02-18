require 'aspose_words_cloud'

class Hyperlinks

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

  # Read document hyperlink by its index.
  def read_document_hyperlink_by_index
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    hyperlink_index = 0
    response = @words_api.get_document_hyperlink_by_index(file_name, hyperlink_index)
  end

end

hyperlinks = Hyperlinks.new()
puts hyperlinks.read_document_hyperlink_by_index