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
  public class SplitDocumentResult {
    /// <summary>
    /// Gets or Sets SourceDocument
    /// </summary>    
    public FileLink SourceDocument { get; set; }

    /// <summary>
    /// Gets or Sets Pages
    /// </summary>    
    public List<FileLink> Pages { get; set; }

    /// <summary>
    /// Gets or Sets ZippedPages
    /// </summary>    
    public FileLink ZippedPages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class SplitDocumentResult {\n");
      sb.Append("  SourceDocument: ").Append(SourceDocument).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("  ZippedPages: ").Append(ZippedPages).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
