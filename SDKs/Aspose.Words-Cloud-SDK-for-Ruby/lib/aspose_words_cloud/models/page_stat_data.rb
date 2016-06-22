module AsposeWordsCloud
  # 
  class PageStatData < BaseObject
    attr_accessor :page_number, :word_count, :paragraph_count
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'page_number' => :'PageNumber',
        
        # 
        :'word_count' => :'WordCount',
        
        # 
        :'paragraph_count' => :'ParagraphCount'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'page_number' => :'Integer',
        :'word_count' => :'Integer',
        :'paragraph_count' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'PageNumber']
        self.page_number = attributes[:'PageNumber']
      end
      
      if attributes[:'WordCount']
        self.word_count = attributes[:'WordCount']
      end
      
      if attributes[:'ParagraphCount']
        self.paragraph_count = attributes[:'ParagraphCount']
      end
      
    end

  end
end
