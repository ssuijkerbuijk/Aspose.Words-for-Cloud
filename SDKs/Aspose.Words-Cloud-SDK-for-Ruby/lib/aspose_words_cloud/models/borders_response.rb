module AsposeWordsCloud
  # 
  class BordersResponse < BaseObject
    attr_accessor :borders, :code, :status
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'borders' => :'Borders',
        
        # 
        :'code' => :'Code',
        
        # 
        :'status' => :'Status'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'borders' => :'BordersCollection',
        :'code' => :'String',
        :'status' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Borders']
        self.borders = attributes[:'Borders']
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
