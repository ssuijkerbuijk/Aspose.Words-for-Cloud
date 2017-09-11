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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/tables/{0}/rows/{1}/rowformat
  /// </summary>  
  public class TableRowFormatResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Table.
        /// </summary>
        /// <value>Table.</value>    
        public TableRowFormat RowFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRowFormatResponse {\n");
          sb.Append("  RowFormat: ").Append(RowFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
