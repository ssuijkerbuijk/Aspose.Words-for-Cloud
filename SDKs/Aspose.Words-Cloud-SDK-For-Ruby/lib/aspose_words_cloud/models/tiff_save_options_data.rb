module AsposeWordsCloud
  # 
  class TiffSaveOptionsData < BaseObject
    attr_accessor :tiff_binarization_method, :tiff_compression, :page_count, :pixel_format, :paper_color, :resolution, :scale, :image_brightness, :image_color_mode, :image_contrast, :use_high_quality_rendering, :use_anti_aliasing, :page_index, :metafile_rendering_options, :numeral_format, :save_format, :file_name, :dml_rendering_mode, :dml_effects_rendering_mode, :zip_output
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'tiff_binarization_method' => :'TiffBinarizationMethod',
        
        # 
        :'tiff_compression' => :'TiffCompression',
        
        # 
        :'page_count' => :'PageCount',
        
        # 
        :'pixel_format' => :'PixelFormat',
        
        # 
        :'paper_color' => :'PaperColor',
        
        # 
        :'resolution' => :'Resolution',
        
        # 
        :'scale' => :'Scale',
        
        # 
        :'image_brightness' => :'ImageBrightness',
        
        # 
        :'image_color_mode' => :'ImageColorMode',
        
        # 
        :'image_contrast' => :'ImageContrast',
        
        # 
        :'use_high_quality_rendering' => :'UseHighQualityRendering',
        
        # 
        :'use_anti_aliasing' => :'UseAntiAliasing',
        
        # 
        :'page_index' => :'PageIndex',
        
        # 
        :'metafile_rendering_options' => :'MetafileRenderingOptions',
        
        # 
        :'numeral_format' => :'NumeralFormat',
        
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
        :'tiff_binarization_method' => :'String',
        :'tiff_compression' => :'String',
        :'page_count' => :'Integer',
        :'pixel_format' => :'String',
        :'paper_color' => :'Color',
        :'resolution' => :'Float',
        :'scale' => :'Float',
        :'image_brightness' => :'Float',
        :'image_color_mode' => :'String',
        :'image_contrast' => :'Float',
        :'use_high_quality_rendering' => :'BOOLEAN',
        :'use_anti_aliasing' => :'BOOLEAN',
        :'page_index' => :'Integer',
        :'metafile_rendering_options' => :'MetafileRenderingOptionsData',
        :'numeral_format' => :'String',
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

      
      if attributes[:'TiffBinarizationMethod']
        self.tiff_binarization_method = attributes[:'TiffBinarizationMethod']
      end
      
      if attributes[:'TiffCompression']
        self.tiff_compression = attributes[:'TiffCompression']
      end
      
      if attributes[:'PageCount']
        self.page_count = attributes[:'PageCount']
      end
      
      if attributes[:'PixelFormat']
        self.pixel_format = attributes[:'PixelFormat']
      end
      
      if attributes[:'PaperColor']
        self.paper_color = attributes[:'PaperColor']
      end
      
      if attributes[:'Resolution']
        self.resolution = attributes[:'Resolution']
      end
      
      if attributes[:'Scale']
        self.scale = attributes[:'Scale']
      end
      
      if attributes[:'ImageBrightness']
        self.image_brightness = attributes[:'ImageBrightness']
      end
      
      if attributes[:'ImageColorMode']
        self.image_color_mode = attributes[:'ImageColorMode']
      end
      
      if attributes[:'ImageContrast']
        self.image_contrast = attributes[:'ImageContrast']
      end
      
      if attributes[:'UseHighQualityRendering']
        self.use_high_quality_rendering = attributes[:'UseHighQualityRendering']
      end
      
      if attributes[:'UseAntiAliasing']
        self.use_anti_aliasing = attributes[:'UseAntiAliasing']
      end
      
      if attributes[:'PageIndex']
        self.page_index = attributes[:'PageIndex']
      end
      
      if attributes[:'MetafileRenderingOptions']
        self.metafile_rendering_options = attributes[:'MetafileRenderingOptions']
      end
      
      if attributes[:'NumeralFormat']
        self.numeral_format = attributes[:'NumeralFormat']
      end
      
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
