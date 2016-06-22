module AsposeWordsCloud
  # 
  class DrawingObject < BaseObject
    attr_accessor :render_links, :width, :height, :ole_data_link, :image_data_link, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'render_links' => :'RenderLinks',
        
        # 
        :'width' => :'Width',
        
        # 
        :'height' => :'Height',
        
        # 
        :'ole_data_link' => :'OleDataLink',
        
        # 
        :'image_data_link' => :'ImageDataLink',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'render_links' => :'Array<Link>',
        :'width' => :'Integer',
        :'height' => :'Integer',
        :'ole_data_link' => :'Link',
        :'image_data_link' => :'Link',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'RenderLinks']
        if (value = attributes[:'RenderLinks']).is_a?(Array)
          self.render_links = value
        end
      end
      
      if attributes[:'Width']
        self.width = attributes[:'Width']
      end
      
      if attributes[:'Height']
        self.height = attributes[:'Height']
      end
      
      if attributes[:'OleDataLink']
        self.ole_data_link = attributes[:'OleDataLink']
      end
      
      if attributes[:'ImageDataLink']
        self.image_data_link = attributes[:'ImageDataLink']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
