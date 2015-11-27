using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class DocumentEntry {
    public string Href { get; set; }

    public string ImportFormatMode { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentEntry {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  ImportFormatMode: ").Append(ImportFormatMode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
