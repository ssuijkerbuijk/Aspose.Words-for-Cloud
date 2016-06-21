# -*- encoding: utf-8 -*-
$:.push File.expand_path("../lib", __FILE__)
require "aspose_words_cloud/version"

Gem::Specification.new do |s|
  s.name        = "aspose_words_cloud"
  s.version     = AsposeWordsCloud::VERSION
  s.platform    = Gem::Platform::RUBY
  s.authors     = ["M. Sohail Ismail"]
  s.email       = ["muhammad.sohail@aspose.com"]
  s.homepage    = "http://www.aspose.com/cloud/word-api.aspx"
  s.summary     = %q{Aspose.Words for Cloud}
  s.description = %q{Aspose.Words for Cloud, a cloud-based document creation, manipulation and conversion API, helps you process documents with its many flexible features. Create a new document from scratch, modify an existing document, convert documents to different formats, and render the document to images. Aspose.Words for Cloud allows you to convert documents to DOC, DOCX, XPS, TIFF, PDF, HTML, SWF, and many other formats.}
  s.license     = "MIT"

  s.add_runtime_dependency 'typhoeus', '~> 0.8'
  s.add_runtime_dependency 'json', '~> 1.7'
  s.add_runtime_dependency 'aspose_storage_cloud', '~> 1.0', '>= 1.0.0'

  s.add_development_dependency 'minitest', '~> 5.8'

  s.files         = `git ls-files`.split("\n")
  s.test_files    = `git ls-files -- test/*`.split("\n")
  s.executables   = []
  s.require_paths = ["lib"]
end