module AsposeWordsCloud
  # 
  class TableProperties < BaseObject
    attr_accessor :alignment, :allow_auto_fit, :bidi, :bottom_padding, :cell_spacing, :left_indent, :left_padding, :preferred_width, :right_padding, :style_identifier, :style_name, :style_options, :text_wrapping, :top_padding, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'alignment' => :'Alignment',
        
        # 
        :'allow_auto_fit' => :'AllowAutoFit',
        
        # 
        :'bidi' => :'Bidi',
        
        # 
        :'bottom_padding' => :'BottomPadding',
        
        # 
        :'cell_spacing' => :'CellSpacing',
        
        # 
        :'left_indent' => :'LeftIndent',
        
        # 
        :'left_padding' => :'LeftPadding',
        
        # 
        :'preferred_width' => :'PreferredWidth',
        
        # 
        :'right_padding' => :'RightPadding',
        
        # 
        :'style_identifier' => :'StyleIdentifier',
        
        # 
        :'style_name' => :'StyleName',
        
        # 
        :'style_options' => :'StyleOptions',
        
        # 
        :'text_wrapping' => :'TextWrapping',
        
        # 
        :'top_padding' => :'TopPadding',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'alignment' => :'String',
        :'allow_auto_fit' => :'BOOLEAN',
        :'bidi' => :'BOOLEAN',
        :'bottom_padding' => :'Float',
        :'cell_spacing' => :'Float',
        :'left_indent' => :'Float',
        :'left_padding' => :'Float',
        :'preferred_width' => :'PreferredWidth',
        :'right_padding' => :'Float',
        :'style_identifier' => :'String',
        :'style_name' => :'String',
        :'style_options' => :'String',
        :'text_wrapping' => :'String',
        :'top_padding' => :'Float',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Alignment']
        self.alignment = attributes[:'Alignment']
      end
      
      if attributes[:'AllowAutoFit']
        self.allow_auto_fit = attributes[:'AllowAutoFit']
      end
      
      if attributes[:'Bidi']
        self.bidi = attributes[:'Bidi']
      end
      
      if attributes[:'BottomPadding']
        self.bottom_padding = attributes[:'BottomPadding']
      end
      
      if attributes[:'CellSpacing']
        self.cell_spacing = attributes[:'CellSpacing']
      end
      
      if attributes[:'LeftIndent']
        self.left_indent = attributes[:'LeftIndent']
      end
      
      if attributes[:'LeftPadding']
        self.left_padding = attributes[:'LeftPadding']
      end
      
      if attributes[:'PreferredWidth']
        self.preferred_width = attributes[:'PreferredWidth']
      end
      
      if attributes[:'RightPadding']
        self.right_padding = attributes[:'RightPadding']
      end
      
      if attributes[:'StyleIdentifier']
        self.style_identifier = attributes[:'StyleIdentifier']
      end
      
      if attributes[:'StyleName']
        self.style_name = attributes[:'StyleName']
      end
      
      if attributes[:'StyleOptions']
        self.style_options = attributes[:'StyleOptions']
      end
      
      if attributes[:'TextWrapping']
        self.text_wrapping = attributes[:'TextWrapping']
      end
      
      if attributes[:'TopPadding']
        self.top_padding = attributes[:'TopPadding']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
