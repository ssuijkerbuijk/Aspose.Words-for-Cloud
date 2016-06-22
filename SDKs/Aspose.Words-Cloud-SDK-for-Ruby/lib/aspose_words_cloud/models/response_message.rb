module AsposeWordsCloud
  # 
  class ResponseMessage < BaseObject
    attr_accessor :code, :message
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'code' => :'Code',
        
        # 
        :'message' => :'Message'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'code' => :'Integer',
        :'message' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Code']
        self.code = attributes[:'Code']
      end
      
      if attributes[:'Message']
        self.message = attributes[:'Message']
      end
      
    end

  end
end
