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
  public class PageNumber {
    
    /// <summary>
    /// Gets or Sets Format
    /// </summary>    
    public string Format { get; set; }

    
    /// <summary>
    /// Gets or Sets Alignment
    /// </summary>    
    public string Alignment { get; set; }

    
    /// <summary>
    /// Gets or Sets IsTop
    /// </summary>    
    public bool? IsTop { get; set; }

    
    /// <summary>
    /// Gets or Sets SetPageNumberOnFirstPage
    /// </summary>    
    public bool? SetPageNumberOnFirstPage { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageNumber {\n");
      
      sb.Append("  Format: ").Append(Format).Append("\n");
      
      sb.Append("  Alignment: ").Append(Alignment).Append("\n");
      
      sb.Append("  IsTop: ").Append(IsTop).Append("\n");
      
      sb.Append("  SetPageNumberOnFirstPage: ").Append(SetPageNumberOnFirstPage).Append("\n");
      
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
