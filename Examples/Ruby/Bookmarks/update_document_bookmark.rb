require 'aspose_words_cloud'

class Bookmarks

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

  def update_document_bookmark
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)

    bookmark_data = BookmarkData.new
    bookmark_data.name = "aspose"
    bookmark_data.text = "Aspose APIs"

    bookmark_name = "aspose"
    response = @words_api.post_update_document_bookmark(file_name, bookmark_name, bookmark_data)
  end

end

bookmarks = Bookmarks.new()
puts bookmarks.update_document_bookmark