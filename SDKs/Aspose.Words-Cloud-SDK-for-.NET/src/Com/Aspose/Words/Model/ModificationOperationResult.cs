using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ModificationOperationResult {
    public Link Source { get; set; }

    public Link Dest { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModificationOperationResult {\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Dest: ").Append(Dest).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
