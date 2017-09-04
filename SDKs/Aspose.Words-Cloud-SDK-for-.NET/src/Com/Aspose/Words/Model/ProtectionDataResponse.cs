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
  public class ProtectionDataResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets ProtectionData
        /// </summary>    
        public ProtectionData ProtectionData { get; set; }

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
          sb.Append("class ProtectionDataResponse {\n");
          sb.Append("  ProtectionData: ").Append(ProtectionData).Append("\n");
          sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
