require 'aspose_words_cloud'

class WorkingWithDocument

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

  def append_a_document
    file_name = "SampleWordDocument.docx"
    upload_file(file_name)
    append_doc_1_file_name = "SampleAppendDoc.docx"
    upload_file(append_doc_1_file_name)
    append_doc_2_file_name = "SampleAppendDoc2.docx"
    upload_file(append_doc_2_file_name)

    document_1 = DocumentEntry.new
    document_1.href = append_doc_1_file_name
    document_1.import_format_mode = "KeepSourceFormatting"

    document_2 = DocumentEntry.new
    document_2.href = append_doc_2_file_name
    document_2.import_format_mode = "KeepSourceFormatting"

    document_list = DocumentEntryList.new
    document_list.document_entries = [document_1, document_2]

    response = @words_api.post_append_document(file_name, document_list)
  end

end

workingWithDocument = WorkingWithDocument.new()
puts workingWithDocument.append_a_document