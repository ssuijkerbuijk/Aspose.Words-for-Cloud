module AsposeWordsCloud
  # 
  class OfficeMathObjectsResponse < BaseObject
    attr_accessor :office_math_objects, :code, :status
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'office_math_objects' => :'OfficeMathObjects',
        
        # 
        :'code' => :'Code',
        
        # 
        :'status' => :'Status'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'office_math_objects' => :'OfficeMathObjectsCollection',
        :'code' => :'String',
        :'status' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'OfficeMathObjects']
        self.office_math_objects = attributes[:'OfficeMathObjects']
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
