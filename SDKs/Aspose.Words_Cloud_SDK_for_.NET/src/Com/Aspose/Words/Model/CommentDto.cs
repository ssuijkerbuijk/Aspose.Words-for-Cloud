using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class CommentDto {
    public DocumentPositionDto RangeStart { get; set; }

    public DocumentPositionDto RangeEnd { get; set; }

    public string Author { get; set; }

    public string Initial { get; set; }

    public System.DateTime DateTime { get; set; }

    public string Text { get; set; }

    public StoryChildNodes Content { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommentDto {\n");
      sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
      sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Initial: ").Append(Initial).Append("\n");
      sb.Append("  DateTime: ").Append(DateTime).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
