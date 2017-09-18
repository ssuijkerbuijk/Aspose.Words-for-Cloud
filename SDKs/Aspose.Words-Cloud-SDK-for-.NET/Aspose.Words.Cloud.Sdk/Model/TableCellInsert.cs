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
  /// Table cell element
  /// </summary>  
  public class TableCellInsert 
  {                       
        /// <summary>
        /// Table cell will be inserted after cell with specified 0-based index.
        /// </summary>  
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellInsert {\n");
          sb.Append("  InsertAfter: ").Append(this.InsertAfter).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
