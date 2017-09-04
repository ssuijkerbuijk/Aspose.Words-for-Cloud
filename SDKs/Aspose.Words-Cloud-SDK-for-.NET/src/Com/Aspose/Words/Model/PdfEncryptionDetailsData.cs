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
  public class PdfEncryptionDetailsData 
  {                       
        /// <summary>
        /// Gets or sets EncryptionAlgorithm
        /// </summary>    
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets OwnerPassword
        /// </summary>    
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Gets or sets Permissions
        /// </summary>    
        public string Permissions { get; set; }

        /// <summary>
        /// Gets or sets UserPassword
        /// </summary>    
        public string UserPassword { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfEncryptionDetailsData {\n");
          sb.Append("  EncryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
          sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
          sb.Append("  Permissions: ").Append(Permissions).Append("\n");
          sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
