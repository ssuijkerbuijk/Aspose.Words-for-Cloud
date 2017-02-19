require 'aspose_words_cloud'

class Fields

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

  # Insert document page numbers.
  def insert_document_page_numbers
    file_name = "SampleWordDocument.docx"
    #upload_file(file_name)

    page_number = PageNumber.new
    page_number.format = "{PAGE} of {NUMPAGES}"
    page_number.alignment = "center"

    response = @words_api.post_insert_page_numbers(file_name, page_number)
  end

end

fields = Fields.new()
puts fields.insert_document_page_numbers