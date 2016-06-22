module AsposeWordsCloud
  # 
  class ReplaceTextRequest < BaseObject
    attr_accessor :old_value, :current_value, :is_match_case, :is_match_whole_word
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'old_value' => :'OldValue',
        
        # 
        :'current_value' => :'CurrentValue',
        
        # 
        :'is_match_case' => :'IsMatchCase',
        
        # 
        :'is_match_whole_word' => :'IsMatchWholeWord'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'old_value' => :'String',
        :'current_value' => :'String',
        :'is_match_case' => :'BOOLEAN',
        :'is_match_whole_word' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'OldValue']
        self.old_value = attributes[:'OldValue']
      end
      
      if attributes[:'CurrentValue']
        self.current_value = attributes[:'CurrentValue']
      end
      
      if attributes[:'IsMatchCase']
        self.is_match_case = attributes[:'IsMatchCase']
      end
      
      if attributes[:'IsMatchWholeWord']
        self.is_match_whole_word = attributes[:'IsMatchWholeWord']
      end
      
    end

  end
end
