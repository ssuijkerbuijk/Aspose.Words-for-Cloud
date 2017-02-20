#ExStart:
require 'aspose_words_cloud'

class MailMerge

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

  def populate_document_template_with_data_online
    file_name = "SampleExecuteTemplate.doc"
    data_file_name = "SampleExecuteTemplateData.txt"

    file = File.open("../../../data/" << file_name,"r") { |io| io.read }
    data = File.open("../../../data/" << data_file_name,"r") { |io| io.read }
    
    response = @words_api.put_execute_template_online(file, data)
  end

end

mailMerge = MailMerge.new()
puts mailMerge.populate_document_template_with_data_online
#ExEnd: