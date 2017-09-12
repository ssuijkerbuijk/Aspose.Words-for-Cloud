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
  /// Result of search operation.
  /// </summary>  
  public class SearchResult 
  {                       
        /// <summary>
        /// Link to result range start node.
        /// </summary>  
        public DocumentPosition RangeStart { get; set; }

        /// <summary>
        /// Link to result range end node.
        /// </summary>  
        public DocumentPosition RangeEnd { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchResult {\n");
          sb.Append("  RangeStart: ").Append(this.RangeStart).Append("\n");
          sb.Append("  RangeEnd: ").Append(this.RangeEnd).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
