using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ProtectionData {
    public string ProtectionType { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectionData {\n");
      sb.Append("  ProtectionType: ").Append(ProtectionType).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
