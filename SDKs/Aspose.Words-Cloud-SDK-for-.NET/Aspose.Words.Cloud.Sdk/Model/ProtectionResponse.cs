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
  /// Response for the request on changing protection of the document
  /// </summary>  
  public class ProtectionResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Result of the changing of protection
        /// </summary>  
        public bool? ProtectionResult { get; set; }

        /// <summary>
        /// Link to the document
        /// </summary>  
        public FileLink DocumentLink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProtectionResponse {\n");
          sb.Append("  ProtectionResult: ").Append(this.ProtectionResult).Append("\n");
          sb.Append("  DocumentLink: ").Append(this.DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
