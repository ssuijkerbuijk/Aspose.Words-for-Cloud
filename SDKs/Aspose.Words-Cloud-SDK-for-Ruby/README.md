# Aspose.Words Cloud SDK For Ruby
This SDK lets you use [Aspose Cloud Word APIs](http://www.aspose.com/cloud/word-api.aspx) in your web apps.

<p align="center">
  <a title="Download complete Aspose.Words for Cloud source code" href="https://github.com/asposewords/Aspose_Words_Cloud/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

##How to Use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project or use RubyGems. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/wordscloud/Available+SDKs).

## Usage
APIs of this SDK can be called as follows:

```ruby
require 'aspose_words_cloud'

class WordsUsage
  
  include AsposeWordsCloud
  include AsposeStorageCloud
	
  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
    @words_api = WordsApi.new  
  end
  
  def load_web_document_into_the_file
    #Load new document from web into the file with any supported format of data.
    load_web_document_data = LoadWebDocumentData.new
    load_web_document_data.loading_document_url = "http://google.com"

    save_options = SaveOptionsData.new
    save_options.save_format = "doc"
    save_options.file_name = "google.doc"

    load_web_document_data.save_options = save_options
    response = @words_api.post_load_web_document(load_web_document_data)
  end
  
end
```
## Unit Tests
Aspose Words SDK includes a suite of unit tests within the [test](https://github.com/asposewords/Aspose_Words_Cloud/blob/master/SDKs/Aspose.Words_Cloud_SDK_For_Ruby/test/words_tests.rb) subdirectory. These Unit Tests also serves as examples of how to use the Aspose Cells SDK.

##Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://www.aspose.com/community/forums/).



