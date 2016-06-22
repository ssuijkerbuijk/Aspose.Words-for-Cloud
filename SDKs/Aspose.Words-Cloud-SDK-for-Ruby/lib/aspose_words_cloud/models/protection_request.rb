module AsposeWordsCloud
  # 
  class ProtectionRequest < BaseObject
    attr_accessor :password, :new_password, :protection_type
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'password' => :'Password',
        
        # 
        :'new_password' => :'NewPassword',
        
        # 
        :'protection_type' => :'ProtectionType'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'password' => :'String',
        :'new_password' => :'String',
        :'protection_type' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Password']
        self.password = attributes[:'Password']
      end
      
      if attributes[:'NewPassword']
        self.new_password = attributes[:'NewPassword']
      end
      
      if attributes[:'ProtectionType']
        self.protection_type = attributes[:'ProtectionType']
      end
      
    end

  end
end
