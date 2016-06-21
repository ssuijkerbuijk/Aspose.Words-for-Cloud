module AsposeWordsCloud
  # 
  class PageSetup < BaseObject
    attr_accessor :bidi, :border_always_in_front, :border_applies_to, :border_distance_from, :bottom_margin, :different_first_page_header_footer, :first_page_tray, :footer_distance, :gutter, :header_distance, :left_margin, :line_number_count_by, :line_number_distance_from_text, :line_number_restart_mode, :line_starting_number, :orientation, :other_pages_tray, :page_height, :page_number_style, :page_starting_number, :page_width, :paper_size, :restart_page_numbering, :right_margin, :rtl_gutter, :section_start, :suppress_endnotes, :top_margin, :vertical_alignment, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'bidi' => :'Bidi',
        
        # 
        :'border_always_in_front' => :'BorderAlwaysInFront',
        
        # 
        :'border_applies_to' => :'BorderAppliesTo',
        
        # 
        :'border_distance_from' => :'BorderDistanceFrom',
        
        # 
        :'bottom_margin' => :'BottomMargin',
        
        # 
        :'different_first_page_header_footer' => :'DifferentFirstPageHeaderFooter',
        
        # 
        :'first_page_tray' => :'FirstPageTray',
        
        # 
        :'footer_distance' => :'FooterDistance',
        
        # 
        :'gutter' => :'Gutter',
        
        # 
        :'header_distance' => :'HeaderDistance',
        
        # 
        :'left_margin' => :'LeftMargin',
        
        # 
        :'line_number_count_by' => :'LineNumberCountBy',
        
        # 
        :'line_number_distance_from_text' => :'LineNumberDistanceFromText',
        
        # 
        :'line_number_restart_mode' => :'LineNumberRestartMode',
        
        # 
        :'line_starting_number' => :'LineStartingNumber',
        
        # 
        :'orientation' => :'Orientation',
        
        # 
        :'other_pages_tray' => :'OtherPagesTray',
        
        # 
        :'page_height' => :'PageHeight',
        
        # 
        :'page_number_style' => :'PageNumberStyle',
        
        # 
        :'page_starting_number' => :'PageStartingNumber',
        
        # 
        :'page_width' => :'PageWidth',
        
        # 
        :'paper_size' => :'PaperSize',
        
        # 
        :'restart_page_numbering' => :'RestartPageNumbering',
        
        # 
        :'right_margin' => :'RightMargin',
        
        # 
        :'rtl_gutter' => :'RtlGutter',
        
        # 
        :'section_start' => :'SectionStart',
        
        # 
        :'suppress_endnotes' => :'SuppressEndnotes',
        
        # 
        :'top_margin' => :'TopMargin',
        
        # 
        :'vertical_alignment' => :'VerticalAlignment',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'bidi' => :'BOOLEAN',
        :'border_always_in_front' => :'BOOLEAN',
        :'border_applies_to' => :'String',
        :'border_distance_from' => :'String',
        :'bottom_margin' => :'Float',
        :'different_first_page_header_footer' => :'BOOLEAN',
        :'first_page_tray' => :'Integer',
        :'footer_distance' => :'Float',
        :'gutter' => :'Float',
        :'header_distance' => :'Float',
        :'left_margin' => :'Float',
        :'line_number_count_by' => :'Integer',
        :'line_number_distance_from_text' => :'Float',
        :'line_number_restart_mode' => :'String',
        :'line_starting_number' => :'Integer',
        :'orientation' => :'String',
        :'other_pages_tray' => :'Integer',
        :'page_height' => :'Float',
        :'page_number_style' => :'String',
        :'page_starting_number' => :'Integer',
        :'page_width' => :'Float',
        :'paper_size' => :'String',
        :'restart_page_numbering' => :'BOOLEAN',
        :'right_margin' => :'Float',
        :'rtl_gutter' => :'BOOLEAN',
        :'section_start' => :'String',
        :'suppress_endnotes' => :'BOOLEAN',
        :'top_margin' => :'Float',
        :'vertical_alignment' => :'String',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Bidi']
        self.bidi = attributes[:'Bidi']
      end
      
      if attributes[:'BorderAlwaysInFront']
        self.border_always_in_front = attributes[:'BorderAlwaysInFront']
      end
      
      if attributes[:'BorderAppliesTo']
        self.border_applies_to = attributes[:'BorderAppliesTo']
      end
      
      if attributes[:'BorderDistanceFrom']
        self.border_distance_from = attributes[:'BorderDistanceFrom']
      end
      
      if attributes[:'BottomMargin']
        self.bottom_margin = attributes[:'BottomMargin']
      end
      
      if attributes[:'DifferentFirstPageHeaderFooter']
        self.different_first_page_header_footer = attributes[:'DifferentFirstPageHeaderFooter']
      end
      
      if attributes[:'FirstPageTray']
        self.first_page_tray = attributes[:'FirstPageTray']
      end
      
      if attributes[:'FooterDistance']
        self.footer_distance = attributes[:'FooterDistance']
      end
      
      if attributes[:'Gutter']
        self.gutter = attributes[:'Gutter']
      end
      
      if attributes[:'HeaderDistance']
        self.header_distance = attributes[:'HeaderDistance']
      end
      
      if attributes[:'LeftMargin']
        self.left_margin = attributes[:'LeftMargin']
      end
      
      if attributes[:'LineNumberCountBy']
        self.line_number_count_by = attributes[:'LineNumberCountBy']
      end
      
      if attributes[:'LineNumberDistanceFromText']
        self.line_number_distance_from_text = attributes[:'LineNumberDistanceFromText']
      end
      
      if attributes[:'LineNumberRestartMode']
        self.line_number_restart_mode = attributes[:'LineNumberRestartMode']
      end
      
      if attributes[:'LineStartingNumber']
        self.line_starting_number = attributes[:'LineStartingNumber']
      end
      
      if attributes[:'Orientation']
        self.orientation = attributes[:'Orientation']
      end
      
      if attributes[:'OtherPagesTray']
        self.other_pages_tray = attributes[:'OtherPagesTray']
      end
      
      if attributes[:'PageHeight']
        self.page_height = attributes[:'PageHeight']
      end
      
      if attributes[:'PageNumberStyle']
        self.page_number_style = attributes[:'PageNumberStyle']
      end
      
      if attributes[:'PageStartingNumber']
        self.page_starting_number = attributes[:'PageStartingNumber']
      end
      
      if attributes[:'PageWidth']
        self.page_width = attributes[:'PageWidth']
      end
      
      if attributes[:'PaperSize']
        self.paper_size = attributes[:'PaperSize']
      end
      
      if attributes[:'RestartPageNumbering']
        self.restart_page_numbering = attributes[:'RestartPageNumbering']
      end
      
      if attributes[:'RightMargin']
        self.right_margin = attributes[:'RightMargin']
      end
      
      if attributes[:'RtlGutter']
        self.rtl_gutter = attributes[:'RtlGutter']
      end
      
      if attributes[:'SectionStart']
        self.section_start = attributes[:'SectionStart']
      end
      
      if attributes[:'SuppressEndnotes']
        self.suppress_endnotes = attributes[:'SuppressEndnotes']
      end
      
      if attributes[:'TopMargin']
        self.top_margin = attributes[:'TopMargin']
      end
      
      if attributes[:'VerticalAlignment']
        self.vertical_alignment = attributes[:'VerticalAlignment']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

    def border_applies_to=(border_applies_to)
      allowed_values = ["AllPages", "FirstPage", "OtherPages"]
      if border_applies_to && !allowed_values.include?(border_applies_to)
        fail "invalid value for 'border_applies_to', must be one of #{allowed_values}"
      end
      @border_applies_to = border_applies_to
    end

    def border_distance_from=(border_distance_from)
      allowed_values = ["Text", "PageEdge"]
      if border_distance_from && !allowed_values.include?(border_distance_from)
        fail "invalid value for 'border_distance_from', must be one of #{allowed_values}"
      end
      @border_distance_from = border_distance_from
    end

    def line_number_restart_mode=(line_number_restart_mode)
      allowed_values = ["RestartPage", "RestartSection", "Continuous"]
      if line_number_restart_mode && !allowed_values.include?(line_number_restart_mode)
        fail "invalid value for 'line_number_restart_mode', must be one of #{allowed_values}"
      end
      @line_number_restart_mode = line_number_restart_mode
    end

    def orientation=(orientation)
      allowed_values = ["Portrait", "Landscape"]
      if orientation && !allowed_values.include?(orientation)
        fail "invalid value for 'orientation', must be one of #{allowed_values}"
      end
      @orientation = orientation
    end

    def page_number_style=(page_number_style)
      allowed_values = ["Arabic", "UppercaseRoman", "LowercaseRoman", "UppercaseLetter", "LowercaseLetter", "Ordinal", "Number", "OrdinalText", "Hex", "ChicagoManual", "Kanji", "KanjiDigit", "AiueoHalfWidth", "IrohaHalfWidth", "ArabicFullWidth", "ArabicHalfWidth", "KanjiTraditional", "KanjiTraditional2", "NumberInCircle", "DecimalFullWidth", "Aiueo", "Iroha", "LeadingZero", "Bullet", "Ganada", "Chosung", "GB1", "GB2", "GB3", "GB4", "Zodiac1", "Zodiac2", "Zodiac3", "TradChinNum1", "TradChinNum2", "TradChinNum3", "TradChinNum4", "SimpChinNum1", "SimpChinNum2", "SimpChinNum3", "SimpChinNum4", "HanjaRead", "HanjaReadDigit", "Hangul", "Hanja", "Hebrew1", "Arabic1", "Hebrew2", "Arabic2", "HindiLetter1", "HindiLetter2", "HindiArabic", "HindiCardinalText", "ThaiLetter", "ThaiArabic", "ThaiCardinalText", "VietCardinalText", "NumberInDash", "NumInDash", "LowercaseRussian", "UppercaseRussian", "None"]
      if page_number_style && !allowed_values.include?(page_number_style)
        fail "invalid value for 'page_number_style', must be one of #{allowed_values}"
      end
      @page_number_style = page_number_style
    end

    def paper_size=(paper_size)
      allowed_values = ["A3", "A4", "A5", "B4", "B5", "Executive", "Folio", "Ledger", "Legal", "Letter", "EnvelopeDL", "Quarto", "Statement", "Tabloid", "Paper10x14", "Paper11x17", "Custom"]
      if paper_size && !allowed_values.include?(paper_size)
        fail "invalid value for 'paper_size', must be one of #{allowed_values}"
      end
      @paper_size = paper_size
    end

    def section_start=(section_start)
      allowed_values = ["Continuous", "NewColumn", "NewPage", "EvenPage", "OddPage"]
      if section_start && !allowed_values.include?(section_start)
        fail "invalid value for 'section_start', must be one of #{allowed_values}"
      end
      @section_start = section_start
    end

    def vertical_alignment=(vertical_alignment)
      allowed_values = ["Top", "Center", "Justify", "Bottom"]
      if vertical_alignment && !allowed_values.include?(vertical_alignment)
        fail "invalid value for 'vertical_alignment', must be one of #{allowed_values}"
      end
      @vertical_alignment = vertical_alignment
    end

  end
end
