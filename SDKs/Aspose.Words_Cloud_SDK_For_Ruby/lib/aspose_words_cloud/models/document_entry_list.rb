module AsposeWordsCloud
  # 
  class DocumentEntryList < BaseObject
    attr_accessor :document_entries
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'document_entries' => :'DocumentEntries'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'document_entries' => :'Array<DocumentEntry>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'DocumentEntries']
        if (value = attributes[:'DocumentEntries']).is_a?(Array)
          self.document_entries = value
        end
      end
      
    end

  end
end
