module AsposeWordsCloud
  # 
  class SplitDocumentResult < BaseObject
    attr_accessor :source_document, :pages, :zipped_pages
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'source_document' => :'SourceDocument',
        
        # 
        :'pages' => :'Pages',
        
        # 
        :'zipped_pages' => :'ZippedPages'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'source_document' => :'Link',
        :'pages' => :'Array<Link>',
        :'zipped_pages' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'SourceDocument']
        self.source_document = attributes[:'SourceDocument']
      end
      
      if attributes[:'Pages']
        if (value = attributes[:'Pages']).is_a?(Array)
          self.pages = value
        end
      end
      
      if attributes[:'ZippedPages']
        self.zipped_pages = attributes[:'ZippedPages']
      end
      
    end

  end
end
