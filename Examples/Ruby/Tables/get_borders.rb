#ExStart:
require 'aspose_words_cloud'

class WorkingWithTables

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

  def get_borders
    file_name = "TableDocument.doc"
    upload_file(file_name)
      
    table_index = 1
    row_index = 0
    response = @words_api.get_borders(file_name, table_index, row_index)
  end

end

workingWithTables = WorkingWithTables.new()
puts workingWithTables.get_borders
#ExEnd:
