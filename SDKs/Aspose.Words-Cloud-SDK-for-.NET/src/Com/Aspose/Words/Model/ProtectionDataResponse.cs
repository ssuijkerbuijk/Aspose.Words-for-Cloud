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
  /// Response for the request of data about protection
  /// </summary>  
  public class ProtectionDataResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Protection's data of the document
        /// </summary>
        /// <value>Protection's data of the document</value>    
        public ProtectionData ProtectionData { get; set; }

        /// <summary>
        /// Link to the document
        /// </summary>
        /// <value>Link to the document</value>    
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
