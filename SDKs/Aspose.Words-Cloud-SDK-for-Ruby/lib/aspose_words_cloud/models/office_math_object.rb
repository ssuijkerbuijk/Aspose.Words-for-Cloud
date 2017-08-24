module AsposeWordsCloud
  # 
  class OfficeMathObject < BaseObject
    attr_accessor :content, :display_type, :justification, :math_object_type, :node_id, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'content' => :'Content',
        
        # 
        :'display_type' => :'DisplayType',
        
        # 
        :'justification' => :'Justification',
        
        # 
        :'math_object_type' => :'MathObjectType',
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'content' => :'StoryChildNodes',
        :'display_type' => :'String',
        :'justification' => :'String',
        :'math_object_type' => :'String',
        :'node_id' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Content']
        self.content = attributes[:'Content']
      end
      
      if attributes[:'DisplayType']
        self.display_type = attributes[:'DisplayType']
      end
      
      if attributes[:'Justification']
        self.justification = attributes[:'Justification']
      end
      
      if attributes[:'MathObjectType']
        self.math_object_type = attributes[:'MathObjectType']
      end
      
      if attributes[:'NodeId']
        self.node_id = attributes[:'NodeId']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
