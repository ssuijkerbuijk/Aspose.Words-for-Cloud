module AsposeWordsCloud
  # 
  class Table < BaseObject
    attr_accessor :table_row_list, :table_properties, :node_id, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'table_row_list' => :'TableRowList',
        
        # 
        :'table_properties' => :'TableProperties',
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'table_row_list' => :'Array<TableRow>',
        :'table_properties' => :'TableProperties',
        :'node_id' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'TableRowList']
        if (value = attributes[:'TableRowList']).is_a?(Array)
          self.table_row_list = value
        end
      end
      
      if attributes[:'TableProperties']
        self.table_properties = attributes[:'TableProperties']
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
