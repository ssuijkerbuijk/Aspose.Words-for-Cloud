module AsposeWordsCloud
  # 
  class DocumentEntry < BaseObject
    attr_accessor :href, :import_format_mode
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'href' => :'Href',
        
        # 
        :'import_format_mode' => :'ImportFormatMode'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'href' => :'String',
        :'import_format_mode' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Href']
        self.href = attributes[:'Href']
      end
      
      if attributes[:'ImportFormatMode']
        self.import_format_mode = attributes[:'ImportFormatMode']
      end
      
    end

  end
end
