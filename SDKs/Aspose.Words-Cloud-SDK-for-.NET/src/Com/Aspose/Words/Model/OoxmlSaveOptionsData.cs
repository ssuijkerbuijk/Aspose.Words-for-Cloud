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
  public class OoxmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets PrettyFormat
        /// </summary>    
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Gets or sets Compliance
        /// </summary>    
        public string Compliance { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>    
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OoxmlSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(PrettyFormat).Append("\n");
          sb.Append("  Compliance: ").Append(Compliance).Append("\n");
          sb.Append("  Password: ").Append(Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
