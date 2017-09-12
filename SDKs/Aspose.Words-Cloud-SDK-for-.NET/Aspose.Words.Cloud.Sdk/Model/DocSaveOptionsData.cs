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
  /// container class for doc/dot save options
  /// </summary>  
  public class DocSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Determine whether or not save RoutingSlip data saved to output document
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
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  SaveRoutingSlip: ").Append(this.SaveRoutingSlip).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
