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
  public class CommentDto {
    /// <summary>
    /// Gets or Sets RangeStart
    /// </summary>    
    public DocumentPositionDto RangeStart { get; set; }

    /// <summary>
    /// Gets or Sets RangeEnd
    /// </summary>    
    public DocumentPositionDto RangeEnd { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>    
    public string Author { get; set; }

    /// <summary>
    /// Gets or Sets Initial
    /// </summary>    
    public string Initial { get; set; }

    /// <summary>
    /// Gets or Sets DateTime
    /// </summary>    
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>    
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>    
    public StoryChildNodes Content { get; set; }

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
      sb.Append("class CommentDto {\n");
      sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
      sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Initial: ").Append(Initial).Append("\n");
      sb.Append("  DateTime: ").Append(DateTime).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
