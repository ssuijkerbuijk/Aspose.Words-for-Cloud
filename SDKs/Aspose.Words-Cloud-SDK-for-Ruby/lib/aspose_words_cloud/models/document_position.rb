module AsposeWordsCloud
  # 
  class DocumentPosition < BaseObject
    attr_accessor :node, :offset
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'node' => :'Node',
        
        # 
        :'offset' => :'Offset'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'node' => :'NodeLink',
        :'offset' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Node']
        self.node = attributes[:'Node']
      end
      
      if attributes[:'Offset']
        self.offset = attributes[:'Offset']
      end
      
    end

  end
end
