using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class TableCellDto {
    /// <summary>
    /// Gets or Sets ChildNodes
    /// </summary>    
    public List<Object> ChildNodes { get; set; }

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
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class TableCellDto {\n");
      sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
