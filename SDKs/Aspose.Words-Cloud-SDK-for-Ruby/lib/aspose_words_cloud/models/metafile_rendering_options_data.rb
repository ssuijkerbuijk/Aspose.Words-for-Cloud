module AsposeWordsCloud
  # 
  class MetafileRenderingOptionsData < BaseObject
    attr_accessor :emf_plus_dual_rendering_mode, :rendering_mode, :use_emf_embedded_to_wmf
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'emf_plus_dual_rendering_mode' => :'EmfPlusDualRenderingMode',
        
        # 
        :'rendering_mode' => :'RenderingMode',
        
        # 
        :'use_emf_embedded_to_wmf' => :'UseEmfEmbeddedToWmf'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'emf_plus_dual_rendering_mode' => :'String',
        :'rendering_mode' => :'String',
        :'use_emf_embedded_to_wmf' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'EmfPlusDualRenderingMode']
        self.emf_plus_dual_rendering_mode = attributes[:'EmfPlusDualRenderingMode']
      end
      
      if attributes[:'RenderingMode']
        self.rendering_mode = attributes[:'RenderingMode']
      end
      
      if attributes[:'UseEmfEmbeddedToWmf']
        self.use_emf_embedded_to_wmf = attributes[:'UseEmfEmbeddedToWmf']
      end
      
    end

  end
end
