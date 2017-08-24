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

  def render_page
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)
      
    page_index = 1
    format = "bmp"
    response = @words_api.render_page(file_name, page_index, format, opts = {})
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.render_page
#ExEnd:
