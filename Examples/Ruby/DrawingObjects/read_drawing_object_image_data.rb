#ExStart:
require 'aspose_words_cloud'

class DrawingObjects

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

  # Read drawing object image data.
  def read_drawing_object_image_data
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    object_index = 2
    response = @words_api.get_document_drawing_object_image_data(file_name, object_index)
  end

end

drawingObjects = DrawingObjects.new()
puts drawingObjects.read_drawing_object_image_data
#ExEnd: