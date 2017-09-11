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
  /// Response for \&quot;Replace text\&quot; action.
  /// </summary>  
  public class ReplaceTextResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Number of occurrences of the captured text in the document.
        /// </summary>
        /// <value>Number of occurrences of the captured text in the document.</value>    
        public int? Matches { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public FileLink DocumentLink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReplaceTextResponse {\n");
          sb.Append("  Matches: ").Append(Matches).Append("\n");
          sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
