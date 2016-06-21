using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class DocumentPositionDto {
    public NodeLink Node { get; set; }

    public int Offset { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentPositionDto {\n");
      sb.Append("  Node: ").Append(Node).Append("\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
