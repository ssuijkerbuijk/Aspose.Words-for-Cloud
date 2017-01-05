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
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def replace_text
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    replace_text = ReplaceTextRequest.new
    replace_text.old_value = "Times New Roman"
    replace_text.current_value = "Arial Black"

    response = @words_api.post_replace_text(file_name, replace_text)
  end

end

workingWithText = WorkingWithText.new()
puts workingWithText.replace_text