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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/tables/{0}
  /// </summary>  
  public class TableCellResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Table cell.
        /// </summary>
        /// <value>Table cell.</value>    
        public TableCell Cell { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellResponse {\n");
          sb.Append("  Cell: ").Append(Cell).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
