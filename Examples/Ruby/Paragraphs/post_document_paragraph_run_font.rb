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

  def post_document_paragraph_run_font
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    font = Font.new
    font.name = "Arial"
    font.bold = true

    paragraph_index = 0
    run_index = 0
    response = @words_api.post_document_paragraph_run_font(file_name, paragraph_index, run_index, font)
  end

end

workingWithParagraphs = WorkingWithParagraphs.new()
puts workingWithParagraphs.post_document_paragraph_run_font