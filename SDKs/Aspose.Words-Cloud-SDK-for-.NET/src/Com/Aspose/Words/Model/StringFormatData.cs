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
  public class StringFormatData {
    /// <summary>
    /// Gets or Sets Alignment
    /// </summary>    
    public string Alignment { get; set; }

    /// <summary>
    /// Gets or Sets FormatFlags
    /// </summary>    
    public string FormatFlags { get; set; }

    /// <summary>
    /// Gets or Sets HotkeyPrefix
    /// </summary>    
    public string HotkeyPrefix { get; set; }

    /// <summary>
    /// Gets or Sets LineAlignment
    /// </summary>    
    public string LineAlignment { get; set; }

    /// <summary>
    /// Gets or Sets Trimming
    /// </summary>    
    public string Trimming { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class StringFormatData {\n");
      sb.Append("  Alignment: ").Append(Alignment).Append("\n");
      sb.Append("  FormatFlags: ").Append(FormatFlags).Append("\n");
      sb.Append("  HotkeyPrefix: ").Append(HotkeyPrefix).Append("\n");
      sb.Append("  LineAlignment: ").Append(LineAlignment).Append("\n");
      sb.Append("  Trimming: ").Append(Trimming).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
