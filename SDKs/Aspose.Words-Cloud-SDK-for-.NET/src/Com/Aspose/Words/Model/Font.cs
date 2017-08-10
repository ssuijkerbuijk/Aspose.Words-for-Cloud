using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace Com.Aspose.Words.Model {

  /// <summary>
  /// 
  /// </summary>  
  public class Font {
    
    /// <summary>
    /// Gets or Sets AllCaps
    /// </summary>    
    public bool? AllCaps { get; set; }

    
    /// <summary>
    /// Gets or Sets Bidi
    /// </summary>    
    public bool? Bidi { get; set; }

    
    /// <summary>
    /// Gets or Sets Bold
    /// </summary>    
    public bool? Bold { get; set; }

    
    /// <summary>
    /// Gets or Sets BoldBi
    /// </summary>    
    public bool? BoldBi { get; set; }

    
    /// <summary>
    /// Gets or Sets Border
    /// </summary>    
    public Border Border { get; set; }

    
    /// <summary>
    /// Gets or Sets Color
    /// </summary>    
    public XmlColor Color { get; set; }

    
    /// <summary>
    /// Gets or Sets ComplexScript
    /// </summary>    
    public bool? ComplexScript { get; set; }

    
    /// <summary>
    /// Gets or Sets DoubleStrikeThrough
    /// </summary>    
    public bool? DoubleStrikeThrough { get; set; }

    
    /// <summary>
    /// Gets or Sets Emboss
    /// </summary>    
    public bool? Emboss { get; set; }

    
    /// <summary>
    /// Gets or Sets Engrave
    /// </summary>    
    public bool? Engrave { get; set; }

    
    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>    
    public bool? Hidden { get; set; }

    
    /// <summary>
    /// Gets or Sets HighlightColor
    /// </summary>    
    public XmlColor HighlightColor { get; set; }

    
    /// <summary>
    /// Gets or Sets Italic
    /// </summary>    
    public bool? Italic { get; set; }

    
    /// <summary>
    /// Gets or Sets ItalicBi
    /// </summary>    
    public bool? ItalicBi { get; set; }

    
    /// <summary>
    /// Gets or Sets Kerning
    /// </summary>    
    public double? Kerning { get; set; }

    
    /// <summary>
    /// Gets or Sets LocaleId
    /// </summary>    
    public int? LocaleId { get; set; }

    
    /// <summary>
    /// Gets or Sets LocaleIdBi
    /// </summary>    
    public int? LocaleIdBi { get; set; }

    
    /// <summary>
    /// Gets or Sets LocaleIdFarEast
    /// </summary>    
    public int? LocaleIdFarEast { get; set; }

    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>    
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets NameAscii
    /// </summary>    
    public string NameAscii { get; set; }

    
    /// <summary>
    /// Gets or Sets NameBi
    /// </summary>    
    public string NameBi { get; set; }

    
    /// <summary>
    /// Gets or Sets NameFarEast
    /// </summary>    
    public string NameFarEast { get; set; }

    
    /// <summary>
    /// Gets or Sets NameOther
    /// </summary>    
    public string NameOther { get; set; }

    
    /// <summary>
    /// Gets or Sets NoProofing
    /// </summary>    
    public bool? NoProofing { get; set; }

    
    /// <summary>
    /// Gets or Sets Outline
    /// </summary>    
    public bool? Outline { get; set; }

    
    /// <summary>
    /// Gets or Sets Position
    /// </summary>    
    public double? Position { get; set; }

    
    /// <summary>
    /// Gets or Sets Scaling
    /// </summary>    
    public int? Scaling { get; set; }

    
    /// <summary>
    /// Gets or Sets Shadow
    /// </summary>    
    public bool? Shadow { get; set; }

    
    /// <summary>
    /// Gets or Sets Size
    /// </summary>    
    public double? Size { get; set; }

    
    /// <summary>
    /// Gets or Sets SizeBi
    /// </summary>    
    public double? SizeBi { get; set; }

    
    /// <summary>
    /// Gets or Sets SmallCaps
    /// </summary>    
    public bool? SmallCaps { get; set; }

    
    /// <summary>
    /// Gets or Sets Spacing
    /// </summary>    
    public double? Spacing { get; set; }

    
    /// <summary>
    /// Gets or Sets StrikeThrough
    /// </summary>    
    public bool? StrikeThrough { get; set; }

    
    /// <summary>
    /// Gets or Sets StyleIdentifier
    /// </summary>    
    public string StyleIdentifier { get; set; }

    
    /// <summary>
    /// Gets or Sets StyleName
    /// </summary>    
    public string StyleName { get; set; }

    
    /// <summary>
    /// Gets or Sets Subscript
    /// </summary>    
    public bool? Subscript { get; set; }

    
    /// <summary>
    /// Gets or Sets Superscript
    /// </summary>    
    public bool? Superscript { get; set; }

    
    /// <summary>
    /// Gets or Sets TextEffect
    /// </summary>    
    public string TextEffect { get; set; }

    
    /// <summary>
    /// Gets or Sets Underline
    /// </summary>    
    public string Underline { get; set; }

    
    /// <summary>
    /// Gets or Sets UnderlineColor
    /// </summary>    
    public XmlColor UnderlineColor { get; set; }

    
    /// <summary>
    /// Gets or Sets Link
    /// </summary>    
    public WordsApiLink Link { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Font {\n");
      
      sb.Append("  AllCaps: ").Append(AllCaps).Append("\n");
      
      sb.Append("  Bidi: ").Append(Bidi).Append("\n");
      
      sb.Append("  Bold: ").Append(Bold).Append("\n");
      
      sb.Append("  BoldBi: ").Append(BoldBi).Append("\n");
      
      sb.Append("  Border: ").Append(Border).Append("\n");
      
      sb.Append("  Color: ").Append(Color).Append("\n");
      
      sb.Append("  ComplexScript: ").Append(ComplexScript).Append("\n");
      
      sb.Append("  DoubleStrikeThrough: ").Append(DoubleStrikeThrough).Append("\n");
      
      sb.Append("  Emboss: ").Append(Emboss).Append("\n");
      
      sb.Append("  Engrave: ").Append(Engrave).Append("\n");
      
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      
      sb.Append("  HighlightColor: ").Append(HighlightColor).Append("\n");
      
      sb.Append("  Italic: ").Append(Italic).Append("\n");
      
      sb.Append("  ItalicBi: ").Append(ItalicBi).Append("\n");
      
      sb.Append("  Kerning: ").Append(Kerning).Append("\n");
      
      sb.Append("  LocaleId: ").Append(LocaleId).Append("\n");
      
      sb.Append("  LocaleIdBi: ").Append(LocaleIdBi).Append("\n");
      
      sb.Append("  LocaleIdFarEast: ").Append(LocaleIdFarEast).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  NameAscii: ").Append(NameAscii).Append("\n");
      
      sb.Append("  NameBi: ").Append(NameBi).Append("\n");
      
      sb.Append("  NameFarEast: ").Append(NameFarEast).Append("\n");
      
      sb.Append("  NameOther: ").Append(NameOther).Append("\n");
      
      sb.Append("  NoProofing: ").Append(NoProofing).Append("\n");
      
      sb.Append("  Outline: ").Append(Outline).Append("\n");
      
      sb.Append("  Position: ").Append(Position).Append("\n");
      
      sb.Append("  Scaling: ").Append(Scaling).Append("\n");
      
      sb.Append("  Shadow: ").Append(Shadow).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
      sb.Append("  SizeBi: ").Append(SizeBi).Append("\n");
      
      sb.Append("  SmallCaps: ").Append(SmallCaps).Append("\n");
      
      sb.Append("  Spacing: ").Append(Spacing).Append("\n");
      
      sb.Append("  StrikeThrough: ").Append(StrikeThrough).Append("\n");
      
      sb.Append("  StyleIdentifier: ").Append(StyleIdentifier).Append("\n");
      
      sb.Append("  StyleName: ").Append(StyleName).Append("\n");
      
      sb.Append("  Subscript: ").Append(Subscript).Append("\n");
      
      sb.Append("  Superscript: ").Append(Superscript).Append("\n");
      
      sb.Append("  TextEffect: ").Append(TextEffect).Append("\n");
      
      sb.Append("  Underline: ").Append(Underline).Append("\n");
      
      sb.Append("  UnderlineColor: ").Append(UnderlineColor).Append("\n");
      
      sb.Append("  Link: ").Append(Link).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}
