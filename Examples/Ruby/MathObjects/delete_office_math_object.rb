#ExStart:
require 'aspose_words_cloud'

class WorkingWithMathObjects

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

  def delete_office_math_object
    file_name = "MathsObject.docx"
    upload_file(file_name)
      
    index = 1
    response = @words_api.delete_office_math_object(file_name, index, opts = {})
  end

end

workingWithMathObjects = WorkingWithMathObjects.new()
puts workingWithMathObjects.delete_office_math_object
#ExEnd:
