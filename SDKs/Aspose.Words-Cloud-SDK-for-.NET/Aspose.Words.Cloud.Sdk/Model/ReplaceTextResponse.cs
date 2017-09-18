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
  /// Response for \&quot;Replace text\&quot; action.
  /// </summary>  
  public class ReplaceTextResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Number of occurrences of the captured text in the document.
        /// </summary>  
        public int? Matches { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public FileLink DocumentLink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReplaceTextResponse {\n");
          sb.Append("  Matches: ").Append(this.Matches).Append("\n");
          sb.Append("  DocumentLink: ").Append(this.DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
