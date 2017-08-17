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
  public class RevisionsModificationResponse {
    /// <summary>
    /// Gets or Sets Result
    /// </summary>    
    public ModificationOperationResult Result { get; set; }

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
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class RevisionsModificationResponse {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
