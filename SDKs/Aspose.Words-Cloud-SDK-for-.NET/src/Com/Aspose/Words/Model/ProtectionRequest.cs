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
  public class ProtectionRequest 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectionRequest" /> class.
        /// </summary>
        /// <param name="Password">Password.</param>
        /// <param name="NewPassword">NewPassword.</param>
        /// <param name="ProtectionType">ProtectionType.</param>
        public ProtectionRequest(string Password = default(string), string NewPassword = default(string), string ProtectionType = default(string))
        {
                        this.Password = Password;
                        this.NewPassword = NewPassword;
                        this.ProtectionType = ProtectionType;
        }

        /// <summary>
        /// Gets or sets Password
        /// </summary>    
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets NewPassword
        /// </summary>    
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets ProtectionType
        /// </summary>    
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
