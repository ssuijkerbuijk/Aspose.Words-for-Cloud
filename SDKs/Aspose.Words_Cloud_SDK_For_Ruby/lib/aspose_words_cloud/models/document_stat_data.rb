module AsposeWordsCloud
  # 
  class DocumentStatData < BaseObject
    attr_accessor :word_count, :paragraph_count, :page_count, :page_stat_data
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'word_count' => :'WordCount',
        
        # 
        :'paragraph_count' => :'ParagraphCount',
        
        # 
        :'page_count' => :'PageCount',
        
        # 
        :'page_stat_data' => :'PageStatData'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'word_count' => :'Integer',
        :'paragraph_count' => :'Integer',
        :'page_count' => :'Integer',
        :'page_stat_data' => :'Array<PageStatData>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'WordCount']
        self.word_count = attributes[:'WordCount']
      end
      
      if attributes[:'ParagraphCount']
        self.paragraph_count = attributes[:'ParagraphCount']
      end
      
      if attributes[:'PageCount']
        self.page_count = attributes[:'PageCount']
      end
      
      if attributes[:'PageStatData']
        if (value = attributes[:'PageStatData']).is_a?(Array)
          self.page_stat_data = value
        end
      end
      
    end

  end
end
