using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class PageStatData {
    public int PageNumber { get; set; }

    public int WordCount { get; set; }

    public int ParagraphCount { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageStatData {\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
      sb.Append("  WordCount: ").Append(WordCount).Append("\n");
      sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
