using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class SplitDocumentResult {
    public Link SourceDocument { get; set; }

    public List<Link> Pages { get; set; }

    public Link ZippedPages { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SplitDocumentResult {\n");
      sb.Append("  SourceDocument: ").Append(SourceDocument).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("  ZippedPages: ").Append(ZippedPages).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
