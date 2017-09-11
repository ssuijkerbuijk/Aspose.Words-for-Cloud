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
  /// container class for doc/dot save options
  /// </summary>  
  public class DocSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>    
        public string Password { get; set; }

        /// <summary>
        /// Determine whether or not save RoutingSlip data saved to output document
        /// </summary>
        /// <value>Determine whether or not save RoutingSlip data saved to output document</value>    
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
