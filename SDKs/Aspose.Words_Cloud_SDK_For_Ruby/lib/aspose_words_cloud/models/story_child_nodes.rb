module AsposeWordsCloud
  # 
  class StoryChildNodes < BaseObject
    attr_accessor :child_nodes
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'child_nodes' => :'ChildNodes'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'child_nodes' => :'Array<BaseResponse>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'ChildNodes']
        if (value = attributes[:'ChildNodes']).is_a?(Array)
          self.child_nodes = value
        end
      end
      
    end

  end
end
