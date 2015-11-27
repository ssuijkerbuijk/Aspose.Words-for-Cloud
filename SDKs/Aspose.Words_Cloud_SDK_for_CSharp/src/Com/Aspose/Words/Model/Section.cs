using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class Section {
    public LinkElement Paragraphs { get; set; }

    public LinkElement PageSetup { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Section {\n");
      sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
      sb.Append("  PageSetup: ").Append(PageSetup).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
