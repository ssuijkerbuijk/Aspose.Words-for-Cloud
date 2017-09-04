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
  /// 
  /// </summary>  
  public class TableInsertDto 
  {                       
        /// <summary>
        /// Gets or sets Postion
        /// </summary>    
        public DocumentPositionDto Postion { get; set; }

        /// <summary>
        /// Gets or sets ColumnsCount
        /// </summary>    
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Gets or sets RowsCount
        /// </summary>    
        public int? RowsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableInsertDto {\n");
          sb.Append("  Postion: ").Append(Postion).Append("\n");
          sb.Append("  ColumnsCount: ").Append(ColumnsCount).Append("\n");
          sb.Append("  RowsCount: ").Append(RowsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
