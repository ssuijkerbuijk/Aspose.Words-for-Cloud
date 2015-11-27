using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class Hyperlink {
    public string DisplayText { get; set; }

    public string Value { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Hyperlink {\n");
      sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
