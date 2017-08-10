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
  public class TableDto {
    
    /// <summary>
    /// Gets or Sets TableRowList
    /// </summary>    
    public List<TableRowDto> TableRowList { get; set; }

    
    /// <summary>
    /// Gets or Sets TableProperties
    /// </summary>    
    public TablePropertiesDto TableProperties { get; set; }

    
    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>    
    public string NodeId { get; set; }

    
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
      sb.Append("class TableDto {\n");
      
      sb.Append("  TableRowList: ").Append(TableRowList).Append("\n");
      
      sb.Append("  TableProperties: ").Append(TableProperties).Append("\n");
      
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      
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
