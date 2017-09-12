namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Table element
  /// </summary>  
  public class Table 
  {                       
        /// <summary>
        /// Collection of table's rows.
        /// </summary>  
        public List<TableRow> TableRowList { get; set; }

        /// <summary>
        /// Table properties.
        /// </summary>  
        public TableProperties TableProperties { get; set; }

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
          sb.Append("class Table {\n");
          sb.Append("  TableRowList: ").Append(this.TableRowList).Append("\n");
          sb.Append("  TableProperties: ").Append(this.TableProperties).Append("\n");
          sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
