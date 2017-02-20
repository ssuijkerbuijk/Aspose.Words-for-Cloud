#ExStart:
require 'aspose_words_cloud'

class Watermark

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

  # Insert document watermark text.
  def insert_watermark_text
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    watermark_text = WatermarkText.new
    watermark_text.text = "Welcome Aspose"
    watermark_text.rotation_angle = 45
    response = @words_api.post_insert_document_watermark_text(file_name, watermark_text)
  end

end

watermark = Watermark.new()
puts watermark.insert_watermark_text
#ExEnd: