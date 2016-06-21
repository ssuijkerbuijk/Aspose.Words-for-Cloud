module AsposeWordsCloud
  # 
  class Document < BaseObject
    attr_accessor :links, :file_name, :source_format, :is_encrypted, :is_signed, :document_properties
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'links' => :'Links',
        
        # 
        :'file_name' => :'FileName',
        
        # 
        :'source_format' => :'SourceFormat',
        
        # 
        :'is_encrypted' => :'IsEncrypted',
        
        # 
        :'is_signed' => :'IsSigned',
        
        # 
        :'document_properties' => :'DocumentProperties'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'links' => :'Array<Link>',
        :'file_name' => :'String',
        :'source_format' => :'String',
        :'is_encrypted' => :'BOOLEAN',
        :'is_signed' => :'BOOLEAN',
        :'document_properties' => :'DocumentProperties'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Links']
        if (value = attributes[:'Links']).is_a?(Array)
          self.links = value
        end
      end
      
      if attributes[:'FileName']
        self.file_name = attributes[:'FileName']
      end
      
      if attributes[:'SourceFormat']
        self.source_format = attributes[:'SourceFormat']
      end
      
      if attributes[:'IsEncrypted']
        self.is_encrypted = attributes[:'IsEncrypted']
      end
      
      if attributes[:'IsSigned']
        self.is_signed = attributes[:'IsSigned']
      end
      
      if attributes[:'DocumentProperties']
        self.document_properties = attributes[:'DocumentProperties']
      end
      
    end

    def source_format=(source_format)
      allowed_values = ["Unknown", "Doc", "Dot", "DocPreWord97", "Docx", "Docm", "Dotx", "Dotm", "FlatOpc", "Rtf", "WordML", "Html", "Mhtml", "Epub", "Text", "Odt", "Ott", "Pdf", "Xps", "Swf", "Tiff", "Svg"]
      if source_format && source_format.to_i >= allowed_values.size
        fail "invalid value for 'source_format', must be one of #{allowed_values}"
      end
      @source_format = allowed_values[source_format.to_i]
    end

  end
end
