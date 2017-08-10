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
  public class SearchResult {
    
    /// <summary>
    /// Gets or Sets RangeStart
    /// </summary>    
    public DocumentPositionDto RangeStart { get; set; }

    
    /// <summary>
    /// Gets or Sets RangeEnd
    /// </summary>    
    public DocumentPositionDto RangeEnd { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchResult {\n");
      
      sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
      
      sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
      
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
