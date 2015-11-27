using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class PageNumber {
    public string Format { get; set; }

    public string Alignment { get; set; }

    public bool IsTop { get; set; }

    public bool SetPageNumberOnFirstPage { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageNumber {\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  Alignment: ").Append(Alignment).Append("\n");
      sb.Append("  IsTop: ").Append(IsTop).Append("\n");
      sb.Append("  SetPageNumberOnFirstPage: ").Append(SetPageNumberOnFirstPage).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
