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
  public class TableCellFormatResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets CellFormat
        /// </summary>    
        public TableCellFormatDto CellFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellFormatResponse {\n");
          sb.Append("  CellFormat: ").Append(CellFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
