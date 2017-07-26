module AsposeWordsCloud
  # 
  class TableResponse < BaseObject
    attr_accessor :table, :code, :status
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'table' => :'Table',
        
        # 
        :'code' => :'Code',
        
        # 
        :'status' => :'Status'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'table' => :'Table',
        :'code' => :'String',
        :'status' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Table']
        self.table = attributes[:'Table']
      end
      
      if attributes[:'Code']
        self.code = attributes[:'Code']
      end
      
      if attributes[:'Status']
        self.status = attributes[:'Status']
      end
      
    end

  end
end
