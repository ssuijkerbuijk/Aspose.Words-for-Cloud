module AsposeWordsCloud
  # 
  class Bookmarks < BaseObject
    attr_accessor :bookmark_list, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'bookmark_list' => :'BookmarkList',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'bookmark_list' => :'Array<Bookmark>',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'BookmarkList']
        if (value = attributes[:'BookmarkList']).is_a?(Array)
          self.bookmark_list = value
        end
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
