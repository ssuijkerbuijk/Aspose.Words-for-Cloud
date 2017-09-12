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
  /// Result of saving.
  /// </summary>  
  public class SaveResult 
  {                       
        /// <summary>
        /// Link to source document.
        /// </summary>  
        public FileLink SourceDocument { get; set; }

        /// <summary>
        /// Link to destination document.
        /// </summary>  
        public FileLink DestDocument { get; set; }

        /// <summary>
        /// Links to additional items (css, images etc).
        /// </summary>  
        public List<FileLink> AdditionalItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveResult {\n");
          sb.Append("  SourceDocument: ").Append(this.SourceDocument).Append("\n");
          sb.Append("  DestDocument: ").Append(this.DestDocument).Append("\n");
          sb.Append("  AdditionalItems: ").Append(this.AdditionalItems).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
