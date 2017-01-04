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
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def get_document_drawing_object_ole_data
    file_name = "Sample_EmbeddedOLE.docx"
    upload_file(file_name)

    object_index = 0
    response = @words_api.get_document_drawing_object_ole_data(file_name, object_index)
  end

end

drawingObjects = DrawingObjects.new()
puts drawingObjects.get_document_drawing_object_ole_data