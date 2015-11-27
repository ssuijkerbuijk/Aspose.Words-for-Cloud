using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ReplaceTextRequest {
    public string OldValue { get; set; }

    public string NewValue { get; set; }

    public bool IsMatchCase { get; set; }

    public bool IsMatchWholeWord { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReplaceTextRequest {\n");
      sb.Append("  OldValue: ").Append(OldValue).Append("\n");
      sb.Append("  NewValue: ").Append(NewValue).Append("\n");
      sb.Append("  IsMatchCase: ").Append(IsMatchCase).Append("\n");
      sb.Append("  IsMatchWholeWord: ").Append(IsMatchWholeWord).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
