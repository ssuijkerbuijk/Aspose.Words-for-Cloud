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
  public class Document {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>    
    public List<Link> Links { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>    
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets SourceFormat
    /// </summary>    
    public string SourceFormat { get; set; }

    /// <summary>
    /// Gets or Sets IsEncrypted
    /// </summary>    
    public bool? IsEncrypted { get; set; }

    /// <summary>
    /// Gets or Sets IsSigned
    /// </summary>    
    public bool? IsSigned { get; set; }

    /// <summary>
    /// Gets or Sets DocumentProperties
    /// </summary>    
    public DocumentProperties DocumentProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Document {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  SourceFormat: ").Append(SourceFormat).Append("\n");
      sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
      sb.Append("  IsSigned: ").Append(IsSigned).Append("\n");
      sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
