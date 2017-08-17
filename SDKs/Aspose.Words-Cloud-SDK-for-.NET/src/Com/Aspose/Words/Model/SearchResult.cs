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
  public class SearchResult 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="RangeStart">RangeStart.</param>
        /// <param name="RangeEnd">RangeEnd.</param>
        public SearchResult(DocumentPositionDto RangeStart = default(DocumentPositionDto), DocumentPositionDto RangeEnd = default(DocumentPositionDto))
        {
                        this.RangeStart = RangeStart;
                        this.RangeEnd = RangeEnd;
        }

        /// <summary>
        /// Gets or sets RangeStart
        /// </summary>    
        public DocumentPositionDto RangeStart { get; set; }

        /// <summary>
        /// Gets or sets RangeEnd
        /// </summary>    
        public DocumentPositionDto RangeEnd { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchResult {\n");
          sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
          sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
