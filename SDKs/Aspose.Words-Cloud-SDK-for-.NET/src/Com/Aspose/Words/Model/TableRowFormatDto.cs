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
  public class TableRowFormatDto {
    
    /// <summary>
    /// Gets or Sets Height
    /// </summary>    
    public double? Height { get; set; }

    
    /// <summary>
    /// Gets or Sets HeightRule
    /// </summary>    
    public string HeightRule { get; set; }

    
    /// <summary>
    /// Gets or Sets AllowBreakAcrossPages
    /// </summary>    
    public bool? AllowBreakAcrossPages { get; set; }

    
    /// <summary>
    /// Gets or Sets HeadingFormat
    /// </summary>    
    public bool? HeadingFormat { get; set; }

    
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
      sb.Append("class TableRowFormatDto {\n");
      
      sb.Append("  Height: ").Append(Height).Append("\n");
      
      sb.Append("  HeightRule: ").Append(HeightRule).Append("\n");
      
      sb.Append("  AllowBreakAcrossPages: ").Append(AllowBreakAcrossPages).Append("\n");
      
      sb.Append("  HeadingFormat: ").Append(HeadingFormat).Append("\n");
      
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
