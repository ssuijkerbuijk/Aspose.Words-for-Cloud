require "uri"

module AsposeWordsCloud
  class WordsApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end

    # Convert document from request content to format specified.
    # 
    # @param file 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :format Format to convert.
    # @option opts [String] :out_path Path for saving operation result to the local storage.
    # @option opts [String] :replace_resources_host_to Controls wherefrom Aspose.Words loads external resource when importing a document from HTML or MHTML.
    # @return [File]
    def convert_document(file, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_convert_document ..."
      end
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling put_convert_document" if file.nil?
      
      # resource path
      path = "/words/convert".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'format'] = opts[:'format'] if opts[:'format']
      query_params[:'outPath'] = opts[:'out_path'] if opts[:'out_path']
      query_params[:'replaceResourcesHostTo'] = opts[:'replace_resources_host_to'] if opts[:'replace_resources_host_to']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_convert_document. Result: #{result.inspect}"
      end
      return result
    end

    # Execute document mail merge online.
    # 
    # @param with_regions With regions flag.
    # @param file 
    # @param data 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :cleanup Clean up options.
    # @return [File]
    def put_execute_mail_merge_online(with_regions, file, data, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_execute_mail_merge_online ..."
      end
      
      # verify the required parameter 'with_regions' is set
      fail "Missing the required parameter 'with_regions' when calling put_execute_mail_merge_online" if with_regions.nil?
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling put_execute_mail_merge_online" if file.nil?
      
      # verify the required parameter 'data' is set
      fail "Missing the required parameter 'data' when calling put_execute_mail_merge_online" if data.nil?
      
      # resource path
      path = "/words/executeMailMerge".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'withRegions'] = with_regions
      query_params[:'cleanup'] = opts[:'cleanup'] if opts[:'cleanup']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file
      form_params["data"] = data

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_execute_mail_merge_online. Result: #{result.inspect}"
      end
      return result
    end

    # Populate document template with data online.
    # 
    # @param file 
    # @param data 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :cleanup Clean up options.
    # @option opts [BOOLEAN] :use_whole_paragraph_as_region Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields. The default value is true.
    # @option opts [BOOLEAN] :with_regions Merge with regions or not. True by default
    # @return [File]
    def put_execute_template_online(file, data, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_execute_template_online ..."
      end
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling put_execute_template_online" if file.nil?
      
      # verify the required parameter 'data' is set
      fail "Missing the required parameter 'data' when calling put_execute_template_online" if data.nil?
      
      # resource path
      path = "/words/executeTemplate".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'cleanup'] = opts[:'cleanup'] if opts[:'cleanup']
      query_params[:'useWholeParagraphAsRegion'] = opts[:'use_whole_paragraph_as_region'] if opts[:'use_whole_paragraph_as_region']
      query_params[:'withRegions'] = opts[:'with_regions'] if opts[:'with_regions']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file
      form_params["data"] = data

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_execute_template_online. Result: #{result.inspect}"
      end
      return result
    end

    # Load new document from web into the file with any supported format of data.
    # 
    # @param data 
    # @param [Hash] opts the optional parameters
    # @return [SaveResponse]
    def post_load_web_document(data, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_load_web_document ..."
      end
      
      # verify the required parameter 'data' is set
      fail "Missing the required parameter 'data' when calling post_load_web_document" if data.nil?
      
      # resource path
      path = "/words/loadWebDocument".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(data)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SaveResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_load_web_document. Result: #{result.inspect}"
      end
      return result
    end

    # Read document field names.
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [BOOLEAN] :use_non_merge_fields 
    # @return [FieldNamesResponse]
    def put_document_field_names(opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_document_field_names ..."
      end
      
      # resource path
      path = "/words/mailMergeFieldNames".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'useNonMergeFields'] = opts[:'use_non_merge_fields'] if opts[:'use_non_merge_fields']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FieldNamesResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_document_field_names. Result: #{result.inspect}"
      end
      return result
    end

    # Run tasks
    # 
    # @param file 
    # @param [Hash] opts the optional parameters
    # @return [ResponseMessage]
    def post_run_task(file, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_run_task ..."
      end
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling post_run_task" if file.nil?
      
      # resource path
      path = "/words/tasks".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ResponseMessage')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_run_task. Result: #{result.inspect}"
      end
      return result
    end

    # Read document common info.
    # 
    # @param name The file name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def get_document(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document" if name.nil?
      
      # resource path
      path = "/words/{name}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document. Result: #{result.inspect}"
      end
      return result
    end

    # Export the document into the specified format.
    # 
    # @param name 
    # @param format 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @option opts [String] :out_path 
    # @return [File]
    def get_document_with_format(name, format, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_with_format ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_with_format" if name.nil?
      
      # verify the required parameter 'format' is set
      fail "Missing the required parameter 'format' when calling get_document_with_format" if format.nil?
      
      # resource path
      path = "/words/{name}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'format'] = format
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'outPath'] = opts[:'out_path'] if opts[:'out_path']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_with_format. Result: #{result.inspect}"
      end
      return result
    end

    # Convert document to destination format with detailed settings and save result to storage.
    # 
    # @param name The document name.
    # @param save_options_data Save options.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [SaveResponse]
    def post_document_save_as(name, save_options_data, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_document_save_as ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_document_save_as" if name.nil?
      
      # verify the required parameter 'save_options_data' is set
      fail "Missing the required parameter 'save_options_data' when calling post_document_save_as" if save_options_data.nil?
      
      # resource path
      path = "/words/{name}/SaveAs".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(save_options_data)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SaveResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_document_save_as. Result: #{result.inspect}"
      end
      return result
    end

    # Convert document to tiff with detailed settings and save result to storage.
    # 
    # @param name The document name.
    # @param save_options Tiff save options.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :result_file The resulting file name.
    # @option opts [BOOLEAN] :use_anti_aliasing Use antialiasing flag.
    # @option opts [BOOLEAN] :use_high_quality_rendering Use high quality flag.
    # @option opts [Float] :image_brightness Brightness for the generated images.
    # @option opts [String] :image_color_mode Color mode for the generated images.
    # @option opts [Float] :image_contrast The contrast for the generated images.
    # @option opts [String] :numeral_format The images numeral format.
    # @option opts [Integer] :page_count Number of pages to render.
    # @option opts [Integer] :page_index Page index to start rendering.
    # @option opts [String] :paper_color Background image color.
    # @option opts [String] :pixel_format The pixel format of generated images.
    # @option opts [Float] :resolution The resolution of generated images.
    # @option opts [Float] :scale Zoom factor for generated images.
    # @option opts [String] :tiff_compression The compression tipe.
    # @option opts [String] :dml_rendering_mode Optional, default is Fallback.
    # @option opts [String] :dml_effects_rendering_mode Optional, default is Simplified.
    # @option opts [String] :tiff_binarization_method Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [BOOLEAN] :zip_output Optional. A value determining zip output or not.
    # @return [SaveResponse]
    def put_document_save_as_tiff(name, save_options, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_document_save_as_tiff ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_document_save_as_tiff" if name.nil?
      
      # verify the required parameter 'save_options' is set
      fail "Missing the required parameter 'save_options' when calling put_document_save_as_tiff" if save_options.nil?
      
      # resource path
      path = "/words/{name}/SaveAs/tiff".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'resultFile'] = opts[:'result_file'] if opts[:'result_file']
      query_params[:'useAntiAliasing'] = opts[:'use_anti_aliasing'] if opts[:'use_anti_aliasing']
      query_params[:'useHighQualityRendering'] = opts[:'use_high_quality_rendering'] if opts[:'use_high_quality_rendering']
      query_params[:'imageBrightness'] = opts[:'image_brightness'] if opts[:'image_brightness']
      query_params[:'imageColorMode'] = opts[:'image_color_mode'] if opts[:'image_color_mode']
      query_params[:'imageContrast'] = opts[:'image_contrast'] if opts[:'image_contrast']
      query_params[:'numeralFormat'] = opts[:'numeral_format'] if opts[:'numeral_format']
      query_params[:'pageCount'] = opts[:'page_count'] if opts[:'page_count']
      query_params[:'pageIndex'] = opts[:'page_index'] if opts[:'page_index']
      query_params[:'paperColor'] = opts[:'paper_color'] if opts[:'paper_color']
      query_params[:'pixelFormat'] = opts[:'pixel_format'] if opts[:'pixel_format']
      query_params[:'resolution'] = opts[:'resolution'] if opts[:'resolution']
      query_params[:'scale'] = opts[:'scale'] if opts[:'scale']
      query_params[:'tiffCompression'] = opts[:'tiff_compression'] if opts[:'tiff_compression']
      query_params[:'dmlRenderingMode'] = opts[:'dml_rendering_mode'] if opts[:'dml_rendering_mode']
      query_params[:'dmlEffectsRenderingMode'] = opts[:'dml_effects_rendering_mode'] if opts[:'dml_effects_rendering_mode']
      query_params[:'tiffBinarizationMethod'] = opts[:'tiff_binarization_method'] if opts[:'tiff_binarization_method']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'zipOutput'] = opts[:'zip_output'] if opts[:'zip_output']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(save_options)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SaveResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_document_save_as_tiff. Result: #{result.inspect}"
      end
      return result
    end

    # Append documents to original document.
    # 
    # @param name Original document name.
    # @param document_list {DocumentEntryList} with a list of documents to append.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage Original document storage.
    # @option opts [String] :folder Original document folder.
    # @return [DocumentResponse]
    def post_append_document(name, document_list, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_append_document ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_append_document" if name.nil?
      
      # verify the required parameter 'document_list' is set
      fail "Missing the required parameter 'document_list' when calling post_append_document" if document_list.nil?
      
      # resource path
      path = "/words/{name}/appendDocument".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(document_list)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_append_document. Result: #{result.inspect}"
      end
      return result
    end

    # Read document bookmarks common info.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BookmarksResponse]
    def get_document_bookmarks(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_bookmarks ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_bookmarks" if name.nil?
      
      # resource path
      path = "/words/{name}/bookmarks".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BookmarksResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_bookmarks. Result: #{result.inspect}"
      end
      return result
    end

    # Read document bookmark data by its name.
    # 
    # @param name The document name.
    # @param bookmark_name The bookmark name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BookmarkResponse]
    def get_document_bookmark_by_name(name, bookmark_name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_bookmark_by_name ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_bookmark_by_name" if name.nil?
      
      # verify the required parameter 'bookmark_name' is set
      fail "Missing the required parameter 'bookmark_name' when calling get_document_bookmark_by_name" if bookmark_name.nil?
      
      # resource path
      path = "/words/{name}/bookmarks/{bookmarkName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'bookmarkName' + '}', bookmark_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BookmarkResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_bookmark_by_name. Result: #{result.inspect}"
      end
      return result
    end

    # Update document bookmark.
    # 
    # @param name The document name.
    # @param bookmark_name The bookmark name.
    # @param bookmark_data {BookmarkData} with new bookmark data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BookmarkResponse]
    def post_update_document_bookmark(name, bookmark_name, bookmark_data, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_update_document_bookmark ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_update_document_bookmark" if name.nil?
      
      # verify the required parameter 'bookmark_name' is set
      fail "Missing the required parameter 'bookmark_name' when calling post_update_document_bookmark" if bookmark_name.nil?
      
      # verify the required parameter 'bookmark_data' is set
      fail "Missing the required parameter 'bookmark_data' when calling post_update_document_bookmark" if bookmark_data.nil?
      
      # resource path
      path = "/words/{name}/bookmarks/{bookmarkName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'bookmarkName' + '}', bookmark_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(bookmark_data)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BookmarkResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_update_document_bookmark. Result: #{result.inspect}"
      end
      return result
    end

    # Get comments from document.
    # 
    # @param name The file name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [CommentsResponse]
    def get_comments(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_comments ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_comments" if name.nil?
      
      # resource path
      path = "/words/{name}/comments".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'CommentsResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_comments. Result: #{result.inspect}"
      end
      return result
    end

    # Adds comment to document, returns inserted comment&#39;s data.
    # 
    # @param name The document name.
    # @param comment Comment data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :file_name Destination file name.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [CommentResponse]
    def put_comment(name, comment, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_comment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_comment" if name.nil?
      
      # verify the required parameter 'comment' is set
      fail "Missing the required parameter 'comment' when calling put_comment" if comment.nil?
      
      # resource path
      path = "/words/{name}/comments".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'fileName'] = opts[:'file_name'] if opts[:'file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(comment)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'CommentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_comment. Result: #{result.inspect}"
      end
      return result
    end

    # Get comment from document.
    # 
    # @param name The file name.
    # @param comment_index Comment index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [CommentResponse]
    def get_comment(name, comment_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_comment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_comment" if name.nil?
      
      # verify the required parameter 'comment_index' is set
      fail "Missing the required parameter 'comment_index' when calling get_comment" if comment_index.nil?
      
      # resource path
      path = "/words/{name}/comments/{commentIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'commentIndex' + '}', comment_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'CommentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_comment. Result: #{result.inspect}"
      end
      return result
    end

    # Updates the comment, returns updated comment&#39;s data.
    # 
    # @param name The document name.
    # @param comment_index Comment index
    # @param comment Comment data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :file_name Destination file name.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [CommentResponse]
    def post_comment(name, comment_index, comment, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_comment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_comment" if name.nil?
      
      # verify the required parameter 'comment_index' is set
      fail "Missing the required parameter 'comment_index' when calling post_comment" if comment_index.nil?
      
      # verify the required parameter 'comment' is set
      fail "Missing the required parameter 'comment' when calling post_comment" if comment.nil?
      
      # resource path
      path = "/words/{name}/comments/{commentIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'commentIndex' + '}', comment_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'fileName'] = opts[:'file_name'] if opts[:'file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(comment)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'CommentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_comment. Result: #{result.inspect}"
      end
      return result
    end

    # Remove comment from document.
    # 
    # @param name The file name.
    # @param comment_index Comment index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [String] :file_name Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
    # @return [BaseResponse]
    def delete_comment(name, comment_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_comment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_comment" if name.nil?
      
      # verify the required parameter 'comment_index' is set
      fail "Missing the required parameter 'comment_index' when calling delete_comment" if comment_index.nil?
      
      # resource path
      path = "/words/{name}/comments/{commentIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'commentIndex' + '}', comment_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'fileName'] = opts[:'file_name'] if opts[:'file_name']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_comment. Result: #{result.inspect}"
      end
      return result
    end

    # Read document properties info.
    # 
    # @param name The document&#39;s name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document&#39;s storage.
    # @option opts [String] :folder The document&#39;s folder.
    # @return [DocumentPropertiesResponse]
    def get_document_properties(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_properties ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_properties" if name.nil?
      
      # resource path
      path = "/words/{name}/documentProperties".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentPropertiesResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_properties. Result: #{result.inspect}"
      end
      return result
    end

    # Read document property info by the property name.
    # 
    # @param name The document name.
    # @param property_name The property name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentPropertyResponse]
    def get_document_property(name, property_name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_property ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_property" if name.nil?
      
      # verify the required parameter 'property_name' is set
      fail "Missing the required parameter 'property_name' when calling get_document_property" if property_name.nil?
      
      # resource path
      path = "/words/{name}/documentProperties/{propertyName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'propertyName' + '}', property_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentPropertyResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_property. Result: #{result.inspect}"
      end
      return result
    end

    # Add new or update existing document property.
    # 
    # @param name The document name.
    # @param property_name The property name.
    # @param property The property with new value.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage Document&#39;s storage.
    # @option opts [String] :folder Document&#39;s folder.
    # @return [DocumentPropertyResponse]
    def put_update_document_property(name, property_name, property, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_update_document_property ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_update_document_property" if name.nil?
      
      # verify the required parameter 'property_name' is set
      fail "Missing the required parameter 'property_name' when calling put_update_document_property" if property_name.nil?
      
      # verify the required parameter 'property' is set
      fail "Missing the required parameter 'property' when calling put_update_document_property" if property.nil?
      
      # resource path
      path = "/words/{name}/documentProperties/{propertyName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'propertyName' + '}', property_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(property)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentPropertyResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_update_document_property. Result: #{result.inspect}"
      end
      return result
    end

    # Delete document property.
    # 
    # @param name The document name.
    # @param property_name The property name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage Document&#39;s storage.
    # @option opts [String] :folder Document&#39;s folder.
    # @return [BaseResponse]
    def delete_document_property(name, property_name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_document_property ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_document_property" if name.nil?
      
      # verify the required parameter 'property_name' is set
      fail "Missing the required parameter 'property_name' when calling delete_document_property" if property_name.nil?
      
      # resource path
      path = "/words/{name}/documentProperties/{propertyName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'propertyName' + '}', property_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_document_property. Result: #{result.inspect}"
      end
      return result
    end

    # Read document drawing objects common info.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DrawingObjectsResponse]
    def get_document_drawing_objects(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_drawing_objects ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_drawing_objects" if name.nil?
      
      # resource path
      path = "/words/{name}/drawingObjects".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DrawingObjectsResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_drawing_objects. Result: #{result.inspect}"
      end
      return result
    end
    
    # Read document drawing object common info by its index
    # 
    # @param name The document name.
    # @param object_index The drawing object index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder full path.
    # @return [DrawingObjectResponse]
    def get_document_drawing_object_by_index(name, object_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_drawing_object_by_index ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_drawing_object_by_index" if name.nil?
      
      # verify the required parameter 'object_index' is set
      fail "Missing the required parameter 'object_index' when calling get_document_drawing_object_by_index" if object_index.nil?
      
      # resource path
      path = "/words/{name}/drawingObjects/{objectIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'objectIndex' + '}', object_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DrawingObjectResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_drawing_object_by_index. Result: #{result.inspect}"
      end
      return result
    end
    
    # Read document drawing object common info by its index or convert to format specified.
    # 
    # @param name 
    # @param object_index 
    # @param format 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [File]
    def get_document_drawing_object_by_index_with_format(name, object_index, format, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_drawing_object_by_index_with_format ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_drawing_object_by_index_with_format" if name.nil?
      
      # verify the required parameter 'object_index' is set
      fail "Missing the required parameter 'object_index' when calling get_document_drawing_object_by_index_with_format" if object_index.nil?
      
      # verify the required parameter 'format' is set
      fail "Missing the required parameter 'format' when calling get_document_drawing_object_by_index_with_format" if format.nil?
      
      # resource path
      path = "/words/{name}/drawingObjects/{objectIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'objectIndex' + '}', object_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'format'] = format
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_drawing_object_by_index_with_format. Result: #{result.inspect}"
      end
      return result
    end

    # Read drawing object image data.
    # 
    # @param name The document name.
    # @param object_index The drawing object index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [File]
    def get_document_drawing_object_image_data(name, object_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_drawing_object_image_data ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_drawing_object_image_data" if name.nil?
      
      # verify the required parameter 'object_index' is set
      fail "Missing the required parameter 'object_index' when calling get_document_drawing_object_image_data" if object_index.nil?
      
      # resource path
      path = "/words/{name}/drawingObjects/{objectIndex}/imageData".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'objectIndex' + '}', object_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_drawing_object_image_data. Result: #{result.inspect}"
      end
      return result
    end

    # Get drawing object OLE data.
    # 
    # @param name The document name.
    # @param object_index The object index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [File]
    def get_document_drawing_object_ole_data(name, object_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_drawing_object_ole_data ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_drawing_object_ole_data" if name.nil?
      
      # verify the required parameter 'object_index' is set
      fail "Missing the required parameter 'object_index' when calling get_document_drawing_object_ole_data" if object_index.nil?
      
      # resource path
      path = "/words/{name}/drawingObjects/{objectIndex}/oleData".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'objectIndex' + '}', object_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['multipart/form-data']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_drawing_object_ole_data. Result: #{result.inspect}"
      end
      return result
    end

    # Execute document mail merge operation.
    # 
    # @param name The document name.
    # @param with_regions With regions flag.
    # @param file 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :mail_merge_data_file Mail merge data.
    # @option opts [String] :cleanup Clean up options.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [BOOLEAN] :use_whole_paragraph_as_region Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields. The default value is true.
    # @return [DocumentResponse]
    def post_document_execute_mail_merge(name, with_regions, file, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_document_execute_mail_merge ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_document_execute_mail_merge" if name.nil?
      
      # verify the required parameter 'with_regions' is set
      fail "Missing the required parameter 'with_regions' when calling post_document_execute_mail_merge" if with_regions.nil?
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling post_document_execute_mail_merge" if file.nil?
      
      # resource path
      path = "/words/{name}/executeMailMerge/{withRegions}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'withRegions' + '}', with_regions.to_s)

      # query parameters
      query_params = {}
      query_params[:'mailMergeDataFile'] = opts[:'mail_merge_data_file'] if opts[:'mail_merge_data_file']
      query_params[:'cleanup'] = opts[:'cleanup'] if opts[:'cleanup']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'useWholeParagraphAsRegion'] = opts[:'use_whole_paragraph_as_region'] if opts[:'use_whole_paragraph_as_region']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_document_execute_mail_merge. Result: #{result.inspect}"
      end
      return result
    end

    # Populate document template with data.
    # 
    # @param name The template document name.
    # @param file 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :cleanup Clean up options.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [BOOLEAN] :use_whole_paragraph_as_region Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.  The default value is true.
    # @option opts [BOOLEAN] :with_regions Merge with regions or not. True by default
    # @return [DocumentResponse]
    def post_execute_template(name, file, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_execute_template ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_execute_template" if name.nil?
      
      # verify the required parameter 'file' is set
      fail "Missing the required parameter 'file' when calling post_execute_template" if file.nil?
      
      # resource path
      path = "/words/{name}/executeTemplate".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'cleanup'] = opts[:'cleanup'] if opts[:'cleanup']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'useWholeParagraphAsRegion'] = opts[:'use_whole_paragraph_as_region'] if opts[:'use_whole_paragraph_as_region']
      query_params[:'withRegions'] = opts[:'with_regions'] if opts[:'with_regions']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['multipart/form-data']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}
      form_params["file"] = file

      # http body (model)
      post_body = nil
      
      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_execute_template. Result: #{result.inspect}"
      end
      return result
    end

    # Remove fields from document.
    # 
    # @param name The file name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_document_fields(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_document_fields ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_document_fields" if name.nil?
      
      # resource path
      path = "/words/{name}/fields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_document_fields. Result: #{result.inspect}"
      end
      return result
    end

    # Delete document headers and footers.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :headers_footers_types List of types of headers and footers.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_headers_footers(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_headers_footers ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_headers_footers" if name.nil?
      
      # resource path
      path = "/words/{name}/headersfooters".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'headersFootersTypes'] = opts[:'headers_footers_types'] if opts[:'headers_footers_types']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_headers_footers. Result: #{result.inspect}"
      end
      return result
    end

    # Read document hyperlinks common info.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [HyperlinksResponse]
    def get_document_hyperlinks(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_hyperlinks ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_hyperlinks" if name.nil?
      
      # resource path
      path = "/words/{name}/hyperlinks".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'HyperlinksResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_hyperlinks. Result: #{result.inspect}"
      end
      return result
    end

    # Read document hyperlink by its index.
    # 
    # @param name The document name.
    # @param hyperlink_index The hyperlink index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [HyperlinkResponse]
    def get_document_hyperlink_by_index(name, hyperlink_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_hyperlink_by_index ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_hyperlink_by_index" if name.nil?
      
      # verify the required parameter 'hyperlink_index' is set
      fail "Missing the required parameter 'hyperlink_index' when calling get_document_hyperlink_by_index" if hyperlink_index.nil?
      
      # resource path
      path = "/words/{name}/hyperlinks/{hyperlinkIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'hyperlinkIndex' + '}', hyperlink_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'HyperlinkResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_hyperlink_by_index. Result: #{result.inspect}"
      end
      return result
    end

    # Insert document page numbers.
    # 
    # @param name A document name.
    # @param page_number {PageNumber} with the page numbers settings.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_insert_page_numbers(name, page_number, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_insert_page_numbers ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_insert_page_numbers" if name.nil?
      
      # verify the required parameter 'page_number' is set
      fail "Missing the required parameter 'page_number' when calling post_insert_page_numbers" if page_number.nil?
      
      # resource path
      path = "/words/{name}/insertPageNumbers".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(page_number)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_insert_page_numbers. Result: #{result.inspect}"
      end
      return result
    end

    # Insert document watermark image.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [Float] :rotation_angle The watermark rotation angle.
    # @option opts [String] :image The image file server full name. If the name is empty the image is expected in request content.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_insert_watermark_image(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_insert_watermark_image ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_insert_watermark_image" if name.nil?
      
      # resource path
      path = "/words/{name}/insertWatermarkImage".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'image'] = opts[:'image'] if opts[:'image']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_insert_watermark_image. Result: #{result.inspect}"
      end
      return result
    end

    # Insert document watermark text.
    # 
    # @param name The document name.
    # @param watermark_text {WatermarkText} with the watermark data.If the parameter is provided the query string parameters are ignored.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :text The text to insert.
    # @option opts [Float] :rotation_angle The text rotation angle.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_insert_watermark_text(name, watermark_text, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_insert_watermark_text ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_insert_watermark_text" if name.nil?
      
      # verify the required parameter 'watermark_text' is set
      fail "Missing the required parameter 'watermark_text' when calling post_insert_watermark_text" if watermark_text.nil?
      
      # resource path
      path = "/words/{name}/insertWatermarkText".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'text'] = opts[:'text'] if opts[:'text']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(watermark_text)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_insert_watermark_text. Result: #{result.inspect}"
      end
      return result
    end

    # Remove macros from document.
    # 
    # @param name The file name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_document_macros(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_document_macros ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_document_macros" if name.nil?
      
      # resource path
      path = "/words/{name}/macros".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_document_macros. Result: #{result.inspect}"
      end
      return result
    end

    # Read document field names.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [BOOLEAN] :use_non_merge_fields 
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [FieldNamesResponse]
    def get_document_field_names(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_field_names ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_field_names" if name.nil?
      
      # resource path
      path = "/words/{name}/mailMergeFieldNames".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'useNonMergeFields'] = opts[:'use_non_merge_fields'] if opts[:'use_non_merge_fields']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FieldNamesResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_field_names. Result: #{result.inspect}"
      end
      return result
    end

    # Return a list of paragraphs that are contained in the document.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ParagraphLinkCollectionResponse]
    def get_document_paragraphs(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_paragraphs ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_paragraphs" if name.nil?
      
      # resource path
      path = "/words/{name}/paragraphs".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ParagraphLinkCollectionResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_paragraphs. Result: #{result.inspect}"
      end
      return result
    end

    # This resource represents one of the paragraphs contained in the document.
    # 
    # @param name The document name.
    # @param index Paragraph index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ParagraphResponse]
    def get_document_paragraph(name, index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_paragraph ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_paragraph" if name.nil?
      
      # verify the required parameter 'index' is set
      fail "Missing the required parameter 'index' when calling get_document_paragraph" if index.nil?
      
      # resource path
      path = "/words/{name}/paragraphs/{index}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'index' + '}', index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ParagraphResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_paragraph. Result: #{result.inspect}"
      end
      return result
    end

    # Remove fields from paragraph.
    # 
    # @param name The file name.
    # @param index Paragraph index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_paragraph_fields(name, index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_paragraph_fields ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_paragraph_fields" if name.nil?
      
      # verify the required parameter 'index' is set
      fail "Missing the required parameter 'index' when calling delete_paragraph_fields" if index.nil?
      
      # resource path
      path = "/words/{name}/paragraphs/{index}/fields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'index' + '}', index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_paragraph_fields. Result: #{result.inspect}"
      end
      return result
    end

    # This resource represents one of the paragraphs contained in the document.
    # 
    # @param name The document name.
    # @param index Paragraph index
    # @param run_index Run index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [RunResponse]
    def get_document_paragraph_run(name, index, run_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_paragraph_run ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_paragraph_run" if name.nil?
      
      # verify the required parameter 'index' is set
      fail "Missing the required parameter 'index' when calling get_document_paragraph_run" if index.nil?
      
      # verify the required parameter 'run_index' is set
      fail "Missing the required parameter 'run_index' when calling get_document_paragraph_run" if run_index.nil?
      
      # resource path
      path = "/words/{name}/paragraphs/{index}/runs/{runIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'index' + '}', index.to_s).sub('{' + 'runIndex' + '}', run_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'RunResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_paragraph_run. Result: #{result.inspect}"
      end
      return result
    end

    # This resource represents one of the paragraphs contained in the document.
    # 
    # @param name The document name.
    # @param index Paragraph index
    # @param run_index Run index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [FontResponse]
    def get_document_paragraph_run_font(name, index, run_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_paragraph_run_font ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_paragraph_run_font" if name.nil?
      
      # verify the required parameter 'index' is set
      fail "Missing the required parameter 'index' when calling get_document_paragraph_run_font" if index.nil?
      
      # verify the required parameter 'run_index' is set
      fail "Missing the required parameter 'run_index' when calling get_document_paragraph_run_font" if run_index.nil?
      
      # resource path
      path = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'index' + '}', index.to_s).sub('{' + 'runIndex' + '}', run_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FontResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_paragraph_run_font. Result: #{result.inspect}"
      end
      return result
    end

    # This resource represents one of the paragraphs contained in the document.
    # 
    # @param name The document name.
    # @param index Paragraph index
    # @param run_index Run index
    # @param font Font object
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @return [FontResponse]
    def post_document_paragraph_run_font(name, index, run_index, font, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_document_paragraph_run_font ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_document_paragraph_run_font" if name.nil?
      
      # verify the required parameter 'index' is set
      fail "Missing the required parameter 'index' when calling post_document_paragraph_run_font" if index.nil?
      
      # verify the required parameter 'run_index' is set
      fail "Missing the required parameter 'run_index' when calling post_document_paragraph_run_font" if run_index.nil?
      
      # verify the required parameter 'font' is set
      fail "Missing the required parameter 'font' when calling post_document_paragraph_run_font" if font.nil?
      
      # resource path
      path = "/words/{name}/paragraphs/{index}/runs/{runIndex}/font".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'index' + '}', index.to_s).sub('{' + 'runIndex' + '}', run_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(font)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FontResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_document_paragraph_run_font. Result: #{result.inspect}"
      end
      return result
    end

    # Read document protection common info.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ProtectionDataResponse]
    def get_document_protection(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_protection ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_protection" if name.nil?
      
      # resource path
      path = "/words/{name}/protection".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ProtectionDataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_protection. Result: #{result.inspect}"
      end
      return result
    end

    # Protect document.
    # 
    # @param name The document name.
    # @param protection_request {ProtectionRequest} with protection settings.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ProtectionDataResponse]
    def put_protect_document(name, protection_request, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_protect_document ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_protect_document" if name.nil?
      
      # verify the required parameter 'protection_request' is set
      fail "Missing the required parameter 'protection_request' when calling put_protect_document" if protection_request.nil?
      
      # resource path
      path = "/words/{name}/protection".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(protection_request)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ProtectionDataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_protect_document. Result: #{result.inspect}"
      end
      return result
    end

    # Change document protection.
    # 
    # @param name The document name.
    # @param protection_request {ProtectionRequest} with protection settings.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ProtectionDataResponse]
    def post_change_document_protection(name, protection_request, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_change_document_protection ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_change_document_protection" if name.nil?
      
      # verify the required parameter 'protection_request' is set
      fail "Missing the required parameter 'protection_request' when calling post_change_document_protection" if protection_request.nil?
      
      # resource path
      path = "/words/{name}/protection".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(protection_request)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ProtectionDataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_change_document_protection. Result: #{result.inspect}"
      end
      return result
    end

    # Unprotect document.
    # 
    # @param name The document name.
    # @param protection_request {ProtectionRequest} with protection settings.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ProtectionDataResponse]
    def delete_unprotect_document(name, protection_request, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_unprotect_document ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_unprotect_document" if name.nil?
      
      # verify the required parameter 'protection_request' is set
      fail "Missing the required parameter 'protection_request' when calling delete_unprotect_document" if protection_request.nil?
      
      # resource path
      path = "/words/{name}/protection".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(protection_request)
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ProtectionDataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_unprotect_document. Result: #{result.inspect}"
      end
      return result
    end

    # Replace document text.
    # 
    # @param name The document name.
    # @param replace_text {ReplaceTextResponse} with the replace operation settings.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [ReplaceTextResponse]
    def post_replace_text(name, replace_text, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_replace_text ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_replace_text" if name.nil?
      
      # verify the required parameter 'replace_text' is set
      fail "Missing the required parameter 'replace_text' when calling post_replace_text" if replace_text.nil?
      
      # resource path
      path = "/words/{name}/replaceText".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(replace_text)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'ReplaceTextResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_replace_text. Result: #{result.inspect}"
      end
      return result
    end

    # Accept all revisions in document
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [RevisionsModificationResponse]
    def accept_all_revisions(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#accept_all_revisions ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling accept_all_revisions" if name.nil?
      
      # resource path
      path = "/words/{name}/revisions/acceptAll".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'RevisionsModificationResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#accept_all_revisions. Result: #{result.inspect}"
      end
      return result
    end

    # Reject all revisions in document
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [RevisionsModificationResponse]
    def reject_all_revisions(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#reject_all_revisions ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling reject_all_revisions" if name.nil?
      
      # resource path
      path = "/words/{name}/revisions/rejectAll".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'RevisionsModificationResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#reject_all_revisions. Result: #{result.inspect}"
      end
      return result
    end

    # 
    # 
    # @param name 
    # @param pattern 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [SearchResponse]
    def get_words_search(name, pattern, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_words_search ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_words_search" if name.nil?
      
      # verify the required parameter 'pattern' is set
      fail "Missing the required parameter 'pattern' when calling get_words_search" if pattern.nil?
      
      # resource path
      path = "/words/{name}/search".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'pattern'] = pattern
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SearchResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_words_search. Result: #{result.inspect}"
      end
      return result
    end

    # Return a list of sections that are contained in the document.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [SectionLinkCollectionResponse]
    def get_sections(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_sections ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_sections" if name.nil?
      
      # resource path
      path = "/words/{name}/sections".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SectionLinkCollectionResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_sections. Result: #{result.inspect}"
      end
      return result
    end

    # Get document section by index.
    # 
    # @param name The document name.
    # @param section_index Section index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [SectionResponse]
    def get_section(name, section_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_section ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_section" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling get_section" if section_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SectionResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_section. Result: #{result.inspect}"
      end
      return result
    end

    # Remove fields from section.
    # 
    # @param name The file name.
    # @param section_index Section index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_section_fields(name, section_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_section_fields ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_section_fields" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling delete_section_fields" if section_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/fields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_section_fields. Result: #{result.inspect}"
      end
      return result
    end

    # Get page setup of section.
    # 
    # @param name The document name.
    # @param section_index Section index
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [SectionPageSetupResponse]
    def get_section_page_setup(name, section_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_section_page_setup ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_section_page_setup" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling get_section_page_setup" if section_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/pageSetup".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SectionPageSetupResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_section_page_setup. Result: #{result.inspect}"
      end
      return result
    end

    # Update page setup of section.
    # 
    # @param name The document name.
    # @param section_index Section index
    # @param page_setup Page setup properties
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
    # @return [SectionPageSetupResponse]
    def update_section_page_setup(name, section_index, page_setup, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#update_section_page_setup ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling update_section_page_setup" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling update_section_page_setup" if section_index.nil?
      
      # verify the required parameter 'page_setup' is set
      fail "Missing the required parameter 'page_setup' when calling update_section_page_setup" if page_setup.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/pageSetup".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(page_setup)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SectionPageSetupResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#update_section_page_setup. Result: #{result.inspect}"
      end
      return result
    end

    # 
    # 
    # @param name 
    # @param section_index 
    # @param paragraph_index 
    # @param field 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :insert_before_node 
    # @option opts [String] :dest_file_name 
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [FieldResponse]
    def put_field(name, section_index, paragraph_index, field, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling put_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling put_field" if paragraph_index.nil?
      
      # verify the required parameter 'field' is set
      fail "Missing the required parameter 'field' when calling put_field" if field.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'insertBeforeNode'] = opts[:'insert_before_node'] if opts[:'insert_before_node']
      query_params[:'destFileName'] = opts[:'dest_file_name'] if opts[:'dest_file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(field)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_field. Result: #{result.inspect}"
      end
      return result
    end

    # 
    # 
    # @param name 
    # @param section_index 
    # @param paragraph_index 
    # @param field_index 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [FieldResponse]
    def get_field(name, section_index, paragraph_index, field_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling get_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling get_field" if paragraph_index.nil?
      
      # verify the required parameter 'field_index' is set
      fail "Missing the required parameter 'field_index' when calling get_field" if field_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s).sub('{' + 'fieldIndex' + '}', field_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_field. Result: #{result.inspect}"
      end
      return result
    end

    # 
    # 
    # @param name 
    # @param section_index 
    # @param paragraph_index 
    # @param field_index 
    # @param field 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :dest_file_name 
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [FieldResponse]
    def post_field(name, section_index, paragraph_index, field_index, field, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling post_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling post_field" if paragraph_index.nil?
      
      # verify the required parameter 'field_index' is set
      fail "Missing the required parameter 'field_index' when calling post_field" if field_index.nil?
      
      # verify the required parameter 'field' is set
      fail "Missing the required parameter 'field' when calling post_field" if field.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/{fieldIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s).sub('{' + 'fieldIndex' + '}', field_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'destFileName'] = opts[:'dest_file_name'] if opts[:'dest_file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(field)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_field. Result: #{result.inspect}"
      end
      return result
    end

    # Adds form field to paragraph, returns added form field&#39;s data.
    # 
    # @param name The document name.
    # @param section_index Section index.
    # @param paragraph_index Paragraph index.
    # @param form_field From field data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :insert_before_node Form field will be inserted before node with index.
    # @option opts [String] :dest_file_name Destination file name.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [FormFieldResponse]
    def put_form_field(name, section_index, paragraph_index, form_field, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#put_form_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_form_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling put_form_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling put_form_field" if paragraph_index.nil?
      
      # verify the required parameter 'form_field' is set
      fail "Missing the required parameter 'form_field' when calling put_form_field" if form_field.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'insertBeforeNode'] = opts[:'insert_before_node'] if opts[:'insert_before_node']
      query_params[:'destFileName'] = opts[:'dest_file_name'] if opts[:'dest_file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(form_field)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FormFieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#put_form_field. Result: #{result.inspect}"
      end
      return result
    end

    # Returns representation of an one of the form field.
    # 
    # @param name The document name.
    # @param section_index Section index.
    # @param paragraph_index Paragraph index.
    # @param formfield_index Form field index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [FormFieldResponse]
    def get_form_field(name, section_index, paragraph_index, formfield_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_form_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_form_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling get_form_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling get_form_field" if paragraph_index.nil?
      
      # verify the required parameter 'formfield_index' is set
      fail "Missing the required parameter 'formfield_index' when calling get_form_field" if formfield_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s).sub('{' + 'formfieldIndex' + '}', formfield_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FormFieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_form_field. Result: #{result.inspect}"
      end
      return result
    end

    # Updates form field&#39;s properties, returns updated form field&#39;s data.
    # 
    # @param name The document name.
    # @param section_index Section index.
    # @param paragraph_index Paragraph index.
    # @param formfield_index Form field index.
    # @param form_field From field data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :dest_file_name Destination file name.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [FormFieldResponse]
    def post_form_field(name, section_index, paragraph_index, formfield_index, form_field, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_form_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_form_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling post_form_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling post_form_field" if paragraph_index.nil?
      
      # verify the required parameter 'formfield_index' is set
      fail "Missing the required parameter 'formfield_index' when calling post_form_field" if formfield_index.nil?
      
      # verify the required parameter 'form_field' is set
      fail "Missing the required parameter 'form_field' when calling post_form_field" if form_field.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s).sub('{' + 'formfieldIndex' + '}', formfield_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'destFileName'] = opts[:'dest_file_name'] if opts[:'dest_file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(form_field)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'FormFieldResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_form_field. Result: #{result.inspect}"
      end
      return result
    end

    # Removes form field from document.
    # 
    # @param name The document name.
    # @param section_index Section index.
    # @param paragraph_index Paragraph index.
    # @param formfield_index Form field index.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :dest_file_name Destination file name.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [BaseResponse]
    def delete_form_field(name, section_index, paragraph_index, formfield_index, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_form_field ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_form_field" if name.nil?
      
      # verify the required parameter 'section_index' is set
      fail "Missing the required parameter 'section_index' when calling delete_form_field" if section_index.nil?
      
      # verify the required parameter 'paragraph_index' is set
      fail "Missing the required parameter 'paragraph_index' when calling delete_form_field" if paragraph_index.nil?
      
      # verify the required parameter 'formfield_index' is set
      fail "Missing the required parameter 'formfield_index' when calling delete_form_field" if formfield_index.nil?
      
      # resource path
      path = "/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'sectionIndex' + '}', section_index.to_s).sub('{' + 'paragraphIndex' + '}', paragraph_index.to_s).sub('{' + 'formfieldIndex' + '}', formfield_index.to_s)

      # query parameters
      query_params = {}
      query_params[:'destFileName'] = opts[:'dest_file_name'] if opts[:'dest_file_name']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'BaseResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_form_field. Result: #{result.inspect}"
      end
      return result
    end

    # Split document.
    # 
    # @param name Original document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :format Format to split.
    # @option opts [Integer] :from Start page.
    # @option opts [Integer] :to End page.
    # @option opts [BOOLEAN] :zip_output ZipOutput or not.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [SplitDocumentResponse]
    def post_split_document(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_split_document ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_split_document" if name.nil?
      
      # resource path
      path = "/words/{name}/split".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'format'] = opts[:'format'] if opts[:'format']
      query_params[:'from'] = opts[:'from'] if opts[:'from']
      query_params[:'to'] = opts[:'to'] if opts[:'to']
      query_params[:'zipOutput'] = opts[:'zip_output'] if opts[:'zip_output']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'SplitDocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_split_document. Result: #{result.inspect}"
      end
      return result
    end

    # Read document statistics.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [BOOLEAN] :include_comments Support including/excluding comments from the WordCount. Default value is \&quot;true\&quot;.
    # @option opts [BOOLEAN] :include_footnotes Support including/excluding footnotes from the WordCount. Default value is \&quot;false\&quot;.
    # @option opts [BOOLEAN] :include_text_in_shapes Support including/excluding shape&#39;s text from the WordCount. Default value is \&quot;false\&quot;
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [StatDataResponse]
    def get_document_statistics(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_statistics ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_statistics" if name.nil?
      
      # resource path
      path = "/words/{name}/statistics".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'includeComments'] = opts[:'include_comments'] if opts[:'include_comments']
      query_params[:'includeFootnotes'] = opts[:'include_footnotes'] if opts[:'include_footnotes']
      query_params[:'includeTextInShapes'] = opts[:'include_text_in_shapes'] if opts[:'include_text_in_shapes']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'StatDataResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_statistics. Result: #{result.inspect}"
      end
      return result
    end

    # Read document text items.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage Document&#39;s storage.
    # @option opts [String] :folder Document&#39;s folder.
    # @return [TextItemsResponse]
    def get_document_text_items(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#get_document_text_items ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_text_items" if name.nil?
      
      # resource path
      path = "/words/{name}/textItems".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'TextItemsResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#get_document_text_items. Result: #{result.inspect}"
      end
      return result
    end

    # Update (reevaluate) fields in document.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_update_document_fields(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_update_document_fields ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_update_document_fields" if name.nil?
      
      # resource path
      path = "/words/{name}/updateFields".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_update_document_fields. Result: #{result.inspect}"
      end
      return result
    end

    # Delete watermark (for deleting last watermark from the document).
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def delete_document_watermark(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#delete_document_watermark ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling delete_document_watermark" if name.nil?
      
      # resource path
      path = "/words/{name}/watermark".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:DELETE, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#delete_document_watermark. Result: #{result.inspect}"
      end
      return result
    end

    # Insert document watermark image.
    # 
    # @param name The document name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [Float] :rotation_angle The watermark rotation angle.
    # @option opts [String] :image The image file server full name. If the name is empty the image is expected in request content.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_insert_document_watermark_image(name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_insert_document_watermark_image ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_insert_document_watermark_image" if name.nil?
      
      # resource path
      path = "/words/{name}/watermark/insertImage".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'image'] = opts[:'image'] if opts[:'image']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_insert_document_watermark_image. Result: #{result.inspect}"
      end
      return result
    end

    # Insert document watermark text.
    # 
    # @param name The document name.
    # @param watermark_text {WatermarkText} with the watermark data.If the parameter is provided the query string parameters are ignored.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filename Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document
    # @option opts [String] :text The text to insert.
    # @option opts [Float] :rotation_angle The text rotation angle.
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The document folder.
    # @return [DocumentResponse]
    def post_insert_document_watermark_text(name, watermark_text, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: WordsApi#post_insert_document_watermark_text ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_insert_document_watermark_text" if name.nil?
      
      # verify the required parameter 'watermark_text' is set
      fail "Missing the required parameter 'watermark_text' when calling post_insert_document_watermark_text" if watermark_text.nil?
      
      # resource path
      path = "/words/{name}/watermark/insertText".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'filename'] = opts[:'filename'] if opts[:'filename']
      query_params[:'text'] = opts[:'text'] if opts[:'text']
      query_params[:'rotationAngle'] = opts[:'rotation_angle'] if opts[:'rotation_angle']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(watermark_text)
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'DocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: WordsApi#post_insert_document_watermark_text. Result: #{result.inspect}"
      end
      return result
    end
  end
end




