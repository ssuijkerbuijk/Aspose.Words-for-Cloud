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
  /// Save response.
  /// </summary>  
  public class SaveResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Save result.
        /// </summary>  
        public SaveResult SaveResult { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveResponse {\n");
          sb.Append("  SaveResult: ").Append(this.SaveResult).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
