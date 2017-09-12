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
  public class DocumentEntry 
  {                       
        /// <summary>
        /// Gets or sets Href
        /// </summary>  
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets ImportFormatMode
        /// </summary>  
        public string ImportFormatMode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentEntry {\n");
          sb.Append("  Href: ").Append(this.Href).Append("\n");
          sb.Append("  ImportFormatMode: ").Append(this.ImportFormatMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
