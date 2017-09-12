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
  /// Response for the request of data about protection
  /// </summary>  
  public class ProtectionDataResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Protection's data of the document
        /// </summary>  
        public ProtectionData ProtectionData { get; set; }

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
          sb.Append("class ProtectionDataResponse {\n");
          sb.Append("  ProtectionData: ").Append(this.ProtectionData).Append("\n");
          sb.Append("  DocumentLink: ").Append(this.DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
