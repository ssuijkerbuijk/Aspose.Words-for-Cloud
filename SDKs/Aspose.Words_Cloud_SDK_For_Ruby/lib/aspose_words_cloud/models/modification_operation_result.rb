module AsposeWordsCloud
  # 
  class ModificationOperationResult < BaseObject
    attr_accessor :source, :dest
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'source' => :'Source',
        
        # 
        :'dest' => :'Dest'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'source' => :'Link',
        :'dest' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Source']
        self.source = attributes[:'Source']
      end
      
      if attributes[:'Dest']
        self.dest = attributes[:'Dest']
      end
      
    end

  end
end
