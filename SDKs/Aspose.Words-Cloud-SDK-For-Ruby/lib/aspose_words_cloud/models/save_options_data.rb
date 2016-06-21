module AsposeWordsCloud
  # 
  class SaveOptionsData < BaseObject
    attr_accessor :save_format, :file_name, :dml_rendering_mode, :dml_effects_rendering_mode, :zip_output
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'save_format' => :'SaveFormat',
        
        # 
        :'file_name' => :'FileName',
        
        # 
        :'dml_rendering_mode' => :'DmlRenderingMode',
        
        # 
        :'dml_effects_rendering_mode' => :'DmlEffectsRenderingMode',
        
        # 
        :'zip_output' => :'ZipOutput'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'save_format' => :'String',
        :'file_name' => :'String',
        :'dml_rendering_mode' => :'String',
        :'dml_effects_rendering_mode' => :'String',
        :'zip_output' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'SaveFormat']
        self.save_format = attributes[:'SaveFormat']
      end
      
      if attributes[:'FileName']
        self.file_name = attributes[:'FileName']
      end
      
      if attributes[:'DmlRenderingMode']
        self.dml_rendering_mode = attributes[:'DmlRenderingMode']
      end
      
      if attributes[:'DmlEffectsRenderingMode']
        self.dml_effects_rendering_mode = attributes[:'DmlEffectsRenderingMode']
      end
      
      if attributes[:'ZipOutput']
        self.zip_output = attributes[:'ZipOutput']
      end
      
    end

  end
end
