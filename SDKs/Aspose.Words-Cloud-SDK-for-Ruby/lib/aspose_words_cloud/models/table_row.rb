module AsposeWordsCloud
  # 
  class TableRow < BaseObject
    attr_accessor :table_cell_list, :row_format, :node_id, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'table_cell_list' => :'TableCellList',
        
        # 
        :'row_format' => :'RowFormat',
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'table_cell_list' => :'Array<TableCell>',
        :'row_format' => :'TableRowFormat',
        :'node_id' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'TableCellList']
        if (value = attributes[:'TableCellList']).is_a?(Array)
          self.table_cell_list = value
        end
      end
      
      if attributes[:'RowFormat']
        self.row_format = attributes[:'RowFormat']
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
