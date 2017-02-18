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

  def read_document_statistics
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    response = @words_api.get_document_statistics(file_name, {include_comments: true, include_footnotes: true, include_text_in_shapes: true})
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.read_document_statistics