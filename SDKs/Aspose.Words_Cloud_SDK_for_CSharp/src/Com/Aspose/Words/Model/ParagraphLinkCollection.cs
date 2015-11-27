using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class ParagraphLinkCollection {
    public List<ParagraphLink> ParagraphLinkList { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParagraphLinkCollection {\n");
      sb.Append("  ParagraphLinkList: ").Append(ParagraphLinkList).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
