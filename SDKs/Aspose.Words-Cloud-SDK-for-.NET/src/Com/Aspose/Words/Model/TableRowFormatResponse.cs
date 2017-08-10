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
  public class TableRowFormatResponse {
    
    /// <summary>
    /// Gets or Sets RowFormat
    /// </summary>    
    public TableRowFormatDto RowFormat { get; set; }

    
    /// <summary>
    /// Gets or Sets Code
    /// </summary>    
    public string Code { get; set; }

    
    /// <summary>
    /// Gets or Sets Status
    /// </summary>    
    public string Status { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TableRowFormatResponse {\n");
      
      sb.Append("  RowFormat: ").Append(RowFormat).Append("\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
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
