using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class FieldDto {
    public string Result { get; set; }

    public string FieldCode { get; set; }

    public string NodeId { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FieldDto {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  FieldCode: ").Append(FieldCode).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
