require 'aspose_words_cloud'

class WorkingWithParagraphs

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

  # Return a list of paragraphs that are contained in the document.
  def get_document_paragraphs
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    response = @words_api.get_document_paragraphs(file_name)
  end

end

workingWithParagraphs = WorkingWithParagraphs.new()
puts workingWithParagraphs.get_document_paragraphs