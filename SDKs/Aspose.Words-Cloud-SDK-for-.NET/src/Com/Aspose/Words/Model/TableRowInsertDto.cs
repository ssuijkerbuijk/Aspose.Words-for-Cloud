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
  public class TableRowInsertDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowInsertDto" /> class.
        /// </summary>
        /// <param name="InsertAfter">InsertAfter.</param>
        /// <param name="ColumnsCount">ColumnsCount.</param>
        public TableRowInsertDto(int? InsertAfter = default(int?), int? ColumnsCount = default(int?))
        {
                        this.InsertAfter = InsertAfter;
                        this.ColumnsCount = ColumnsCount;
        }

        /// <summary>
        /// Gets or sets InsertAfter
        /// </summary>    
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Gets or sets ColumnsCount
        /// </summary>    
        public int? ColumnsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRowInsertDto {\n");
          sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
          sb.Append("  ColumnsCount: ").Append(ColumnsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
