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
  /// Base class for all responses.
  /// </summary>  
  public class SaaSposeResponse 
  {                       
        /// <summary>
        /// Response status code.
        /// </summary>  
        public int? Code { get; set; }

        /// <summary>
        /// Response status.
        /// </summary>  
        public string Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaaSposeResponse {\n");
          sb.Append("  Code: ").Append(this.Code).Append("\n");
          sb.Append("  Status: ").Append(this.Status).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
