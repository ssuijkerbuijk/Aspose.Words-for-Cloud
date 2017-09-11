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
  /// Table cell element
  /// </summary>  
  public class TableCellInsert 
  {                       
        /// <summary>
        /// Table cell will be inserted after cell with specified 0-based index.
        /// </summary>
        /// <value>Table cell will be inserted after cell with specified 0-based index.</value>    
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellInsert {\n");
          sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
