module AsposeWordsCloud
  # 
  class WatermarkText < BaseObject
    attr_accessor :text, :rotation_angle
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'text' => :'Text',
        
        # 
        :'rotation_angle' => :'RotationAngle'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'text' => :'String',
        :'rotation_angle' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Text']
        self.text = attributes[:'Text']
      end
      
      if attributes[:'RotationAngle']
        self.rotation_angle = attributes[:'RotationAngle']
      end
      
    end

  end
end
