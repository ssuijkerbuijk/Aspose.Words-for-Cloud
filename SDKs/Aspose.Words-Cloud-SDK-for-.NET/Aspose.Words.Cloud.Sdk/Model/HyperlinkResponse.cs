namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  public class HyperlinkResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Hyperlink
        /// </summary>  
        public Hyperlink Hyperlink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HyperlinkResponse {\n");
          sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
