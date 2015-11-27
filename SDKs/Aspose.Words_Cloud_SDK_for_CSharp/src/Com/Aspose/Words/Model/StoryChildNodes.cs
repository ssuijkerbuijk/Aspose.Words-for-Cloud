using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class StoryChildNodes {
    public List<object> ChildNodes { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StoryChildNodes {\n");
      sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
