Pod::Spec.new do |s|
  s.name         = "AsposeWordsCloud"
  s.version      = "0.0.1"
  s.summary      = "Aspose.Words for Cloud"
  s.description  = <<-DESC
                    Aspose.Words for Cloud, a cloud-based document creation, manipulation and conversion API, helps you process documents with its many flexible features. You can perform a wide variety of document operations with Aspose.Words for Cloud’s REST API. Create a new document from scratch, modify an existing document, convert documents to different formats, and render the document to images. Aspose.Words for Cloud allows you to convert documents to DOC, DOCX, XPS, TIFF, PDF, HTML, SWF, and many other formats. It lets you render a complete document or a single page to different image formats (JPEG, GIF, PNG, TIFF, and so on). Taking a step further, it lets you render drawing shapes in documents to images.
                   DESC

  s.homepage     = "http://www.aspose.com/cloud/word-api.aspx"
  s.license = { :type => 'MIT', :file => 'LICENSE'}
  s.author = { "M. Sohail Ismail" => "muhammad.sohail@aspose.com" }
  s.social_media_url = "https://www.facebook.com/asposeplugins/"
  s.platform = :ios, "7.0"
  s.source       = { :git => "https://github.com/asposewords/Aspose_Words_Cloud.git", :tag => "0.0.1" }
  
  s.subspec 'model' do |ss|
      ss.source_files = 'SDKs/Aspose.Words_Cloud_SDK_for_ObjectiveC/Aspose.Words_Cloud_SDK_for_ObjectiveC/words/model/*.{h,m}'
  end
  s.subspec 'api' do |ss|
      ss.dependency 'AsposeWordsCloud/model'
      ss.source_files = 'SDKs/Aspose.Words_Cloud_SDK_for_ObjectiveC/Aspose.Words_Cloud_SDK_for_ObjectiveC/words/api/*.{h,m}'
  end
  
  s.dependency "AFNetworking", "~> 2.0"
  s.dependency "JSONModel", "~> 1.1"
  s.dependency "ISO8601", "~> 0.3"
  s.dependency "AsposeStorageCloud"

  s.requires_arc = true

end