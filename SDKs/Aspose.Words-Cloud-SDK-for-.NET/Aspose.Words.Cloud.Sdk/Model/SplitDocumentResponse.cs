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
  public class SplitDocumentResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets SplitResult
        /// </summary>  
        public SplitDocumentResult SplitResult { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SplitDocumentResponse {\n");
          sb.Append("  SplitResult: ").Append(this.SplitResult).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
