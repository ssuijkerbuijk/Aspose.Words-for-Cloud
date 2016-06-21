using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class SearchResponse {
    public string SearchingPattern { get; set; }

    public SearchResultsCollection SearchResults { get; set; }

    public string Code { get; set; }

    public string Status { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchResponse {\n");
      sb.Append("  SearchingPattern: ").Append(SearchingPattern).Append("\n");
      sb.Append("  SearchResults: ").Append(SearchResults).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
