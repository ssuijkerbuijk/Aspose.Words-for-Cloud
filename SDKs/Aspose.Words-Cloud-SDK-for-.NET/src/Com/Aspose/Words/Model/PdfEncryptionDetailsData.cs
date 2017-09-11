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
  /// container class for details of encryption
  /// </summary>  
  public class PdfEncryptionDetailsData 
  {                       
        /// <summary>
        /// Specifies the encryption algorithm to use
        /// </summary>
        /// <value>Specifies the encryption algorithm to use</value>    
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Specifies the owner password for the encrypted PDF document
        /// </summary>
        /// <value>Specifies the owner password for the encrypted PDF document</value>    
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Specifies the operations that are allowed to a user on an encrypted PDF document
        /// </summary>
        /// <value>Specifies the operations that are allowed to a user on an encrypted PDF document</value>    
        public string Permissions { get; set; }

        /// <summary>
        /// Specifies the user password required for opening the encrypted PDF document
        /// </summary>
        /// <value>Specifies the user password required for opening the encrypted PDF document</value>    
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
