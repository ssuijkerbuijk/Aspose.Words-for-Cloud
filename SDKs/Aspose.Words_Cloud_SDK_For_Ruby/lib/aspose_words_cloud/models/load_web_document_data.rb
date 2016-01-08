module AsposeWordsCloud
  # 
  class LoadWebDocumentData < BaseObject
    attr_accessor :loading_document_url, :save_options
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'loading_document_url' => :'LoadingDocumentUrl',
        
        # 
        :'save_options' => :'SaveOptions'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'loading_document_url' => :'String',
        :'save_options' => :'SaveOptionsData'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'LoadingDocumentUrl']
        self.loading_document_url = attributes[:'LoadingDocumentUrl']
      end
      
      if attributes[:'SaveOptions']
        self.save_options = attributes[:'SaveOptions']
      end
      
    end

  end
end
