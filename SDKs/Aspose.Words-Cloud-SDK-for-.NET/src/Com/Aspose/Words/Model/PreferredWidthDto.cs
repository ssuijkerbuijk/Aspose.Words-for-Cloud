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
  public class PreferredWidthDto {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>    
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>    
    public double? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PreferredWidthDto {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
