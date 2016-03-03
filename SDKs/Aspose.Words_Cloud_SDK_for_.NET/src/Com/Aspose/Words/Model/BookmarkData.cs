using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class BookmarkData {
    public string Name { get; set; }

    public string Text { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookmarkData {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
