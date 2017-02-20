#ExStart:
require 'aspose_words_cloud'

class WorkingWithSplitResource

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

  def split_specific_pages_to_new_pdfs
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    response = @words_api.post_split_document(file_name, {format: "pdf", from: 1, to: 2, zip_output: false})
  end

end

workingWithSplitResource = WorkingWithSplitResource.new()
puts workingWithSplitResource.split_specific_pages_to_new_pdfs
#ExEnd: