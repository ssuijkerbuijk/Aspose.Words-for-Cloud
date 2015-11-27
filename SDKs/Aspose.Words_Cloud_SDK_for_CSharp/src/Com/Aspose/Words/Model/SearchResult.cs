using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class SearchResult {
    public DocumentPositionDto RangeStart { get; set; }

    public DocumentPositionDto RangeEnd { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchResult {\n");
      sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
      sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
