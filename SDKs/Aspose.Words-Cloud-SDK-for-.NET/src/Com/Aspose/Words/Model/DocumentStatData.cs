using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class DocumentStatData {
    public int WordCount { get; set; }

    public int ParagraphCount { get; set; }

    public int PageCount { get; set; }

    public List<PageStatData> PageStatData { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentStatData {\n");
      sb.Append("  WordCount: ").Append(WordCount).Append("\n");
      sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  PageStatData: ").Append(PageStatData).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
