module AsposeWordsCloud
  # 
  class BookmarkData < BaseObject
    attr_accessor :name, :text
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'Name',
        
        # 
        :'text' => :'Text'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'text' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Name']
        self.name = attributes[:'Name']
      end
      
      if attributes[:'Text']
        self.text = attributes[:'Text']
      end
      
    end

  end
end
