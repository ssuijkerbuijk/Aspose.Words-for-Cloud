using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ProtectionRequest {
    public string Password { get; set; }

    public string NewPassword { get; set; }

    public string ProtectionType { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectionRequest {\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
      sb.Append("  ProtectionType: ").Append(ProtectionType).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
