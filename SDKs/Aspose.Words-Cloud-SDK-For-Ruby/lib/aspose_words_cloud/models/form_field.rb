module AsposeWordsCloud
  # 
  class FormField < BaseObject
    attr_accessor :node_id, :name, :enabled, :status_text, :own_status, :help_text, :own_help, :calculate_on_exit, :entry_macro, :exit_macro, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'node_id' => :'NodeId',
        
        # 
        :'name' => :'Name',
        
        # 
        :'enabled' => :'Enabled',
        
        # 
        :'status_text' => :'StatusText',
        
        # 
        :'own_status' => :'OwnStatus',
        
        # 
        :'help_text' => :'HelpText',
        
        # 
        :'own_help' => :'OwnHelp',
        
        # 
        :'calculate_on_exit' => :'CalculateOnExit',
        
        # 
        :'entry_macro' => :'EntryMacro',
        
        # 
        :'exit_macro' => :'ExitMacro',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'node_id' => :'String',
        :'name' => :'String',
        :'enabled' => :'BOOLEAN',
        :'status_text' => :'String',
        :'own_status' => :'BOOLEAN',
        :'help_text' => :'String',
        :'own_help' => :'BOOLEAN',
        :'calculate_on_exit' => :'BOOLEAN',
        :'entry_macro' => :'String',
        :'exit_macro' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'NodeId']
        self.node_id = attributes[:'NodeId']
      end
      
      if attributes[:'Name']
        self.name = attributes[:'Name']
      end
      
      if attributes[:'Enabled']
        self.enabled = attributes[:'Enabled']
      end
      
      if attributes[:'StatusText']
        self.status_text = attributes[:'StatusText']
      end
      
      if attributes[:'OwnStatus']
        self.own_status = attributes[:'OwnStatus']
      end
      
      if attributes[:'HelpText']
        self.help_text = attributes[:'HelpText']
      end
      
      if attributes[:'OwnHelp']
        self.own_help = attributes[:'OwnHelp']
      end
      
      if attributes[:'CalculateOnExit']
        self.calculate_on_exit = attributes[:'CalculateOnExit']
      end
      
      if attributes[:'EntryMacro']
        self.entry_macro = attributes[:'EntryMacro']
      end
      
      if attributes[:'ExitMacro']
        self.exit_macro = attributes[:'ExitMacro']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
