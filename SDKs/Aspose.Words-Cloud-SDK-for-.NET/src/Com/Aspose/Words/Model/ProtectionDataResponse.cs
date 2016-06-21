using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ProtectionDataResponse {
    public ProtectionData ProtectionData { get; set; }

    public Link DocumentLink { get; set; }

    public string Code { get; set; }

    public string Status { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectionDataResponse {\n");
      sb.Append("  ProtectionData: ").Append(ProtectionData).Append("\n");
      sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
