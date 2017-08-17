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
  public class XmlColor {
    /// <summary>
    /// Gets or Sets Web
    /// </summary>    
    public string Web { get; set; }

    /// <summary>
    /// Gets or Sets Alpha
    /// </summary>    
    public int? Alpha { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class XmlColor {\n");
      sb.Append("  Web: ").Append(Web).Append("\n");
      sb.Append("  Alpha: ").Append(Alpha).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
