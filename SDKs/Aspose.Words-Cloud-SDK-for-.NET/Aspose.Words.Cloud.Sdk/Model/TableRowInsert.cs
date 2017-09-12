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
  /// Table row element
  /// </summary>  
  public class TableRowInsert 
  {                       
        /// <summary>
        /// Table row will be inserted after row with specified 0-based index.
        /// </summary>  
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Count of columns. Default is 1.
        /// </summary>  
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRowInsert {\n");
          sb.Append("  InsertAfter: ").Append(this.InsertAfter).Append("\n");
          sb.Append("  ColumnsCount: ").Append(this.ColumnsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
