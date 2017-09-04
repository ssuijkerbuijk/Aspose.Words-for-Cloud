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
  public class ProtectionResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets ProtectionResult
        /// </summary>    
        public bool? ProtectionResult { get; set; }

        /// <summary>
        /// Gets or sets DocumentLink
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
          sb.Append("  ProtectionResult: ").Append(ProtectionResult).Append("\n");
          sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
