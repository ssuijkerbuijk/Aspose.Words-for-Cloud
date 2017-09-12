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
  public class TableInsert 
  {                       
        /// <summary>
        /// Table will be inserted before specified position.
        /// </summary>  
        public DocumentPosition Postion { get; set; }

        /// <summary>
        /// Count of columns. Default is 2.
        /// </summary>  
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Count of rows. Default is 2.
        /// </summary>  
        public int? RowsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableInsert {\n");
          sb.Append("  Postion: ").Append(this.Postion).Append("\n");
          sb.Append("  ColumnsCount: ").Append(this.ColumnsCount).Append("\n");
          sb.Append("  RowsCount: ").Append(this.RowsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
