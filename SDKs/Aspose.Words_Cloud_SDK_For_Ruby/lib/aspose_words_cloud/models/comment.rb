module AsposeWordsCloud
  # 
  class Comment < BaseObject
    attr_accessor :range_start, :range_end, :author, :initial, :date_time, :text, :content, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'range_start' => :'RangeStart',
        
        # 
        :'range_end' => :'RangeEnd',
        
        # 
        :'author' => :'Author',
        
        # 
        :'initial' => :'Initial',
        
        # 
        :'date_time' => :'DateTime',
        
        # 
        :'text' => :'Text',
        
        # 
        :'content' => :'Content',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'range_start' => :'DocumentPosition',
        :'range_end' => :'DocumentPosition',
        :'author' => :'String',
        :'initial' => :'String',
        :'date_time' => :'String',
        :'text' => :'String',
        :'content' => :'StoryChildNodes',
        :'link' => :'Link'
        
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
      
      if attributes[:'Author']
        self.author = attributes[:'Author']
      end
      
      if attributes[:'Initial']
        self.initial = attributes[:'Initial']
      end
      
      if attributes[:'DateTime']
        self.date_time = attributes[:'DateTime']
      end
      
      if attributes[:'Text']
        self.text = attributes[:'Text']
      end
      
      if attributes[:'Content']
        self.content = attributes[:'Content']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
