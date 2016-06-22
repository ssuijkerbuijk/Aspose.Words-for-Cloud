require 'aspose_storage_cloud'

# Common files
require_relative 'aspose_words_cloud/api_client'
require_relative 'aspose_words_cloud/api_error'
require_relative 'aspose_words_cloud/version'
require_relative 'aspose_words_cloud/configuration'

# Models
require_relative 'aspose_words_cloud/models/base_object'
require_relative 'aspose_words_cloud/models/base_response'
require_relative 'aspose_words_cloud/models/text_items_response'
require_relative 'aspose_words_cloud/models/text_items'
require_relative 'aspose_words_cloud/models/text_item'
require_relative 'aspose_words_cloud/models/replace_text_request'
require_relative 'aspose_words_cloud/models/replace_text_response'
require_relative 'aspose_words_cloud/models/bookmarks_response'
require_relative 'aspose_words_cloud/models/bookmarks'
require_relative 'aspose_words_cloud/models/bookmark'
require_relative 'aspose_words_cloud/models/bookmark_response'
require_relative 'aspose_words_cloud/models/bookmark_data'
require_relative 'aspose_words_cloud/models/drawing_objects_response'
require_relative 'aspose_words_cloud/models/drawing_objects'
require_relative 'aspose_words_cloud/models/link_element'
require_relative 'aspose_words_cloud/models/document_response'
require_relative 'aspose_words_cloud/models/document'
require_relative 'aspose_words_cloud/models/document_properties'
require_relative 'aspose_words_cloud/models/document_property'
require_relative 'aspose_words_cloud/models/watermark_text'
require_relative 'aspose_words_cloud/models/field_names_response'
require_relative 'aspose_words_cloud/models/field_names'
require_relative 'aspose_words_cloud/models/stat_data_response'
require_relative 'aspose_words_cloud/models/document_stat_data'
require_relative 'aspose_words_cloud/models/page_stat_data'
require_relative 'aspose_words_cloud/models/paragraph_link_collection_response'
require_relative 'aspose_words_cloud/models/paragraph_link_collection'
require_relative 'aspose_words_cloud/models/paragraph_link'
require_relative 'aspose_words_cloud/models/paragraph_response'
require_relative 'aspose_words_cloud/models/paragraph'
require_relative 'aspose_words_cloud/models/run_response'
require_relative 'aspose_words_cloud/models/run'
require_relative 'aspose_words_cloud/models/font_response'
require_relative 'aspose_words_cloud/models/font'
require_relative 'aspose_words_cloud/models/border'
require_relative 'aspose_words_cloud/models/color'
require_relative 'aspose_words_cloud/models/page_number'
require_relative 'aspose_words_cloud/models/document_entry_list'
require_relative 'aspose_words_cloud/models/document_entry'
require_relative 'aspose_words_cloud/models/split_document_response'
require_relative 'aspose_words_cloud/models/split_document_result'
require_relative 'aspose_words_cloud/models/load_web_document_data'
require_relative 'aspose_words_cloud/models/save_options_data'
require_relative 'aspose_words_cloud/models/save_response'
require_relative 'aspose_words_cloud/models/save_result'
require_relative 'aspose_words_cloud/models/protection_data_response'
require_relative 'aspose_words_cloud/models/protection_data'
require_relative 'aspose_words_cloud/models/protection_request'
require_relative 'aspose_words_cloud/models/revisions_modification_response'
require_relative 'aspose_words_cloud/models/modification_operation_result'
require_relative 'aspose_words_cloud/models/form_field_response'
require_relative 'aspose_words_cloud/models/form_field'
require_relative 'aspose_words_cloud/models/section_link_collection_response'
require_relative 'aspose_words_cloud/models/section_link_collection'
require_relative 'aspose_words_cloud/models/section_link'
require_relative 'aspose_words_cloud/models/section_response'
require_relative 'aspose_words_cloud/models/section'
require_relative 'aspose_words_cloud/models/section_page_setup_response'
require_relative 'aspose_words_cloud/models/page_setup'
require_relative 'aspose_words_cloud/models/document_properties_response'
require_relative 'aspose_words_cloud/models/document_property_response'
require_relative 'aspose_words_cloud/models/hyperlinks_response'
require_relative 'aspose_words_cloud/models/hyperlinks'
require_relative 'aspose_words_cloud/models/hyperlink'
require_relative 'aspose_words_cloud/models/hyperlink_response'
require_relative 'aspose_words_cloud/models/tiff_save_options_data'
require_relative 'aspose_words_cloud/models/comment_response'
require_relative 'aspose_words_cloud/models/comments_response'
require_relative 'aspose_words_cloud/models/comments_collection'
require_relative 'aspose_words_cloud/models/comment'
require_relative 'aspose_words_cloud/models/document_position'
require_relative 'aspose_words_cloud/models/node_link'
require_relative 'aspose_words_cloud/models/story_child_nodes'
require_relative 'aspose_words_cloud/models/response_message'
require_relative 'aspose_words_cloud/models/metafile_rendering_options_data'
require_relative 'aspose_words_cloud/models/field_response'
require_relative 'aspose_words_cloud/models/field'
require_relative 'aspose_words_cloud/models/rectangle'
require_relative 'aspose_words_cloud/models/search_response'
require_relative 'aspose_words_cloud/models/search_results_collection'
require_relative 'aspose_words_cloud/models/search_result'
require_relative 'aspose_words_cloud/models/link'
require_relative 'aspose_words_cloud/models/drawing_object_response'
require_relative 'aspose_words_cloud/models/drawing_object'

# APIs
require_relative 'aspose_words_cloud/api/words_api'

module AsposeWordsCloud
  class << self
    # Configure sdk using block.
    # AsposeWordsCloud.configure do |config|
    #   config.username = "xxx"
    #   config.password = "xxx"
    # end
    # If no block given, return the configuration singleton instance.
    def configure
      if block_given?
        yield Configuration.instance
      else
        Configuration.instance
      end
    end
  end
end
