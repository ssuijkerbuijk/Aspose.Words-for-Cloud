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
  public class DocSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets Password
        /// </summary>    
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets SaveRoutingSlip
        /// </summary>    
        public bool? SaveRoutingSlip { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocSaveOptionsData {\n");
          sb.Append("  Password: ").Append(Password).Append("\n");
          sb.Append("  SaveRoutingSlip: ").Append(SaveRoutingSlip).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
