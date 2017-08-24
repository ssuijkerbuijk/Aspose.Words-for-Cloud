module AsposeWordsCloud
  # 
  class TableRowFormat < BaseObject
    attr_accessor :height, :height_rule, :allow_break_across_pages, :heading_format, :node_id, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'height' => :'Height',
        
        # 
        :'height_rule' => :'HeightRule',
        
        # 
        :'allow_break_across_pages' => :'AllowBreakAcrossPages',
        
        # 
        :'heading_format' => :'HeadingFormat',
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'height' => :'Float',
        :'height_rule' => :'String',
        :'allow_break_across_pages' => :'BOOLEAN',
        :'heading_format' => :'BOOLEAN',
        :'node_id' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Height']
        self.height = attributes[:'Height']
      end
      
      if attributes[:'HeightRule']
        self.height_rule = attributes[:'HeightRule']
      end
      
      if attributes[:'AllowBreakAcrossPages']
        self.allow_break_across_pages = attributes[:'AllowBreakAcrossPages']
      end
      
      if attributes[:'HeadingFormat']
        self.heading_format = attributes[:'HeadingFormat']
      end
      
      if attributes[:'NodeId']
        self.node_id = attributes[:'NodeId']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

    def height_rule=(height_rule)
      allowed_values = ["AtLeast", "Exactly", "Auto"]
      if height_rule && !allowed_values.include?(height_rule)
        fail "invalid value for 'height_rule', must be one of #{allowed_values}"
      end
      @height_rule = height_rule
    end

  end
end
