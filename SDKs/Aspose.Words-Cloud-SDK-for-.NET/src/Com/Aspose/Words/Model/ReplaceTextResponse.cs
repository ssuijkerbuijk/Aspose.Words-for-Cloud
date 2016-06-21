using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ReplaceTextResponse {
    public int Matches { get; set; }

    public Link DocumentLink { get; set; }

    public string Code { get; set; }

    public string Status { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReplaceTextResponse {\n");
      sb.Append("  Matches: ").Append(Matches).Append("\n");
      sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
