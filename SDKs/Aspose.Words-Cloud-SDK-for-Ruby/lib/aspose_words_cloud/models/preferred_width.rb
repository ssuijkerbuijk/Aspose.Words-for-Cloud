module AsposeWordsCloud
  # 
  class PreferredWidth < BaseObject
    attr_accessor :type, :value
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'type' => :'Type',
        
        # 
        :'value' => :'Value'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type' => :'String',
        :'value' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Type']
        self.type = attributes[:'Type']
      end
      
      if attributes[:'Value']
        self.value = attributes[:'Value']
      end
      
    end

  end
end
