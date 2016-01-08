module AsposeWordsCloud
  # 
  class Hyperlinks < BaseObject
    attr_accessor :hyperlink_list, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'hyperlink_list' => :'HyperlinkList',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'hyperlink_list' => :'Array<Hyperlink>',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'HyperlinkList']
        if (value = attributes[:'HyperlinkList']).is_a?(Array)
          self.hyperlink_list = value
        end
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
