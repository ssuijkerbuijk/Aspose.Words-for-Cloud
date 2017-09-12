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
  /// 
  /// </summary>  
  public class DocumentResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Document
        /// </summary>  
        public Document Document { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentResponse {\n");
          sb.Append("  Document: ").Append(this.Document).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
