using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class DocumentEntryList {
    public List<DocumentEntry> DocumentEntries { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentEntryList {\n");
      sb.Append("  DocumentEntries: ").Append(DocumentEntries).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
