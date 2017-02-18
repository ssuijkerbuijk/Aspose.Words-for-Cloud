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
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  # Load new document from web into the file with any supported format of data.
  def load_web_document 
    load_web_document_data = LoadWebDocumentData.new
    load_web_document_data.loading_document_url = "http://google.com"

    save_options = SaveOptionsData.new
    save_options.save_format = "doc"
    save_options.file_name = "google.doc"

    load_web_document_data.save_options = save_options

    response = @words_api.post_load_web_document(load_web_document_data)
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.load_web_document