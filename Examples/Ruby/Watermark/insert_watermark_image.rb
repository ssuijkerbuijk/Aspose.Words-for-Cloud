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

  # Insert document watermark image.
  def insert_watermark_image
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)
    image_file_name = "aspose-cloud.png"
    upload_file(image_file_name)

    response = @words_api.post_insert_watermark_image(file_name, {rotation_angle: 45, image: image_file_name})
  end

end

watermark = Watermark.new()
puts watermark.insert_watermark_image