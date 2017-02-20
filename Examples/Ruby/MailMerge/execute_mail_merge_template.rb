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

  def execute_mail_merge_template
    file_name = "SampleMailMergeTemplateImage.doc"
    upload_file(file_name)
    image_name = "header-logo.png"
    upload_file(image_name)

    with_regions = false

    response = @words_api.post_document_execute_mail_merge(file_name, with_regions, File.open("../../../data/SampleMailMergeTemplateImageData.txt","r") { |io| io.read })
  end

end

mailMerge = MailMerge.new()
puts mailMerge.execute_mail_merge_template
#ExEnd: