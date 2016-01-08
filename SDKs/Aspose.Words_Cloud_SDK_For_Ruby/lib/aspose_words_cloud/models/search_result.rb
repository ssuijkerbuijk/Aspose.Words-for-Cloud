module AsposeWordsCloud
  # 
  class SearchResult < BaseObject
    attr_accessor :range_start, :range_end
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'range_start' => :'RangeStart',
        
        # 
        :'range_end' => :'RangeEnd'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'range_start' => :'DocumentPosition',
        :'range_end' => :'DocumentPosition'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'RangeStart']
        self.range_start = attributes[:'RangeStart']
      end
      
      if attributes[:'RangeEnd']
        self.range_end = attributes[:'RangeEnd']
      end
      
    end

  end
end
