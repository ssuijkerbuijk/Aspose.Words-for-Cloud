namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Table row element.
  /// </summary>  
  public class TableRow 
  {                       
        /// <summary>
        /// Collection of table's rows.
        /// </summary>  
        public List<TableCell> TableCellList { get; set; }

        /// <summary>
        /// Provides access to the formatting properties of the row.
        /// </summary>  
        public TableRowFormat RowFormat { get; set; }

        /// <summary>
        /// Node id
        /// </summary>  
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRow {\n");
          sb.Append("  TableCellList: ").Append(this.TableCellList).Append("\n");
          sb.Append("  RowFormat: ").Append(this.RowFormat).Append("\n");
          sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
