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
  public class FootnoteDto {
    /// <summary>
    /// Gets or Sets Position
    /// </summary>    
    public DocumentPositionDto Position { get; set; }

    /// <summary>
    /// Gets or Sets FootnoteType
    /// </summary>    
    public string FootnoteType { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceMark
    /// </summary>    
    public string ReferenceMark { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>    
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>    
    public StoryChildNodes Content { get; set; }

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
      sb.Append("class FootnoteDto {\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  FootnoteType: ").Append(FootnoteType).Append("\n");
      sb.Append("  ReferenceMark: ").Append(ReferenceMark).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
