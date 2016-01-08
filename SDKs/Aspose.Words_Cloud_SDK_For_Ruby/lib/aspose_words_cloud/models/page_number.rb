module AsposeWordsCloud
  # 
  class PageNumber < BaseObject
    attr_accessor :format, :alignment, :is_top, :set_page_number_on_first_page
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'format' => :'Format',
        
        # 
        :'alignment' => :'Alignment',
        
        # 
        :'is_top' => :'IsTop',
        
        # 
        :'set_page_number_on_first_page' => :'SetPageNumberOnFirstPage'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'format' => :'String',
        :'alignment' => :'String',
        :'is_top' => :'BOOLEAN',
        :'set_page_number_on_first_page' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Format']
        self.format = attributes[:'Format']
      end
      
      if attributes[:'Alignment']
        self.alignment = attributes[:'Alignment']
      end
      
      if attributes[:'IsTop']
        self.is_top = attributes[:'IsTop']
      end
      
      if attributes[:'SetPageNumberOnFirstPage']
        self.set_page_number_on_first_page = attributes[:'SetPageNumberOnFirstPage']
      end
      
    end

  end
end
