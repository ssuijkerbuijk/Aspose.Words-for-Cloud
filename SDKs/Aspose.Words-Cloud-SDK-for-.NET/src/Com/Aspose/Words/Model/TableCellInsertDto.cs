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
  public class TableCellInsertDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="TableCellInsertDto" /> class.
        /// </summary>
        /// <param name="InsertAfter">InsertAfter.</param>
        public TableCellInsertDto(int? InsertAfter = default(int?))
        {
                        this.InsertAfter = InsertAfter;
        }

        /// <summary>
        /// Gets or sets InsertAfter
        /// </summary>    
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellInsertDto {\n");
          sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
