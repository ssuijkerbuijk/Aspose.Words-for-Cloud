module AsposeWordsCloud
  # 
  class ParagraphLinkCollection < BaseObject
    attr_accessor :paragraph_link_list, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'paragraph_link_list' => :'ParagraphLinkList',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'paragraph_link_list' => :'Array<ParagraphLink>',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'ParagraphLinkList']
        if (value = attributes[:'ParagraphLinkList']).is_a?(Array)
          self.paragraph_link_list = value
        end
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
