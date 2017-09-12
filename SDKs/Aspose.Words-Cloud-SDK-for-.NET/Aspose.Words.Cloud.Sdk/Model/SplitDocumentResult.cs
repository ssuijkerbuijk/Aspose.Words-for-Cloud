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
  public class SplitDocumentResult 
  {                       
        /// <summary>
        /// Gets or sets SourceDocument
        /// </summary>  
        public FileLink SourceDocument { get; set; }

        /// <summary>
        /// Gets or sets Pages
        /// </summary>  
        public List<FileLink> Pages { get; set; }

        /// <summary>
        /// Gets or sets ZippedPages
        /// </summary>  
        public FileLink ZippedPages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SplitDocumentResult {\n");
          sb.Append("  SourceDocument: ").Append(this.SourceDocument).Append("\n");
          sb.Append("  Pages: ").Append(this.Pages).Append("\n");
          sb.Append("  ZippedPages: ").Append(this.ZippedPages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
