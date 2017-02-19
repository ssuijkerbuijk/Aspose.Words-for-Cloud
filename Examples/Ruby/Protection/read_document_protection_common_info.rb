require 'aspose_words_cloud'

class Protection

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

  # Read document protection common info.
  def read_document_protection_common_info
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    response = @words_api.get_document_protection(file_name)
  end

end

protection = Protection.new()
puts protection.read_document_protection_common_info