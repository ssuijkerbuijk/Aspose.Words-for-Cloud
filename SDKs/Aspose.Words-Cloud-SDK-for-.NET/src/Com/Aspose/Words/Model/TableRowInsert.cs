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
  /// Table row element
  /// </summary>  
  public class TableRowInsert 
  {                       
        /// <summary>
        /// Table row will be inserted after row with specified 0-based index.
        /// </summary>
        /// <value>Table row will be inserted after row with specified 0-based index.</value>    
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Count of columns. Default is 1.
        /// </summary>
        /// <value>Count of columns. Default is 1.</value>    
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRowInsert {\n");
          sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
          sb.Append("  ColumnsCount: ").Append(ColumnsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
