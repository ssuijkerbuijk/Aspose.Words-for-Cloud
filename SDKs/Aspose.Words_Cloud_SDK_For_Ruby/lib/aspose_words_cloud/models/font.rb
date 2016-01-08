module AsposeWordsCloud
  # 
  class Font < BaseObject
    attr_accessor :all_caps, :bidi, :bold, :bold_bi, :border, :color, :complex_script, :double_strike_through, :emboss, :engrave, :hidden, :highlight_color, :italic, :italic_bi, :kerning, :locale_id, :locale_id_bi, :locale_id_far_east, :name, :name_ascii, :name_bi, :name_far_east, :name_other, :no_proofing, :outline, :position, :scaling, :shadow, :size, :size_bi, :small_caps, :spacing, :strike_through, :style_identifier, :style_name, :subscript, :superscript, :text_effect, :underline, :underline_color, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'all_caps' => :'AllCaps',
        
        # 
        :'bidi' => :'Bidi',
        
        # 
        :'bold' => :'Bold',
        
        # 
        :'bold_bi' => :'BoldBi',
        
        # 
        :'border' => :'Border',
        
        # 
        :'color' => :'Color',
        
        # 
        :'complex_script' => :'ComplexScript',
        
        # 
        :'double_strike_through' => :'DoubleStrikeThrough',
        
        # 
        :'emboss' => :'Emboss',
        
        # 
        :'engrave' => :'Engrave',
        
        # 
        :'hidden' => :'Hidden',
        
        # 
        :'highlight_color' => :'HighlightColor',
        
        # 
        :'italic' => :'Italic',
        
        # 
        :'italic_bi' => :'ItalicBi',
        
        # 
        :'kerning' => :'Kerning',
        
        # 
        :'locale_id' => :'LocaleId',
        
        # 
        :'locale_id_bi' => :'LocaleIdBi',
        
        # 
        :'locale_id_far_east' => :'LocaleIdFarEast',
        
        # 
        :'name' => :'Name',
        
        # 
        :'name_ascii' => :'NameAscii',
        
        # 
        :'name_bi' => :'NameBi',
        
        # 
        :'name_far_east' => :'NameFarEast',
        
        # 
        :'name_other' => :'NameOther',
        
        # 
        :'no_proofing' => :'NoProofing',
        
        # 
        :'outline' => :'Outline',
        
        # 
        :'position' => :'Position',
        
        # 
        :'scaling' => :'Scaling',
        
        # 
        :'shadow' => :'Shadow',
        
        # 
        :'size' => :'Size',
        
        # 
        :'size_bi' => :'SizeBi',
        
        # 
        :'small_caps' => :'SmallCaps',
        
        # 
        :'spacing' => :'Spacing',
        
        # 
        :'strike_through' => :'StrikeThrough',
        
        # 
        :'style_identifier' => :'StyleIdentifier',
        
        # 
        :'style_name' => :'StyleName',
        
        # 
        :'subscript' => :'Subscript',
        
        # 
        :'superscript' => :'Superscript',
        
        # 
        :'text_effect' => :'TextEffect',
        
        # 
        :'underline' => :'Underline',
        
        # 
        :'underline_color' => :'UnderlineColor',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'all_caps' => :'BOOLEAN',
        :'bidi' => :'BOOLEAN',
        :'bold' => :'BOOLEAN',
        :'bold_bi' => :'BOOLEAN',
        :'border' => :'Border',
        :'color' => :'Color',
        :'complex_script' => :'BOOLEAN',
        :'double_strike_through' => :'BOOLEAN',
        :'emboss' => :'BOOLEAN',
        :'engrave' => :'BOOLEAN',
        :'hidden' => :'BOOLEAN',
        :'highlight_color' => :'Color',
        :'italic' => :'BOOLEAN',
        :'italic_bi' => :'BOOLEAN',
        :'kerning' => :'Float',
        :'locale_id' => :'Integer',
        :'locale_id_bi' => :'Integer',
        :'locale_id_far_east' => :'Integer',
        :'name' => :'String',
        :'name_ascii' => :'String',
        :'name_bi' => :'String',
        :'name_far_east' => :'String',
        :'name_other' => :'String',
        :'no_proofing' => :'BOOLEAN',
        :'outline' => :'BOOLEAN',
        :'position' => :'Float',
        :'scaling' => :'Integer',
        :'shadow' => :'BOOLEAN',
        :'size' => :'Float',
        :'size_bi' => :'Float',
        :'small_caps' => :'BOOLEAN',
        :'spacing' => :'Float',
        :'strike_through' => :'BOOLEAN',
        :'style_identifier' => :'String',
        :'style_name' => :'String',
        :'subscript' => :'BOOLEAN',
        :'superscript' => :'BOOLEAN',
        :'text_effect' => :'String',
        :'underline' => :'String',
        :'underline_color' => :'Color',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'AllCaps']
        self.all_caps = attributes[:'AllCaps']
      end
      
      if attributes[:'Bidi']
        self.bidi = attributes[:'Bidi']
      end
      
      if attributes[:'Bold']
        self.bold = attributes[:'Bold']
      end
      
      if attributes[:'BoldBi']
        self.bold_bi = attributes[:'BoldBi']
      end
      
      if attributes[:'Border']
        self.border = attributes[:'Border']
      end
      
      if attributes[:'Color']
        self.color = attributes[:'Color']
      end
      
      if attributes[:'ComplexScript']
        self.complex_script = attributes[:'ComplexScript']
      end
      
      if attributes[:'DoubleStrikeThrough']
        self.double_strike_through = attributes[:'DoubleStrikeThrough']
      end
      
      if attributes[:'Emboss']
        self.emboss = attributes[:'Emboss']
      end
      
      if attributes[:'Engrave']
        self.engrave = attributes[:'Engrave']
      end
      
      if attributes[:'Hidden']
        self.hidden = attributes[:'Hidden']
      end
      
      if attributes[:'HighlightColor']
        self.highlight_color = attributes[:'HighlightColor']
      end
      
      if attributes[:'Italic']
        self.italic = attributes[:'Italic']
      end
      
      if attributes[:'ItalicBi']
        self.italic_bi = attributes[:'ItalicBi']
      end
      
      if attributes[:'Kerning']
        self.kerning = attributes[:'Kerning']
      end
      
      if attributes[:'LocaleId']
        self.locale_id = attributes[:'LocaleId']
      end
      
      if attributes[:'LocaleIdBi']
        self.locale_id_bi = attributes[:'LocaleIdBi']
      end
      
      if attributes[:'LocaleIdFarEast']
        self.locale_id_far_east = attributes[:'LocaleIdFarEast']
      end
      
      if attributes[:'Name']
        self.name = attributes[:'Name']
      end
      
      if attributes[:'NameAscii']
        self.name_ascii = attributes[:'NameAscii']
      end
      
      if attributes[:'NameBi']
        self.name_bi = attributes[:'NameBi']
      end
      
      if attributes[:'NameFarEast']
        self.name_far_east = attributes[:'NameFarEast']
      end
      
      if attributes[:'NameOther']
        self.name_other = attributes[:'NameOther']
      end
      
      if attributes[:'NoProofing']
        self.no_proofing = attributes[:'NoProofing']
      end
      
      if attributes[:'Outline']
        self.outline = attributes[:'Outline']
      end
      
      if attributes[:'Position']
        self.position = attributes[:'Position']
      end
      
      if attributes[:'Scaling']
        self.scaling = attributes[:'Scaling']
      end
      
      if attributes[:'Shadow']
        self.shadow = attributes[:'Shadow']
      end
      
      if attributes[:'Size']
        self.size = attributes[:'Size']
      end
      
      if attributes[:'SizeBi']
        self.size_bi = attributes[:'SizeBi']
      end
      
      if attributes[:'SmallCaps']
        self.small_caps = attributes[:'SmallCaps']
      end
      
      if attributes[:'Spacing']
        self.spacing = attributes[:'Spacing']
      end
      
      if attributes[:'StrikeThrough']
        self.strike_through = attributes[:'StrikeThrough']
      end
      
      if attributes[:'StyleIdentifier']
        self.style_identifier = attributes[:'StyleIdentifier']
      end
      
      if attributes[:'StyleName']
        self.style_name = attributes[:'StyleName']
      end
      
      if attributes[:'Subscript']
        self.subscript = attributes[:'Subscript']
      end
      
      if attributes[:'Superscript']
        self.superscript = attributes[:'Superscript']
      end
      
      if attributes[:'TextEffect']
        self.text_effect = attributes[:'TextEffect']
      end
      
      if attributes[:'Underline']
        self.underline = attributes[:'Underline']
      end
      
      if attributes[:'UnderlineColor']
        self.underline_color = attributes[:'UnderlineColor']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

    def style_identifier=(style_identifier)
      allowed_values = ["Normal", "Heading1", "Heading2", "Heading3", "Heading4", "Heading5", "Heading6", "Heading7", "Heading8", "Heading9", "Index1", "Index2", "Index3", "Index4", "Index5", "Index6", "Index7", "Index8", "Index9", "Toc1", "Toc2", "Toc3", "Toc4", "Toc5", "Toc6", "Toc7", "Toc8", "Toc9", "NormalIndent", "FootnoteText", "CommentText", "Header", "Footer", "IndexHeading", "Caption", "TableOfFigures", "EnvelopeAddress", "EnvelopeReturn", "FootnoteReference", "CommentReference", "LineNumber", "PageNumber", "EndnoteReference", "EndnoteText", "TableOfAuthorities", "Macro", "ToaHeading", "List", "ListBullet", "ListNumber", "List2", "List3", "List4", "List5", "ListBullet2", "ListBullet3", "ListBullet4", "ListBullet5", "ListNumber2", "ListNumber3", "ListNumber4", "ListNumber5", "Title", "Closing", "Signature", "DefaultParagraphFont", "BodyText", "BodyTextInd", "ListContinue", "ListContinue2", "ListContinue3", "ListContinue4", "ListContinue5", "MessageHeader", "Subtitle", "Salutation", "Date", "BodyText1I", "BodyText1I2", "NoteHeading", "BodyText2", "BodyText3", "BodyTextInd2", "BodyTextInd3", "BlockText", "Hyperlink", "FollowedHyperlink", "Strong", "Emphasis", "DocumentMap", "PlainText", "EmailSignature", "HtmlTopOfForm", "HtmlBottomOfForm", "NormalWeb", "HtmlAcronym", "HtmlAddress", "HtmlCite", "HtmlCode", "HtmlDefinition", "HtmlKeyboard", "HtmlPreformatted", "HtmlSample", "HtmlTypewriter", "HtmlVariable", "TableNormal", "CommentSubject", "NoList", "OutlineList1", "OutlineList2", "OutlineList3", "TableSimple1", "TableSimple2", "TableSimple3", "TableClassic1", "TableClassic2", "TableClassic3", "TableClassic4", "TableColorful1", "TableColorful2", "TableColorful3", "TableColumns1", "TableColumns2", "TableColumns3", "TableColumns4", "TableColumns5", "TableGrid1", "TableGrid2", "TableGrid3", "TableGrid4", "TableGrid5", "TableGrid6", "TableGrid7", "TableGrid8", "TableList1", "TableList2", "TableList3", "TableList4", "TableList5", "TableList6", "TableList7", "TableList8", "Table3DEffects1", "Table3DEffects2", "Table3DEffects3", "TableContemporary", "TableElegant", "TableProfessional", "TableSubtle1", "TableSubtle2", "TableWeb1", "TableWeb2", "TableWeb3", "BalloonText", "TableGrid", "TableTheme", "PlaceholderText", "NoSpacing", "LightShading", "LightList", "LightGrid", "MediumShading1", "MediumShading2", "MediumList1", "MediumList2", "MediumGrid1", "MediumGrid2", "MediumGrid3", "DarkList", "ColorfulShading", "ColorfulList", "ColorfulGrid", "LightShadingAccent1", "LightListAccent1", "LightGridAccent1", "MediumShading1Accent1", "MediumShading2Accent1", "MediumList1Accent1", "Revision", "ListParagraph", "Quote", "IntenseQuote", "MediumList2Accent1", "MediumGrid1Accent1", "MediumGrid2Accent1", "MediumGrid3Accent1", "DarkListAccent1", "ColorfulShadingAccent1", "ColorfulListAccent1", "ColorfulGridAccent1", "LightShadingAccent2", "LightListAccent2", "LightGridAccent2", "MediumShading1Accent2", "MediumShading2Accent2", "MediumList1Accent2", "MediumList2Accent2", "MediumGrid1Accent2", "MediumGrid2Accent2", "MediumGrid3Accent2", "DarkListAccent2", "ColorfulShadingAccent2", "ColorfulListAccent2", "ColorfulGridAccent2", "LightShadingAccent3", "LightListAccent3", "LightGridAccent3", "MediumShading1Accent3", "MediumShading2Accent3", "MediumList1Accent3", "MediumList2Accent3", "MediumGrid1Accent3", "MediumGrid2Accent3", "MediumGrid3Accent3", "DarkListAccent3", "ColorfulShadingAccent3", "ColorfulListAccent3", "ColorfulGridAccent3", "LightShadingAccent4", "LightListAccent4", "LightGridAccent4", "MediumShading1Accent4", "MediumShading2Accent4", "MediumList1Accent4", "MediumList2Accent4", "MediumGrid1Accent4", "MediumGrid2Accent4", "MediumGrid3Accent4", "DarkListAccent4", "ColorfulShadingAccent4", "ColorfulListAccent4", "ColorfulGridAccent4", "LightShadingAccent5", "LightListAccent5", "LightGridAccent5", "MediumShading1Accent5", "MediumShading2Accent5", "MediumList1Accent5", "MediumList2Accent5", "MediumGrid1Accent5", "MediumGrid2Accent5", "MediumGrid3Accent5", "DarkListAccent5", "ColorfulShadingAccent5", "ColorfulListAccent5", "ColorfulGridAccent5", "LightShadingAccent6", "LightListAccent6", "LightGridAccent6", "MediumShading1Accent6", "MediumShading2Accent6", "MediumList1Accent6", "MediumList2Accent6", "MediumGrid1Accent6", "MediumGrid2Accent6", "MediumGrid3Accent6", "DarkListAccent6", "ColorfulShadingAccent6", "ColorfulListAccent6", "ColorfulGridAccent6", "SubtleEmphasis", "IntenseEmphasis", "SubtleReference", "IntenseReference", "BookTitle", "Bibliography", "TocHeading", "User", "Nil"]
      if style_identifier && !allowed_values.include?(style_identifier)
        fail "invalid value for 'style_identifier', must be one of #{allowed_values}"
      end
      @style_identifier = style_identifier
    end

    def text_effect=(text_effect)
      allowed_values = ["None", "LasVegasLights", "BlinkingBackground", "SparkleText", "MarchingBlackAnts", "MarchingRedAnts", "Shimmer"]
      if text_effect && !allowed_values.include?(text_effect)
        fail "invalid value for 'text_effect', must be one of #{allowed_values}"
      end
      @text_effect = text_effect
    end

    def underline=(underline)
      allowed_values = ["None", "Single", "Words", "Double", "Dotted", "Thick", "Dash", "DotDash", "DotDotDash", "Wavy", "DottedHeavy", "DashHeavy", "DotDashHeavy", "DotDotDashHeavy", "WavyHeavy", "DashLong", "WavyDouble", "DashLongHeavy"]
      if underline && !allowed_values.include?(underline)
        fail "invalid value for 'underline', must be one of #{allowed_values}"
      end
      @underline = underline
    end

  end
end
