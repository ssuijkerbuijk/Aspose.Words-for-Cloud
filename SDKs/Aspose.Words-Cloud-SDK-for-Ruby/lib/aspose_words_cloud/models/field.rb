module AsposeWordsCloud
  # 
  class Field < BaseObject
    attr_accessor :result, :field_code, :node_id, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'result' => :'Result',
        
        # 
        :'field_code' => :'FieldCode',
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'result' => :'String',
        :'field_code' => :'String',
        :'node_id' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Result']
        self.result = attributes[:'Result']
      end
      
      if attributes[:'FieldCode']
        self.field_code = attributes[:'FieldCode']
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
