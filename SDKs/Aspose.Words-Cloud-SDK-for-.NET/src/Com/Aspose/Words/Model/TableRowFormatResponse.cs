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
  public class TableRowFormatResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets RowFormat
        /// </summary>    
        public TableRowFormatDto RowFormat { get; set; }

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
