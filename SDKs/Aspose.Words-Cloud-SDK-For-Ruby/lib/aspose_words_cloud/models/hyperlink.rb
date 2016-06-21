module AsposeWordsCloud
  # 
  class Hyperlink < BaseObject
    attr_accessor :display_text, :value, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'display_text' => :'DisplayText',
        
        # 
        :'value' => :'Value',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'display_text' => :'String',
        :'value' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'DisplayText']
        self.display_text = attributes[:'DisplayText']
      end
      
      if attributes[:'Value']
        self.value = attributes[:'Value']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
