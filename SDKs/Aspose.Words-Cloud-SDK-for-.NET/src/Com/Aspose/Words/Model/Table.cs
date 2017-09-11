using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// Table element
  /// </summary>  
  public class Table 
  {                       
        /// <summary>
        /// Collection of table's rows.
        /// </summary>
        /// <value>Collection of table's rows.</value>    
        public List<TableRow> TableRowList { get; set; }

        /// <summary>
        /// Table properties.
        /// </summary>
        /// <value>Table properties.</value>    
        public TableProperties TableProperties { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Table {\n");
          sb.Append("  TableRowList: ").Append(TableRowList).Append("\n");
          sb.Append("  TableProperties: ").Append(TableProperties).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
