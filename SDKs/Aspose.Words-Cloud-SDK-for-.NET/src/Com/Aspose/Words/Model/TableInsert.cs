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
  public class TableInsert 
  {                       
        /// <summary>
        /// Table will be inserted before specified position.
        /// </summary>
        /// <value>Table will be inserted before specified position.</value>    
        public DocumentPosition Postion { get; set; }

        /// <summary>
        /// Count of columns. Default is 2.
        /// </summary>
        /// <value>Count of columns. Default is 2.</value>    
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Count of rows. Default is 2.
        /// </summary>
        /// <value>Count of rows. Default is 2.</value>    
        public int? RowsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableInsert {\n");
          sb.Append("  Postion: ").Append(Postion).Append("\n");
          sb.Append("  ColumnsCount: ").Append(ColumnsCount).Append("\n");
          sb.Append("  RowsCount: ").Append(RowsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
