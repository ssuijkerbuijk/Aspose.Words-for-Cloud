using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class Document {
    public List<Link> Links { get; set; }

    public string FileName { get; set; }

    public string SourceFormat { get; set; }

    public bool IsEncrypted { get; set; }

    public bool IsSigned { get; set; }

    public DocumentProperties DocumentProperties { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Document {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  SourceFormat: ").Append(SourceFormat).Append("\n");
      sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
      sb.Append("  IsSigned: ").Append(IsSigned).Append("\n");
      sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
