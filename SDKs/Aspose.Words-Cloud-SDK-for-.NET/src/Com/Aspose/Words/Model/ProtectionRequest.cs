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
  /// Request on changing of protection
  /// </summary>  
  public class ProtectionRequest 
  {                       
        /// <summary>
        /// Current password
        /// </summary>
        /// <value>Current password</value>    
        public string Password { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        /// <value>New password</value>    
        public string NewPassword { get; set; }

        /// <summary>
        /// New type of protection
        /// </summary>
        /// <value>New type of protection</value>    
        public string ProtectionType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProtectionRequest {\n");
          sb.Append("  Password: ").Append(Password).Append("\n");
          sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
          sb.Append("  ProtectionType: ").Append(ProtectionType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
