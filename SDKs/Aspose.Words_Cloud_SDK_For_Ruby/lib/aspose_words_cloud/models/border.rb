module AsposeWordsCloud
  # 
  class Border < BaseObject
    attr_accessor :line_style, :line_width, :color, :distance_from_text, :shadow
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'line_style' => :'LineStyle',
        
        # 
        :'line_width' => :'LineWidth',
        
        # 
        :'color' => :'Color',
        
        # 
        :'distance_from_text' => :'DistanceFromText',
        
        # 
        :'shadow' => :'Shadow'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'line_style' => :'String',
        :'line_width' => :'Float',
        :'color' => :'Color',
        :'distance_from_text' => :'Float',
        :'shadow' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'LineStyle']
        self.line_style = attributes[:'LineStyle']
      end
      
      if attributes[:'LineWidth']
        self.line_width = attributes[:'LineWidth']
      end
      
      if attributes[:'Color']
        self.color = attributes[:'Color']
      end
      
      if attributes[:'DistanceFromText']
        self.distance_from_text = attributes[:'DistanceFromText']
      end
      
      if attributes[:'Shadow']
        self.shadow = attributes[:'Shadow']
      end
      
    end

    def line_style=(line_style)
      allowed_values = ["None", "Single", "Thick", "Double", "Hairline", "Dot", "DashLargeGap", "DotDash", "DotDotDash", "Triple", "ThinThickSmallGap", "ThickThinSmallGap", "ThinThickThinSmallGap", "ThinThickMediumGap", "ThickThinMediumGap", "ThinThickThinMediumGap", "ThinThickLargeGap", "ThickThinLargeGap", "ThinThickThinLargeGap", "Wave", "DoubleWave", "DashSmallGap", "DashDotStroker", "Emboss3D", "Engrave3D", "Outset", "Inset"]
      if line_style && !allowed_values.include?(line_style)
        fail "invalid value for 'line_style', must be one of #{allowed_values}"
      end
      @line_style = line_style
    end

  end
end
