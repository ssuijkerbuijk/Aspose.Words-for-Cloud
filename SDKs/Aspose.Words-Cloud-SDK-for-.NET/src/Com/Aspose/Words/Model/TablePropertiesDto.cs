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
  public class TablePropertiesDto {
    
    /// <summary>
    /// Gets or Sets Alignment
    /// </summary>    
    public string Alignment { get; set; }

    
    /// <summary>
    /// Gets or Sets AllowAutoFit
    /// </summary>    
    public bool? AllowAutoFit { get; set; }

    
    /// <summary>
    /// Gets or Sets Bidi
    /// </summary>    
    public bool? Bidi { get; set; }

    
    /// <summary>
    /// Gets or Sets BottomPadding
    /// </summary>    
    public double? BottomPadding { get; set; }

    
    /// <summary>
    /// Gets or Sets CellSpacing
    /// </summary>    
    public double? CellSpacing { get; set; }

    
    /// <summary>
    /// Gets or Sets LeftIndent
    /// </summary>    
    public double? LeftIndent { get; set; }

    
    /// <summary>
    /// Gets or Sets LeftPadding
    /// </summary>    
    public double? LeftPadding { get; set; }

    
    /// <summary>
    /// Gets or Sets PreferredWidth
    /// </summary>    
    public PreferredWidthDto PreferredWidth { get; set; }

    
    /// <summary>
    /// Gets or Sets RightPadding
    /// </summary>    
    public double? RightPadding { get; set; }

    
    /// <summary>
    /// Gets or Sets StyleIdentifier
    /// </summary>    
    public string StyleIdentifier { get; set; }

    
    /// <summary>
    /// Gets or Sets StyleName
    /// </summary>    
    public string StyleName { get; set; }

    
    /// <summary>
    /// Gets or Sets StyleOptions
    /// </summary>    
    public string StyleOptions { get; set; }

    
    /// <summary>
    /// Gets or Sets TextWrapping
    /// </summary>    
    public string TextWrapping { get; set; }

    
    /// <summary>
    /// Gets or Sets TopPadding
    /// </summary>    
    public double? TopPadding { get; set; }

    
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
      sb.Append("class TablePropertiesDto {\n");
      
      sb.Append("  Alignment: ").Append(Alignment).Append("\n");
      
      sb.Append("  AllowAutoFit: ").Append(AllowAutoFit).Append("\n");
      
      sb.Append("  Bidi: ").Append(Bidi).Append("\n");
      
      sb.Append("  BottomPadding: ").Append(BottomPadding).Append("\n");
      
      sb.Append("  CellSpacing: ").Append(CellSpacing).Append("\n");
      
      sb.Append("  LeftIndent: ").Append(LeftIndent).Append("\n");
      
      sb.Append("  LeftPadding: ").Append(LeftPadding).Append("\n");
      
      sb.Append("  PreferredWidth: ").Append(PreferredWidth).Append("\n");
      
      sb.Append("  RightPadding: ").Append(RightPadding).Append("\n");
      
      sb.Append("  StyleIdentifier: ").Append(StyleIdentifier).Append("\n");
      
      sb.Append("  StyleName: ").Append(StyleName).Append("\n");
      
      sb.Append("  StyleOptions: ").Append(StyleOptions).Append("\n");
      
      sb.Append("  TextWrapping: ").Append(TextWrapping).Append("\n");
      
      sb.Append("  TopPadding: ").Append(TopPadding).Append("\n");
      
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
