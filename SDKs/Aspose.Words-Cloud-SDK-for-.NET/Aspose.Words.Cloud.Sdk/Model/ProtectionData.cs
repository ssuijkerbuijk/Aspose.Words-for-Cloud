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
  /// Container for the data about protection of the document
  /// </summary>  
  public class ProtectionData 
  {                       
        /// <summary>
        /// Type of the protection
        /// </summary>  
        public string ProtectionType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProtectionData {\n");
          sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
